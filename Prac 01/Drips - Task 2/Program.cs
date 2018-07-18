using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips___Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip drop (in seconds)?");
            string n = Console.ReadLine();
            int m = Convert.ToInt32(n);

            double hours = 3600 / m * 0.00025;
            double days = 86400 / m * 0.00025;
            double weeks = 604800 / m * 0.00025;

            string result1 = string.Format("This wastes {0} litres of water per hour.", hours);
            string result2 = string.Format("This wastes {0} litres of water per day.", days);
            string result3 = string.Format("This wastes {0} litres of water per week.", weeks);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            // This extra ReadLine keeps the console window open while we admire our results.
            string dummy = Console.ReadLine();
        }
    }
}
