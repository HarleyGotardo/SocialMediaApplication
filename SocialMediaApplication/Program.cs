using SocialMediaApplicationFacebook;

public class Program
{
    public static void Main(string[] args)
    {
        UserProfile FacebookUser1 = new UserProfile("Harleyharrr", "harleygwapo123", "harleygothards@gmail.com", "09606623222", "Harley", "Gotardo", 20, "August 24, 2002", "Single", 2000);

        UserProfile FacebookUser2 = new UserProfile("Eren111", "freedom", "erenyeager@gmail.com", "09606229322", "Eren", "Yeager", 23, "December 01, 2002", "Single", 1);

        Console.WriteLine(FacebookUser1);

        Group grp1 = new Group("Secret", "This is a secret group", 0, FacebookUser1);
        Console.WriteLine(grp1);

        GroupPost grp1Post = new GroupPost("Secret", "This is a secret group", 0, FacebookUser1, grp1, "Hello Everyone!", "Text", "Greetings");
        Console.WriteLine(grp1Post);

        PrivateMessage pm1 = new PrivateMessage(FacebookUser2, FacebookUser1, "Hello Eren!", "Dec. 01, 2022, 12:00am", "Text");
        Console.WriteLine(pm1);
    }
}