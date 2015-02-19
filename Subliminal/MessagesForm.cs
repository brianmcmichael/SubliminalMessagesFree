using System;
using System.Drawing;
using System.Windows.Forms;

namespace Subliminal
{
    public partial class MessagesForm : Form
    {
        #region Members

        // Members
        private string strPrevMessagesFile = Settings.GetSettings().MessagesQueueFile;
        private bool bHadMessagesChanged = false;

        #endregion

        #region Ctor

        // Ctor
        public MessagesForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        // Events
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.conveyorBelt1.SaveMessages(false);
            Settings.GetSettings().SaveSettings();
            Settings.GetSettings().HadMessagesChanged = this.bHadMessagesChanged;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Settings.GetSettings().MessagesQueueFile = strPrevMessagesFile;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult drCancel = this.sfdSaveMessages.ShowDialog();
            if (drCancel == DialogResult.OK)
            {
                if (Type.GetType("Mono.Runtime") == null)
                {
                    Settings.GetSettings().MessagesQueueFile =
                                this.sfdSaveMessages.FileName.Substring(
                                    this.sfdSaveMessages.FileName.LastIndexOf("\\") + 1); 
                }
                else
                {
                    Settings.GetSettings().MessagesQueueFile =
                                this.sfdSaveMessages.FileName.Substring(
                                    this.sfdSaveMessages.FileName.LastIndexOf("/") + 1); 
                }
                this.Text = "Messages Window" + " - " + Settings.GetSettings().MessagesQueueFile;
                this.conveyorBelt1.SaveMessages(true);
                this.bHadMessagesChanged = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult drCancel = this.lfdLoadMessages.ShowDialog();
            if (drCancel == DialogResult.OK)
            {
                if (Type.GetType("Mono.Runtime") == null)
                {
                    Settings.GetSettings().MessagesQueueFile =
                                this.lfdLoadMessages.FileName.Substring(
                                    this.lfdLoadMessages.FileName.LastIndexOf("\\") + 1); 
                }
                else
                {
                    Settings.GetSettings().MessagesQueueFile =
                                this.lfdLoadMessages.FileName.Substring(
                                    this.lfdLoadMessages.FileName.LastIndexOf("/") + 1);
                }
                this.Text = "Messages Window" + " - " + Settings.GetSettings().MessagesQueueFile;
                this.conveyorBelt1.LoadMessages(true);
                this.bHadMessagesChanged = false;
            }
        }

        private void MessagesForm_Load(object sender, EventArgs e)
        {
            this.Text = "Messages Window" + " - " + Settings.GetSettings().MessagesQueueFile;
            this.Location = new Point(200, 200);
            this.DragDropPic.AllowDrop = true;

            // Adjusting Window to Mono on linux
            if (Type.GetType("Mono.Runtime") != null)
            {
                this.conveyorBelt1.Size = 
                    new Size(this.conveyorBelt1.Size.Width + 50, 
                             this.conveyorBelt1.Size.Height + 10);
            }
        }

        private void DragDropPic_DragEnter(object sender, DragEventArgs e)
        {
            string[] arr = e.Data.GetFormats();
        }

        private void conveyorBelt1_ChangeMessage(object sender, EventArgs e)
        {
            this.bHadMessagesChanged = true;
        }

        #endregion
    }
}
