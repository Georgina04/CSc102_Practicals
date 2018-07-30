using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaxCalculator
{
    class Program
    {
        static int taxcalculation(int age, double salary)
        {

            if (age >= 20 && age <= 100)
            {
                int tax = 0;

                if ((salary >= 0) && (salary <= 4999))
                {
                    tax = 0;
                }

                if ((salary >= 5000) && (salary <= 6499))
                {
                    if (age < 65)
                    {
                        tax = 13;
                    }
                    else
                    {
                        tax = 0;
                    }

                }

                if ((salary >= 6500) && (salary <= 7799))
                {
                    if (age < 65)
                    {
                        tax = 250;
                    }
                    else
                    {
                        tax = 0;
                    }
                }

                if ((salary >= 7800) && (salary <= 9999))
                {
                    if (age < 65)
                    {
                        tax = 620;
                    }
                    else
                    {
                        tax = 0;
                    }
                }

                if ((salary >= 10000) && (salary <= 13499))
                {
                    if (age < 65)
                    {
                        tax = 1200;
                    }
                    else if ((age >= 65) && (age <= 75))
                    {
                        tax = 600;
                    }
                    else
                    {
                        tax = 400;
                    }
                }

                if ((salary >= 13500) && (salary <= 17899))
                {
                    if (age < 65)
                    {
                        tax = 2100;
                    }
                    else if ((age >= 65) && (age <= 75))
                    {
                        tax = 1500;
                    }
                    else
                    {
                        tax = 1200;
                    }
                }

                if ((salary >= 17900) && (salary <= 19999))
                {
                    if (age < 65)
                    {
                        tax = 2700;
                    }
                    else if ((age >= 65) && (age <= 75))
                    {
                        tax = 2000;
                    }
                    else
                    {
                        tax = 1800;
                    }
                }

                if ((salary >= 20000) && (salary <= 39999))
                {
                    if (age < 65)
                    {
                        tax = 8000;
                    }
                    else if ((age >= 65) && (age <= 75))
                    {
                        tax = 7500;
                    }
                    else
                    {
                        tax = 7300;
                    }
                }

                if ((salary >= 40000) && (salary <= 59999))
                {
                    if (age < 65)
                    {
                        tax = 16000;
                    }
                    else if ((age >= 65) && (age <= 75))
                    {
                        tax = 15600;
                    }
                    else
                    {
                        tax = 15400;
                    }
                }

                else if (salary >= 60000)
                {
                    if (age < 65)
                    {
                        tax = 20000;
                    }
                    else if ((age >= 65) && (age <= 75))
                    {
                        tax = 17050;
                    }
                    else
                    {
                        tax = 17000;
                    }
                }
                else
                {
                    Console.Write("This is not a valid salary");
                    return -1;
                }

                return tax;
            }

            else
            {
                Console.Write("This is not a valid age");
                return -1;
            }
            
        }

        static void Main(string[] args)
        {
            int count = 0, agecount = 0, taxcount = 0, salcount = 0;
            int age = 0, agesum = 0;
            double sal = 0, salsum = 0, taxsum = 0;

            while (count != args.Length)
            {
                if (args[count].Contains(",") == false)
                {
                    agesum += Convert.ToInt32(args[count]);
                    agecount++;
                    count++;
                }

                else
                {
                    salsum += Convert.ToDouble(args[count]);
                    salcount++;
                    count++; 
                }
            }

            for (int i = 0; i < args.Length; i = i + 2)
            {
                sal = Convert.ToDouble(args[i]);
                age = Convert.ToInt32(args[i + 1]);
                int tax = taxcalculation(age, sal);

                if (tax != -1)
                {
                    taxsum += tax;
                    taxcount++;
                }
            }

            int avage = agesum / agecount;
            double avsal = salsum / salcount;
            double avtax = taxsum / taxcount;

            Console.Write("Average age of the taxpayers was {0}\nAverage salary of the taxpayers was R{1}\nAverage tax paid by the taxpayers was R{2}\n", avage, avsal, avtax);

            Console.Write("Press Enter to continue . . .");
            Console.ReadLine();

        }
    }
} 

