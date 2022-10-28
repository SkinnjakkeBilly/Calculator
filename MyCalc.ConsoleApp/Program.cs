using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;

namespace MyCalc.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string math = "2*(3-1)-2+32*21";
            //string math = "(2 + 3) * (10 / 2)";
            string math = "(2 + 4) * 3 + (4 - 2) / 4 + 6";
            //string math = "((2 + 3) * 5) / 3";
            //string math = "";
            
            Calculator c = new Calculator();
            Console.WriteLine( math + " = " + c.calc(math));

        }
    }

}
