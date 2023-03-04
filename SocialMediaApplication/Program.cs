using SocialMediaApplicationFacebook;

public class Program
{
    public static void Main(string[] args)
    {
        UserProfile FacebookUser1 = new UserProfile("Harleyharrrr", "harleygwapo123", "Harley", "Gotardo", "harley@gmail.com", 20, "August 24, 2002", "Single", "Hehe", "Hilltop Zone", 2000, ProfileStatus.Gaming);

        UserProfile FacebookUser2 = new UserProfile("eren111", "freedom143", "Eren", "Yeager", "freedom@gmail.com", 23, "December 2, 2000", "Single", "I love freedom", "Eldia", 1, ProfileStatus.Busy);

        Console.WriteLine(FacebookUser1);

        UserProfile[] grp1Members = { FacebookUser1, FacebookUser2 };
        int grp1TotalNumberOfMembers = grp1Members.Length;

        Group grp1 = new Group("Secret", "This is a secret group", grp1TotalNumberOfMembers, FacebookUser1, grp1Members);
        Console.WriteLine(grp1);

        GroupPost grp1Post = new GroupPost("Secret", "Nothing", grp1TotalNumberOfMembers, FacebookUser1, grp1Members, grp1, "Hello", PostMessageType.Text, "Greetings");
        Console.WriteLine(grp1Post);

        PrivateMessage pm1 = new PrivateMessage(FacebookUser2, FacebookUser1, "Hello Eren!", "Dec. 01, 2022, 12:00am", PostMessageType.Text);
        Console.WriteLine(pm1);
    }
}