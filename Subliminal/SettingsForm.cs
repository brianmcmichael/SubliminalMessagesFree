using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Subliminal
{
    public partial class SettingsForm : Form
    {
        #region Members

        // Members
        private ArrayList arlSampleTextLetter = new ArrayList("Sample Text".ToCharArray());
        private Random rndSampleTextRandom = new Random();
        private int nRandomLetter;
        private bool bIsExtended = false;
        private int nOrigWidth;

        #endregion

        #region Ctor

        // Ctor
        public SettingsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        // Events
        private void btnTextFont_Click(object sender, EventArgs e)
        {
            if (this.fndlFontDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.GetSettings().TextFont = this.fndlFontDialog.Font;
                Settings.GetSettings().TextColor = this.fndlFontDialog.Color;
                this.lblSample.Font = this.fndlFontDialog.Font;
                this.lblSample.ForeColor = this.fndlFontDialog.Color;
                this.pnlSample_MouseEnter(sender, e);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Settings.GetSettings().SaveSettings();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Settings.GetSettings().LoadSettings();
            this.Close();
        }

        private void trkTranceperacy_Scroll(object sender, EventArgs e)
        {
            Settings.GetSettings().Transperacy = this.trkTransparency.Value;
            this.lblSample.ForeColor =
                Color.FromArgb((this.fndlFontDialog.Color.R * (this.trkTransparency.Value - 1) / 100) +
                               (255 * Math.Abs(100 - this.trkTransparency.Value) / 100),
                               (this.fndlFontDialog.Color.G * this.trkTransparency.Value / 100) +
                               (240 * Math.Abs(100 - this.trkTransparency.Value) / 100),
                               (this.fndlFontDialog.Color.B * this.trkTransparency.Value / 100) +
                               (220 * Math.Abs(100 - this.trkTransparency.Value) / 100));
            this.pnlSample_MouseEnter(sender, e);
        }

        private void trkTimeForMsg_Scroll(object sender, EventArgs e)
        {
            Settings.GetSettings().TimeForMsg = this.trkTimeForMsg.Value;
            this.tmrForEach.Interval = Settings.GetSettings().TimeForMsg;
            this.pnlSample_MouseEnter(sender, e);
        }

        private void trkBetweenMsgs_Scroll(object sender, EventArgs e)
        {
            Settings.GetSettings().TimeBetween = this.trkBetweenMsgs.Value;
            this.tmrBetween.Interval = Settings.GetSettings().TimeBetween;
            this.pnlSample_MouseEnter(sender, e);
        }

        private void directionControl1_Click(object sender, EventArgs e)
        {
            Settings.GetSettings().Direction = this.directionControl1.Direction;
            this.pnlSample_MouseEnter(sender, e);
        }

        private void directionControl1_DirClick(object sender, EventArgs e)
        {
            Settings.GetSettings().Direction = this.directionControl1.Direction;
            this.pnlSample_MouseEnter(sender, e);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.nOrigWidth = this.Width;
            this.trkTransparency.Value = Settings.GetSettings().Transperacy;
            this.trkTimeForMsg.Value = Settings.GetSettings().TimeForMsg;
            this.trkBetweenMsgs.Value = Settings.GetSettings().TimeBetween;
            this.ckbShuffle.Checked = Settings.GetSettings().DoShuffle;
            this.fndlFontDialog.Font = Settings.GetSettings().TextFont;
            this.fndlFontDialog.Color = Settings.GetSettings().TextColor;
            this.Location = new Point(200, 200);
            this.cmbTimeForMsg.DropDownWidth = 100;
            this.cmbBetweenMsgs.DropDownWidth = 100;
            this.cmbTransparency.DropDownWidth = 40;
            this.lblSample.Font = Settings.GetSettings().TextFont;
            this.pnlSample.Width = this.lblSample.Width + 30;
            this.lblSample.ForeColor =
                Color.FromArgb((this.fndlFontDialog.Color.R * (this.trkTransparency.Value - 1) / 100) +
                               (255 * Math.Abs(100 - this.trkTransparency.Value) / 100),
                               (this.fndlFontDialog.Color.G * this.trkTransparency.Value / 100) +
                               (240 * Math.Abs(100 - this.trkTransparency.Value) / 100),
                               (this.fndlFontDialog.Color.B * this.trkTransparency.Value / 100) +
                               (220 * Math.Abs(100 - this.trkTransparency.Value) / 100));
            this.tmrBetween.Interval = Settings.GetSettings().TimeBetween +
                                       Settings.GetSettings().TimeForMsg;
            this.tmrForEach.Interval = Settings.GetSettings().TimeForMsg;
            this.tmrForEach.Start();
            this.tmrBetween.Start();
            
            // Adjusting Window to Mono on linux
            if (Type.GetType("Mono.Runtime") != null)
            {
                this.lblTransPercent.Text =
                    "1%                                                        50%                                                     100%";
                this.directionControl1.Size = 
                    new Size(this.directionControl1.Size.Width + 25, 
                             this.directionControl1.Size.Height + 10);
            }
        }

        private void ckbShuffle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.GetSettings().DoShuffle = this.ckbShuffle.Checked;
            this.pnlSample_MouseEnter(sender, e);
        }

        private void cmbTimeForMsg_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbTimeForMsg.SelectedIndex)
            {
                case 0:
                {
                    this.trkTimeForMsg.Value = 1;
                    break;
                }
                case 1:
                {
                    this.trkTimeForMsg.Value = 10;
                    break;
                }
                case 2:
                {
                    this.trkTimeForMsg.Value = 100;
                    break;
                }
                case 3:
                {
                    this.trkTimeForMsg.Value = 1000;
                    break;
                }
                case 4:
                {
                    this.trkTimeForMsg.Value = 2500;
                    break;
                }
                case 5:
                {
                    this.trkTimeForMsg.Value = 5000;
                    break;
                }
                default:
                    break;
            }
            Settings.GetSettings().TimeForMsg = this.trkTimeForMsg.Value;
            this.tmrForEach.Interval = Settings.GetSettings().TimeForMsg;
            this.pnlSample_MouseEnter(sender, e);
        }

        private void cmbBetweenMsgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbBetweenMsgs.SelectedIndex)
            {
                case 0:
                {
                    this.trkBetweenMsgs.Value = 1;
                    break;
                }
                case 1:
                {
                    this.trkBetweenMsgs.Value = 10;
                    break;
                }
                case 2:
                {
                    this.trkBetweenMsgs.Value = 100;
                    break;
                }
                case 3:
                {
                    this.trkBetweenMsgs.Value = 1000;
                    break;
                }
                case 4:
                {
                    this.trkBetweenMsgs.Value = 2500;
                    break;
                }
                case 5:
                {
                    this.trkBetweenMsgs.Value = 5000;
                    break;
                }
                default:
                    break;
            }
            Settings.GetSettings().TimeBetween = this.trkBetweenMsgs.Value;
            this.tmrBetween.Interval = Settings.GetSettings().TimeBetween;
            this.pnlSample_MouseEnter(sender, e);
        }

        private void cmbTranparency_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbTransparency.SelectedIndex)
            {
                case 0:
                {
                    this.trkTransparency.Value = 100;
                    break;
                }
                case 1:
                {
                    this.trkTransparency.Value = 75;
                    break;
                }
                case 2:
                {
                    this.trkTransparency.Value = 50;
                    break;
                }
                case 3:
                {
                    this.trkTransparency.Value = 25;
                    break;
                }
                case 4:
                {
                    this.trkTransparency.Value = 1;
                    break;
                }
                default:
                    break;
            }
            Settings.GetSettings().Transperacy = this.trkTransparency.Value;
            this.lblSample.ForeColor =
                Color.FromArgb((this.fndlFontDialog.Color.R * (this.trkTransparency.Value - 1) / 100) +
                               (255 * Math.Abs(100 - this.trkTransparency.Value) / 100),
                               (this.fndlFontDialog.Color.G * this.trkTransparency.Value / 100) +
                               (240 * Math.Abs(100 - this.trkTransparency.Value) / 100),
                               (this.fndlFontDialog.Color.B * this.trkTransparency.Value / 100) +
                               (220 * Math.Abs(100 - this.trkTransparency.Value) / 100));
            this.pnlSample_MouseEnter(sender, e);
        }

        private void pnlSample_MouseEnter(object sender, EventArgs e)
        {
            if ((Type.GetType("Mono.Runtime") == null) || (this.tmrSample.Enabled == true))
            {
                if (!this.bIsExtended)
                {
                    this.tmrSample.Start();
                    this.bIsExtended = true;
                    this.Width += this.pnlSample.Width;
                } 
            }
            this.tmrSample.Enabled = true;
        }

        private void pnlSample_MouseLeave(object sender, EventArgs e)
        {
            this.tmrSample.Start();
        }

        private void lblSample_SizeChanged(object sender, EventArgs e)
        {
            this.pnlSample.Width = this.lblSample.Width + 30;
        }

        private void tmrForEach_Tick(object sender, EventArgs e)
        {
            this.lblSample.Visible = false;
            this.tmrForEach.Stop();
        }

        private void tmrBetween_Tick(object sender, EventArgs e)
        {
            this.tmrForEach.Start();
            this.tmrBetween.Start();
            this.lblSample.Visible = true;
            if (this.ckbShuffle.Checked)
            {
                this.lblSample.Text = "";
                while (this.arlSampleTextLetter.Count > 0)
                {
                    this.nRandomLetter =
                        this.rndSampleTextRandom.Next(this.arlSampleTextLetter.Count - 1);
                    this.lblSample.Text = this.lblSample.Text +
                        this.arlSampleTextLetter[this.nRandomLetter].ToString();
                    this.arlSampleTextLetter.RemoveAt(this.nRandomLetter);
                }
                this.arlSampleTextLetter = new ArrayList("Sample Text".ToCharArray());
            }
            else
            {
                this.lblSample.Text = "Sample Text";
            }

            switch (this.directionControl1.Direction)
            {
                case ("Bottom"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Left + this.pnlSample.Width / 2 -
                                  this.lblSample.Width / 2 + 15,
                                  this.pnlSample.Bottom - this.lblSample.Height);
                    break;
                }
                case ("Center"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Left + this.pnlSample.Width / 2 -
                                  this.lblSample.Width / 2 + 15,
                                  this.pnlSample.Top + this.pnlSample.Height / 2 -
                                  this.lblSample.Height / 2);
                    break;
                }
                case ("Left"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Left + 15,
                                  this.pnlSample.Top + this.pnlSample.Height / 2 -
                                  this.lblSample.Height / 2);
                    break;
                }
                case ("LeftBottom"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Left + 15,
                                  this.pnlSample.Bottom - this.lblSample.Height);
                    break;
                }
                case ("LeftTop"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Left + 15,
                                  this.pnlSample.Top);
                    break;
                }
                case ("Random"):
                {
                    this.nRandomLetter =
                        this.rndSampleTextRandom.Next(this.pnlSample.Height -
                                                      this.lblSample.Height);
                    this.lblSample.Top = this.nRandomLetter;
                    this.nRandomLetter =
                        this.rndSampleTextRandom.Next(this.pnlSample.Width -
                                                      this.lblSample.Width);
                    this.lblSample.Left = this.pnlSample.Left + 15 + this.nRandomLetter;
                    break;
                }
                case ("Right"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Right - this.lblSample.Width + 25,
                                  this.pnlSample.Top + this.pnlSample.Height / 2 -
                                  this.lblSample.Height / 2);
                    break;
                }
                case ("RightBottom"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Right - this.lblSample.Width + 25,
                                  this.pnlSample.Bottom - this.lblSample.Height);
                    break;
                }
                case ("RightTop"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Right - this.lblSample.Width + 25,
                                  this.pnlSample.Top);
                    break;
                }
                case ("Top"):
                {
                    this.lblSample.Location =
                        new Point(this.pnlSample.Left + this.pnlSample.Width / 2 -
                                  this.lblSample.Width / 2 + 15,
                                  this.pnlSample.Top);
                    break;
                }
                default:
                    break;
            }
        }

        private void tmrSample_Tick(object sender, EventArgs e)
        {
            this.Width = this.nOrigWidth;
            this.tmrSample.Stop();
            this.bIsExtended = false;
        }

        #endregion
    }
}
