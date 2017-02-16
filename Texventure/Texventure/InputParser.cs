using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Texventure
{
    public class InputParser
    {
        public static bool parseAsText(string text)
        {
            bool success = Regex.IsMatch(text, @"^[a-zA-Z]+$");

            return success;
        }
    }
}