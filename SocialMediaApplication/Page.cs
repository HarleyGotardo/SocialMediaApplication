using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public abstract class Page
    {
        public string PageName { get; set; }
        public UserProfile Admin { get; set; }
        public string About { get; set; }
        public string PageDescription { get; set; }
        public int NumberOfFollowers { get; set; }
        public int NumberOfLikes { get; set; }

        public Page(string pageName, UserProfile admin, string about, string pageDescription, int numberOfFollowers, int numberOfLikes)
        {
            this.PageName = pageName;
            this.Admin = admin;
            this.About = about;
            this.PageDescription = pageDescription;
            this.NumberOfFollowers = numberOfFollowers;
            this.NumberOfLikes = numberOfLikes;
        }

        public override string ToString()
        {
            return "\nPage Name: " + this.PageName + "\n"
                + "Page Admin: " + this.Admin + "\n"
                + "About: " + this.About + "\n"
                + "Page Description: " + this.PageDescription + "\n"
                + "Number of Followers: " + this.NumberOfFollowers + "\n"
                + "Number of Likes: " + this.NumberOfLikes;
        }
    }
}
