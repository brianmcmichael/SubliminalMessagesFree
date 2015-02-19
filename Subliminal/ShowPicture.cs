using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subliminal
{
    public partial class ShowPicture : Form
    {
        #region Ctor

        // Ctor
        public ShowPicture()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        // Methods
        public void SetImage(Image imgPicture)
        {
            this.pctPicture.Image = imgPicture;
            this.Size = imgPicture.Size;
        }

        #endregion

    }
}
