using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFundamentals_InATestProject
{
	[TestClass]
	public class If_Elseif_Else
	{
		[TestMethod]
		public void If_Else()
		{
			//birthday
			int month = 2;
			int day = 5;
			int year = 1967;

			DateTime birthday = new DateTime(year, month, day);

			if (DateTime.Today.Month == birthday.Month && DateTime.Today.Day == birthday.Day)
			{
				Console.WriteLine("Happy birthday!");
			}
			else
			{
				int daysUntil = birthday.DayOfYear - DateTime.Today.DayOfYear;

				if(daysUntil < 0)
				{
					daysUntil += 365;
					Console.WriteLine($"Your birthday isn't for {daysUntil} days!");
				}
				else
				{
					Console.WriteLine($"Your birthday isn't for {daysUntil} days!");
				}
			}


			//Get age in years
			int age = DateTime.Today.Year - birthday.Year;
			if (DateTime.Today.DayOfYear < birthday.DayOfYear)
			{
				age = DateTime.Today.Year - birthday.Year - 1;
			}
			else
			{
				age = DateTime.Today.Year - birthday.Year;
			}
			
			Console.WriteLine($"Your age = {age}");

			if (age <= 18)
			{
				Console.WriteLine("Still a kid (under 18)");
			}
			else if (age > 18 && age < 25)
			{
				Console.WriteLine("You be adult (18-25)");
			}
			else if (age >= 25 && age <= 50)
			{
				Console.WriteLine("Car cheap rent (25-50)");
			}
			else
			{
				Console.WriteLine("You be wise (50+)");
			}
		}
	}
}
