using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example
{
	class Program
	{
		
		static void Main(string[] args)
		{
			ReadWrite rw = new ReadWrite();
			Commands command = new Commands();

			Console.WriteLine("1337 COOKIES\nMax Griffin\nFeb. 8th 2019\n------------------\n");
			command.Menu();
			Console.ReadLine();

		}


	}
}

//  \r\n