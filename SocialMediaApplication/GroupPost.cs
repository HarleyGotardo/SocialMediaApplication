using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class GroupPost : Group
    {
        public Group Group { get; set; }
        public string PostContent { get; set; }
        public PostMessageType PostType { get; set; }
        public string PostTitle { get; set; }

        public GroupPost(string groupName, string description, int totalNumberOfMembers, UserProfile owner, UserProfile[] members, Group group, string postContent, PostMessageType postType, string postTitle) : base(groupName, description, totalNumberOfMembers, owner, members)
        {
            this.Group = group;
            this.PostContent = postContent;
            this.PostType = postType;
            this.PostTitle = postTitle;
        }

        public override string ToString()
        {
            return "\nGroup: " + Group.GroupName + "\n" 
                + "Post Title: " + this.PostTitle + "\n"
                + "PostType: " + this.PostType + "\n"
                + "Post Content: " + this.PostContent;
        }
    }
}
