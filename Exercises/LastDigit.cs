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
        Given three ints, a b c, return true if two or more of them have the same rightmost digit. 
        The ints are non-negative. 
        Note: the % "mod" operator computes the remainder, e.g. 17 % 10 is 7.
        
        lastDigit(23, 19, 13) → true
        lastDigit(23, 19, 12) → false
        lastDigit(23, 19, 3) → true
        */
        public bool LastDigit(int a, int b, int c)
        {
            if(a%10==b%10 || a%10==c%10 || b%10==c%10)
            {
                return true;
            }
            return false;
        }
    }
}
