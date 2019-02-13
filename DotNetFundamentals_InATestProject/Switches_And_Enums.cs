using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFundamentals_InATestProject
{
	[TestClass]
	public class Switches_And_Enums
	{
		[TestMethod]
		public void Switches()
		{
			int input = 21;

			switch (input)
			{
				case 1:
					Console.WriteLine("You got 1. Try again next time.");
					break;
				case 2:
					Console.WriteLine("Good job!");
					break;
				default:
					Console.WriteLine("Default");
					break;
			}

			//using it with boolean
			switch (input > 100)
			{
				case true:
					Console.WriteLine("True >100");
					break;
				case false:
					Console.WriteLine("False <100");
					break;
			}

			//just for fun, actually works
			bool test = (2 > 1);
			if (test == true)
			{
				Console.WriteLine("True!");
			}
			else
			{
				Console.WriteLine("error");
			}
		}

		public enum Dogs
		{
			Yorkie, GermanShepherd, Wolf, IrishWolfhound, FinnishSpitz
		}

		public enum DogSize
		{
			small, large, medium, xlarge
		}

		//To start enum on 1 instead of 0:
		public enum Dogs2
		{
			Yorkie = 1, GermanShepherd, Wolf //etc...
		}


		[TestMethod]
		public void Enum()
		{
			Dogs dog;

			int input = 2;

			switch (input)
			{
				case 0:
					dog = Dogs.Yorkie;
					break;
				case 1:
					dog = Dogs.GermanShepherd;
					break;
				case 2:
					dog = Dogs.Wolf;
					break;
				case 3:
					dog = Dogs.IrishWolfhound;
					break;
				case 4:
					dog = Dogs.FinnishSpitz;
					break;
				default:
					break;
			}

		}

	}
}
