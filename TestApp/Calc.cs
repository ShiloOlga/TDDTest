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
            return string.IsNullOrEmpty(s) ? 0 : 1;
        }
    }
}
