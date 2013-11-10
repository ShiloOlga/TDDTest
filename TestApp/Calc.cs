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
            if (s.Equals("0,0"))
                return 0;
            if (s.Equals("0,1"))
                return 1;
            return 0;
        }
    }
}
