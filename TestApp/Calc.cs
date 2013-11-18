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
            var delimiters = GetDelimiters(s, ref _s);
            var args = _s.Split(delimiters);
            var numbers = args.Select(p => decimal.Parse(p)).ToArray();
            if (numbers.Any(p => p < 0))
                throw new Exception(string.Format("negatives not allowed: " + numbers
                    .Where(p => p < 0)
                    .Select(p => p.ToString())
                    .Aggregate((i, j) => string.Concat(i, ",", j))));
            return numbers.Where(p => p < 1001).Sum();
        }

        private static char[] GetDelimiters(string s, ref string _s)
        {
            var delimiters = new List<char> { ',', '\n' };
            if (_s.StartsWith("//") && s.Substring(3, 1).Equals("\n"))
            {
                delimiters.Insert(0, char.Parse(_s.Substring(2, 1)));
                _s = _s.Substring(4);
            }
            return delimiters.ToArray();
        }
    }
}
