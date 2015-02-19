using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subliminal
{
    public partial class MainForm : Form
    {
        #region Members

        // Members
        SettingsForm sfrmSettingsForm = new SettingsForm();
        MessagesForm mfrmMessagesForm = new MessagesForm();
        TransperantMessage trmRunning = new TransperantMessage();

        #endregion

        #region Ctor

        // Ctor
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        // Methods


        #endregion

        #region Events

        // Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult drSave = DialogResult.None;
            if (Settings.GetSettings().HadMessagesChanged)
            {
                drSave =
                                    MessageBox.Show("Do you want to save messages in \"" +
                                    Settings.GetSettings().MessagesQueueFile +
                                    "\"?",
                                    "Save Before Exit.",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.None,
                                    MessageBoxDefaultButton.Button1);
                if (drSave == DialogResult.Yes)
                {
                    MessageQueue.GetMsgQueue().SaveMessages();
                } 
            }
            if (drSave != DialogResult.Cancel)
            {
                Application.Exit(); 
            }
        }

        private void lnkCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Type.GetType("Mono.Runtime") == null)
            {
                System.Diagnostics.Process.Start("mailto:zanzamer1@yahoo.com"); 
            }
            else
	        {
                System.Diagnostics.Process.Start("firefox mailto:zanzamer1@yahoo.com");
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.sfrmSettingsForm.ShowDialog();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            this.mfrmMessagesForm.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (MessageQueue.GetMsgQueue().Count != 0)
            {
                this.notifyIcon1.Visible = true;
                this.Hide();
                this.trmRunning.Show();
            }
            else
            {
                MessageBox.Show("No messages were defined to show. In order to add messages click \"Messages\".",
                                "Can't start messages.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.None,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void הפסקהודעותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.הפסקהודעותToolStripMenuItem.Text == "Pause Messages" )
            {
                this.trmRunning.Hide();
                this.הפסקהודעותToolStripMenuItem.Text = "Continue Messages";
            }
            else
	        {
                this.trmRunning.Show();
                this.הפסקהודעותToolStripMenuItem.Text = "Stop Messages";
	        }
        }

        private void עצורהודעותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;
            this.Show();
            this.trmRunning.HideTransperant();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.trmRunning.Owner = this;
            this.mfrmMessagesForm.Owner = this;
            this.sfrmSettingsForm.Owner = this;

            foreach (string strParm in Settings.GetSettings().CommandParms)
            {
                switch (strParm)
                {
                    case ("/autostart"):
                        {
                            Settings.GetSettings().AutoStart =
                                Settings.GetSettings().CommandParms[
                                    Settings.GetSettings().CommandParms.IndexOf(strParm) + 1].ToString();
                            Settings.GetSettings().MessagesQueueFile = 
                                Settings.GetSettings().AutoStart;
                            goto EndCmdParms;
                        }
                    default:
                    case ("-h"):
                    case ("/?"):
                        {
                            (new CmdParameters()).ShowDialog();
                            goto EndCmdParms;
                        }
                }
            }
            EndCmdParms:
            MessageQueue.GetMsgQueue().LoadMessages();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            // Checking if need to autostart
            if (Settings.GetSettings().AutoStart.Length != 0)
            {
                btnStart.PerformClick();
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            Settings.GetSettings().AutoStart = "";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.עצורהודעותToolStripMenuItem_Click(sender, e);
        }

        #endregion
    }
}
