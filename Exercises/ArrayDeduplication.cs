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
        Given an integer array, return the array with all of the duplicate values removed.         

        ArrayDeduplication([8, 13, 13, 9, 11, 12]) → [8, 13, 9, 11, 12]
        ArrayDeduplication([]) → []        
        ArrayDeduplication([1, 1, 1]) → [1]
        */
        public int[] ArrayDeduplication(int[] nums)
        {
            HashSet<int> singleNumber = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                singleNumber.Add(nums[i]);
            }
            int[] arrayDedup = new int[singleNumber.Count];
            singleNumber.CopyTo(arrayDedup);

            return arrayDedup;
        }
    }
}
