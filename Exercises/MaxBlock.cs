using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {

        /*
        CHALLENGE: Given a string, return the length of the largest "block" in the string. 
        A block is a run of adjacent chars that are the same.

        maxBlock("hoopla") → 2
        maxBlock("abbCCCddBBBxx") → 3
        maxBlock("") → 0
        */
        public int MaxBlock(string str)
        {
            int maxLength = 0;
            int actualMaxLength = 1;
            int currentLength = 1;
            if (str.Length == 1)
            {
                maxLength = currentLength;
            }
            if (str.Length > 1)
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == str[i - 1])
                    {
                        currentLength += 1;
                    }
                    else
                    {
                        actualMaxLength = currentLength;
                        currentLength = 1;
                    }
                    if (actualMaxLength > maxLength)
                    {
                        maxLength = actualMaxLength;
                    }
                }
            }
            return maxLength;
        }
    }
}
