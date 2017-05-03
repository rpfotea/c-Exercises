using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class GoSecondHighest
    {
        /*
        * CHALLENGE: Given an array of integers, return the second highest number.
        * For arrays of length 0 retun 0, length 1 return the highest number.
        * 
        * SecondHighest([]) -> 0
        * SecondHighest([1]) -> 1
        * SecondHighest([1, 3, 5]) -> 3
        * SecondHighest([1, 3, 3]) -> 3
        * SecondHighest([1, 4, 6, 8, 23, 13]) -> 13
        */
        public int SecondHighest(int[] nums)
        {
            int secondNumber = 0;
            
            if(nums.Length==0)
            {
                secondNumber = 0;
            }

            if(nums.Length==1)
            {
                secondNumber =nums[0];
            }
            if(nums.Length>1)
            {
                Array.Sort(nums);
                secondNumber = nums[nums.Length - 2];
            }
            return secondNumber;
        }

    }
}
