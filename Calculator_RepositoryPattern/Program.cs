using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_RepositoryPattern
{ //collections
	public class Program
    {
		static void Main(string[] args)
        {
			ProgramUI usermenu = new ProgramUI();
			usermenu.Ui();
        }
    }
}
