using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_150
{
    public class RemoveElement
    {
        public static int RemoveElementFromArray(int[] nums, int val)
        {
            int count = 0;
            int jumpback = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    jumpback++;
                }
                else
                {
                    if (jumpback > 0) 
                    { 
                        nums[i -jumpback] = nums[i];
                        nums[i] = val;
                    }

                    count++;
                }
            }

            return count;
        }
    }

}
