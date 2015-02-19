using System;
using System.Windows.Forms;

namespace Subliminal
{
    public partial class CmdParameters : Form
    {
        # region Ctors

        public CmdParameters()
        {
            InitializeComponent();
        }

        #endregion

        # region Events
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdParameters_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            // Ajusting size for Mono on linux
            if (Type.GetType("Mono.Runtime") != null)
            {
                this.lblPrmAutostart.Text = 
                    "/autostart [Filename] - Shows messages with activation of \n" +
                    "                                        Subliminal Messages Free.\n" +
                    "                                        Adding file name a will result in \n" +
                    "                                        autostarting messages from this file.";
            }
        }

        #endregion

    }
}