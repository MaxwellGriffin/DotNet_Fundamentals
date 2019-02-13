using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_RepositoryPattern
{
	//access modifier INTERNAL by default
    public class CalculatorRepository
    {
        public int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public int SubtractTwoNumbers(int x, int y)
        {
            return x - y;
        }

        //How to do it in one line:
        public int MultiplyTwoNumbers(int x, int y) => x * y;
        public int DivideTwoNumbers(int x, int y) => x / y;
        public int FindRemainder(int x, int y) => x % y;
    }
}
