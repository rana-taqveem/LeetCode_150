using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_150
{
    public class RemoveDuplicateSortedArray
    {
        public static int RemoveDuplicateFromSortedArray(int[] nums)
        {
            int count = 0;
            int jump = 0;

            if (nums.Length > 0)
            {
                count = 1;
                int current = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] <= current)
                    {
                        jump++;
                    }
                    else
                    {
                        current = nums[i];
                        if (jump > 0)
                        {
                            nums[i - jump] = nums[i];
                        }

                        count++;
                    }
                }
            }

            return count;
        }
    }

}
