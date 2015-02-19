using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Subliminal
{
    public partial class DirectionControl : UserControl
    {
        #region Members

        // Members
        private string strDirection;

        [Description("Occurs when any direction button that is not random is pressed.")]
        public event EventHandler DirClick;

        #endregion

        #region Ctor

        public DirectionControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        // Properties
        public string Direction
        {
            get {return (this.strDirection);}
        }

        #endregion

        #region Events

        // Events
        private void btn_Click(object sender, EventArgs e)
        {
            this.btnBottom.Enabled = true;
            this.btnCenter.Enabled = true;
            this.btnLeft.Enabled = true;
            this.btnLeftBottom.Enabled = true;
            this.btnLeftTop.Enabled = true;
            this.btnRandom.Enabled = true;
            this.btnRight.Enabled = true;
            this.btnRightBottom.Enabled = true;
            this.btnRightTop.Enabled = true;
            this.btnTop.Enabled = true;
            (sender as Button).Enabled = false;
            this.strDirection = (sender as Button).Name.Substring(3);
            Settings.GetSettings().Direction = this.strDirection;
            if ((sender as Button).Name.CompareTo("btnRandom") != 0)
            {
                this.DirClick(sender, e); 
            }
        }

        private void DirectionControl_Click(object sender, EventArgs e)
        {
            this.DirClick(sender, e); 
        }

        private void DirectionControl_Load(object sender, EventArgs e)
        {
            this.strDirection = Settings.GetSettings().Direction;
            string strButton = "btn" + this.strDirection;
            (this.Controls[this.Controls.IndexOfKey(strButton)] as Button).PerformClick();
        }

        #endregion
    }
}
