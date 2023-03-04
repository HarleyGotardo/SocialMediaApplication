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
        public string ProfileBirthDate { get; private set; }
        public string Status { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public int NumberOfFriends { get; set; }

        public UserProfile(string username, string password, string email, string phoneNumber, string firstName, string lastName, int age, string ProfileBirthDate, string status, int numberOfFriends) : base(username, password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.ProfileBirthDate = ProfileBirthDate;
            this.Status = status;
            this.NumberOfFriends = numberOfFriends;
        }

        public override void Post()
        {
            Console.WriteLine("What's on your Mind?: ");
            string content = Console.ReadLine();
            Console.WriteLine(this.FirstName + " posted: " + content);
        }

        public override string ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName;
        }
    }
}
