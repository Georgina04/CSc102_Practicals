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
			Console.Write("How old are you?");
			string age = Console.ReadLine();
			int new_age = Convert.ToInt32(age);

			Console.Write("What is your salary?");
			string sal = Console.ReadLine();
			int salary = Convert.ToInt32(sal);

			int tax;

			if ((salary >= 0) && (salary <= 4999)) ;
			{
				if (new_age < 65) ;
				{
					tax = 0;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 0;
				}
				else if (new_age > 75) ;
				{
					tax = 0;
				}
			}

			if ((salary >= 5000) && (salary <= 6499)) ;
			{
				if (new_age < 65) ;
				{
					tax = 13;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 0;
				}
				else if (new_age > 75) ;
				{
					tax = 0;
				}
			}

			if ((salary >= 6500) && (salary <= 7799)) ;
			{
				if (new_age < 65) ;
				{
					tax = 250;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 0;
				}
				else if (new_age > 75) ;
				{
					tax = 0;
				}
			}

			if ((salary >= 7800) && (salary <= 9999)) ;
			{
				if (new_age < 65) ;
				{
					tax = 620;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 0;
				}
				else if (new_age > 75) ;
				{
					tax = 0;
				}
			}

			if ((salary >= 10000) && (salary <= 13499)) ;
			{
				if (new_age < 65) ;
				{
					tax = 1200;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 600;
				}
				else if (new_age > 75) ;
				{
					tax = 400;
				}
			}

			if ((salary >= 13500) && (salary <= 17899)) ;
			{
				if (new_age < 65) ;
				{
					tax = 2100;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 1500;
				}
				else if (new_age > 75) ;
				{
					tax = 1200;
				}
			}

			if ((salary >= 17900) && (salary <= 19999)) ;
			{
				if (new_age < 65) ;
				{
					tax = 2700;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 2000;
				}
				else if (new_age > 75) ;
				{
					tax = 1800;
				}
			}

			if ((salary >= 20000) && (salary <= 39999)) ;
			{
				if (new_age < 65) ;
				{
					tax = 8000;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 7500;
				}
				else if (new_age > 75) ;
				{
					tax = 7300;
				}
			}

			if ((salary >= 40000) && (salary <= 59999)) ;
			{
				if (new_age < 65) ;
				{
					tax = 16000;
				} 
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 15600;
				}
				else if (new_age > 75) ;
				{
					tax = 15400;
				}
			}

			if (salary >= 60000) ;
			{
				if (new_age < 65) ;
				{
					tax = 20000;
				}
				else if ((new_age >= 65) && (new_age <= 75)) ;
				{
					tax = 17050;
				}
				else if (new_age > 75) ;
				{
					tax = 17000;
				}
			}

			string result = string.Format("You have to pay R(0) of TAX.", tax);
			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
