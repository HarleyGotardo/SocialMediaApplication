using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class GroupChat : Message //Group chat, just like in messenger
    {
        public string GroupChatName { get; set; }
        public UserProfile[] GroupChatMembers { get; set; }

        public GroupChat(string groupChatName, UserProfile[] gcMembers, string dateAndTimeOfTheMessage, PostMessageType messageType) : base(dateAndTimeOfTheMessage, messageType) 
        { 
            this.GroupChatName = groupChatName;
            this.GroupChatMembers = gcMembers;
        }
        public override string ToString()
        {
            return "Group Chat Name: " + this.GroupChatName;
        }
    }
}
