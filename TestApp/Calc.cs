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
            var _s = s;
            if (string.IsNullOrEmpty(_s))
                return 0;
            if (_s.Length == 1)
                return decimal.Parse(_s);
            var delimiters = new List<char> { ',', '\n' };
            if (_s.StartsWith("//") && s.Substring(3, 1).Equals("\n"))
            {
                delimiters.Insert(0, char.Parse(_s.Substring(2, 1)));
                _s = _s.Substring(4);
            }
            var args = _s.Split(delimiters.ToArray());
            var numbers = args.Select(p => decimal.Parse(p)).ToArray();
            return numbers.Sum();
        }
    }
}
