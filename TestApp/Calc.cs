using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Calc
    {
        internal decimal Add(string s = null)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            if (s.Length == 1)
                return decimal.Parse(s);
            var args = s.Split(',');
            decimal result = 0;
            foreach (var arg in args)
                result += decimal.Parse(arg);
            return result;
        }
    }
}
