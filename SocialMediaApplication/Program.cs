using SocialMediaApplicationFacebook;

public class Program
{
    public static void Main(string[] args)
    {
        List<UserProfile> Friends1 = new List<UserProfile> { };
        List<UserProfile> Friends2 = new List<UserProfile> { };
        List<UserProfile> Friends3 = new List<UserProfile> { };
        List<UserProfile> Friends4 = new List<UserProfile> { };
        //all of these object instantiations are just a tests
        UserProfile FacebookUser1 = new UserProfile("Harleyharrrr", "harleygwapo123", "Harley", "Gotardo", "harley@gmail.com", 20, "August 24, 2002", "Single", "Hehe", "Hilltop Zone", Friends1.Count, ProfileStatus.Gaming, Friends1);

        UserProfile FacebookUser2 = new UserProfile("eren111", "freedom143", "Eren", "Yeager", "freedom@gmail.com", 23, "December 2, 2000", "Single", "I love freedom", "Eldia", Friends2.Count, ProfileStatus.Busy, Friends2);

        Console.WriteLine(FacebookUser1);

        PrivateMessage pm1 = new PrivateMessage(FacebookUser2, "Hi!", FacebookUser1, "September 07, 2022", PostMessageType.Text);
        Console.WriteLine(pm1);

        UserProfile Sam = new UserProfile("HEHE", "12345", "Juan", "Dela Cruz", "juandc@gmail.com", 10, "February 02, 2013", "Single", "Im a kid", "Cebu", Friends4.Count, ProfileStatus.Sleeping, Friends4);

        UserProfile Mel = new UserProfile("Melll", "melgwapo123", "Mel", "Dela Cruz", "mel@gmail.com", 20, "March 08, 2002", "Single", "Hello world", "Cebu", Friends3.Count, ProfileStatus.Online, Friends3);

        List<UserProfile> GroupMembers = new List<UserProfile> { FacebookUser1, FacebookUser2 };

    }
}