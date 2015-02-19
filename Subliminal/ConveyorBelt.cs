using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Subliminal
{
    public partial class ConveyorBelt : UserControl
    {
        #region Members

        // Members
        private MemoryStream memImage;
        private int nNewMsgClickLeft;
        private int nMostLeftMsg;
        private int nMostRightMsg;
        private ShowPicture shpShowPicturesForm = new ShowPicture();
        private WebClient wclFileClient = new WebClient();

        [Description("Occurs when text or image message is added or deleted.")]
        public event EventHandler ChangeMessage;

        #endregion

        #region Consts

        // Consts
        private int nMsgsDistance = 15;
        private int nLeftMsg = 10;
        private int nTopMsg = 15;
        private int nMsgWidth = ConveyorBeltItem.MsgWidth;

        #endregion 

        #region Ctor

        // Ctor
        public ConveyorBelt()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        // Methods
        private Point MoveAllRight(int nControlLeft)
        {
            bool bHadMoved = false;
            int nMostLeftMsg = this.nMostLeftMsg;
            this.nMostRightMsg += this.nMsgWidth + this.nMsgsDistance;
            Point pntNewMsgLocation = new Point(this.nLeftMsg, this.nTopMsg);
            for (int iItemIndex = 0; iItemIndex < this.Controls.Count; iItemIndex++)
            {
                if (this.Controls[iItemIndex] is ConveyorBeltItem)
                {
                    if (this.Controls[iItemIndex].Left > nControlLeft)
                    {
                        if ((nMostLeftMsg == this.nMostLeftMsg) && 
                            (this.Controls[iItemIndex].Left == nMostLeftMsg))
                        {
                            nMostLeftMsg += this.nMsgWidth + this.nMsgsDistance;
                        }
                        this.Controls[iItemIndex].Left += this.nMsgWidth + this.nMsgsDistance;
                        bHadMoved = true;
                    }
                    else if (pntNewMsgLocation.X <= this.Controls[iItemIndex].Left)
                    {
                        pntNewMsgLocation.X = 
                            this.Controls[iItemIndex].Left + this.nMsgsDistance + this.nMsgWidth;
                    }
                }
            }
            this.nMostLeftMsg = nMostLeftMsg;
            if (bHadMoved)
            {
                this.scrollArrows1.MoveRight();
            }
            return (pntNewMsgLocation);
        }

        private void MoveAllLeft(int nControlLeft)
        {
            bool bHadMoved = false;
            int nMostLeftMsg = this.nMostLeftMsg;
            this.nMostRightMsg -= this.nMsgWidth + this.nMsgsDistance;
            for (int iItemIndex = this.Controls.Count - 1; iItemIndex >= 0; iItemIndex--)
            {
                if ((this.Controls[iItemIndex] is ConveyorBeltItem) &&
                    (this.Controls[iItemIndex].Left > nControlLeft))
                {
                    if ((nMostLeftMsg == this.nMostLeftMsg) &&
                        (this.Controls[iItemIndex].Left == nMostLeftMsg))
                    {
                        nMostLeftMsg -= this.nMsgWidth + this.nMsgsDistance;
                    }
                    this.Controls[iItemIndex].Left -= this.nMsgWidth + this.nMsgsDistance;
                    bHadMoved = true;
                }
            }
            this.nMostLeftMsg = nMostLeftMsg;
            if (bHadMoved)
            {
                this.scrollArrows1.MoveLeft();
            }
        }

        #endregion

        #region Events

        // Events
        private void הודעהחדשהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeMessage(sender, e);
            Point pntNewMsgLocation = this.MoveAllRight(this.nNewMsgClickLeft);
            ConveyorBeltItem cbiNewMsg = new ConveyorBeltItem(this.cntxItemMenu, "");
            this.Controls.Add(cbiNewMsg);
            cbiNewMsg.Top = pntNewMsgLocation.Y;
            cbiNewMsg.Left = pntNewMsgLocation.X;
            if (this.nMostLeftMsg > pntNewMsgLocation.X)
            {
                this.nMostLeftMsg = pntNewMsgLocation.X;
            }
            this.scrollArrows1.AddMessage();

            // Focusing on new message
            if (pntNewMsgLocation.X > (3 * (this.nMsgWidth + this.nMsgsDistance)))
            {
                this.MoveAllLeft(-1 * (this.Controls.Count - 2) *
                                 (this.nMsgWidth + this.nMsgsDistance));
            }
            else
            {
                this.scrollArrows1.MoveLeft();
            }
            cbiNewMsg.Focus();
        }

        private void תמונהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ChangeMessage(sender, e);
                if (this.openFileDialog1.FileNames[0].StartsWith("\\\\"))
                {
                    foreach (string strWebFile in this.openFileDialog1.FileNames)
                    {
                        Point pntNewMsgLocation = this.MoveAllRight(this.nNewMsgClickLeft);
                        string strTemp = Path.GetTempFileName();
                        this.wclFileClient.DownloadFile(strWebFile, strTemp);
                        this.memImage = new MemoryStream((File.ReadAllBytes(strTemp)));
                        Image imgNewImage = Image.FromStream(this.memImage);
                        File.Delete(strTemp);
                        ConveyorBeltItem cbiNewMsg =
                            new ConveyorBeltItem(this.cntxItemMenu, imgNewImage);
                        (cbiNewMsg.Controls[0] as PictureBox).DoubleClick += new EventHandler(cbiNewMsg_DoubleClick);
                        this.Controls.Add(cbiNewMsg);
                        cbiNewMsg.Top = pntNewMsgLocation.Y;
                        cbiNewMsg.Left = pntNewMsgLocation.X;
                        if (this.nMostLeftMsg > pntNewMsgLocation.X)
                        {
                            this.nMostLeftMsg = pntNewMsgLocation.X;
                        }

                        // Focusing on new message
                        if (pntNewMsgLocation.X > (3 * (this.nMsgWidth + this.nMsgsDistance)))
                        {
                            this.MoveAllLeft(-1 * (this.Controls.Count - 2) *
                                             (this.nMsgWidth + this.nMsgsDistance));
                        }
                        else
                        {
                            this.scrollArrows1.MoveLeft();
                        }
                        this.scrollArrows1.AddMessage();
                        cbiNewMsg.Focus();
                    }
                }
                else
                {
                    foreach (string strFileName in this.openFileDialog1.FileNames)
                    {
                        Point pntNewMsgLocation = this.MoveAllRight(this.nNewMsgClickLeft);
                        this.memImage = new MemoryStream((File.ReadAllBytes(strFileName)));
                        Image imgNewImage = Image.FromStream(this.memImage);
                        ConveyorBeltItem cbiNewMsg =
                            new ConveyorBeltItem(this.cntxItemMenu, imgNewImage);
                        (cbiNewMsg.Controls[0] as PictureBox).DoubleClick += new EventHandler(cbiNewMsg_DoubleClick);
                        this.Controls.Add(cbiNewMsg);
                        cbiNewMsg.Top = pntNewMsgLocation.Y;
                        cbiNewMsg.Left = pntNewMsgLocation.X;
                        if (this.nMostLeftMsg > pntNewMsgLocation.X)
                        {
                            this.nMostLeftMsg = pntNewMsgLocation.X;
                        }

                        // Focusing on new message
                        if (pntNewMsgLocation.X > (3 * (this.nMsgWidth + this.nMsgsDistance)))
                        {
                            this.MoveAllLeft(-1 * (this.Controls.Count - 2) *
                                             (this.nMsgWidth + this.nMsgsDistance));
                        }
                        else
                        {
                            this.scrollArrows1.MoveLeft();
                        }
                        this.scrollArrows1.AddMessage();
                        cbiNewMsg.Focus();
                    }
                }
            }
        }

        void cbiNewMsg_DoubleClick(object sender, EventArgs e)
        {
            this.shpShowPicturesForm.SetImage((sender as PictureBox).Image);
            this.shpShowPicturesForm.ShowDialog();
        }

        private void רצףתמונותמסרטToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeMessage(sender, e);
            Control cntlDeletedMsg =
                ((sender as ToolStripDropDownItem).Owner as ContextMenuStrip).SourceControl.Parent;
            this.MoveAllLeft(cntlDeletedMsg.Bounds.Left);
            cntlDeletedMsg.Dispose();
            this.scrollArrows1.RemoveMessage();
            this.scrollArrows1.MoveRight();
        }

        private void cntxItemMenu_Opening(object sender, CancelEventArgs e)
        {
            if ((sender as ContextMenuStrip).SourceControl is RichTextBox)
            {
                this.ערוךToolStripMenuItem.Visible = false; 
            }
            else
            {
                this.ערוךToolStripMenuItem.Visible = true;
            }
        }

        private void ConveyorBelt_MouseDown(object sender, MouseEventArgs e)
        {
            this.nNewMsgClickLeft = e.X;
        }

        private void scrollArrows1_LeftMove(object sender, EventArgs e)
        {
            if (!(this.nMostRightMsg < this.Width))
            {
                this.MoveAllLeft(this.nMostLeftMsg - 1); 
            }
        }

        private void scrollArrows1_RightMove(object sender, EventArgs e)
        {
            if (!(this.nMostLeftMsg > 0))
            {
                this.MoveAllRight(this.nMostLeftMsg - 1); 
            }
        }

        private void ConveyorBelt_Load(object sender, EventArgs e)
        {
            this.LoadMessages(false);

            // Adjusting Window to Mono on linux
            if (Type.GetType("Mono.Runtime") != null)
            {
                this.scrollArrows1.Size = 
                    new Size(this.scrollArrows1.Size.Width + 15,this.scrollArrows1.Size.Height);
                nMsgWidth += 20;

            }
        }

        public void SaveMessages(bool bSaveToFile)
        {
            MessageQueue.GetMsgQueue().Clear();
            foreach (Control cntlMsgItem in this.Controls)
            {
                if (cntlMsgItem is ConveyorBeltItem)
                {
                    if ((cntlMsgItem as ConveyorBeltItem).IsText == true)
                    {
                        MessageQueue.GetMsgQueue().Add(
                            ((cntlMsgItem as ConveyorBeltItem).Controls[0] as RichTextBox).Text);
                    }
                    else
                    {
                        MessageQueue.GetMsgQueue().Add(
                            ((cntlMsgItem as ConveyorBeltItem).Controls[0] as PictureBox).Image);
                    }
                }
            }
            if (bSaveToFile)
            {
                MessageQueue.GetMsgQueue().SaveMessages(); 
            }
        }

        public void LoadMessages(bool bLoadFromFile)
        {
            this.scrollArrows1.Zero();
            this.nMostLeftMsg = this.nLeftMsg;
            this.nMostRightMsg = this.nLeftMsg;
            for (int nConveyorIndex = this.Controls.Count - 1; nConveyorIndex >= 1; nConveyorIndex--)
            {
                if (this.Controls[nConveyorIndex] is ConveyorBeltItem)
                {
                    this.Controls[nConveyorIndex].Dispose();
                }
            }
            Point pntAdditionalMsgLoc = new Point(this.nLeftMsg, this.nTopMsg);
            if (bLoadFromFile)
            {
                MessageQueue.GetMsgQueue().LoadMessages(); 
            }
            foreach (object objMsgContent in MessageQueue.GetMsgQueue())
            {
                this.nMostRightMsg += this.nMsgsDistance + this.nMsgWidth;
                if (objMsgContent is string)
                {
                    ConveyorBeltItem cbiNewMsg =
                        new ConveyorBeltItem(this.cntxItemMenu, (string)objMsgContent);
                    this.Controls.Add(cbiNewMsg);
                    (cbiNewMsg.Controls[0] as RichTextBox).Text = (string)objMsgContent;
                    cbiNewMsg.Top = pntAdditionalMsgLoc.Y;
                    cbiNewMsg.Left = pntAdditionalMsgLoc.X;
                    pntAdditionalMsgLoc.X += this.nMsgWidth + this.nMsgsDistance;
                    this.scrollArrows1.AddMessage();
                    if (this.Controls.Count < 5)
                    {
                        this.scrollArrows1.MoveLeft(); 
                    }
                }
                else
                {
                    ConveyorBeltItem cbiNewMsg =
                        new ConveyorBeltItem(this.cntxItemMenu, (Image)objMsgContent);
                    this.Controls.Add(cbiNewMsg);
                    cbiNewMsg.Top = pntAdditionalMsgLoc.Y;
                    cbiNewMsg.Left = pntAdditionalMsgLoc.X;
                    pntAdditionalMsgLoc.X += this.nMsgWidth + this.nMsgsDistance;
                    this.scrollArrows1.AddMessage();
                    if (this.Controls.Count < 5)
                    {
                        this.scrollArrows1.MoveLeft();
                    }
                }
            } 
        }

        private void cntxBeltMenu_Opening(object sender, CancelEventArgs e)
        {
            if ((sender as ContextMenuStrip).SourceControl is Panel)
            {
                e.Cancel = true;
            }
        }

        private void מחקהכלToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeMessage(sender, e);
            MessageQueue.GetMsgQueue().Clear();
            this.nMostLeftMsg = this.nLeftMsg;
            this.nMostRightMsg = this.nLeftMsg;
            for (int nConveyorIndex = this.Controls.Count - 1; nConveyorIndex >= 1; nConveyorIndex--)
            {
                if (this.Controls[nConveyorIndex] is ConveyorBeltItem)
                {
                    this.Controls[nConveyorIndex].Dispose();
                    this.scrollArrows1.RemoveMessage();
                    this.scrollArrows1.MoveRight();
                }
            }
        }

        private void ערוךToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ChangeMessage(sender, e);
            this.openFileDialog1.Multiselect = false;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.memImage = 
                    new MemoryStream((File.ReadAllBytes(this.openFileDialog1.FileName)));
                Image imgNewImage = Image.FromStream(this.memImage);
                PictureBox pctChangedImage = (PictureBox)
                    ((sender as ToolStripDropDownItem).Owner as ContextMenuStrip).SourceControl;
                pctChangedImage.Image = imgNewImage;
            }
            this.openFileDialog1.Multiselect = true;
        }

        #endregion
    }
}
