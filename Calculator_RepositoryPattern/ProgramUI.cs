using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_RepositoryPattern
{
	public class ProgramUI
	{
		CalculatorRepository_Advanced _calculatorRepo = new CalculatorRepository_Advanced();

		public void Ui()
		{
			Console.WriteLine("L33T CALCULATOR\n" +
				"By Max Griffin\n" +
				"Feb. 7th 2019\n" +
				"V1.0\n");
			

			//bool notDone = true;
			while (true)
			{
				Menu();
				string operation = Console.ReadLine().ToLower();
				switch (operation)
				{
					case "a":
						_calculatorRepo.Add();
						Pause();
						break;
					case "s":
						_calculatorRepo.Subtract();
						Pause();
						break;
					case "m":
						_calculatorRepo.Multiply();
						Pause();
						break;
					case "d":
						_calculatorRepo.Divide();
						Pause();
						break;
					case "":
						return;
					default:
						Console.WriteLine("Invalid character.\n");
						break;
				}
			}
		}

		private void Menu()
		{
			Console.WriteLine("Choose an operation or press ENTER to exit.\n" +
				"(A)dd\n" +
				"(S)ubtract\n" +
				"(M)ultiply\n" +
				"(D)ivide\n");
		}

		public void Pause()
		{
			Console.WriteLine("\nPress ENTER Key To Continue...");
			Console.ReadLine();
		}
	}
}
