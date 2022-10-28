using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MyCalc.ConsoleApp;

namespace MyCalc
{
    public class Calculator
    {
        
        public object calc(string math)
        {

            try
            {
                Shunt s = new Shunt();
                Stack operands = new Stack();

                Queue output = s.shunt(math);

                foreach (string verdi in output)
                {
                    Decimal number;
                    Decimal number2;

                    if (Decimal.TryParse(verdi, out number))
                    {
                        operands.Push(number);

                    }
                    else if (verdi.Equals("*"))
                    {
                        number = Decimal.Parse(operands.Pop().ToString());
                        number2 = Decimal.Parse(operands.Pop().ToString());
                        //Console.WriteLine(number2 + "*" + number);
                        operands.Push(number2 * number);
                    }
                    else if (verdi.Equals("/"))
                    {
                        number = Decimal.Parse(operands.Pop().ToString());
                        number2 = Decimal.Parse(operands.Pop().ToString());
                        //Console.WriteLine(number2 + "/" + number);

                        operands.Push(number2 / number);
                    }
                    else if (verdi.Equals("+"))
                    {
                        number = Decimal.Parse(operands.Pop().ToString());
                        number2 = Decimal.Parse(operands.Pop().ToString());
                        //Console.WriteLine(number2 + "+" + number);

                        operands.Push(number2 + number);
                    }
                    else if (verdi.Equals("-"))
                    {
                        number = Decimal.Parse(operands.Pop().ToString());
                        number2 = Decimal.Parse(operands.Pop().ToString());
                        //Console.WriteLine(number2 + "-" + number);

                        operands.Push(number2 - number);
                    }
                }
                return operands.Pop();
            }catch(Exception e)
            {
                
                Console.WriteLine(e);
                //Dumt å returnere null eller? 
                return null;
            }

        }

    }
}
