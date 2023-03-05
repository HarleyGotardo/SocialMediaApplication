using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public abstract class Post
    {
        public PostMessageType PostType { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public string Description { get; set; }

        public Post(PostMessageType postType, string title, string postContent, string description)
        {
            this.PostType = postType;
            this.Title = title;
            this.PostContent = postContent;
            this.Description = description;
        }
    }
}
