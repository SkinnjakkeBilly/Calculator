using System;
using System.Collections.Generic;

namespace MyCalc.ConsoleApp
{
    public class OperatorPrioritet
    {
        public Dictionary<string, int> opPrio;
        
        public OperatorPrioritet()
        {


        }
        public Dictionary<string, int> getOpPrio()
        {
            opPrio = new Dictionary<string, int>();
            opPrio.Add(")", 3);
            opPrio.Add("*", 2);
            opPrio.Add("/", 2);
            opPrio.Add("+", 1);
            opPrio.Add("-", 1);

            return opPrio;
        }
    }   
}

