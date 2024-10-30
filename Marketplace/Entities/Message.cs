using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Entities
{
    public class Message
    {
        public int MessageID { get; private set; }
        public string SenderID { get; private set; }
        public string ReciverID { get; private set; }
        public string Title { get; private set; }
        public string MessageText {  get; private set; }

        public Message(string senderID, string reciverID, string title, string messageText)
        {
            SenderID = senderID;
            ReciverID = reciverID;
            Title = title;
            MessageText = messageText;
        }

        //För DB mapping
        public Message(int messageID, string senderID, string reciverID, string title, string messageText)
        {
            MessageID = messageID;
            SenderID = senderID;
            ReciverID = reciverID;
            Title = title;
            MessageText = messageText;
        }
    }
}
