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
        public Dictionary<int, string> Mood { get; set; }
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

            Mood = new Dictionary<int, string>
            {
                {1, "Action" },
                {2, "Chilling" },
                {3, "Danger" },
                {4, "Good Food" }
            };
        }


        public void Task(int action, int numberOfPeople)
        {
            var activity = Actions[action];
            var moodFor = Mood[action];

            var output = string.Format("Okay if you're in the mood for {0}, then you should go to {1} and travel in sneakers!", activity, moodFor);
            var output2 = $"Okay if you're in the mood for {moodFor}, then you should go to {activity} and travel in sneakers!";

            if (numberOfPeople < 1)
            {
                Console.WriteLine($"Okay if you're in the mood for {moodFor}, then you should go to {activity} and travel in sneakers!");
            }
            else if (numberOfPeople < 5)
            {
                Console.WriteLine($"Okay if you're in the mood for {moodFor}, then you should go to {activity} and travel in sedan!");

            }
            else if (numberOfPeople < 11)
            {
                Console.WriteLine($"Okay if you're in the mood for {moodFor}, then you should go to {activity} and travel in Volkswagen bus!");
            }
            else if (numberOfPeople > 11)
            {
                Console.WriteLine($"Okay if you're in the mood for {moodFor}, then you should go to {activity} and travel in an airplane!");
            }
            else
            {
                
            }
        }
        public bool IsValidInput(string input)
        {
            return Actions.ContainsKey(int.Parse(input));
        }
    }
}
