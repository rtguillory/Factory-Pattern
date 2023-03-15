using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FurryFriendFactory
    {
        public static IFurryFriend GetFurryFriend(string furryType)
        {
            switch (furryType.ToLower())
            {
                case "bear":
                    return new TeddyBear();
                case "frog":
                    return new ToadFrog();
                case "bunny":
                    return new CuddlyBunny();
                default:
                    return new TeddyBear();
            }
        }
    }
}
