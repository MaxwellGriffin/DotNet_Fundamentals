using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Mon_1_V2
{
	public class ProgramUI
	{
		ReadWrite rw = new ReadWrite();

		bool firstTimeLoad = true;

		public void ReadCommand()
		{
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

			switch (cmd.ToLower())
			{
				case "load":
					LoadHelper();
					break;
				case "save":
					rw.Save();
					ReadCommand();
					break;
				case "goto":
					ListOneContent(int.Parse(command));
					break;
				case "list":
					ListContent();
					break;
				case "new":
					rw.Add(GetNewContent());
					ReadCommand();
					break;
				case "edit":
					rw.SetMainContentList(GetEditedContent(int.Parse(command)));
					ListOneContent(int.Parse(command));
					ReadCommand();
					break;
				case "del":
					rw.Delete(command);
					ReadCommand();
					break;
				case "help":
					Console.WriteLine();
					Menu();
					break;
				case "q":
					rw.AddToQueue(int.Parse(command));
					var contentList = rw.GetMainContentList();
					Console.WriteLine("\n'" + contentList[int.Parse(command)].Name + "' added to queue.\n");
					ReadCommand();
					break;
				case "showq":
					ShowQueue();
					ReadCommand();
					break;
				default:
					Console.WriteLine($"\nERROR! '{cmd}' not recognized. Type HELP for options.\n");
					ReadCommand();
					break;
			}
		}
		
		private void LoadHelper()
		{
			firstTimeLoad = false;
			Console.Write("\nPath: ");
			string dirPath = @"" + Console.ReadLine();
			if (File.Exists(dirPath))
			{
				//var path = new DirectoryInfo(dirPath);
				rw.Load(dirPath);
				//var files = path.GetFiles();
				firstTimeLoad = false;
				ListContent();
			}
			else
			{
				Console.WriteLine("\nFile does not exist.\n");
			}
			ReadCommand();
		}

		public void Menu()
		{
			Console.WriteLine("\tload: load file\n" +
				"\tsave: save file\n" +
				"\tlist: list all content\n" +
				"\tgoto <index>: goto content\n" +
				"\tnew: add new content\n" +
				"\tedit <index>: edit content\n" +
				"\tdel <index>: delete content\n" +
				"\tq <index>: queue content\n" +
				"\tshowq: show queue\n" +
				"\thelp: show commands\n");
			if (firstTimeLoad == true)
			{
				FirstTimeLoad();
			}

			ReadCommand();
		}

		private void FirstTimeLoad()
		{
			Console.Write("\nLoad last file? (Y/N) ");
			string yn = Console.ReadLine();
			switch (yn.ToLower())
			{
				case "y":
					if (File.Exists("meta.txt"))
					{
						firstTimeLoad = false;
						string dirPath = File.ReadAllText("meta.txt");
						rw.Load(dirPath);
						ListContent();
					}
					else
					{
						firstTimeLoad = false;
						Console.WriteLine("\nFile does not exist.\n");
					}
					//ReadCommand();
					break;
				case "n":
					firstTimeLoad = false;
					LoadHelper();
					break;
				default:
					firstTimeLoad = false;
					Console.WriteLine("Invalid command");
					break;
			}
			
		}

		public void ListContent()
		{
			var contentList = rw.GetMainContentList();
			Console.WriteLine();

			int count = 0;
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
			var contentList = rw.GetMainContentList();
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

		public List<Content> GetEditedContent(int x)
		{
			var contentList = rw.GetMainContentList();
			string input;

			Console.WriteLine();
			Console.WriteLine("\tIndex:\t\t" + x);

			Console.WriteLine("\tName:\t\t" + contentList[x].Name);
			Console.Write("\tNew Name:\t");
			input = Console.ReadLine();
			if(input!="")
			{
				contentList[x].Name = input;
			}

			Console.WriteLine("\tType:\t\t" + GetType(contentList[x].Type));
			Console.Write("\tNew Type:\t");
			input = Console.ReadLine();
			if(input!="")
			{
				contentList[x].Type = int.Parse(input);
			}

			Console.WriteLine("\tRating:\t\t" + contentList[x].Rating);
			Console.Write("\tNew Rating:\t");
			input = Console.ReadLine();
			if(input!="")
			{
				contentList[x].Rating = input;
			}

			Console.WriteLine("\tTime:\t\t" + contentList[x].Time + " min");
			Console.Write("\tNew Time:\t");
			input = Console.ReadLine();
			if (input != "")
			{
				contentList[x].Time = int.Parse(input);
			}

			Console.WriteLine("\tGenre:\t\t" + contentList[x].Genre);
			Console.Write("\tNew Genre:\t");
			input = Console.ReadLine();
			if (input != "")
			{
				contentList[x].Genre = input;
			}

			Console.WriteLine("\nDone editing.");
			return contentList;
			
		}

		public Content GetNewContent()
		{
			var contentList = rw.GetMainContentList();

			Content newContent = new Content();

			Console.Write("\nName:\t\t");
			newContent.Name = Console.ReadLine();
			Console.Write("(0)Movie (1)TV:\t");
			newContent.Type = int.Parse(Console.ReadLine());
			Console.Write("Rating:\t\t");
			newContent.Rating = Console.ReadLine();
			Console.Write("Time:\t\t");
			newContent.Time = int.Parse(Console.ReadLine());
			Console.Write("Genre:\t\t");
			newContent.Genre = Console.ReadLine();
			Console.WriteLine();

			return newContent;
		}

		public void ShowQueue()
		{
			Console.Write("\nQueue (first to last):\t");
			var contentQueue = rw.GetQueue();
			int i = 1;
			foreach (Content content in contentQueue)
			{
				if(i < contentQueue.Count)
				{
					Console.Write($"'{content.Name}', ");
				}
				else
				{
					Console.Write($"'{content.Name}'.");
					Console.WriteLine("\n");
				}
				i++;
			}

		}
	}
}
