using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class GroupPost
    {
        public Group Group { get; set; }
        public string PostContent { get; set; }
        public string PostType { get; set; }
        public string PostTitle { get; set; }

        public GroupPost(Group group, string postContent, string postType, string postTitle)
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
