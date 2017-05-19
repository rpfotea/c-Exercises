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
        CHALLENGE: Consider the leftmost and righmost appearances of some value in an array.
        We'll say that the "span" is the number of elements between the two inclusive. 
        A single value has a span of 1. 
        Returns the largest span found in the given array. (Efficiency is not a priority.)

        maxSpan([1, 2, 1, 1, 3]) → 4
        maxSpan([1, 4, 2, 1, 4, 1, 4]) → 6
        maxSpan([1, 4, 2, 1, 4, 4, 4]) → 6
        */
        public int MaxSpan(int[] nums)
        {
            int finalMaxSpan = 0;
            int actualMaxSpan = 0;
            int actualSpan = 0;
            if (nums.Length == 1)
            {
                finalMaxSpan = 1;
            }
            if (nums.Length > 1)
            {
                for(int i=0; i < nums.Length; i++)
                {
                    for(int j=i; j< nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            //calculate actual span length betwen to identic numbers;
                            actualSpan = j - i + 1;
                            //if actual span is greater than the previous one, then keep the new one;
                            if(actualSpan>actualMaxSpan)
                            {
                                actualMaxSpan = actualSpan;
                            }
                            //reset the actualSpan counter if is the last number from set;
                            if (j == nums.Length - 1)
                            {
                                actualSpan = 0;
                            }
                        }
                        if (actualMaxSpan > finalMaxSpan)
                        {
                            finalMaxSpan = actualMaxSpan;
                        }
                    }
                }

            }

            return finalMaxSpan;
        }
    }
}
