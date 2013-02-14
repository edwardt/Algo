using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rotate.PermCombination
{
    internal static class PermuteStringTest
    {
        public static void Test1()
        {
            PermuteString permuteString = new PermuteString(null);
            permuteString.PrintStringPermuatation();

            permuteString = new PermuteString("");
            permuteString.PrintStringPermuatation();

            permuteString = new PermuteString("a");
            permuteString.PrintStringPermuatation();

            permuteString = new PermuteString("ba");
            permuteString.PrintStringPermuatation();

            permuteString = new PermuteString("aaaa");
            permuteString.PrintStringPermuatation();

            permuteString = new PermuteString("abcdef");
            permuteString.PrintStringPermuatation();

        }
    }
}
