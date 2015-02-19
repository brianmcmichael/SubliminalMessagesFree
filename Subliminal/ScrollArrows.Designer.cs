namespace Subliminal
{
    partial class ScrollArrows
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeftArrow = new System.Windows.Forms.Panel();
            this.pnlRightArrow = new System.Windows.Forms.Panel();
            this.lblNumberMsgs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlLeftArrow
            // 
            this.pnlLeftArrow.BackgroundImage = global::Subliminal.Properties.Resources.LeftArrow;
            this.pnlLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeftArrow.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.pnlLeftArrow.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftArrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeftArrow.Name = "pnlLeftArrow";
            this.pnlLeftArrow.Size = new System.Drawing.Size(44, 41);
            this.pnlLeftArrow.TabIndex = 0;
            this.pnlLeftArrow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLeftArrow_MouseClick);
            this.pnlLeftArrow.MouseHover += new System.EventHandler(this.pnlLeftArrow_MouseHover);
            // 
            // pnlRightArrow
            // 
            this.pnlRightArrow.BackgroundImage = global::Subliminal.Properties.Resources.RightArrow;
            this.pnlRightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRightArrow.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.pnlRightArrow.Location = new System.Drawing.Point(105, 0);
            this.pnlRightArrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRightArrow.Name = "pnlRightArrow";
            this.pnlRightArrow.Size = new System.Drawing.Size(44, 41);
            this.pnlRightArrow.TabIndex = 0;
            this.pnlRightArrow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlRightArrow_MouseClick);
            this.pnlRightArrow.MouseHover += new System.EventHandler(this.pnlRightArrow_MouseHover);
            // 
            // lblNumberMsgs
            // 
            this.lblNumberMsgs.AutoSize = true;
            this.lblNumberMsgs.Location = new System.Drawing.Point(55, 14);
            this.lblNumberMsgs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberMsgs.Name = "lblNumberMsgs";
            this.lblNumberMsgs.Size = new System.Drawing.Size(36, 17);
            this.lblNumberMsgs.TabIndex = 1;
            this.lblNumberMsgs.Text = "0 / 0";
            this.lblNumberMsgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScrollArrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNumberMsgs);
            this.Controls.Add(this.pnlLeftArrow);
            this.Controls.Add(this.pnlRightArrow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScrollArrows";
            this.Size = new System.Drawing.Size(149, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRightArrow;
        private System.Windows.Forms.Panel pnlLeftArrow;
        private System.Windows.Forms.Label lblNumberMsgs;
    }
}
