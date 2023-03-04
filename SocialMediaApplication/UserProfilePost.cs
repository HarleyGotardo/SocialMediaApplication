using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class UserProfilePost : UserProfile
    {
        public UserProfile PostAuthor { get; private set; }
        public string PostContent { get; set; }
        public PostMessageType PostType { get; set; }
        public string PostTitle { get; set; }

        public UserProfilePost(string username, string password, string firstName, string lastName, string email, int age, string profileBirthDate, string status, string bio, string address, int numberOfFriends, UserProfile postAuthor, string postContent, PostMessageType postType, string postTitle, ProfileStatus profileStatus) : base(username, password, firstName, lastName, email, age, profileBirthDate, status, bio, address, numberOfFriends, profileStatus)
        {
            this.PostAuthor = postAuthor;
            this.PostContent = postContent;
            this.PostType = postType;
            this.PostTitle = postTitle;
        }
    }
}
