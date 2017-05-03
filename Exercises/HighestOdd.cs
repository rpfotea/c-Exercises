﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class GoHighestOdd
    {
        /*
         * Given an array of positive integers, find the highest odd number. If there aren't any odd
         * numbers, return back 0.
         * 
         * HighestOdd([]) -> 0
         * HighestOdd([2, 10]) -> 0
         * HighestOdd([3, 7, 8]) -> 7
         */
        public int HighestOdd(int[] nums)
        {
            int highestOddNumber = 0;
            if (nums.Length==0)
            {
                highestOddNumber=0;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]%2==1 && nums[i]>highestOddNumber)
                {
                    highestOddNumber = nums[i];
                }
            }
            return highestOddNumber;
        }
    }
}
