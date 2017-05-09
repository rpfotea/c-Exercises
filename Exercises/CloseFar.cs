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
        Given three ints, a b c, return true if one of b or c is "close" (differing from a by at most 1), 
        while the other is "far", differing from both other values by 2 or more.
        Note: Math.abs(num) computes the absolute value of a number.

        closeFar(1, 2, 10) → true
        closeFar(1, 2, 3) → false
        closeFar(4, 1, 3) → true
        */
        public bool CloseFar(int a, int b, int c)
        {
            if((Math.Abs(a-b)<2 && Math.Abs(a-c)>1 && Math.Abs(b-c)>1) || (Math.Abs(a - c) < 2 && Math.Abs(a - b) > 1 && Math.Abs(b - c) > 1))
            {
                return true;
            }
            return false;
        }
    }
}
