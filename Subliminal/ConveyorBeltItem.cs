using System.Drawing;
using System.Windows.Forms;

namespace Subliminal
{
    public partial class ConveyorBeltItem : UserControl
    {
        #region Members

        // Members
        private bool bIsText;
        static private int nMsgWidth = 110;

        #endregion

        #region Ctors

        // Ctors
        public ConveyorBeltItem(ContextMenuStrip cntxStrip, string strText)
        {
            InitializeComponent();
            RichTextBox rchText = new RichTextBox();
            rchText.Text = strText;
            rchText.Size = new Size(110, 110);
            this.Controls.Add(rchText);
            this.bIsText = true;
            rchText.ContextMenuStrip = cntxStrip;
        }

        public ConveyorBeltItem(ContextMenuStrip cntxStrip, Image imgImage)
        {
            InitializeComponent();
            PictureBox pctPicture = new PictureBox();
            pctPicture.Size = new Size(110, 110);
            pctPicture.Image = imgImage;
            pctPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPicture.ContextMenuStrip = cntxStrip;
            this.Controls.Add(pctPicture);
            this.bIsText = false;
        }

        #endregion

        #region Properties

        // Properties
        public bool IsText
        {
            get {return (this.bIsText);}
        }

        static public int MsgWidth
        {
            get { return (nMsgWidth); }
        }

        #endregion

        #region Methods

        // Methods
        protected void SetImage(Image imgNewImage)
        {
            (this.Controls[0] as PictureBox).Image = imgNewImage;
        }

        #endregion
    }
}
