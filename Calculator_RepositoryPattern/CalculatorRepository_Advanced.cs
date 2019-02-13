using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_RepositoryPattern
{
	
	public class CalculatorRepository_Advanced
	{
		private int[] GetNums()
		{
			var numberList = new List<int>();
			string input;
			bool done = false;
			while (!done)
			{
				input = Console.ReadLine();
				if (input == "")
				{
					done = true;
					Console.WriteLine("Done!");
				}
				else
					numberList.Add(int.Parse(input));
			}
			return numberList.ToArray();
		}

		private void ListArray(int[] nums) //for debugging
		{
			for (int o = 0; o < nums.Length; o++)
			{
				Console.WriteLine(o + ": " + nums[o]);
			}
		}

		public void Add()
		{
			Console.WriteLine("Enter the numbers that you would like to add.\nWhen done, press ENTER.");
			int sum = Operate('a');
			Console.WriteLine("Sum: " + sum);
		}

		public void Subtract()
		{
			Console.WriteLine("Enter the numbers that you would like to subtract.\nWhen done, press ENTER.");
			int difference = Operate('s');
			Console.WriteLine("Difference: " + difference);
		}

		public void Multiply()
		{
			Console.WriteLine("Enter the numbers that you would like to multiply.\nWhen done, press ENTER.");
			int product = Operate('m');
			Console.WriteLine("Product: " + product);
		}

		public void Divide()
		{
			Console.WriteLine("Enter the numbers that you would like to divide.\nWhen done, press ENTER.");
			int quotient = Operate('d');
			Console.WriteLine("Quotient: " + quotient);
		}

		private int Operate(char type)
		{
			int[] numberArray = GetNums();

			//List array (for debugging)
			ListArray(numberArray);

			int result = 0;
			switch (type)
			{
				case 'a':
					for (int i = 0; i < numberArray.Length; i++)
					{
						result += numberArray[i];
					}
					break;
				case 's':
					for (int i = 0; i < numberArray.Length - 1; i++)
					{
						result = numberArray[i] - numberArray[i+1];
					}
					break;
				case 'm':
					result = 1;
					for (int i = 0; i < numberArray.Length; i++)
					{
						result *= numberArray[i];
					}
					break;
				case 'd':
					for (int i = 0; i < numberArray.Length - 1; i++)
					{
						result = numberArray[i] / numberArray[i + 1];
					}
					break;
				default:
					break;
			}

			return result;
		}
	}


}