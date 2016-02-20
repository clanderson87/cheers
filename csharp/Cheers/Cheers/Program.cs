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
            //var giveMe = "Give me";
            var halfNorseMix = "HALFNORSEMIX";
            foreach (var letter in name)
            {
                //if(name[letter] == 'a' || name[letter] == 'e' || name[letter] == 'i' || name[letter] == 'o' || name[letter] == 'u')
                if (halfNorseMix.IndexOf(letter) == -1)
                {
                    Console.WriteLine("Give me a " + letter);
                }
                else {
                    Console.WriteLine("Give me an " + letter);
                };
            }
            Console.WriteLine("press any key to bye bye");
            Console.ReadLine();
        }
    }
}
