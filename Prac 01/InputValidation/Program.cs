using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("How often do you hear a drip drop (in seconds)?");
                string n = Console.ReadLine();
                int m;

                if (Int32.TryParse(n, out m))
                {


                    double litres = 86400 / m * 0.00025;
                    double glasses = litres / 0.250;
                    double total = Math.Floor(glasses);

                    string result = string.Format("This wastes {0} glasses of water per day.", total);

                    Console.WriteLine(result);
                    Console.ReadLine();
                    break;
                    
                }

                else
                {
                    Console.Write("Please try again.");
                }

            }



        }





    }
}


