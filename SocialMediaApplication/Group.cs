using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class Group
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
        public int TotalNumberOfMembers { get; set; }
        public UserProfile Owner { get; set; }
        public UserProfile[] Members { get; set; }
        public Group(string groupName, string description, int totalNumberOfMembers, UserProfile owner, UserProfile[] members)
        {
            this.GroupName = groupName;
            this.Description = description;
            this.TotalNumberOfMembers = totalNumberOfMembers;
            this.Owner = owner;
            this.Members = members;
        }

        public GroupPost Post(GroupPost gp)
        {
            return gp;
        }

        public GroupMessage Message(GroupMessage gp) { return gp; }

        public override string ToString()
        {
            return "\nGroup Name: " + this.GroupName + "\n"
                + "Group Description: " + this.Description + "\n"
                + "Members: " + this.TotalNumberOfMembers;
        }
    }
}
