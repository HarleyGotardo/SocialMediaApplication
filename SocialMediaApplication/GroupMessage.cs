using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class GroupMessage : Message //Messages in group
    {
        public Group ReceiverGroup { get; set; }
        public GroupMessage(UserProfile sender, string messageContent, Group receiverGroup, string dateAndTimeOfTheMessage, PostMessageType messageType) : base(sender, messageContent, dateAndTimeOfTheMessage, messageType)
        {
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
