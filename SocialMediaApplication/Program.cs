using SocialMediaApplicationFacebook;

public class Program
{
    public static void Main(string[] args)
    {
        UserProfile FacebookUser1 = new UserProfile("Harleyharrr", "harleygwapo123", "harleygothards@gmail.com", "09606623222", "Harley", "Gotardo", 20, "August 24, 2002", "Single", 2000);
        
        Console.WriteLine(FacebookUser1);

        Group grp1 = new Group("Secret", "This is a secret group", 0, FacebookUser1);
        Console.WriteLine(grp1);

        GroupPost grp1Post = new GroupPost(grp1, "Hello Everyone!", "Text", "Greetings");
        Console.WriteLine(grp1Post);
    }
}