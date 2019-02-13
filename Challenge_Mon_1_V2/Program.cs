using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Mon_1_V2
{
	class Program
	{
		static void Main(string[] args)
		{
			ProgramUI command = new ProgramUI();

			Console.WriteLine("Streaming Service\nMax Griffin\n");
			Console.WriteLine("Developer notes: will break if certain commands are entered incorrectly.\n0 = movie 1 = TV show.");
			Console.WriteLine("\n------------------\n");
			command.Menu();
		}
	}
}
