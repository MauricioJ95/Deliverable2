using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Activities
    {
        Dictionary<int, string> Actions { get; set; }
        public int[] Num { get; set; }
        public string[] Activity { get; set; }
        public int numberofPeople { get; set; }

        public Activities()
        {
            Num = new[] { 1, 2, 3, 4 };
            Activity = new string[] { "Stock Car Racing", "Hiking", "Skydiving", "Taco Bell" };
            Actions = new Dictionary<int, string>
            {
                {1, "Stock Car Racing" },
                {2, "Hiking" },
                {3, "Skydiving" },
                {4, "Taco Bell" }   
            };

        }

            public void Task()
            {
                
                if (numberofPeople < 1)
                {
                    Console.WriteLine("Okay if you're in the mood for " + (Num) + ", then you should go to " + (Activity) + "and travel in sneakers!");
                }
                else if (numberofPeople < 5)
                {
                    Console.WriteLine("Okay if you're in the mood for " + (Num) + ", then you should go to " + (Activity) + "and travel in sedan!");
                }
                else if (numberofPeople < 11)
                {
                    Console.WriteLine("Okay if you're in the mood for " + (Num) + ", then you should go to " + (Activity) + "and travel in a Volkswagen bus!");
                }
                else if (numberofPeople > 11)
                {
                    Console.WriteLine("Okay if you're in the mood for " + (Num) + ", then you should go to " + (Activity) + "and travel in an airplane!");
                }
                else
                {
                    Console.WriteLine("what is you doing?");
                }
            }
        public bool IsValidInput(string input)
        {
            return Actions.ContainsKey(int.Parse(input));
        }
    }
}
