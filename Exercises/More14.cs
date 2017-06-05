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

        Given an array of ints, return true if the number of 1's is greater than the number of 4's

        more14([1, 4, 1]) → true
        more14([1, 4, 1, 4]) → false
        more14([1, 1]) → true
        */
        public bool More14(int[] nums)
        {
            int ones = 0;
            int fors = 0;
            // loops true nums array
            for (int i = 0; i < nums.Length; i++)
            {
                //count number of 1's
                if (nums[i] == 1)
                {
                    ones += 1;
                }
                //count number of 4's
                if (nums[i] == 4)
                {
                    fors += 1;
                }
            }
            //return true if number of 1's is grater than number of 4's
            if(ones>fors)
            {
                return true;
            }
          
            return false;
        }
    }
}
