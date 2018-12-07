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

        public Activities()
        {
            Num = new[] { 1, 2, 3, 4 };
            Activity = new string[] { "Stock Car Racing", "Hiking", "Skydiving", "Taco Bell" };
            Actions = new Dictionary<int, string>();

            Actions.Add(1, "Stock car Racing");
            Actions.Add(2, "Stock car Racing");
            Actions.Add(3, "Stock car Racing");
            Actions.Add(4, "Stock car Racing");
        }

        public bool IsValidInput(string input)
        {
            return Actions.ContainsKey(int.Parse(input));
        }
    }
}
