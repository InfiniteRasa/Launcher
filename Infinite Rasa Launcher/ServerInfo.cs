using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infinite_Rasa_Launcher
{
    public class ServerInfo
    {
        public String Name       { get; set; }
        public String Host       { get; set; }
        public Int16  Port       { get; set; }
        public String Website    { get; set; }
        public String PatcherUri { get; set; }

        public ServerInfo(String name, String host, Int16 port, String website, String patcherUri)
        {
            Name = name;
            Host = host;
            Port = port;
            Website = website;
            PatcherUri = patcherUri;
        }

        public bool Verify()
        {
            bool safe = false;
            safe &= (Website.StartsWith("http://") && Website.StartsWith("https://"));
            // ToDo something about the patcher uri?
            return safe;
        }
    }
}
