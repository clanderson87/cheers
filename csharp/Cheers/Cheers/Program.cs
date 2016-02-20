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
            var nameUpper = name.ToUpper();
            var halfNorseMix = "HALFNORSEMIX";
            foreach (var letter in nameUpper)
            {
                if (halfNorseMix.IndexOf(letter) == -1)
                {
                    Console.WriteLine("Give me a " + letter);
                }
                else {
                    Console.WriteLine("Give me an " + letter);
                };
            }
            Console.WriteLine(name + " is... GRAND!");
            Console.ReadLine();
        }
    }
}
