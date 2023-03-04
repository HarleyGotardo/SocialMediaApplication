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
        public PostMessageType MessageType { get; set; }
        public string DateAndTimeOfTheMessage { get; private set; }
        public SendGroupChatMessage(string groupChatName, UserProfile[] gcMembers, int totalMembers, UserProfile sender, string messageContent, GroupChat groupChat, PostMessageType message, string dateAndTimeOfTheMessage) : base(groupChatName, gcMembers, totalMembers)
        {
            this.Sender = sender;
            this.MessageContent = messageContent;
            this.GroupChat = groupChat;
            this.DateAndTimeOfTheMessage = dateAndTimeOfTheMessage;
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
