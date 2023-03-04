using SocialMediaApplicationFacebook;

public class Program
{
    public static void Main(string[] args)
    {
        //all of these object instantiations are just a tests
        UserProfile FacebookUser1 = new UserProfile("Harleyharrrr", "harleygwapo123", "Harley", "Gotardo", "harley@gmail.com", 20, "August 24, 2002", "Single", "Hehe", "Hilltop Zone", 2000, ProfileStatus.Gaming);

        UserProfile FacebookUser2 = new UserProfile("eren111", "freedom143", "Eren", "Yeager", "freedom@gmail.com", 23, "December 2, 2000", "Single", "I love freedom", "Eldia", 1, ProfileStatus.Busy);

        Console.WriteLine(FacebookUser1);

        UserProfile[] grp1Members = { FacebookUser1, FacebookUser2 };
        int grp1TotalNumberOfMembers = grp1Members.Length;

        Group grp1 = new Group("Secret", "This is a secret group", grp1TotalNumberOfMembers, FacebookUser1, grp1Members);
        Console.WriteLine(grp1);

        GroupPost grp1Post = new GroupPost("Secret", "Nothing", grp1TotalNumberOfMembers, FacebookUser1, grp1Members, grp1, "Hello", PostMessageType.Text, "Greetings");
        Console.WriteLine(grp1Post);

        PrivateMessage pm1 = new PrivateMessage(FacebookUser2, "Hi!", FacebookUser1, "September 07, 2022", PostMessageType.Text);
        Console.WriteLine(pm1);

        UserProfile Sam = new UserProfile("HEHE", "12345", "Juan", "Dela Cruz", "juandc@gmail.com", 10, "February 02, 2013", "Single", "Im a kid", "Cebu", 200, ProfileStatus.Sleeping);

        UserProfile Mel = new UserProfile("Melll", "melgwapo123", "Mel", "Dela Cruz", "mel@gmail.com", 20, "March 08, 2002", "Single", "Hello world", "Cebu", 2000, ProfileStatus.Online);

        UserProfile[] FamilyMembersGC = { Sam, Mel };
        GroupChat WaRaGud = new GroupChat("Family", FamilyMembersGC, FamilyMembersGC.Length);

        SendGroupChatMessage GcMsg1 = new SendGroupChatMessage(WaRaGud.GroupChatName, FamilyMembersGC, FamilyMembersGC.Length, Sam, "Hello Fam!", WaRaGud, PostMessageType.Text, "September 05, 2005");
    }
}