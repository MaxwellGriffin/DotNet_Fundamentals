using System;
using System.Collections.Generic; 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Reference_Types_And_Collections
    {
        public void ReferenceTypes() //these are reference types, for reference.
        {
            //Classes
            //Interfaces

            string hello = "Hello World";
        }

        public void Collections() //collection types for reference.
        {
            string[] arrayOfStrings = { "This", "can", "be any collection", "of strings" };
            int[] arrayOfNumbers = { 1, 3, 5, 10, 20, 50, 100, 500, 1000, 10000, 1000000, 1000000 };

            //the following uses System.Collections.Generic
            //You must add "using System.Collections.Generic;" at the top of the file to use lists.
            List<string> listOfStrings = new List<string>(); 
            Queue<string> firstInFirstOut = new Queue<string>();
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            SortedList<int, string> sortedKeyAndValuePairs = new SortedList<int, string>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        //UNIT TESTING
        //
        //ARRANGE, ACT, ASSERT

        public string SayHello(string name)
        {
            return ($"Hello {name}");
        }

        [TestMethod] //right click in test explorer > run selected test
        public void SayHello_Test()
        {
            //Arrange
            string name = "John";
            //Act
            string actual = SayHello(name);
            //Assert
            Assert.AreEqual("Hello John", actual); 

            Console.WriteLine(actual); //not a console app but will output when tested.
        }
    }
}
