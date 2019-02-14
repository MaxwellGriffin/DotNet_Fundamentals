using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_Mon_1_V2
{
	public class ReadWrite
	{
		public string filepath;
		public List<Content> mainContentList;
		public Queue<Content> contentQueue;

		public void Load(string path)
		{
			contentQueue = new Queue<Content>();
			mainContentList = new List<Content>();
			filepath = path;
			string[] lines = File.ReadAllLines(filepath);

			int count = 0;
			int ind = 0;
			for (int i = 0; i < lines.Length; i++)
			{
				switch (count)
				{
					case 0:
						mainContentList.Add(new Content());
						mainContentList[ind].Name = lines[i];
						break;
					case 1:
						mainContentList[ind].Type = int.Parse(lines[i]);
						break;
					case 2:
						mainContentList[ind].Rating = lines[i];
						break;
					case 3:
						mainContentList[ind].Time = int.Parse(lines[i]);
						break;
					case 4:
						mainContentList[ind].Genre = lines[i];
						break;
				}
				count++;
				if (count == 5)
				{
					count = 0;
					ind++;
				}
			}
			Console.WriteLine("\nLOADED: " + filepath);
			//Save last file path
			string meta = "meta.txt";
			File.WriteAllText(meta, filepath);
			Console.WriteLine("Metadata saved.");
		}

		public List<Content> GetMainContentList()
		{
			return mainContentList;
		}

		public void SetMainContentList(List<Content> contentList)
		{
			mainContentList = contentList;
		}

		public void Save()
		{
			var linesList = new List<string>();
			
			foreach (Content content in mainContentList)
			{
				linesList.Add(content.Name);
				linesList.Add(content.Type.ToString());
				linesList.Add(content.Rating);
				linesList.Add(content.Time.ToString());
				linesList.Add(content.Genre);
			}
			File.WriteAllText(filepath, String.Empty); //clears the file
			File.WriteAllLines(filepath, linesList); //writes the file

			Console.WriteLine("\nFile saved at " + filepath + "\n");
		}

		public void Add(Content newContent) //add item onto end of file
		{
			mainContentList.Add(newContent);
			Console.WriteLine("'" + newContent.Name + "' added at index " + (mainContentList.Count - 1) + ".\n");
		}

		public void Delete(string x)
		{
			int n;
			if (int.TryParse(x, out n) == true) //delete one item by index
			{
				string name = mainContentList[n].Name;
				mainContentList.RemoveAt(n);
				Console.WriteLine("\n'" + name + "' successfully deleted.\n");
			}
			else if (x == "*" || x == "all") //delete all (not working, leaves blank line at top of file)
			{
				mainContentList.Clear();
			}
			else
			{
				Console.WriteLine("Invalid command.");
			}
		}

		public void AddToQueue(int x)
		{
			contentQueue.Enqueue(mainContentList[x]);
		}
		public Queue<Content> GetQueue()
		{
			return contentQueue;
		}
	}
}
