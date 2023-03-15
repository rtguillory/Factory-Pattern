namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("What type of furry friend would you like?\nYou can type bear, frog, or bunny");
            string userFurryFriend = Console.ReadLine();

            var furryType = FurryFriendFactory.GetFurryFriend(userFurryFriend);
            furryType.Build();
        }
    }
}
