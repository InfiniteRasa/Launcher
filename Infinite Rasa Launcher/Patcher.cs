using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;

namespace Infinite_Rasa_Launcher
{
    class Patcher
    {
        public delegate void OnFinishedPatchingDelegate();
        public delegate void OnFailedPatchingDelegate();
        public delegate void OnCheckingDelegate();
        public delegate void OnPatchingFileDelegate(String filename);
        public delegate void OnFileProgressDelegate(Byte percentage);
        public delegate void OnProgressDelegate(Int64 current, Int64 total);

        public OnFinishedPatchingDelegate OnFinishedPatching;
        public OnFailedPatchingDelegate   OnFailedPatching;
        public OnCheckingDelegate         OnChecking;
        public OnPatchingFileDelegate     OnPatchingFile;
        public OnFileProgressDelegate     OnFileProgress;
        public OnProgressDelegate         OnProgress;

        public String FilesUri   { get; set; }
        public String FilesIndex { get; set; }
        public ServerInfo Info   { get; set; }

        private bool   patching;
        private Int64  count;

        public Patcher(ServerInfo info, String filesIndex)
        {
            Info = info;
            FilesUri = info.PatcherUri;
            FilesIndex = filesIndex;
            count = 0;
            patching = false;
        }

        public void Run()
        {
            if (OnChecking != null) { OnChecking(); }

            WebClient wb = new WebClient();
            wb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            wb.DownloadFileCompleted   += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
    
            string result = "";
            try 
            { 
                result = wb.DownloadString(FilesUri + "/" + FilesIndex); 
            }
            catch (WebException)
            {
                if (OnFailedPatching != null) { OnFailedPatching(); }
                return; 
            }

            string[] checksums = result.Split('\n');
            List<string> dfiles = new List<string>();
            foreach (string pair in checksums)
            {
                string file = pair.Split(':')[0];
                string md5c = pair.Split(':')[1];
                if (File.Exists(file))
                {
                    string md5 = GetMD5(file);
                    if (md5c.ToLower().CompareTo(md5.ToLower()) != 0) 
                    { 
                        dfiles.Add(file); 
                    }
                } 
                else 
                { 
                    dfiles.Add(file); 
                }
            }

            foreach (string file in dfiles)
            {
                patching = true;
                if (OnPatchingFile != null) { OnPatchingFile(file); }

                HandleMyself(file);
                CreateIfMissing(file);
                
                wb.DownloadFileAsync(new Uri(FilesUri + "/" + file), file);

                while (patching == true)
                {
                    System.Threading.Thread.Sleep(10);
                }

                if (OnProgress != null) { OnProgress(count + 1, dfiles.Count); }
            }

            if (OnFinishedPatching != null) { OnFinishedPatching(); }
        }

        private void HandleMyself(String filename)
        {
            String myname = System.AppDomain.CurrentDomain.FriendlyName;
            if (filename == myname)
            {
                File.Move(myname, myname + ".bak");
            }
        }

        private void CreateIfMissing(string path)
        {
            if (!path.Contains("/")) { return; }
            bool folderExists = Directory.Exists(Path.GetDirectoryName(path));
            if (!folderExists)
            { 
                Directory.CreateDirectory(Path.GetDirectoryName(path)); 
            }
        }

        private string GetMD5(string file)
        {
            StringBuilder sb = new StringBuilder();
            FileStream fs = new FileStream(file, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] hash = md5.ComputeHash(fs);
            fs.Close();
            foreach (byte hex in hash)
            { 
                sb.Append(hex.ToString("x2")); 
            }
            return  sb.ToString();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = (bytesIn * 100 / totalBytes);

            if (OnFileProgress != null) { OnFileProgress((byte)percentage); }
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            patching = false;
            count++;
        }
        
    }
}
