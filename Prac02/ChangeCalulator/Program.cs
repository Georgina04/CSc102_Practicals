using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("----Please enter an amount:");
            string n = Console.ReadLine();
            //string n;
            if (n.IndexOf(".") != -1)
            {
                n = n.Replace(".", "");
                //Console.WriteLine(n);

            }
            else
            {
                n += "00";
            }
            double m;
            

            if (Double.TryParse(n, out m))
            {

                double rands = m;

                if (rands / 20000 >= 1)
                {
                    double two = rands / 20000;
                    double two1 = Math.Floor(two);
                    int two2 = Convert.ToInt32(two1);
                    rands = rands - (20000 * two2);
                    string result_200 = string.Format("Return {0} x R200 note(s)", two2);
                    Console.WriteLine(result_200);

                }

                if (rands / 10000 >= 1)
                {
                    double one = rands / 10000;
                    double one1 = Math.Floor(one);
                    int one2 = Convert.ToInt32(one1);
                    rands = rands - (10000 * one2);
                    string result_100 = string.Format("Return {0} x R100 note(s)", one2);
                    Console.WriteLine(result_100);
                }

                if (rands / 5000 >= 1)
                {
                    double fif = rands / 5000;
                    double fif1 = Math.Floor(fif);
                    int fif2 = Convert.ToInt32(fif1);
                    rands = rands - (5000 * fif2);
                    string result_50 = string.Format("Return {0} x R50 note(s)", fif2);
                    Console.WriteLine(result_50);
                }

                if (rands / 2000 >= 1)
                {
                    double twe = rands / 2000;
                    double twe1 = Math.Floor(twe);
                    int twe2 = Convert.ToInt32(twe1);
                    rands = rands - (2000 * twe2);
                    string result_20 = string.Format("Return {0} x R20 note(s)", twe2);
                    Console.WriteLine(result_20);
                }

                if (rands / 1000 >= 1)
                {
                    double ten = rands / 1000;
                    double ten1 = Math.Floor(ten);
                    int ten2 = Convert.ToInt32(ten1);
                    rands = rands - (1000 * ten2);
                    string result_10 = string.Format("Return {0} x R10 note(s)", ten2);
                    Console.WriteLine(result_10);
                }

                if (rands / 500 >= 1)
                {
                    double fiv = rands / 500;
                    double fiv1 = Math.Floor(fiv);
                    int fiv2 = Convert.ToInt32(fiv1);
                    rands = rands - (500 * fiv2);
                    string result_5 = string.Format("Return {0} x R5 coin(s)", fiv2);
                    Console.WriteLine(result_5);
                }

                if (rands / 200 >= 1)
                {
                    double tw = rands / 200;
                    double tw1 = Math.Floor(tw);
                    int tw2 = Convert.ToInt32(tw1);
                    rands = rands - (200 * tw2);
                    string result_2 = string.Format("Return {0} x R2 coin(s)", tw2);
                    Console.WriteLine(result_2);
                }

                if (rands / 100 >= 1)
                {
                    double on = rands / 100;
                    double on1 = Math.Floor(on);
                    int on2 = Convert.ToInt32(on1);
                    rands = rands - (100 * on2);
                    string result_1 = string.Format("Return {0} x R1 coin(s)", on2);
                    Console.WriteLine(result_1);
                }

                if (rands / 50 >= 1)
                {
                    double fifc = rands / 50;
                    double fifc1 = Math.Floor(fifc);
                    int fifc2 = Convert.ToInt32(fifc1);
                    rands = rands - (50 * fifc2);
                    string result_05 = string.Format("Return {0} x 50c coin(s)", fifc2);
                    Console.WriteLine(result_05);
                }

                if (rands / 20 >= 1)
                {
                    double twec = rands / 20;
                    double twec1 = Math.Floor(twec);
                    int twec2 = Convert.ToInt32(twec1);
                    rands = rands - (20 * twec2);
                    string result_02 = string.Format("Return {0} x 20c coin(s)", twec2);
                    Console.WriteLine(result_02);
                }

                if (rands / 10 >= 1)
                {
                    double tenc = rands / 10;
                    double tenc1 = Math.Floor(tenc);
                    int tenc2 = Convert.ToInt32(tenc1);
                    rands = rands - (10 * tenc2);
                    string result_01 = string.Format("Return {0} x 10c coin(s)", tenc2);
                    Console.WriteLine(result_01);
                }

                if (rands / 5 >= 1)
                {
                    double fivc = rands / 5;
                    double fivc1 = Math.Floor(fivc);
                    int fivc2 = Convert.ToInt32(fivc1);
                    rands = rands - (5 * fivc2);
                    string result_005 = string.Format("Return {0} x 5c coin(s)", fivc2);
                    Console.WriteLine(result_005);
                }

                if (rands / 2 >= 1)
                {
                    double twoc = rands / 2;
                    double twoc1 = Math.Floor(twoc);
                    int twoc2 = Convert.ToInt32(twoc1);
                    rands = rands - (2 * twoc2);
                    string result_002 = string.Format("Return {0} x 2c coin(s)", twoc2);
                    Console.WriteLine(result_002);
                }

                if (rands / 1 >= 1)
                {
                    double onec = rands / 1;
                    double onec1 = Math.Floor(onec);
                    int onec2 = Convert.ToInt32(onec1);
                    rands = rands - (1 * onec2);
                    string result_001 = string.Format("Return {0} x 1c coin(s)", onec2);
                    Console.WriteLine(result_001);
                }


            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Please try again.");
            }
            Console.WriteLine();
            Console.WriteLine("Please press Enter to continue :)");
            Console.ReadLine();
        }
    }
}

