using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConsoleLogging
    {
        public static void BuildDialogue()
        {
            Console.WriteLine("Gathering parts!");
            Thread.Sleep(1000);
            Console.WriteLine("Preparing to build!");
            Thread.Sleep(1000);
        }
    }
}
