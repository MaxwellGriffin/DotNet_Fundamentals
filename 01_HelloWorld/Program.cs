using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args) //Max Griffin in class work Feb 5th 2019
        {

            string firstname;
            string lastname;
            int age;

            Console.WriteLine("Hello World");
            Console.WriteLine();

            Console.WriteLine("ENTER YOUR FIRST NAME.");
            firstname = Console.ReadLine();
            Console.WriteLine("firstname = " + firstname); //for testing
            Console.WriteLine();

            Console.WriteLine("ENTER YOUR LAST NAME.");
            lastname = Console.ReadLine();
            Console.WriteLine("lastname = " + lastname);
            Console.WriteLine();

            Console.WriteLine("ENTER YOUR AGE.");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("age = " + age);
            Console.WriteLine();

            Console.WriteLine($"Good morning, {firstname} {lastname}. You are {age} years old. Press ENTER to see some art!");
            Console.ReadLine();

            Console.WriteLine("  _    _  ");
            Console.WriteLine("  0    0  ");
            Console.WriteLine("    ()   ");
            Console.WriteLine("0        0");
            Console.WriteLine(" 00000000 ");
            Console.ReadLine();
        }

        static int AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            return result;
        }
    }
}