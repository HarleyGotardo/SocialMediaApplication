using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class GroupMessage : Message //Messages in group
    {
        public UserProfile Sender { get; set; }
        public Group ReceiverGroup { get; set; }
        public string MessageContent { get; private set; }
        public GroupMessage(UserProfile sender, Group receiverGroup, string MessageContent, string dateAndTimeOfTheMessage, PostMessageType messageType) : base(dateAndTimeOfTheMessage, messageType)
        {
            this.MessageContent = MessageContent;
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
