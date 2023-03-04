using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class SendGroupChatMessage : GroupChat
    {
        public UserProfile Sender { get; private set; }
        public string MessageContent { get; private set; }
        public GroupChat GroupChat { get; private set; }

        public SendGroupChatMessage(string groupChatName, UserProfile[] gcMembers, string dateAndTimeOfTheMessage, PostMessageType messageType, UserProfile sender, string messageContent, GroupChat groupChat) : base(groupChatName, gcMembers, dateAndTimeOfTheMessage, messageType)
        {
            Sender = sender;
            MessageContent = messageContent;
            GroupChat = groupChat;
        }

        public override string ToString()
        {
            return "Sender: " + this.Sender + "\n"
                + "Group Chat: " + this.GroupChat + "\n"
                + "Message: " + this.MessageContent + "\n"
                + "Date and Time: " + this.DateAndTimeOfTheMessage + "\n"
                + "Message Type: " + this.MessageType;
        }
    }
}
