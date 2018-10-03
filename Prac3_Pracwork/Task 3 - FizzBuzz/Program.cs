using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            while (count <= 100)
            {
                if ((count % 3 == 0) && (count % 5 == 0))
                {
                    Console.Write("fizzbuzz\n");
                    count += 1;
                }
                else if (count % 3 == 0)
                {
                    Console.Write("fizz\n");
                    count += 1;
                }

                else if (count % 5 == 0)
                {
                    Console.Write("buzz\n");
                    count += 1;
                }

                else
                {
                    Console.WriteLine(count);
                    count += 1;
                }

                Console.Read();
                

            }
        }
    }
}
