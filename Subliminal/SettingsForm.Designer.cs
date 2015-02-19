namespace Subliminal
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.grpDirection = new System.Windows.Forms.GroupBox();
            this.directionControl1 = new Subliminal.DirectionControl();
            this.trkTimeForMsg = new System.Windows.Forms.TrackBar();
            this.trkBetweenMsgs = new System.Windows.Forms.TrackBar();
            this.lblTimeForMsg = new System.Windows.Forms.Label();
            this.lblBetweenMsgs = new System.Windows.Forms.Label();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.ckbShuffle = new System.Windows.Forms.CheckBox();
            this.lblBetweenPercentMax = new System.Windows.Forms.Label();
            this.lblBetweenPercentAvg = new System.Windows.Forms.Label();
            this.lblBetweenPercentMin = new System.Windows.Forms.Label();
            this.lblTimeForPercentMax = new System.Windows.Forms.Label();
            this.lblTimeForPercentAvg = new System.Windows.Forms.Label();
            this.lblTimeForPercentMin = new System.Windows.Forms.Label();
            this.grpText = new System.Windows.Forms.GroupBox();
            this.lblTransPercent = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTextFont = new System.Windows.Forms.Button();
            this.trkTransparency = new System.Windows.Forms.TrackBar();
            this.lblTransparecy = new System.Windows.Forms.Label();
            this.cldlColorDiaglog = new System.Windows.Forms.ColorDialog();
            this.fndlFontDialog = new System.Windows.Forms.FontDialog();
            this.cmbTimeForMsg = new System.Windows.Forms.ComboBox();
            this.cmbBetweenMsgs = new System.Windows.Forms.ComboBox();
            this.pnlSample = new System.Windows.Forms.Panel();
            this.lblSample = new System.Windows.Forms.Label();
            this.cmbTransparency = new System.Windows.Forms.ComboBox();
            this.lblSeeSample = new System.Windows.Forms.Label();
            this.tmrForEach = new System.Windows.Forms.Timer(this.components);
            this.tmrBetween = new System.Windows.Forms.Timer(this.components);
            this.tmrSample = new System.Windows.Forms.Timer(this.components);
            this.grpDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkTimeForMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBetweenMsgs)).BeginInit();
            this.grpTime.SuspendLayout();
            this.grpText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDirection
            // 
            this.grpDirection.Controls.Add(this.directionControl1);
            this.grpDirection.Location = new System.Drawing.Point(296, 197);
            this.grpDirection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDirection.Name = "grpDirection";
            this.grpDirection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDirection.Size = new System.Drawing.Size(211, 210);
            this.grpDirection.TabIndex = 0;
            this.grpDirection.TabStop = false;
            this.grpDirection.Text = "Messages Location";
            // 
            // directionControl1
            // 
            this.directionControl1.Location = new System.Drawing.Point(7, 22);
            this.directionControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.directionControl1.Name = "directionControl1";
            this.directionControl1.Size = new System.Drawing.Size(196, 180);
            this.directionControl1.TabIndex = 4;
            this.directionControl1.DirClick += new System.EventHandler(this.directionControl1_DirClick);
            this.directionControl1.Click += new System.EventHandler(this.directionControl1_Click);
            // 
            // trkTimeForMsg
            // 
            this.trkTimeForMsg.Location = new System.Drawing.Point(8, 41);
            this.trkTimeForMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkTimeForMsg.Maximum = 5000;
            this.trkTimeForMsg.Minimum = 1;
            this.trkTimeForMsg.Name = "trkTimeForMsg";
            this.trkTimeForMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trkTimeForMsg.Size = new System.Drawing.Size(252, 56);
            this.trkTimeForMsg.TabIndex = 1;
            this.trkTimeForMsg.Tag = "";
            this.trkTimeForMsg.TickFrequency = 500;
            this.trkTimeForMsg.Value = 1;
            this.trkTimeForMsg.Scroll += new System.EventHandler(this.trkTimeForMsg_Scroll);
            // 
            // trkBetweenMsgs
            // 
            this.trkBetweenMsgs.Location = new System.Drawing.Point(8, 119);
            this.trkBetweenMsgs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkBetweenMsgs.Maximum = 5000;
            this.trkBetweenMsgs.Minimum = 1;
            this.trkBetweenMsgs.Name = "trkBetweenMsgs";
            this.trkBetweenMsgs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trkBetweenMsgs.Size = new System.Drawing.Size(252, 56);
            this.trkBetweenMsgs.TabIndex = 1;
            this.trkBetweenMsgs.TickFrequency = 500;
            this.trkBetweenMsgs.Value = 1;
            this.trkBetweenMsgs.Scroll += new System.EventHandler(this.trkBetweenMsgs_Scroll);
            // 
            // lblTimeForMsg
            // 
            this.lblTimeForMsg.AutoSize = true;
            this.lblTimeForMsg.Location = new System.Drawing.Point(8, 21);
            this.lblTimeForMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeForMsg.Name = "lblTimeForMsg";
            this.lblTimeForMsg.Size = new System.Drawing.Size(222, 17);
            this.lblTimeForMsg.TabIndex = 2;
            this.lblTimeForMsg.Text = "Presenting Time (in mili-seconds):";
            // 
            // lblBetweenMsgs
            // 
            this.lblBetweenMsgs.AutoSize = true;
            this.lblBetweenMsgs.Location = new System.Drawing.Point(8, 103);
            this.lblBetweenMsgs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetweenMsgs.Name = "lblBetweenMsgs";
            this.lblBetweenMsgs.Size = new System.Drawing.Size(258, 17);
            this.lblBetweenMsgs.TabIndex = 2;
            this.lblBetweenMsgs.Text = "Messages Delay Time (in mili-seconds):";
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.ckbShuffle);
            this.grpTime.Controls.Add(this.lblBetweenPercentMax);
            this.grpTime.Controls.Add(this.lblBetweenPercentAvg);
            this.grpTime.Controls.Add(this.lblBetweenPercentMin);
            this.grpTime.Controls.Add(this.lblTimeForPercentMax);
            this.grpTime.Controls.Add(this.lblTimeForPercentAvg);
            this.grpTime.Controls.Add(this.lblTimeForPercentMin);
            this.grpTime.Controls.Add(this.trkTimeForMsg);
            this.grpTime.Controls.Add(this.lblBetweenMsgs);
            this.grpTime.Controls.Add(this.trkBetweenMsgs);
            this.grpTime.Controls.Add(this.lblTimeForMsg);
            this.grpTime.Location = new System.Drawing.Point(16, 197);
            this.grpTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTime.Name = "grpTime";
            this.grpTime.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTime.Size = new System.Drawing.Size(272, 210);
            this.grpTime.TabIndex = 3;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Messages Times";
            // 
            // ckbShuffle
            // 
            this.ckbShuffle.AutoSize = true;
            this.ckbShuffle.Location = new System.Drawing.Point(12, 182);
            this.ckbShuffle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbShuffle.Name = "ckbShuffle";
            this.ckbShuffle.Size = new System.Drawing.Size(150, 21);
            this.ckbShuffle.TabIndex = 5;
            this.ckbShuffle.Text = "Shuffle Messages?";
            this.ckbShuffle.UseVisualStyleBackColor = true;
            this.ckbShuffle.CheckedChanged += new System.EventHandler(this.ckbShuffle_CheckedChanged);
            // 
            // lblBetweenPercentMax
            // 
            this.lblBetweenPercentMax.AutoSize = true;
            this.lblBetweenPercentMax.Location = new System.Drawing.Point(232, 162);
            this.lblBetweenPercentMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetweenPercentMax.Name = "lblBetweenPercentMax";
            this.lblBetweenPercentMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBetweenPercentMax.Size = new System.Drawing.Size(23, 17);
            this.lblBetweenPercentMax.TabIndex = 3;
            this.lblBetweenPercentMax.Text = "5s";
            // 
            // lblBetweenPercentAvg
            // 
            this.lblBetweenPercentAvg.AutoSize = true;
            this.lblBetweenPercentAvg.Location = new System.Drawing.Point(116, 162);
            this.lblBetweenPercentAvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetweenPercentAvg.Name = "lblBetweenPercentAvg";
            this.lblBetweenPercentAvg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBetweenPercentAvg.Size = new System.Drawing.Size(58, 17);
            this.lblBetweenPercentAvg.TabIndex = 3;
            this.lblBetweenPercentAvg.Text = "2500ms";
            // 
            // lblBetweenPercentMin
            // 
            this.lblBetweenPercentMin.AutoSize = true;
            this.lblBetweenPercentMin.Location = new System.Drawing.Point(17, 161);
            this.lblBetweenPercentMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetweenPercentMin.Name = "lblBetweenPercentMin";
            this.lblBetweenPercentMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBetweenPercentMin.Size = new System.Drawing.Size(34, 17);
            this.lblBetweenPercentMin.TabIndex = 3;
            this.lblBetweenPercentMin.Text = "1ms";
            // 
            // lblTimeForPercentMax
            // 
            this.lblTimeForPercentMax.AutoSize = true;
            this.lblTimeForPercentMax.Location = new System.Drawing.Point(232, 80);
            this.lblTimeForPercentMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeForPercentMax.Name = "lblTimeForPercentMax";
            this.lblTimeForPercentMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeForPercentMax.Size = new System.Drawing.Size(23, 17);
            this.lblTimeForPercentMax.TabIndex = 3;
            this.lblTimeForPercentMax.Text = "5s";
            // 
            // lblTimeForPercentAvg
            // 
            this.lblTimeForPercentAvg.AutoSize = true;
            this.lblTimeForPercentAvg.Location = new System.Drawing.Point(116, 80);
            this.lblTimeForPercentAvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeForPercentAvg.Name = "lblTimeForPercentAvg";
            this.lblTimeForPercentAvg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeForPercentAvg.Size = new System.Drawing.Size(58, 17);
            this.lblTimeForPercentAvg.TabIndex = 3;
            this.lblTimeForPercentAvg.Text = "2500ms";
            // 
            // lblTimeForPercentMin
            // 
            this.lblTimeForPercentMin.AutoSize = true;
            this.lblTimeForPercentMin.Location = new System.Drawing.Point(17, 80);
            this.lblTimeForPercentMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeForPercentMin.Name = "lblTimeForPercentMin";
            this.lblTimeForPercentMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeForPercentMin.Size = new System.Drawing.Size(34, 17);
            this.lblTimeForPercentMin.TabIndex = 3;
            this.lblTimeForPercentMin.Text = "1ms";
            // 
            // grpText
            // 
            this.grpText.BackColor = System.Drawing.Color.White;
            this.grpText.Controls.Add(this.lblTransPercent);
            this.grpText.Controls.Add(this.btnAccept);
            this.grpText.Controls.Add(this.btnCancel);
            this.grpText.Controls.Add(this.btnTextFont);
            this.grpText.Controls.Add(this.trkTransparency);
            this.grpText.Controls.Add(this.lblTransparecy);
            this.grpText.Location = new System.Drawing.Point(16, 15);
            this.grpText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpText.Name = "grpText";
            this.grpText.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpText.Size = new System.Drawing.Size(491, 175);
            this.grpText.TabIndex = 4;
            this.grpText.TabStop = false;
            this.grpText.Text = "Font, Transparency and General";
            // 
            // lblTransPercent
            // 
            this.lblTransPercent.Location = new System.Drawing.Point(15, 150);
            this.lblTransPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransPercent.Name = "lblTransPercent";
            this.lblTransPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTransPercent.Size = new System.Drawing.Size(460, 21);
            this.lblTransPercent.TabIndex = 3;
            this.lblTransPercent.Text = "1%                                               50%                             " +
    "                100%";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(188, 37);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(108, 42);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(343, 37);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTextFont
            // 
            this.btnTextFont.Location = new System.Drawing.Point(21, 37);
            this.btnTextFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTextFont.Name = "btnTextFont";
            this.btnTextFont.Size = new System.Drawing.Size(116, 42);
            this.btnTextFont.TabIndex = 2;
            this.btnTextFont.Text = "Text Font";
            this.btnTextFont.UseVisualStyleBackColor = true;
            this.btnTextFont.Click += new System.EventHandler(this.btnTextFont_Click);
            // 
            // trkTransparency
            // 
            this.trkTransparency.Location = new System.Drawing.Point(8, 112);
            this.trkTransparency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkTransparency.Maximum = 100;
            this.trkTransparency.Minimum = 1;
            this.trkTransparency.Name = "trkTransparency";
            this.trkTransparency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trkTransparency.Size = new System.Drawing.Size(468, 56);
            this.trkTransparency.TabIndex = 0;
            this.trkTransparency.TickFrequency = 10;
            this.trkTransparency.Value = 100;
            this.trkTransparency.Scroll += new System.EventHandler(this.trkTranceperacy_Scroll);
            // 
            // lblTransparecy
            // 
            this.lblTransparecy.Location = new System.Drawing.Point(17, 95);
            this.lblTransparecy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransparecy.Name = "lblTransparecy";
            this.lblTransparecy.Size = new System.Drawing.Size(133, 28);
            this.lblTransparecy.TabIndex = 1;
            this.lblTransparecy.Text = "Transparency:";
            // 
            // fndlFontDialog
            // 
            this.fndlFontDialog.ShowApply = true;
            this.fndlFontDialog.ShowColor = true;
            // 
            // cmbTimeForMsg
            // 
            this.cmbTimeForMsg.FormattingEnabled = true;
            this.cmbTimeForMsg.Items.AddRange(new object[] {
            "0.001 of second",
            "0.01 of second",
            "0.1 of second",
            "1 second",
            "2.5 seconds",
            "5 seconds"});
            this.cmbTimeForMsg.Location = new System.Drawing.Point(1, 239);
            this.cmbTimeForMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTimeForMsg.Name = "cmbTimeForMsg";
            this.cmbTimeForMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTimeForMsg.Size = new System.Drawing.Size(27, 24);
            this.cmbTimeForMsg.TabIndex = 4;
            this.cmbTimeForMsg.SelectedIndexChanged += new System.EventHandler(this.cmbTimeForMsg_SelectedIndexChanged);
            // 
            // cmbBetweenMsgs
            // 
            this.cmbBetweenMsgs.FormattingEnabled = true;
            this.cmbBetweenMsgs.Items.AddRange(new object[] {
            "0.001 of second",
            "0.01 of second",
            "0.1 of second",
            "1 second",
            "2.5 seconds",
            "5 seconds"});
            this.cmbBetweenMsgs.Location = new System.Drawing.Point(1, 318);
            this.cmbBetweenMsgs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBetweenMsgs.Name = "cmbBetweenMsgs";
            this.cmbBetweenMsgs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBetweenMsgs.Size = new System.Drawing.Size(27, 24);
            this.cmbBetweenMsgs.TabIndex = 4;
            this.cmbBetweenMsgs.SelectedIndexChanged += new System.EventHandler(this.cmbBetweenMsgs_SelectedIndexChanged);
            // 
            // pnlSample
            // 
            this.pnlSample.BackColor = System.Drawing.Color.White;
            this.pnlSample.ForeColor = System.Drawing.Color.Transparent;
            this.pnlSample.Location = new System.Drawing.Point(491, 0);
            this.pnlSample.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(476, 417);
            this.pnlSample.TabIndex = 5;
            this.pnlSample.MouseEnter += new System.EventHandler(this.pnlSample_MouseEnter);
            this.pnlSample.MouseLeave += new System.EventHandler(this.pnlSample_MouseLeave);
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(529, 18);
            this.lblSample.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(86, 17);
            this.lblSample.TabIndex = 6;
            this.lblSample.Text = "Sample Text";
            this.lblSample.SizeChanged += new System.EventHandler(this.lblSample_SizeChanged);
            // 
            // cmbTransparency
            // 
            this.cmbTransparency.FormattingEnabled = true;
            this.cmbTransparency.Items.AddRange(new object[] {
            "100%",
            "75%",
            "50%",
            "25%",
            "1%"});
            this.cmbTransparency.Location = new System.Drawing.Point(1, 129);
            this.cmbTransparency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTransparency.Name = "cmbTransparency";
            this.cmbTransparency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTransparency.Size = new System.Drawing.Size(27, 24);
            this.cmbTransparency.TabIndex = 4;
            this.cmbTransparency.SelectedIndexChanged += new System.EventHandler(this.cmbTranparency_SelectedIndexChanged);
            // 
            // lblSeeSample
            // 
            this.lblSeeSample.AutoSize = true;
            this.lblSeeSample.ForeColor = System.Drawing.Color.Red;
            this.lblSeeSample.Location = new System.Drawing.Point(323, 0);
            this.lblSeeSample.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeeSample.Name = "lblSeeSample";
            this.lblSeeSample.Size = new System.Drawing.Size(171, 17);
            this.lblSeeSample.TabIndex = 7;
            this.lblSeeSample.Text = "See text sample here! --->";
            // 
            // tmrForEach
            // 
            this.tmrForEach.Tick += new System.EventHandler(this.tmrForEach_Tick);
            // 
            // tmrBetween
            // 
            this.tmrBetween.Tick += new System.EventHandler(this.tmrBetween_Tick);
            // 
            // tmrSample
            // 
            this.tmrSample.Interval = 5000;
            this.tmrSample.Tick += new System.EventHandler(this.tmrSample_Tick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 414);
            this.Controls.Add(this.lblSeeSample);
            this.Controls.Add(this.cmbTransparency);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.cmbBetweenMsgs);
            this.Controls.Add(this.cmbTimeForMsg);
            this.Controls.Add(this.grpText);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpDirection);
            this.Controls.Add(this.pnlSample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Text = "Settings Window";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.grpDirection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkTimeForMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBetweenMsgs)).EndInit();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkTransparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDirection;
        private System.Windows.Forms.TrackBar trkTimeForMsg;
        private System.Windows.Forms.TrackBar trkBetweenMsgs;
        private System.Windows.Forms.Label lblTimeForMsg;
        private System.Windows.Forms.Label lblBetweenMsgs;
        private System.Windows.Forms.GroupBox grpTime;
        private DirectionControl directionControl1;
        private System.Windows.Forms.GroupBox grpText;
        private System.Windows.Forms.TrackBar trkTransparency;
        private System.Windows.Forms.Label lblTransparecy;
        private System.Windows.Forms.Button btnTextFont;
        private System.Windows.Forms.Label lblTransPercent;
        private System.Windows.Forms.Label lblTimeForPercentMin;
        private System.Windows.Forms.Label lblBetweenPercentMin;
        private System.Windows.Forms.ColorDialog cldlColorDiaglog;
        private System.Windows.Forms.FontDialog fndlFontDialog;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBetweenPercentMax;
        private System.Windows.Forms.Label lblBetweenPercentAvg;
        private System.Windows.Forms.Label lblTimeForPercentMax;
        private System.Windows.Forms.Label lblTimeForPercentAvg;
        private System.Windows.Forms.CheckBox ckbShuffle;
        private System.Windows.Forms.ComboBox cmbTimeForMsg;
        private System.Windows.Forms.ComboBox cmbBetweenMsgs;
        private System.Windows.Forms.Panel pnlSample;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.ComboBox cmbTransparency;
        private System.Windows.Forms.Label lblSeeSample;
        private System.Windows.Forms.Timer tmrForEach;
        private System.Windows.Forms.Timer tmrBetween;
        private System.Windows.Forms.Timer tmrSample;
    }
}