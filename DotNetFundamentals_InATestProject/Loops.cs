using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
	[TestClass]
	public class Loops
	{
		[TestMethod]
		public void Loop()
		{
			string name = "Joshua";

			for (int i = 0; i < name.Length; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}
