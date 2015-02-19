namespace Subliminal
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.grpTitle = new System.Windows.Forms.GroupBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.lnkCredits = new System.Windows.Forms.LinkLabel();
            this.lblCredits = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntxIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.הפסקהודעותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עצורהודעותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יציאהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTitle.SuspendLayout();
            this.cntxIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.Location = new System.Drawing.Point(23, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.Location = new System.Drawing.Point(23, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle2.Location = new System.Drawing.Point(61, 58);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(281, 26);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "Subliminal Messages Free!!";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle1.Location = new System.Drawing.Point(17, 16);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(159, 30);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Welcome to";
            // 
            // grpTitle
            // 
            this.grpTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.grpTitle.Controls.Add(this.lblTitle2);
            this.grpTitle.Controls.Add(this.lblTitle1);
            this.grpTitle.Location = new System.Drawing.Point(12, 12);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(417, 103);
            this.grpTitle.TabIndex = 2;
            this.grpTitle.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(128, 157);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.Location = new System.Drawing.Point(128, 128);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(75, 23);
            this.btnMessages.TabIndex = 3;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // lnkCredits
            // 
            this.lnkCredits.AutoSize = true;
            this.lnkCredits.Location = new System.Drawing.Point(308, 191);
            this.lnkCredits.Name = "lnkCredits";
            this.lnkCredits.Size = new System.Drawing.Size(121, 13);
            this.lnkCredits.TabIndex = 4;
            this.lnkCredits.TabStop = true;
            this.lnkCredits.Text = "zanzamer1@yahoo.com";
            this.lnkCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCredits_LinkClicked);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(228, 144);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(180, 39);
            this.lblCredits.TabIndex = 5;
            this.lblCredits.Text = "Written by zanzamer...\r\nPlease send any bugs, comments or \r\nimprovement ideas to";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cntxIconMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cntxIconMenu
            // 
            this.cntxIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הפסקהודעותToolStripMenuItem,
            this.עצורהודעותToolStripMenuItem,
            this.יציאהToolStripMenuItem});
            this.cntxIconMenu.Name = "cntxIconMenu";
            this.cntxIconMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cntxIconMenu.Size = new System.Drawing.Size(154, 70);
            // 
            // הפסקהודעותToolStripMenuItem
            // 
            this.הפסקהודעותToolStripMenuItem.Name = "הפסקהודעותToolStripMenuItem";
            this.הפסקהודעותToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.הפסקהודעותToolStripMenuItem.Text = "Pause Messages";
            this.הפסקהודעותToolStripMenuItem.Click += new System.EventHandler(this.הפסקהודעותToolStripMenuItem_Click);
            // 
            // עצורהודעותToolStripMenuItem
            // 
            this.עצורהודעותToolStripMenuItem.Name = "עצורהודעותToolStripMenuItem";
            this.עצורהודעותToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.עצורהודעותToolStripMenuItem.Text = "Stop Messages";
            this.עצורהודעותToolStripMenuItem.Click += new System.EventHandler(this.עצורהודעותToolStripMenuItem_Click);
            // 
            // יציאהToolStripMenuItem
            // 
            this.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem";
            this.יציאהToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.יציאהToolStripMenuItem.Text = "Exit";
            this.יציאהToolStripMenuItem.Click += new System.EventHandler(this.יציאהToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(441, 230);
            this.Controls.Add(this.lnkCredits);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.grpTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(80, 80);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Subliminal Messages Free v1.0.4";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.grpTitle.ResumeLayout(false);
            this.grpTitle.PerformLayout();
            this.cntxIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.GroupBox grpTitle;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.LinkLabel lnkCredits;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cntxIconMenu;
        private System.Windows.Forms.ToolStripMenuItem הפסקהודעותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עצורהודעותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem יציאהToolStripMenuItem;

    }
}

