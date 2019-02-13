using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Mon_1
{
	class Program
	{
		static void Main(string[] args)
		{
			ProgramUI command = new ProgramUI();

			Console.WriteLine("Streaming Service\nMax Griffin\n------------------\n");
			command.Menu();
			Console.ReadLine();
		}
	}
}
