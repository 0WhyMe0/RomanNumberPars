using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberPars
{
    internal class RomNumber
    {
        Dictionary<char, int> RomanNumber = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        public int Parse(string RomanNumberParse)
        {
            int result = 0;

            for (int i = 0; i < RomanNumberParse.Length; i++)
            {
                if(i + 1 < RomanNumberParse.Length && RomanNumberParse[i] < RomanNumberParse[i + 1])
                {
                    result -= RomanNumber[RomanNumberParse[i]];
                }
                else
                {
                    result += RomanNumber[RomanNumberParse[i]];
                }
            }
            return result;
        }
    }
}
