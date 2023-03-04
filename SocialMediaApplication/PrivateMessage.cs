using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class PrivateMessage : Message
    {
        public UserProfile Receiver { get; set; }
        public PrivateMessage(UserProfile sender, string messageContent, UserProfile receiver, string dateAndTimeOfTheMessage, PostMessageType messageType) : base(sender, messageContent, dateAndTimeOfTheMessage, messageType)
        {
            this.Receiver = receiver;
        }

        public override string ToString()
        {
            return "\nMessage Content: " + this.MessageContent + "\n"
                + "Sender: " + this.Sender + "\n"
                + "Receiver: " + this.Receiver + "\n"
                + "Date Sent: " + this.DateAndTimeOfTheMessage;
        }
    }
}
