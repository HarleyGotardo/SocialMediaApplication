using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class GroupChat //Group chat, just like in messenger
    {
        public string GroupChatName { get; set; }
        public UserProfile[] GroupChatMembers { get; set; }
        public int TotalNumberOfMembers { get; set; }
        public GroupChat(string groupChatName, UserProfile[] gcMembers, int totalMembers)
        { 
            this.GroupChatName = groupChatName;
            this.GroupChatMembers = gcMembers;
            this.TotalNumberOfMembers = totalMembers;
        }
        public override string ToString()
        {
            return "Group Chat Name: " + this.GroupChatName;
        }
    }
}
