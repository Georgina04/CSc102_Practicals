using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator
{
	class Program
	{
		static void Main(string[] args)
		{ 
            // The next 3 lines of code gets input from the user as to what age he/she is and changes it to an int
			Console.Write("How old are you?");
			string age = Console.ReadLine();
			int new_age = Convert.ToInt32(age);

            // The next 3 lines of code gets input from the user as to what salary he/she earns and changes it to and int
			Console.Write("What is your salary?");
			string sal = Console.ReadLine();
			int salary = Convert.ToInt32(sal);

            Console.WriteLine();
            
            // The next few conditional statements find out what salary bracket the inputed salary lies in, and then 
            // uses age to determine what tax bracket he or she is in.
			if ((salary >= 0) && (salary <= 4999)) 
			{
                Console.WriteLine("You have to pay R0 of tax.");
            }

			if ((salary >= 5000) && (salary <= 6499)) 
			{
				if (new_age < 65) 
				{
                    Console.WriteLine("You have to pay R13 of tax.");
                } 
				else
				{
                    Console.WriteLine("You have to pay R0 of tax.");
                }
				
			}

			if ((salary >= 6500) && (salary <= 7799)) 
			{
                if (new_age < 65)
                {
                    Console.WriteLine("You have to pay R250 of tax.");
                }
                else
                {
                    Console.WriteLine("You have to pay R0 of tax.");
                }
            }

			if ((salary >= 7800) && (salary <= 9999)) 
			{
                if (new_age < 65)
                {
                    Console.WriteLine("You have to pay R620 of tax.");
                }
                else
                {
                    Console.WriteLine("You have to pay R0 of tax.");
                }
            }

			if ((salary >= 10000) && (salary <= 13499)) 
			{
				if (new_age < 65) 
				{
                    Console.WriteLine("You have to pay R1200 of tax.");
                } 
				else if ((new_age >= 65) && (new_age <= 75)) 
				{
                    Console.WriteLine("You have to pay R600 of tax.");
                }
				else  
				{
                    Console.WriteLine("You have to pay R400 of tax.");
                }
			}

			if ((salary >= 13500) && (salary <= 17899)) 
			{
				if (new_age < 65) 
				{
                    Console.WriteLine("You have to pay R2100 of tax.");
                } 
				else if ((new_age >= 65) && (new_age <= 75)) 
				{
                    Console.WriteLine("You have to pay R1500 of tax.");
                }
				else 
				{
                    Console.WriteLine("You have to pay R1200 of tax.");
                }
			}

			if ((salary >= 17900) && (salary <= 19999)) 
			{
                if (new_age < 65)
                {
                    Console.WriteLine("You have to pay R2700 of tax.");
                }
                else if ((new_age >= 65) && (new_age <= 75))
                {
                    Console.WriteLine("You have to pay R2000 of tax.");
                }
                else
                {
                    Console.WriteLine("You have to pay R1800 of tax.");
                }
            }

			if ((salary >= 20000) && (salary <= 39999)) 
			{
                if (new_age < 65)
                {
                    Console.WriteLine("You have to pay R8000 of tax.");
                }
                else if ((new_age >= 65) && (new_age <= 75))
                {
                    Console.WriteLine("You have to pay R7500 of tax.");
                }
                else
                {
                    Console.WriteLine("You have to pay R7300 of tax.");
                }
            }

            if ((salary >= 40000) && (salary <= 59999))
            {
                if (new_age < 65)
                {
                    Console.WriteLine("You have to pay R16000 of tax.");
                }
                else if ((new_age >= 65) && (new_age <= 75))
                {
                    Console.WriteLine("You have to pay R15600 of tax.");
                }
                else
                {
                    Console.WriteLine("You have to pay R15400 of tax.");
                }
            }

            else if (salary >= 60000)
			{
                if (new_age < 65)
                {
                    Console.WriteLine("You have to pay R20000 of tax.");
                }
                else if ((new_age >= 65) && (new_age <= 75))
                {
                    Console.WriteLine("You have to pay R17050 of tax.");
                }
                else
                {
                    Console.WriteLine("You have to pay R17000 of tax.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue :)");
		Console.ReadLine();
		}
	}
}
