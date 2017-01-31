namespace Infinite_Rasa_Launcher
{
    partial class FormLauncher
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLauncher));
            this.buttonExit = new System.Windows.Forms.Button();
            this.ServerIndexListBox = new System.Windows.Forms.ListBox();
            this.pictureBoxPublicServersIndex = new System.Windows.Forms.PictureBox();
            this.pictureBoxNoServersFound = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxChecking = new System.Windows.Forms.PictureBox();
            this.pictureBoxPatching = new System.Windows.Forms.PictureBox();
            this.pictureBoxProgressBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTotalBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPublicServersIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoServersFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotalBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::Infinite_Rasa_Launcher.Properties.Resources.exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonExit.Location = new System.Drawing.Point(578, 310);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(21, 79);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ServerIndexListBox
            // 
            this.ServerIndexListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.ServerIndexListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerIndexListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.ServerIndexListBox.FormattingEnabled = true;
            this.ServerIndexListBox.Location = new System.Drawing.Point(231, 275);
            this.ServerIndexListBox.Name = "ServerIndexListBox";
            this.ServerIndexListBox.Size = new System.Drawing.Size(244, 91);
            this.ServerIndexListBox.TabIndex = 12;
            this.ServerIndexListBox.SelectedIndexChanged += new System.EventHandler(this.ServerIndexListBox_SelectedIndexChanged);
            // 
            // pictureBoxPublicServersIndex
            // 
            this.pictureBoxPublicServersIndex.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPublicServersIndex.BackgroundImage = global::Infinite_Rasa_Launcher.Properties.Resources.publicserverindex;
            this.pictureBoxPublicServersIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPublicServersIndex.Location = new System.Drawing.Point(231, 229);
            this.pictureBoxPublicServersIndex.Name = "pictureBoxPublicServersIndex";
            this.pictureBoxPublicServersIndex.Size = new System.Drawing.Size(244, 30);
            this.pictureBoxPublicServersIndex.TabIndex = 13;
            this.pictureBoxPublicServersIndex.TabStop = false;
            // 
            // pictureBoxNoServersFound
            // 
            this.pictureBoxNoServersFound.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNoServersFound.BackgroundImage = global::Infinite_Rasa_Launcher.Properties.Resources.noserversfound;
            this.pictureBoxNoServersFound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNoServersFound.Location = new System.Drawing.Point(184, 300);
            this.pictureBoxNoServersFound.Name = "pictureBoxNoServersFound";
            this.pictureBoxNoServersFound.Size = new System.Drawing.Size(342, 42);
            this.pictureBoxNoServersFound.TabIndex = 14;
            this.pictureBoxNoServersFound.TabStop = false;
            this.pictureBoxNoServersFound.Visible = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImage = global::Infinite_Rasa_Launcher.Properties.Resources.play;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(299, 348);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(118, 41);
            this.buttonPlay.TabIndex = 15;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Visible = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBoxChecking
            // 
            this.pictureBoxChecking.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChecking.BackgroundImage = global::Infinite_Rasa_Launcher.Properties.Resources.checkingclientfiles;
            this.pictureBoxChecking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxChecking.Location = new System.Drawing.Point(151, 232);
            this.pictureBoxChecking.Name = "pictureBoxChecking";
            this.pictureBoxChecking.Size = new System.Drawing.Size(408, 62);
            this.pictureBoxChecking.TabIndex = 16;
            this.pictureBoxChecking.TabStop = false;
            this.pictureBoxChecking.Visible = false;
            // 
            // pictureBoxPatching
            // 
            this.pictureBoxPatching.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPatching.BackgroundImage = global::Infinite_Rasa_Launcher.Properties.Resources.patchingclient;
            this.pictureBoxPatching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPatching.Location = new System.Drawing.Point(201, 232);
            this.pictureBoxPatching.Name = "pictureBoxPatching";
            this.pictureBoxPatching.Size = new System.Drawing.Size(304, 62);
            this.pictureBoxPatching.TabIndex = 17;
            this.pictureBoxPatching.TabStop = false;
            this.pictureBoxPatching.Visible = false;
            // 
            // pictureBoxProgressBar
            // 
            this.pictureBoxProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProgressBar.BackgroundImage = global::Infinite_Rasa_Launcher.Properties.Resources.progressbar;
            this.pictureBoxProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProgressBar.Location = new System.Drawing.Point(151, 348);
            this.pictureBoxProgressBar.Name = "pictureBoxProgressBar";
            this.pictureBoxProgressBar.Size = new System.Drawing.Size(0, 18);
            this.pictureBoxProgressBar.TabIndex = 18;
            this.pictureBoxProgressBar.TabStop = false;
            this.pictureBoxProgressBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(148, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patching file: Dummy";
            this.label1.Visible = false;
            // 
            // pictureBoxTotalBar
            // 
            this.pictureBoxTotalBar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTotalBar.BackgroundImage = global::Infinite_Rasa_Launcher.Properties.Resources.progressbar;
            this.pictureBoxTotalBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTotalBar.Location = new System.Drawing.Point(151, 372);
            this.pictureBoxTotalBar.Name = "pictureBoxTotalBar";
            this.pictureBoxTotalBar.Size = new System.Drawing.Size(0, 18);
            this.pictureBoxTotalBar.TabIndex = 20;
            this.pictureBoxTotalBar.TabStop = false;
            this.pictureBoxTotalBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 439);
            this.Controls.Add(this.pictureBoxTotalBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxProgressBar);
            this.Controls.Add(this.pictureBoxPatching);
            this.Controls.Add(this.pictureBoxChecking);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.pictureBoxNoServersFound);
            this.Controls.Add(this.pictureBoxPublicServersIndex);
            this.Controls.Add(this.ServerIndexListBox);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infinite Rasa Launcher";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPublicServersIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoServersFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotalBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox ServerIndexListBox;
        private System.Windows.Forms.PictureBox pictureBoxPublicServersIndex;
        private System.Windows.Forms.PictureBox pictureBoxNoServersFound;
        public System.Windows.Forms.Button buttonPlay;
        public System.Windows.Forms.PictureBox pictureBoxChecking;
        public System.Windows.Forms.PictureBox pictureBoxPatching;
        private System.Windows.Forms.PictureBox pictureBoxProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTotalBar;
    }
}

