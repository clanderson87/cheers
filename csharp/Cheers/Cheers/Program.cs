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
            //gets, sets name
            var nameQuestion = "Whats your name?";
            Console.WriteLine(nameQuestion);
            var name = Console.ReadLine();

            //gets, sets birthday
            Console.WriteLine("What's your birthday? (MM/dd)");
            var dateString = Console.ReadLine();

            //getting usable system dates for today and birthday
            DateTime today = DateTime.Now;
            DateTime birthday = Convert.ToDateTime(dateString);

            //converts character to upper for cheer.
            var nameUpper = name.ToUpper();

            //filter for'a' and 'an'
            var halfNorseMix = "HALFNORSEMIX";

            //iterates over each char in nameUpper, compares with halfNorseMix
            foreach (var letter in nameUpper)
            {
                //if letter is not in halfNorseMix
                if (halfNorseMix.IndexOf(letter) == -1)
                {
                    Console.WriteLine("Give me a " + letter +"... "+ letter);
                }
                //if letter is in halfNorseMix
                else {

                    Console.WriteLine("Give me an " + letter + "... " + letter);
                };//close if/else
            }//close foreach
            
            //check if today and birthday are the same
            if(today.ToShortDateString() == birthday.ToShortDateString())
            {
                Console.WriteLine("Happy Birthday, " + name);
            } else {
                //gets the difference in birthday and today
                var dayDiff = birthday - today;
                if (birthday > today) {
                    //if dayDif is + (birthday hasn't happened this year)
                    int difference = dayDiff.Days;
                    Console.WriteLine("Your birthday is in {0} days!", difference);
                } else {
                    //if birthday is negative (birthday has happened this year), adds a year of days manually.
                    int difference = dayDiff.Days + 365;
                    Console.WriteLine("Your birthday is in {0} days!", difference);
                }//close nested if/else
            }//close if/else
            Console.WriteLine(name + " is... GRAND!");
            Console.ReadLine();
        }
    }
}
