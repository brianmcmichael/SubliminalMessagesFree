using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Subliminal
{
    [Serializable]
    class Settings
    {
        #region Members

        // Members
        private static Settings setSettings = null;
        private static BinaryFormatter bnfFormatter = new BinaryFormatter();
        private static Stream stmSerializationStream;
        private string strDirection = "Random";
        private int nTimeBetween = 1;
        private int nTimeForMsg = 1;
        private int nTransperacy = 100;
        private string strAutoStart = "";
        private bool bHadMessagesChanged = false;
        private bool bShuffle = false;
        private Font fntTextFont = new Font("Microsoft Sans Serif", 12);
        private Color clrTextColor = new Color();
        private string strQueueFile = "messages";
        private Point pntRightBottom = 
            new Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width,
                      System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height);
        private ArrayList arlCommandParms;

        #endregion

        #region Consts

        // Consts
        private string strCurrentPath =
            System.IO.Directory.GetCurrentDirectory();
        private const string strSettingsFile = "settings";

        #endregion

        #region Ctor

        // Ctor
        private Settings()
        {
            if (Type.GetType("Mono.Runtime") == null)
            {
                if (File.Exists(System.Windows.Forms.Application.StartupPath + "\\" + strSettingsFile))
                {
                    this.LoadSettings();
                } 
            }
            else
            {
                if (File.Exists(System.Windows.Forms.Application.StartupPath + "/" + strSettingsFile))
                {
                    this.LoadSettings();
                } 
            }
        }

        #endregion

        #region Properties

        // Properties
        public string Direction
        {
            get
            {
                return (this.strDirection);
            }
            set
            {
                this.strDirection = value;
            }
        }

        public int TimeBetween
        {
            get
            {
                return (this.nTimeBetween);
            }
            set
            {
                this.nTimeBetween = value;
            }
        }

        public int TimeForMsg
        {
            get
            {
                return (this.nTimeForMsg);
            }
            set
            {
                this.nTimeForMsg = value;
            }
        }

        public int Transperacy
        {
            get
            {
                return (this.nTransperacy);
            }
            set
            {
                this.nTransperacy = value;
            }
        }

        public string AutoStart
        {
            get
            {
                return (this.strAutoStart);
            }
            set
            {
                this.strAutoStart = value;
            }
        }

        public bool DoShuffle
        {
            get
            {
                return (this.bShuffle);
            }
            set
            {
                this.bShuffle = value;
            }
        }

        public bool HadMessagesChanged
        {
            get
            {
                return (this.bHadMessagesChanged);
            }
            set
            {
                this.bHadMessagesChanged = value;
            }
        }

        public Font TextFont
        {
            get
            {
                return (this.fntTextFont);
            }
            set
            {
                this.fntTextFont = value;
            }
        }

        public Color TextColor
        {
            get
            {
                return (this.clrTextColor);
            }
            set
            {
                this.clrTextColor = value;
            }
        }

        public string CurrentPath
        {
            get
            {
                return (this.strCurrentPath);
            }
        }

        public string MessagesQueueFile
        {
            get
            {
                return (this.strQueueFile);
            }
            set
            {
                this.strQueueFile = value;
            }
        }

        public Point RightBottom
        {
            get
            {
                return (this.pntRightBottom);
            }
        }

        public ArrayList CommandParms
        {
            get
            {
                return (this.arlCommandParms);
            }
            set
            {
                this.arlCommandParms = value;
            }
        }

        #endregion

        #region Methods

        // Methods
        public static Settings GetSettings()
        {
            if (setSettings == null)
            {
                setSettings = new Settings();
            }
            return (setSettings);
        }

        public void LoadSettings()
        {
            try
            {
                if (Type.GetType("Mono.Runtime") == null)
                {
                    stmSerializationStream =
                                    File.Open(System.Windows.Forms.Application.StartupPath + "\\" + strSettingsFile,
                                              FileMode.Open); 
                }
                else
                {
                    stmSerializationStream =
                                    File.Open(System.Windows.Forms.Application.StartupPath + "/" + strSettingsFile,
                                              FileMode.Open);
                }
                Settings setLoaded = bnfFormatter.Deserialize(stmSerializationStream) as Settings;
                this.strDirection = setLoaded.strDirection;
                this.nTimeBetween = setLoaded.nTimeBetween;
                this.nTimeForMsg = setLoaded.nTimeForMsg;
                this.nTransperacy = setLoaded.nTransperacy;
                this.fntTextFont = setLoaded.fntTextFont;
                this.strQueueFile = setLoaded.strQueueFile;
                this.bShuffle = setLoaded.bShuffle;
                this.pntRightBottom = 
                    new Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width,
                              System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height);
                stmSerializationStream.Close();
            }
            catch (FileNotFoundException){}
        }

        public void SaveSettings()
        {
            if (Type.GetType("Mono.Runtime") == null)
            {
                stmSerializationStream =
                    File.Open(System.Windows.Forms.Application.StartupPath + "\\" + strSettingsFile,
                              FileMode.OpenOrCreate);
            }
            else
            {
                stmSerializationStream =
                    File.Open(System.Windows.Forms.Application.StartupPath + "/" + strSettingsFile,
                              FileMode.OpenOrCreate);
            }
            bnfFormatter.Serialize(stmSerializationStream, this);
            stmSerializationStream.Close();
        }

        #endregion
    }
}
