using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CuddlyBunny : IFurryFriend
    {
        public void Build()
        {
            ConsoleLogging.BuildDialogue();
            Console.WriteLine("Building furry friend Cuddly Bunny!");
        }
    }
}
