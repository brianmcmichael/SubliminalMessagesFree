namespace Subliminal
{
    partial class MessagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesForm));
            this.grpMessageSet = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpDragNDrop = new System.Windows.Forms.GroupBox();
            this.DragDropPic = new System.Windows.Forms.PictureBox();
            this.lfdLoadMessages = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveMessages = new System.Windows.Forms.SaveFileDialog();
            this.conveyorBelt1 = new Subliminal.ConveyorBelt();
            this.grpMessageSet.SuspendLayout();
            this.grpDragNDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DragDropPic)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMessageSet
            // 
            this.grpMessageSet.Controls.Add(this.btnCancel);
            this.grpMessageSet.Controls.Add(this.btnAccept);
            this.grpMessageSet.Controls.Add(this.btnSave);
            this.grpMessageSet.Controls.Add(this.btnLoad);
            this.grpMessageSet.Location = new System.Drawing.Point(16, 234);
            this.grpMessageSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMessageSet.Name = "grpMessageSet";
            this.grpMessageSet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMessageSet.Size = new System.Drawing.Size(281, 175);
            this.grpMessageSet.TabIndex = 2;
            this.grpMessageSet.TabStop = false;
            this.grpMessageSet.Text = "Messages Set and General";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(23, 112);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(23, 34);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(108, 42);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 112);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save To File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(153, 34);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 42);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load From File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grpDragNDrop
            // 
            this.grpDragNDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpDragNDrop.Controls.Add(this.DragDropPic);
            this.grpDragNDrop.Location = new System.Drawing.Point(305, 234);
            this.grpDragNDrop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDragNDrop.Name = "grpDragNDrop";
            this.grpDragNDrop.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDragNDrop.Size = new System.Drawing.Size(189, 175);
            this.grpDragNDrop.TabIndex = 2;
            this.grpDragNDrop.TabStop = false;
            this.grpDragNDrop.Text = "Drag n Drop";
            // 
            // DragDropPic
            // 
            this.DragDropPic.BackgroundImage = global::Subliminal.Properties.Resources.dragndrop;
            this.DragDropPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DragDropPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DragDropPic.Location = new System.Drawing.Point(4, 19);
            this.DragDropPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DragDropPic.Name = "DragDropPic";
            this.DragDropPic.Size = new System.Drawing.Size(181, 152);
            this.DragDropPic.TabIndex = 3;
            this.DragDropPic.TabStop = false;
            this.DragDropPic.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragDropPic_DragEnter);
            // 
            // conveyorBelt1
            // 
            this.conveyorBelt1.BackColor = System.Drawing.Color.White;
            this.conveyorBelt1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.conveyorBelt1.Location = new System.Drawing.Point(-7, -1);
            this.conveyorBelt1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.conveyorBelt1.Name = "conveyorBelt1";
            this.conveyorBelt1.Size = new System.Drawing.Size(515, 228);
            this.conveyorBelt1.TabIndex = 0;
            this.conveyorBelt1.ChangeMessage += new System.EventHandler(this.conveyorBelt1_ChangeMessage);
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 414);
            this.Controls.Add(this.grpDragNDrop);
            this.Controls.Add(this.grpMessageSet);
            this.Controls.Add(this.conveyorBelt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MessagesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Messages Window";
            this.Load += new System.EventHandler(this.MessagesForm_Load);
            this.grpMessageSet.ResumeLayout(false);
            this.grpDragNDrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DragDropPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ConveyorBelt conveyorBelt1;
        private System.Windows.Forms.GroupBox grpMessageSet;
        private System.Windows.Forms.GroupBox grpDragNDrop;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog lfdLoadMessages;
        private System.Windows.Forms.SaveFileDialog sfdSaveMessages;
        private System.Windows.Forms.PictureBox DragDropPic;




    }
}