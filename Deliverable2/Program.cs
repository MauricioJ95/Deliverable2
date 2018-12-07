using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Program
    {
        private static Activities activity;
        static void Main(string[] args)
        {
            activity = new Activities();
            string input;

            var isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Hello user, what are you in the mood for?");
                Console.WriteLine("Here are your options: 1) Action 2) Chill times 3) Danger 4) Good food");
                input = Console.ReadLine();

                isValidInput = activity.IsValidInput(input);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid selection, please choose from the menu");
                }
            }


            Console.WriteLine("How many people are you bringing with you?");

            input = Console.ReadLine();

            var a = new Activities();

            a.Task();

        }
    }
}
