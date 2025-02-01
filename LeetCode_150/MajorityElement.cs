using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_150
{
    internal class MajorityElement
    {
        public static int FindMajorityelement(int[] nums)
        {
            int majority_element = 0;
            int max_count = 0;

            if (nums != null && nums.Length > 0)
            {
                if (nums.Length == 1)
                {
                    return nums[0];
                }

                var map = new Dictionary<int, int>();
                foreach (int num in nums)
                {
                    int current_count = 0;
                    if (map.TryGetValue(num, out current_count))
                    {
                        map[num] = current_count + 1;

                        if (current_count + 1 > max_count)
                        {
                            max_count = current_count + 1;
                            majority_element = num;
                        }
                    }
                    else
                    {
                        map.Add(num, 1);
                    }
                }
            }

            return majority_element;
        }


        public static int FindMajorityElement_Boyer_Moore_Voting(int[] nums)
        {

            if (nums.Length < 1)
            {
                return -1;
            }

            int majority_element = nums[0];
            int votes = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == majority_element)
                {
                    votes++;
                }
                else
                {
                    votes--;
                }

                if (votes == 0)
                {
                    majority_element = nums[i];
                    votes++;
                }
            }

            int count = 0;
            int required = nums.Length / 2 + 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == majority_element)
                {
                    count++;
                    if (count >= required)
                        return majority_element;
                }
            }


            return -1;=
            
        }
    }
}
