using System;
using System.StubHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rotate.PermCombination
{
    internal class PermuteString
    {
        readonly string baseString;
        readonly int baseStringLength;
        IList<string> result;

        public PermuteString(string sourceString)
        {
            if(!String.IsNullOrEmpty(sourceString)) 
            {
                char[] sortedString = sourceString.Trim().ToCharArray();
                Array.Sort<char>(sortedString);
                baseString = new String(sortedString);
                baseStringLength =baseString.Length;
            }
            result = new List<string>();
        }

        public void PrintStringPermuatation()
        {
            if(!String.IsNullOrEmpty(baseString))
            {
                char[] startString = baseString.ToCharArray();
                generateStringPermutation(0, startString);
                foreach(var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Input String is empty");
            }
        }

        private void generateStringPermutation(int startIndex, char[] startString)
        {
            if (startIndex < baseStringLength)
            {
                int i = startIndex;
                int j = i;
                while (j < baseStringLength)
                {
                    startString[i] = baseString[j];
                    result.Add(new String(startString));
                    ++j;
                }
                generateStringPermutation(++startIndex, startString);
            }
            else
            {
                return;
            }
        }

    }
}
