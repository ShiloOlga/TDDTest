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
            if (s.Length == 3)
            {
                var args = s.Split(',');
                return decimal.Parse(args[0]) + decimal.Parse(args[1]);
            }
            return 0;
        }
    }
}
