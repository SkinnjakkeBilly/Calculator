using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyCalc.ConsoleApp
{
    //Bruker shunting yard algoritmen til å returnere et Queue objekt med uttrykket i parameteret som et postfix uttrykk
    public class Shunt
    {
        
        OperatorPrioritet opPri = new OperatorPrioritet();
        Dictionary<string, int> opPrio;

        public Queue shunt(string math)
        {
            //Fjern alle whitespace fra uttrykket
            math = Regex.Replace(math, @"\s+", "");

            MatchCollection uttrykkCollection = Regex.Matches(math, @"\D|\d*\.?\d");
            var list = new string[uttrykkCollection.Count];
            ArrayList uttrykk = new ArrayList();
            uttrykk.AddRange(list);
            
            opPrio = opPri.getOpPrio();
            
            Queue output = new Queue();
            Stack operators = new Stack();


            for (int i = 0; i < uttrykk.Count; i++)
            {
                uttrykk[i] = uttrykkCollection[i].ToString();
                String verdi = uttrykk[i].ToString();
                Decimal number;

                if (Decimal.TryParse(verdi, out number))
                {
                    output.Enqueue(verdi);
                }else if(verdi == ("(")) 
                {
                    operators.Push(verdi);
                }
                
                else if(operators.Count != 0 && opPrio.GetValueOrDefault(verdi) <= opPrio.GetValueOrDefault(operators.Peek().ToString()))
                {
                    output.Enqueue(operators.Pop());
                    operators.Push(verdi);
                }
                else if (verdi==(")"))
                {
                    
                    while (!operators.Peek().Equals("(")) 
                    {
                       
                        output.Enqueue(operators.Pop());
                    }
                    if (operators.Peek().Equals("(")) 
                    {

                    }operators.Pop();

                }
                else
                {
                    operators.Push(verdi);

                }

            }
            while (operators.Count > 0)
            {
                if (operators.Peek().Equals("("))
                {
                    operators.Pop();
                }
                else {
                    output.Enqueue(operators.Pop());
                }
                
            }
            return output;
        }
    }
}

