using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public class UserProfile : Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string ProfileBirthDate { get; private set; }
        public string Status { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public List<UserProfile> Friends { get; set; }
        public int NumberOfFriends { get; set; }
        public ProfileStatus ProfileStatus { get; set; }

        public UserProfile(string username, string password, string firstName, string lastName, string email, int age, string profileBirthDate, string status, string bio, string address, int numberOfFriends, ProfileStatus profileStatus, List<UserProfile> friends) : base(username, password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.ProfileBirthDate = profileBirthDate;
            this.Status = status;
            this.NumberOfFriends = numberOfFriends;
            this.Bio = bio;
            this.Address = address;
            this.Email = email;
            this.ProfileStatus = profileStatus;
            this.Friends = friends;
        }

        public PrivateMessage PrivateMessage(PrivateMessage pm)
        {
            return pm;
        }

        public GroupMessage GroupMessage(UserProfile sender, Group g, GroupMessage gm) 
        {
            if (!g.Members.Contains(sender))
            {
                throw new Exception("Sender is not a member of the group chat.");
            }
            return gm;
        }

        public SendGroupChatMessage MessageGroupChat(UserProfile sender, GroupChat g, SendGroupChatMessage s)
        {
            if (!g.GroupChatMembers.Contains(sender))
            {
                throw new Exception("Sender is not a member of the group chat.");
            }
            return s;
        }

        public UserProfilePost PostSomething(UserProfilePost post) 
        { 
            return post; 
        }

        public GroupPost PostInGroup(UserProfile sender, GroupPost gp, Group g)
        {
            if (!g.Members.Contains(sender))
            {
                throw new Exception("Sender is not a member of the group chat.");
            }
            return gp;
        }

        public override string ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName + "\n"
                + "Profile Status: " + this.ProfileStatus;
        }
    }
}
