using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class PagePost : Post
    {
        public PagePost Page { get; private set; }
        public string DateTime { get; private set; }
        public PagePost(PagePost page, string dateTime, PostMessageType postType, string title, string postContent, string description) : base(postType, title, postContent, description) 
        {
            this.Page = page;
            this.DateTime = dateTime;
        }

        public override string ToString()
        {
            return "\nPage: " + this.Page + "\n" 
                + "PostType: " + this.PostType + "\n"
                + "Post Title: " + this.Title + "\n"
                + "Post Content: " + this.PostContent + "\n";
        }
    }
}
