using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class UserProfilePost : Post
    {
        public UserProfile UserAuthor { get; private set; }
        public string DateAndTimeOfThePost { get; private set; }

        public UserProfilePost(UserProfile userAuthor, string dateAndTimeOfThePost, PostMessageType postType, string title, string postContent, string description) : base(postType, title, postContent, description)
        {
            this.UserAuthor = userAuthor;
            this.DateAndTimeOfThePost = dateAndTimeOfThePost;
        }

        public override string ToString()
        {
            return "\nAuthor: " + this.UserAuthor + "\n"
                + "Post Title: " + this.Title + "\n"
                + "PostType: " + this.PostType + "\n"
                + "Post Content: " + this.PostContent + "\n"
                + "Date and Time: " + this.DateAndTimeOfThePost;
        }
    }
}
