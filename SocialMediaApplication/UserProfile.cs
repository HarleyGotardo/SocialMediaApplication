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
        public string Email { get; set; }
        public int Age { get; set; }
        public string ProfileBirthDate { get; private set; }
        public string Status { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public int NumberOfFriends { get; set; }
        public ProfileStatus ProfileStatus { get; set; }

        public UserProfile(string username, string password, string firstName, string lastName, string email, int age, string profileBirthDate, string status, string bio, string address, int numberOfFriends, ProfileStatus profileStatus) : base(username, password)
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
        }

        public PrivateMessage PrivateMessage(PrivateMessage pm)
        {
            return pm;
        }

        public GroupMessage GroupMessage(Group g, GroupMessage gm) 
        {
            for(int i=0; i<g.Members.Length; i++)
            {
                if (this.Username != g.Members[i].Username)
                    Console.WriteLine("Can't Message this group, you're not a member.");
                else 
                    return gm;
            }
            return gm;
        }

        public SendGroupChatMessage MessageGroupChat(GroupChat g, SendGroupChatMessage s)
        {
            for (int i = 0; i < g.GroupChatMembers.Length; i++)
            {
                if (this.Username != g.GroupChatMembers[i].Username)
                    Console.WriteLine("Can't Message this group, you're not a member.");
                else
                    return s;
            }
            return s; 
        }

        public UserProfilePost PostSomething(UserProfilePost post) 
        { 
            return post; 
        }

        public GroupPost PostInGroup(GroupPost gp)
        {
            for (int i = 0; i < gp.Members.Length; i++)
            {
                if (this.Username != gp.Members[i].Username)
                    Console.WriteLine("Can't post in this group, you're not a member.");
                else
                    return gp;
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
