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
        public Group(string groupName, string description, int totalNumberOfMembers, UserProfile owner)
        {
            this.GroupName = groupName;
            this.Description = description;
            this.TotalNumberOfMembers = totalNumberOfMembers;
            this.Owner = owner;
        }

        public override string ToString()
        {
            return "\nGroup Name: " + this.GroupName + "\n"
                + "Group Description: " + this.Description + "\n"
                + "Members: " + this.TotalNumberOfMembers;
        }
    }
}
