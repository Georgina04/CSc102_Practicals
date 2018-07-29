using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double av_sal = 0, av_age = 0, av_tax = 0;
            int counter = 0;
            int numElements = args.Length;
            while (counter < numElements)
            {
                string sal = Convert.ToString(args[counter]), ag = Convert.ToString(args[counter + 1]);

                double salary, age;
                if ((double.TryParse(sal, out salary)) && (double.TryParse(ag, out age)))
                {
                    salary = Convert.ToDouble(sal);
                    age = Convert.ToDouble(ag);
                    if (((age < 20) || age > 100) && (salary < 0))
                    {
                        Console.WriteLine("Invalid entry \nPress enter to exit");
                        Console.ReadLine();
                    }

                    else if (((salary < 10000) && (age > 65)) || (((salary < 5000) && (age < 65)))) { av_sal += 0; }
                    else if (age < 65)
                    {
                        if (salary <= 6499) { av_sal += 13; }
                        else if (salary <= 7799) { av_sal += 250; }
                        else if (salary <= 9999) { av_sal += 620; }
                        else if (salary <= 13499) { av_sal += 1200; }
                        else if (salary <= 17899) { av_sal += 2100; }
                        else if (salary <= 19999) { av_sal += 2700; }
                        else if (salary <= 39999) { av_sal += 8000; }
                        else if (salary <= 59999) { av_sal += 16000; }
                        else { av_sal += 20000; }

                    }

                    else if (age <= 75)
                    {
                        if (salary <= 13499) { av_sal += 600; }
                        else if (salary <= 17899) { av_sal += 1500; }
                        else if (salary <= 19999) { av_sal += 2000; }
                        else if (salary <= 39999) { av_sal += 7500; }
                        else if (salary <= 59999) { av_sal += 15600; }
                        else { av_sal += 17050; }
                    }
                    else
                    {
                        if (salary <= 13499) { av_sal += 400; }
                        else if (salary <= 17899) { av_sal += 1200; }
                        else if (salary <= 19999) { av_sal += 1800; }
                        else if (salary <= 39999) { av_sal += 7300; }
                        else if (salary <= 59999) { av_sal += 15400; }
                        else { av_sal += 17000; }
                    }

                    av_tax += salary;
                    av_age += age;
                }
                else
                {
                    Console.WriteLine("Invalid entry \nPress enter to exit");
                    Console.ReadLine();
                }


                counter += 2;
            }
            double print = (av_age / (numElements / 2));
            Console.WriteLine("Average age of taxpayers is " + Math.Floor(av_age / (numElements / 2)));
            Console.WriteLine("Average monthly salary R" + Math.Round(print, 2));
            Console.WriteLine("Averege tax of taxpayesr is R" + (av_sal / (numElements / 2)));
            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();



        }
    }
}

