using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameQuestion = "Whats your name?";
            Console.WriteLine(nameQuestion);
            var name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}
