using System;
using Xunit;

using MyCalc.ConsoleApp;
using Xunit.Sdk;
using System.Data;

namespace MyCalc.Tests
{
    public class UnitTest1 : Calculator
    {
        //int SomeInt = Calc.SomeInt;
        [Fact]
        public void Test1()
        {

            //string math = "2*(3-1)-2+32*21";
            //string math = "(2 + 3) * (10 / 2)";
            //string math = "(2 + 4) * 3 + (4 - 2) / 4 + 6";
            string math = "1+1";
            string expected = "2";
            Assert.Equal(expected, calc(math).ToString());
            math = "(2 + 4) * 3 + (4 - 2) *34 +4 + 6";
            expected = "96";
            Assert.Equal(expected, calc(math).ToString());
            math = "2*(3-1)-2+32*21";
            expected = "674";
            Assert.Equal(expected, calc(math).ToString());
            math = "(2 + 3) * (10 / 2)";
            expected = "25";
            Assert.Equal(expected, calc(math).ToString());

        }

     }
    /*
    var testClass = new UnitTest1 { SomeInt = 234 };
    var result = testClass.calc("10 * SomeInt / 2 + 1");*/
}
