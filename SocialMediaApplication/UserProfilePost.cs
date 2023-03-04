using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class UserProfilePost
    {
        public UserProfile PostAuthor { get; private set; }
        public string PostContent { get; set; }
        public string PostType { get; set; }
        public string PostTitle { get; set; }

        public UserProfilePost(UserProfile postAuthor, string postContent, string postType, string postTitle)
        {
            this.PostAuthor = postAuthor;
            this.PostContent = postContent;
            this.PostType = postType;
            this.PostTitle = postTitle;
        }
    }
}
