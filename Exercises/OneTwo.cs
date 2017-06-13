﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        * Given a string, compute a new string by moving the first char to come after the next two chars, so "abc" yields "bca". 
        * Repeat this process for each subsequent group of 3 chars, so "abcdef" yields "bcaefd". 
        * Ignore any group of fewer than 3 chars at the end.
        *
        * oneTwo("abc") → "bca"
        * oneTwo("tca") → "cat"
        * oneTwo("tcagdo") → "catdog"
        */
        public string OneTwo(string str)
        {
            string output = "";
            string changeLetter = "";
            if (str.Length > 2 && str.Length % 3 == 0)
            {
                for (int i = 0; i < str.Length - 2; i += 3)
                {
                    changeLetter = str.Substring(i, 1);
                    //for first iteration will use initial string
                    if (i < 1)
                    {
                        output = str.Insert(i + 3, changeLetter);
                        output = output.Remove(i, 1);
                    }
                    //starting with second iteration will use thre previous output
                    else
                    {
                        output = output.Insert(i + 3, changeLetter);
                        output = output.Remove(i, 1);
                    }
                }
                return output;
            }
            return str;
        }
    }
}
