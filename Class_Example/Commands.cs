using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example
{
	public class Commands
	{
		public void ReadCommand()
		{
			ReadWrite rw = new ReadWrite();
			string input = Console.ReadLine();
			int space;
			string command ="";
			string cmd;
			if (input.Contains(" "))
			{
				space = input.IndexOf(" ");
				command = input.Substring(space + 1);
				cmd = input.Substring(0, space);
			}
			else
			{
				cmd = input;
			}

			switch (cmd)
			{
				case "goto":
					ListOneCookie(int.Parse(command));
					break;
				case "list":
					ListCookies();
					break;
				case "new":
					rw.Add(GetNewCookie());
					break;
				case "edit":
					break;
				case "del":
					rw.Delete(int.Parse(command));
					break;
				case "help":
					Console.WriteLine();
					Menu();
					break;
				case "exit":
					break;
				default:
					Console.WriteLine($"\nERROR! {cmd} not recognized. Type help");
					ReadCommand();
					break;
			}
		}

		public void Menu()
		{
			Console.WriteLine("\tnew: create new cookie\n" +
				"\tgoto <index>: goto cookie\n" +
				"\tlist: list all cookies\n" +
				"\tnew: write new cookie recipe\n" +
				"\tedit <index>: edit cookie, leave blank to edit current cookie\n" +
				"\tdel <index>\n" +
				"\thelp: list commands\n");
			ReadCommand();
		}

		public void ListCookies()
		{
			ReadWrite rw = new ReadWrite();
			var cookieList = rw.Read();
			Console.WriteLine();
			foreach (Cookie cookie in cookieList)
			{
				Console.WriteLine("Index:\t\t" + cookie.Index);
				Console.WriteLine("Name:\t\t" + cookie.Name);
				Console.WriteLine("Ingredients:\t" + cookie.Ingredient);
				Console.WriteLine("Batch size:\t" + cookie.BatchSize);
				Console.WriteLine("Gluten free:\t" + cookie.IsGlutenFree);
				Console.WriteLine();
			}
			ReadCommand();
		}

		public void ListOneCookie(int ind)
		{
			ReadWrite rw = new ReadWrite();
			var cookieList = rw.Read();
			Console.WriteLine();
			Console.WriteLine("\tIndex:\t\t" + cookieList[ind].Index);
			Console.WriteLine("\tName:\t\t" + cookieList[ind].Name);
			Console.WriteLine("\tIngredients:\t" + cookieList[ind].Ingredient);
			Console.WriteLine("\tBatch size:\t" + cookieList[ind].BatchSize);
			Console.WriteLine("\tGluten free:\t" + cookieList[ind].IsGlutenFree);
			Console.WriteLine();
			ReadCommand();
			
		}

		public Cookie GetNewCookie()
		{
			ReadWrite rw = new ReadWrite();
			var cookieList = rw.Read();

			int lastCookie = cookieList.Count();

			Cookie newCookie = new Cookie();
			newCookie.Index = lastCookie;
			Console.Write("\nName:\t\t");
			newCookie.Name = Console.ReadLine();
			Console.Write("Ingredients:\t");
			newCookie.Ingredient = Console.ReadLine();
			Console.Write("Batch size:\t");
			newCookie.BatchSize = int.Parse(Console.ReadLine());
			Console.Write("Gluten free? (t/f):\t");
			switch (Console.ReadLine().ToLower())
			{
				case "t":
					newCookie.IsGlutenFree = true;
					break;
				case "f":
					newCookie.IsGlutenFree = false;
					break;
				default:
					break;
			}
			return newCookie;
		}
	}
}
