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
            return decimal.Parse(s);
        }
    }
}
