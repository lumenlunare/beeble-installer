namespace beeble_install
{
    partial class baseWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseWindow));
            this.link = new System.Windows.Forms.LinkLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnInstall = new System.Windows.Forms.Button();
            this.captionInstall = new System.Windows.Forms.Label();
            this.captionRepair = new System.Windows.Forms.Label();
            this.btnRepair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.promoBanner = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.copyright = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.link.Location = new System.Drawing.Point(12, 73);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(99, 16);
            this.link.TabIndex = 0;
            this.link.TabStop = true;
            this.link.Text = "http://beeble.top";
            this.link.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // logo
            // 
            this.logo.ImageLocation = "C:/Users/camth/Downloads/beeble-install/resources/roblox_logo.png";
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(226, 58);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progress.ForeColor = System.Drawing.Color.Crimson;
            this.progress.Location = new System.Drawing.Point(15, 392);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(389, 31);
            this.progress.TabIndex = 2;
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInstall.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.ForeColor = System.Drawing.Color.DimGray;
            this.btnInstall.Location = new System.Drawing.Point(15, 108);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(96, 23);
            this.btnInstall.TabIndex = 4;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // captionInstall
            // 
            this.captionInstall.AutoSize = true;
            this.captionInstall.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionInstall.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.captionInstall.Location = new System.Drawing.Point(12, 134);
            this.captionInstall.Name = "captionInstall";
            this.captionInstall.Size = new System.Drawing.Size(256, 15);
            this.captionInstall.TabIndex = 5;
            this.captionInstall.Text = "install the client and register the COM library";
            this.captionInstall.Click += new System.EventHandler(this.captionInstall_Click);
            // 
            // captionRepair
            // 
            this.captionRepair.AutoSize = true;
            this.captionRepair.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionRepair.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.captionRepair.Location = new System.Drawing.Point(12, 181);
            this.captionRepair.Name = "captionRepair";
            this.captionRepair.Size = new System.Drawing.Size(312, 15);
            this.captionRepair.TabIndex = 7;
            this.captionRepair.Text = "repairs corrupted or missing files back onto your system";
            this.captionRepair.Click += new System.EventHandler(this.captionRepair_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRepair.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair.ForeColor = System.Drawing.Color.DimGray;
            this.btnRepair.Location = new System.Drawing.Point(15, 155);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(96, 23);
            this.btnRepair.TabIndex = 6;
            this.btnRepair.Text = "Repair";
            this.btnRepair.UseVisualStyleBackColor = false;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "removes any related files off your system";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnUninstall
            // 
            this.btnUninstall.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUninstall.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.ForeColor = System.Drawing.Color.DimGray;
            this.btnUninstall.Location = new System.Drawing.Point(15, 201);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(96, 23);
            this.btnUninstall.TabIndex = 8;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // logo2
            // 
            this.logo2.ImageLocation = "C:\\Users\\camth\\Downloads\\beeble-install\\resources\\beebleb-avatar-1024.png";
            this.logo2.Location = new System.Drawing.Point(372, 12);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(32, 32);
            this.logo2.TabIndex = 10;
            this.logo2.TabStop = false;
            // 
            // promoBanner
            // 
            this.promoBanner.ImageLocation = "C:\\Users\\camth\\Downloads\\beeble-install\\resources\\banner.png";
            this.promoBanner.Location = new System.Drawing.Point(15, 255);
            this.promoBanner.Name = "promoBanner";
            this.promoBanner.Size = new System.Drawing.Size(392, 97);
            this.promoBanner.TabIndex = 11;
            this.promoBanner.TabStop = false;
            this.promoBanner.Click += new System.EventHandler(this.promoBanner_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPath.Location = new System.Drawing.Point(15, 358);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(312, 28);
            this.txtPath.TabIndex = 3;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.copyright.Location = new System.Drawing.Point(12, 435);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(169, 15);
            this.copyright.TabIndex = 12;
            this.copyright.Text = "©2026 beeble because i said so";
            // 
            // baseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.promoBanner);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.captionRepair);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.captionInstall);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.link);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "baseWindow";
            this.Text = "install booble";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label captionInstall;
        private System.Windows.Forms.Label captionRepair;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.PictureBox promoBanner;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

