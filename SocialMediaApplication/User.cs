using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplication
{
    public abstract class User : Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateOnly BirthDate { get; private set; }
        public string Status { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }

        public User(string username, string password, string email, string phoneNumber, string firstName, string lastName, int age, DateOnly birthDate, string status) : base(username, password, email, phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.BirthDate = birthDate;
            this.Status = status;
        }
    }
}
