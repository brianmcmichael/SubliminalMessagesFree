namespace Subliminal
{
    partial class CmdParameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CmdParameters));
            this.lblPrmAutostart = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrmHelp = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrmAutostart
            // 
            this.lblPrmAutostart.AutoSize = true;
            this.lblPrmAutostart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrmAutostart.Location = new System.Drawing.Point(12, 35);
            this.lblPrmAutostart.Name = "lblPrmAutostart";
            this.lblPrmAutostart.Size = new System.Drawing.Size(281, 52);
            this.lblPrmAutostart.TabIndex = 2;
            this.lblPrmAutostart.Text = resources.GetString("lblPrmAutostart.Text");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Parameter - Description";
            // 
            // lblPrmHelp
            // 
            this.lblPrmHelp.AutoSize = true;
            this.lblPrmHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrmHelp.Location = new System.Drawing.Point(12, 91);
            this.lblPrmHelp.Name = "lblPrmHelp";
            this.lblPrmHelp.Size = new System.Drawing.Size(227, 13);
            this.lblPrmHelp.TabIndex = 2;
            this.lblPrmHelp.Text = "/? or -h                     - Shows this help window.";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(115, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CmdParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(299, 163);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPrmHelp);
            this.Controls.Add(this.lblPrmAutostart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(307, 190);
            this.Name = "CmdParameters";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Command Line Parameters";
            this.Load += new System.EventHandler(this.CmdParameters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrmAutostart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrmHelp;
        private System.Windows.Forms.Button btnOK;
    }
}