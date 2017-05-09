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
        CHALLENGE: Say that a "clump" in an array is a series of 2 or more adjacent elements of the same value.
        Return the number of clumps in the given array.

        countClumps([1, 2, 2, 3, 4, 4]) → 2
        countClumps([1, 1, 2, 1, 1]) → 2
        countClumps([1, 1, 1, 1, 1]) → 1
        */
        public int CountClumps(int[] nums)
        {
            int setClamps = 0;
            bool moreClams = false;
            int numbSetClamps = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i]==nums[i-1])
                {
                    moreClams = true;
                    numbSetClamps += 1;
                }
                else
                {
                    if (moreClams==true)
                    {
                        setClamps += 1;
                        numbSetClamps = 0;
                    }
                }
            }
            if(numbSetClamps>0 & setClamps==0)
            {
                setClamps += 1;
            }
            return setClamps;
        }
    }
}
