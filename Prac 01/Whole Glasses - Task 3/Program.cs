using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whole_Glasses___Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip drop (in seconds)?");
            string n = Console.ReadLine();
            int m = Convert.ToInt32(n);

            double litres = 86400 / m * 0.00025;
            double glasses = litres / 0.250;
            double total = Math.Floor(glasses);
            
            string result = string.Format("This wastes {0} glasses of water per day.", total);

            Console.WriteLine(result);

            // This extra ReadLine keeps the console window open while we admire our results.
            string dummy = Console.ReadLine();
        }
    }
}
