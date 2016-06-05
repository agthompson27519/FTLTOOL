namespace FTL_SaveScummer
{
    partial class FTL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTL));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyFTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyDRMFreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buySteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runFTLSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lbSaves = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.buyFTLToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.runFTLSteamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buyFTLToolStripMenuItem
            // 
            this.buyFTLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyIOSToolStripMenuItem,
            this.buyDRMFreeToolStripMenuItem,
            this.buySteamToolStripMenuItem});
            this.buyFTLToolStripMenuItem.Name = "buyFTLToolStripMenuItem";
            this.buyFTLToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.buyFTLToolStripMenuItem.Text = "Buy FTL";
            // 
            // buyIOSToolStripMenuItem
            // 
            this.buyIOSToolStripMenuItem.Name = "buyIOSToolStripMenuItem";
            this.buyIOSToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.buyIOSToolStripMenuItem.Text = "Buy iOS";
            this.buyIOSToolStripMenuItem.Click += new System.EventHandler(this.buyIOSToolStripMenuItem_Click);
            // 
            // buyDRMFreeToolStripMenuItem
            // 
            this.buyDRMFreeToolStripMenuItem.Name = "buyDRMFreeToolStripMenuItem";
            this.buyDRMFreeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.buyDRMFreeToolStripMenuItem.Text = "Buy DRM-Free";
            this.buyDRMFreeToolStripMenuItem.Click += new System.EventHandler(this.buyDRMFreeToolStripMenuItem_Click);
            // 
            // buySteamToolStripMenuItem
            // 
            this.buySteamToolStripMenuItem.Name = "buySteamToolStripMenuItem";
            this.buySteamToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.buySteamToolStripMenuItem.Text = "Buy Steam";
            this.buySteamToolStripMenuItem.Click += new System.EventHandler(this.buySteamToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // runFTLSteamToolStripMenuItem
            // 
            this.runFTLSteamToolStripMenuItem.Name = "runFTLSteamToolStripMenuItem";
            this.runFTLSteamToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.runFTLSteamToolStripMenuItem.Text = "Run FTL <Steam>";
            this.runFTLSteamToolStripMenuItem.Click += new System.EventHandler(this.runFTLSteamToolStripMenuItem_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.Location = new System.Drawing.Point(1052, 569);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 100);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Backup Current Save";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Location = new System.Drawing.Point(1052, 463);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(200, 100);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import Selected Save";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lbSaves
            // 
            this.lbSaves.FormattingEnabled = true;
            this.lbSaves.Location = new System.Drawing.Point(1052, 27);
            this.lbSaves.Name = "lbSaves";
            this.lbSaves.Size = new System.Drawing.Size(200, 433);
            this.lbSaves.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 668);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "v0.1";
            // 
            // FTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FTL_SaveScummer.Properties.Resources.ftlbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSaves);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FTL";
            this.Text = "FTL SaveScummer";
            this.Load += new System.EventHandler(this.FTL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyFTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyDRMFreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buySteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ListBox lbSaves;
        private System.Windows.Forms.ToolStripMenuItem runFTLSteamToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

