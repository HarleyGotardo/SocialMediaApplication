using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class UserProfile : Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateOnly ProfileBirthDate { get; private set; }
        public string Status { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public int NumberOfFriends { get; set; }
        public string CommentContent { get; set; }

        public UserProfile(string username, string password, string email, string phoneNumber, string firstName, string lastName, int age, DateOnly ProfileBirthDate, string status, int numberOfFriends, string commentContent)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.ProfileBirthDate = ProfileBirthDate;
            this.Status = status;
            this.NumberOfFriends = numberOfFriends;
            this.CommentContent = commentContent;
        }

        public static string Comment(UserProfile p, string content)
        {
            UserProfile.CommentContent = content;
            return content;
        }
    }
}
