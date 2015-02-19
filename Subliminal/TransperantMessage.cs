using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Subliminal
{
    public partial class TransperantMessage : Form
    {
        #region Members

        // Members
        private Settings setSettings;
        private Random rndRandom = new Random();
        private MessageQueue msqQueue;

        #endregion

        #region Arrays

        // Arrays
        private ArrayList arlstrDirections = new ArrayList(
            new string[] { "Random", "LeftTop", "Top", "RightTop", 
                           "Left", "Center", "Right", "LeftBottom", 
                           "Bottom" ,"RightBottom"});

        #endregion

        #region Ctor

        // Ctor
        public TransperantMessage()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        // Methods
        public void InitializeTransperant()
        {
            this.msqQueue = MessageQueue.GetMsgQueue();
            this.setSettings = Settings.GetSettings();
            this.Opacity = ((double)this.setSettings.Transperacy) / 100;
            this.lblLabel.ForeColor = this.setSettings.TextColor;
            this.lblLabel.Font = this.setSettings.TextFont;
            this.tmrBetween.Interval = this.setSettings.TimeBetween +
                                       this.setSettings.TimeForMsg;
            this.tmrForEach.Interval = this.setSettings.TimeForMsg;
            this.ShowMessages();
        }

        private void ShowMessages()
        {
            this.HideMessage();
            this.tmrForEach.Start();
            this.tmrBetween.Start();
        }

        private void HideMessage()
        {
            this.lblLabel.Visible = false;
            this.lblLabel.Text = String.Empty;
            this.BackgroundImage = null;
            if (Type.GetType("Mono.Runtime") != null)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void ReplaceMessage()
        {
            object objMsgCurrent = this.msqQueue.Enqueue();
            
            // Shuffle messages if checked in settings form
            if (Settings.GetSettings().DoShuffle)
            {
                this.msqQueue.Reverse(0, this.rndRandom.Next(this.msqQueue.Count));
            }

            if (objMsgCurrent is string)
            {
                this.lblLabel.Text = (string)objMsgCurrent;
                if (Regex.IsMatch(this.lblLabel.Text, "^[אבגדהוזחטיכלמנסעפצקרשתםןץףך]+.*"))
                {
                    this.lblLabel.RightToLeft = RightToLeft.Yes;
                }
                else
                {
                    this.lblLabel.RightToLeft = RightToLeft.No;
                }
                this.lblLabel.Visible = true;
                this.Size = this.lblLabel.Size;
            }
            else
            {
                this.BackgroundImage = objMsgCurrent as Image;
                this.Size = this.BackgroundImage.Size;
            }
            if (Type.GetType("Mono.Runtime") != null)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private Point PlaceTransperant()
        {
            Point pntMsgPlace = this.setSettings.RightBottom;
            pntMsgPlace.X = Math.Abs(pntMsgPlace.X - this.Width);
            pntMsgPlace.Y = Math.Abs(pntMsgPlace.Y - this.Height);
            int nDirecionIndex = this.arlstrDirections.IndexOf(this.setSettings.Direction);
            if (nDirecionIndex == 0)
            {
                pntMsgPlace.X = this.rndRandom.Next(pntMsgPlace.X);
                pntMsgPlace.Y = this.rndRandom.Next(pntMsgPlace.Y);
            }
            else
            {
                switch (nDirecionIndex % 3)
                {
                    case (1):
                    {
                        pntMsgPlace.X = this.rndRandom.Next(pntMsgPlace.X / 3);
                        break;
                    }
                    case (2):
                    {
                        pntMsgPlace.X = 
                            this.rndRandom.Next(pntMsgPlace.X / 3) + (pntMsgPlace.X / 3);
                        break;
                    }
                    default:
                    {
                        pntMsgPlace.X = 
                            this.rndRandom.Next(pntMsgPlace.X / 3) + (pntMsgPlace.X / 3 * 2);
                        break;
                    }
                }
                switch ((nDirecionIndex - 1) / 3)
                {
                    case (0):
                        {
                            pntMsgPlace.Y = this.rndRandom.Next(pntMsgPlace.Y / 3);
                            break;
                        }
                    case (1):
                        {
                            pntMsgPlace.Y =
                                this.rndRandom.Next(pntMsgPlace.Y / 3) + (pntMsgPlace.Y / 3);
                            break;
                        }
                    default:
                        {
                            pntMsgPlace.Y =
                                this.rndRandom.Next(pntMsgPlace.Y / 3) + (pntMsgPlace.Y / 3 * 2);
                            break;
                        }
                }
            }
            return (pntMsgPlace);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            this.Visible = false;
            Point p = PointToScreen(e.Location);
            if (Type.GetType("Mono.Runtime") == null)
            {
                Mouse.SendDoubleClick((uint)p.X, (uint)p.Y);
            }
            System.Threading.Thread.Sleep(40);
            this.Visible = true;
        }

        public void HideTransperant()
        {
            this.tmrBetween.Stop();
            this.tmrForEach.Stop();
            this.HideMessage();
            this.Hide();
        }

        #endregion

        #region Events

        // Events
        private void tmrBetween_Tick(object sender, EventArgs e)
        {
            this.tmrForEach.Start();
            this.tmrBetween.Start();
            this.Location = this.PlaceTransperant();
            this.ReplaceMessage();
        }

        private void tmrForEach_Tick(object sender, EventArgs e)
        {
            this.HideMessage();
            this.tmrForEach.Stop();
        }

        private void TransperantMessage_Activated(object sender, EventArgs e)
        {
            this.InitializeTransperant();
        }

        #endregion
    }
}
