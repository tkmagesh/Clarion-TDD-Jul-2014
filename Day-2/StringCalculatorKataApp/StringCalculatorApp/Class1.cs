using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculatorApp
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            return input.Split(new char[]{',','\n'}).Select<string,int>(item =>
                {
                    var n = 0;
                    int.TryParse(item, out n);
                    return n;
                }).Sum();
            
        }
    }
}
