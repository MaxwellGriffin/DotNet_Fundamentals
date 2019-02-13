using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Mon_1
{
	public class ReadWrite
	{
		ProgramUI command = new ProgramUI();

		public List<Content> Read()
		{
			var contentList = new List<Content>();

			string[] lines = File.ReadAllLines("./data.txt");

			int count = 0;
			int ind = 0;
			for (int i = 0; i < lines.Length; i++)
			{
				switch (count)
				{
					case 0:
						contentList.Add(new Content());
						contentList[ind].Name = lines[i];
						break;
					case 1:
						contentList[ind].Type = int.Parse(lines[i]);
						break;
					case 2:
						contentList[ind].Rating = lines[i];
						break;
					case 3:
						contentList[ind].Time = int.Parse(lines[i]);
						break;
					case 4:
						contentList[ind].Genre = lines[i];
						break;
				}
				count++;
				if (count == 5)
				{
					count = 0;
					ind++;
				}
			}
			return contentList;
		}

		public void Add(Content newContent) //add item onto end of file
		{
			string[] linesArray = File.ReadAllLines("./data.txt");
			var linesList = new List<string>();
			linesList = linesArray.ToList();

			linesList.Add(newContent.Name);
			linesList.Add(newContent.Type.ToString());
			linesList.Add(newContent.Rating);
			linesList.Add(newContent.Time.ToString());
			linesList.Add(newContent.Genre);

			File.WriteAllLines("./data.txt", linesList);
			command.ReadCommand();
		}

		public void Delete(string x)
		{
			string[] linesArray = File.ReadAllLines("./data.txt");
			var linesList = new List<string>();
			linesList = linesArray.ToList();
			if (int.TryParse(x, out int n) == true) //delete one item by index
			{
				n = n * 5;
				for (int i = 0; i < 5; i++)
				{
					linesList.RemoveAt(n);
				}
				File.WriteAllLines("./data.txt", linesList);
			}
			else if (x == "*" || x == "all") //delete all (not working, leaves blank line at top of file)
			{
				linesList.Clear();
				File.WriteAllLines("./data.txt", linesList);
			}
			else
			{
				Console.WriteLine("Invalid command.");
			}

			command.ReadCommand();
		}

		public void Edit(int x)
		{
			string[] linesArray = File.ReadAllLines("./data.txt");
			var linesList = new List<string>();
			linesList = linesArray.ToList();
		}
	}
}
