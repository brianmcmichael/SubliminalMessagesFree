using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Subliminal
{
    public partial class ScrollArrows : UserControl
    {
        #region Members

        // Members
        [Description("Occurs when mouse hovers above right arrow button.")]
        public event EventHandler RightMove;
        [Description("Occurs when mouse hovers above left arrow button.")]
        public event EventHandler LeftMove;

        int nNumMessages;
        int nCurrRightMsg;

        #endregion

        #region Ctor

        // Ctor
        public ScrollArrows()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        // Properties

        #endregion

        #region Methods

        public void Zero()
        {
            this.nNumMessages = 0;
            this.nCurrRightMsg = 0;
            this.UpdateText();
        }

        public void AddMessage()
        {
            this.nNumMessages++;
            this.UpdateText();
        }

        public void RemoveMessage()
        {
            this.nNumMessages--;
            this.UpdateText();
        }

        public void MoveLeft()
        {
            this.nCurrRightMsg++;
            this.UpdateText();
        }

        public void MoveRight()
        {
            this.nCurrRightMsg--;
            this.UpdateText();
        }

        public void UpdateText()
        {
            if (this.nNumMessages > 3)
            {
                this.lblNumberMsgs.Text = this.nCurrRightMsg.ToString() + " / " +
                                          this.nNumMessages.ToString();
            }
            else
            {
                this.lblNumberMsgs.Text = this.nNumMessages.ToString() + " / " +
                                          this.nNumMessages.ToString();
            }
        }

        #endregion

        #region Events

        // Events
        private void pnlRightArrow_MouseHover(object sender, EventArgs e)
        {
            this.RightMove(sender, e);
        }

        private void pnlLeftArrow_MouseHover(object sender, EventArgs e)
        {
            this.LeftMove(sender, e);
        }

        private void pnlRightArrow_MouseClick(object sender, MouseEventArgs e)
        {
            this.RightMove(sender, e);
        }

        private void pnlLeftArrow_MouseClick(object sender, MouseEventArgs e)
        {
            this.LeftMove(sender, e);
        }

        #endregion

    }
}
