﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
            var args = _s.Split(delimiters, StringSplitOptions.None);
            var numbers = args.Select(p => decimal.Parse(p)).ToArray();
            if (numbers.Any(p => p < 0))
                throw new Exception(string.Format("negatives not allowed: " + numbers
                    .Where(p => p < 0)
                    .Select(p => p.ToString())
                    .Aggregate((i, j) => string.Concat(i, ",", j))));
            return numbers.Where(p => p < 1001).Sum();
        }

        private static string[] GetDelimiters(string s, ref string _s)
        {
            var delimiters = new List<string> { ",", "\n" };
            if (_s.StartsWith("//"))
            {
                if (s.Substring(3, 1).Equals("\n"))
                {
                    delimiters.Insert(0, _s.Substring(2, 1));
                    _s = _s.Substring(4);
                }
                else
                {
                    var matches = Regex.Matches(_s, @"\[(.+)+\]");
                    if (matches.Count > 0)
                    {
                        foreach (var m in matches)
                        {
                            var matchString = m.ToString();
                            delimiters.Add(matchString.Substring(1, matchString.Length - 2));
                        }
                    }
                }
            }

            return delimiters.ToArray();
        }
    }
}
