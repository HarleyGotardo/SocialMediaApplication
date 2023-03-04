using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class PagePost : Page
    {
        public UserProfile Author { get; private set; }
        public string PostTitle { get; set; }
        public string PostContent { get; set; }
        public PostMessageType PostType { get; set; }

        public PagePost(string pageName, UserProfile admin, string about, string pageDescription, int numberOfFollowers, int numberOfLikes, UserProfile author, string postTitle, string postContent, PostMessageType postType) : base(pageName, admin, about, pageDescription, numberOfFollowers, numberOfLikes)
        {
            this.Author = author;
            this.PostTitle = postTitle;
            this.PostContent = postContent;
            this.PostType = postType;
        }

        public override string ToString()
        {
            return "\nPage: " + this.PageName + "\n" 
                + "PostType: " + this.PostType + "\n"
                + "Author: " + this.Author + "\n"
                + "Post Title: " + this.PostTitle + "\n"
                + "Post Content: " + this.PostContent + "\n";
        }
    }
}
