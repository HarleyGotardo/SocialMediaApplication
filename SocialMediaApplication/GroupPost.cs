using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class GroupPost : Post
    {
        public UserProfile Author { get; private set; }
        public Group Group { get; set; }
        public string Datetime { get; private set; }
        public GroupPost(PostMessageType postType, string title, string postContent, string description, UserProfile author, Group group, string dateTime) : base(postType, title, postContent, description) 
        { 
            this.Author = author;
            this.Group = group;
            this.Datetime = dateTime;
        }

        public override string ToString()
        {
            return "Author: " + this.Author + "\n"
                + "Group: " + this.Group + "\n" 
                + "Post Title: " + this.Title + "\n"
                + "PostType: " + this.PostType + "\n"
                + "Post Content: " + this.PostContent;
        }
    }
}
