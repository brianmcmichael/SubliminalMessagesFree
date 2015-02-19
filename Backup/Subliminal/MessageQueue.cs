using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Subliminal
{
    [Serializable]
    class MessageQueue : ArrayList
    {
        #region Members

        // Members
        static private MessageQueue msqQueue = null;
        private static BinaryFormatter bnfFormatter = new BinaryFormatter();
        private static Stream stmSerializationStream;

        #endregion

        #region Ctor

        // Ctor
        private MessageQueue()
        {
            if (File.Exists(Settings.GetSettings().MessagesQueueFile))
            {
                this.LoadMessages();
            }
        }

        #endregion

        #region Methods

        // Methods

        public static MessageQueue GetMsgQueue()
        {
            if (msqQueue == null)
            {
                msqQueue = new MessageQueue();
            }
            return(msqQueue);
        }

        public void SaveMessages()
        {
            if (Type.GetType("Mono.Runtime") == null)
            {
                stmSerializationStream =
                    File.Open(Settings.GetSettings().CurrentPath + "\\" +
                                  Settings.GetSettings().MessagesQueueFile,
                              FileMode.OpenOrCreate);
            }
            else
            {
                stmSerializationStream =
                    File.Open(Settings.GetSettings().CurrentPath + "/" +
                                  Settings.GetSettings().MessagesQueueFile,
                              FileMode.OpenOrCreate);
            }
            bnfFormatter.Serialize(stmSerializationStream,this);
            stmSerializationStream.Close();
        }

        public void LoadMessages()
        {
            try
            {
                if (Type.GetType("Mono.Runtime") == null)
                {
                    stmSerializationStream =
                                        File.Open(Settings.GetSettings().CurrentPath + "\\" +
                                                      Settings.GetSettings().MessagesQueueFile,
                                                  FileMode.Open); 
                }
                else
                {
                    stmSerializationStream =
                                        File.Open(Settings.GetSettings().CurrentPath + "/" +
                                                      Settings.GetSettings().MessagesQueueFile,
                                                  FileMode.Open); 
                }
                MessageQueue msqLoaded = bnfFormatter.Deserialize(stmSerializationStream) as MessageQueue;
                this.Clear();
                foreach (object item in msqLoaded)
                {
                    this.Add(item);
                }
                stmSerializationStream.Close();
            }
            catch (FileNotFoundException){}
        }

        public object Enqueue()
        {
            if (this.Count != 0)
            {
                object objMsgCurrent = this[0];
                this.RemoveAt(0);
                this.Add(objMsgCurrent);
                return (objMsgCurrent); 
            }
            else
            {
                return (null);
            }
        }

        #endregion
    }
}
