using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class GroupMessage : Message
    {
        public UserProfile Sender { get; set; }
        public Group ReceiverGroup { get; set; }

        public GroupMessage(UserProfile sender, Group receiverGroup, string messageContent, string dateAndTimeOfTheMessage, string messageType) : base(sender, messageContent, dateAndTimeOfTheMessage, messageType)
        {
            this.Sender = sender;
            this.ReceiverGroup = receiverGroup;
        }

        public override string ToString()
        {
            return "\nMessage Content: " + this.MessageContent + "\n"
                + "Sender: " + this.Sender + "\n"
                + "Receiver: " + this.ReceiverGroup + "\n"
                + "Date Sent: " + this.DateAndTimeOfTheMessage;
        }
    }
}
