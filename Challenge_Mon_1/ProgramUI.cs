using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_Mon_1
{
	public class ProgramUI
	{
		
		public void ReadCommand()
		{
			ReadWrite rw = new ReadWrite();
			string input = Console.ReadLine();
			int space;
			string command = "";
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
					ListOneContent(int.Parse(command));
					break;
				case "list":
					ListContent();
					break;
				case "new":
					rw.Add(GetNewContent());
					break;
				case "edit":
					rw.Edit(int.Parse(command));
					break;
				case "del":
					rw.Delete(command);
					break;
				case "help":
					Console.WriteLine();
					Menu();
					break;
				case "exit":
					return;
				default:
					Console.WriteLine($"\nERROR! '{cmd}' not recognized. Type HELP for options.");
					ReadCommand();
					break;
			}
		}

		public void Menu()
		{
			Console.WriteLine("\tgoto <index>: goto content\n" +
				"\tlist: list all content\n" +
				"\tnew: add new content\n" +
				"\tedit <index>: edit content\n" +
				"\tdel <index>: delete content\n");
			ReadCommand();
		}

		public void ListContent()
		{
			ReadWrite rw = new ReadWrite();
			var contentList = rw.Read();
			Console.WriteLine();

			int count=0;
			foreach (Content content in contentList)
			{
				Console.WriteLine("Index:\t\t" + count);
				Console.WriteLine("Name:\t\t" + content.Name);
				Console.WriteLine("Type:\t\t" + GetType(content.Type));
				Console.WriteLine("Rating:\t\t" + content.Rating);
				Console.WriteLine("Time:\t\t" + content.Time + " min");
				Console.WriteLine("Genre:\t\t" + content.Genre);
				Console.WriteLine();
				count++;
			}
			ReadCommand();
		}

		public void ListOneContent(int ind)
		{
			ReadWrite rw = new ReadWrite();
			var contentList = rw.Read();
			Console.WriteLine();
			Console.WriteLine("\tIndex:\t\t" + ind);
			Console.WriteLine("\tName:\t\t" + contentList[ind].Name);
			Console.WriteLine("\tType:\t\t" + GetType(contentList[ind].Type));
			Console.WriteLine("\tRating:\t\t" + contentList[ind].Rating);
			Console.WriteLine("\tTime:\t\t" + contentList[ind].Time + " min");
			Console.WriteLine("\tGenre:\t\t" + contentList[ind].Genre);
			Console.WriteLine();
			ReadCommand();

		}

		public string GetType(int x)
		{
			switch (x)
			{
				case 0:
					return "Movie";
				case 1:
					return "TV";
				default:
					return "Error";
			}
		}

		public Content GetNewContent()
		{
			ReadWrite rw = new ReadWrite();
			var contentList = rw.Read();

			int lastContent = contentList.Count();

			Content newContent = new Content();

			Console.Write("\nName:\t\t");
			newContent.Name = Console.ReadLine();
			Console.Write("(0)Movie (1)TV:\t");
			newContent.Type = int.Parse(Console.ReadLine());
			Console.Write("Rating:\t");
			newContent.Rating = Console.ReadLine();
			Console.Write("Time:\t");
			newContent.Time = int.Parse(Console.ReadLine());
			Console.Write("Genre:\t");
			newContent.Genre = Console.ReadLine();

			return newContent;
		}
	}
}
