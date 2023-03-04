using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class PrivateMessage : Message
    {
        public UserProfile Sender { get; private set; }
        public UserProfile Receiver { get; set; }

        public PrivateMessage(UserProfile receiver, UserProfile sender, string messageContent, string dateAndTimeOfTheMessage, string messageType) : base(sender, messageContent, dateAndTimeOfTheMessage, messageType)
        {
            this.Sender = sender;
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
