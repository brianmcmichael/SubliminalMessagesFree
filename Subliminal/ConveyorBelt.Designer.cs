namespace Subliminal
{
    partial class ConveyorBelt
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
            this.components = new System.ComponentModel.Container();
            this.cntxBeltMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.חדשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הודעהחדשהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.תמונהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רצףתמונותמסרטToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחקהכלToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxItemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.מחקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ערוךToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrollArrows1 = new Subliminal.ScrollArrows();
            this.cntxBeltMenu.SuspendLayout();
            this.cntxItemMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntxBeltMenu
            // 
            this.cntxBeltMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxBeltMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.חדשToolStripMenuItem,
            this.מחקהכלToolStripMenuItem});
            this.cntxBeltMenu.Name = "cntxMenu";
            this.cntxBeltMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cntxBeltMenu.Size = new System.Drawing.Size(196, 52);
            this.cntxBeltMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cntxBeltMenu_Opening);
            // 
            // חדשToolStripMenuItem
            // 
            this.חדשToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הודעהחדשהToolStripMenuItem,
            this.תמונהToolStripMenuItem,
            this.רצףתמונותמסרטToolStripMenuItem});
            this.חדשToolStripMenuItem.Name = "חדשToolStripMenuItem";
            this.חדשToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.חדשToolStripMenuItem.Text = "New";
            // 
            // הודעהחדשהToolStripMenuItem
            // 
            this.הודעהחדשהToolStripMenuItem.Name = "הודעהחדשהToolStripMenuItem";
            this.הודעהחדשהToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.הודעהחדשהToolStripMenuItem.Text = "Text Message";
            this.הודעהחדשהToolStripMenuItem.Click += new System.EventHandler(this.הודעהחדשהToolStripMenuItem_Click);
            // 
            // תמונהToolStripMenuItem
            // 
            this.תמונהToolStripMenuItem.Name = "תמונהToolStripMenuItem";
            this.תמונהToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.תמונהToolStripMenuItem.Text = "Picture";
            this.תמונהToolStripMenuItem.Click += new System.EventHandler(this.תמונהToolStripMenuItem_Click);
            // 
            // רצףתמונותמסרטToolStripMenuItem
            // 
            this.רצףתמונותמסרטToolStripMenuItem.Name = "רצףתמונותמסרטToolStripMenuItem";
            this.רצףתמונותמסרטToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.רצףתמונותמסרטToolStripMenuItem.Text = "Pictures From Movie";
            this.רצףתמונותמסרטToolStripMenuItem.Click += new System.EventHandler(this.רצףתמונותמסרטToolStripMenuItem_Click);
            // 
            // מחקהכלToolStripMenuItem
            // 
            this.מחקהכלToolStripMenuItem.Name = "מחקהכלToolStripMenuItem";
            this.מחקהכלToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.מחקהכלToolStripMenuItem.Text = "Delete Everything";
            this.מחקהכלToolStripMenuItem.Click += new System.EventHandler(this.מחקהכלToolStripMenuItem_Click);
            // 
            // cntxItemMenu
            // 
            this.cntxItemMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxItemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.מחקToolStripMenuItem,
            this.ערוךToolStripMenuItem});
            this.cntxItemMenu.Name = "cntxItemMenu";
            this.cntxItemMenu.Size = new System.Drawing.Size(123, 52);
            this.cntxItemMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cntxItemMenu_Opening);
            // 
            // מחקToolStripMenuItem
            // 
            this.מחקToolStripMenuItem.Name = "מחקToolStripMenuItem";
            this.מחקToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.מחקToolStripMenuItem.Text = "Delete";
            this.מחקToolStripMenuItem.Click += new System.EventHandler(this.מחקToolStripMenuItem_Click);
            // 
            // ערוךToolStripMenuItem
            // 
            this.ערוךToolStripMenuItem.Name = "ערוךToolStripMenuItem";
            this.ערוךToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.ערוךToolStripMenuItem.Text = "Edit";
            this.ערוךToolStripMenuItem.Click += new System.EventHandler(this.ערוךToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp|Jepg (*.jpg)|*.jpg|Gif (*.gif)|*.gif";
            this.openFileDialog1.Multiselect = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ContextMenuStrip = this.cntxBeltMenu;
            this.panel1.Controls.Add(this.scrollArrows1);
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 55);
            this.panel1.TabIndex = 3;
            // 
            // scrollArrows1
            // 
            this.scrollArrows1.BackColor = System.Drawing.Color.White;
            this.scrollArrows1.Location = new System.Drawing.Point(172, 11);
            this.scrollArrows1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scrollArrows1.Name = "scrollArrows1";
            this.scrollArrows1.Size = new System.Drawing.Size(149, 41);
            this.scrollArrows1.TabIndex = 2;
            this.scrollArrows1.RightMove += new System.EventHandler(this.scrollArrows1_RightMove);
            this.scrollArrows1.LeftMove += new System.EventHandler(this.scrollArrows1_LeftMove);
            // 
            // ConveyorBelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.cntxBeltMenu;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConveyorBelt";
            this.Size = new System.Drawing.Size(515, 228);
            this.Load += new System.EventHandler(this.ConveyorBelt_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConveyorBelt_MouseDown);
            this.cntxBeltMenu.ResumeLayout(false);
            this.cntxItemMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cntxBeltMenu;
        private System.Windows.Forms.ToolStripMenuItem מחקהכלToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntxItemMenu;
        private System.Windows.Forms.ToolStripMenuItem מחקToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ערוךToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem חדשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הודעהחדשהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem תמונהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רצףתמונותמסרטToolStripMenuItem;
        private ScrollArrows scrollArrows1;
        private System.Windows.Forms.Panel panel1;
    }
}
