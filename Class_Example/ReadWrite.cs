using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Class_Example
{
	public class ReadWrite
	{
		Commands command = new Commands();
		public List<Cookie> Read()
		{
			StreamReader sr = new StreamReader("./data.txt");
			var cookieList = new List<Cookie>();
			int ind = 0;

			string line = sr.ReadLine();
			while (line != null)
			{
				//write the lie to console window
				if (line.StartsWith("?"))
				{
					cookieList.Add(new Cookie());
					cookieList[ind].Index = int.Parse(sr.ReadLine());
					cookieList[ind].Name = sr.ReadLine();
					cookieList[ind].Ingredient = sr.ReadLine();
					cookieList[ind].BatchSize = int.Parse(sr.ReadLine());
					string tf = sr.ReadLine();
					switch (tf)
					{
						case "True":
							cookieList[ind].IsGlutenFree = true;
							break;
						case "False":
							cookieList[ind].IsGlutenFree = false;
							break;
					}
					ind++;
				}
				//Read the next line
				line = sr.ReadLine();
			}
			sr.Close();
			return cookieList;
		}

		public void Add(Cookie newCookie) //add item onto end of file
		{

			StreamWriter sw;
			sw = File.AppendText("./data.txt");
			sw.WriteLine("\n?");
			sw.WriteLine(newCookie.Index);
			sw.WriteLine(newCookie.Name);
			sw.WriteLine(newCookie.Ingredient);
			sw.WriteLine(newCookie.BatchSize);
			sw.WriteLine(newCookie.IsGlutenFree);
			sw.Flush();
			sw.Close();
			command.ReadCommand();
		}

		public void Delete(int x)
		{
			x = x * 6;

			string[] lines = System.IO.File.ReadAllLines("./data.txt");

			var linesList = new List<string>();
			linesList = lines.ToList();
			linesList.Add("");

			for (int o = 0; o < 6; o++)
			{
				for (int i = x - 1; i < linesList.Count - 1; i++)
				{

					linesList[i] = linesList[i + 1];
				}
			}

			string[] lines2 = linesList.ToArray();

			bool done = false;
			int k = 0;
			int u = 0;
			while (!done)
			{
				for (int j = 0; j < 6; j++)
				{
					if(j==1)
					{
						lines2[k] = u.ToString();
						u++;
					}
					k++;
					if(k==lines2.Length -1)
					{
						done = true;
					}
				}
			}
			
			System.IO.File.WriteAllLines("./data.txt", lines2);

			var CookieList = Read();
			for (int j = 0; j < CookieList.Count(); j++)
			{
				CookieList[j].Index = j;
			}

			command.ReadCommand();
		}
	}
}
