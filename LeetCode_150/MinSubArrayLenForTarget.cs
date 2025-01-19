using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_150
{
    public  class MinSubArrayLenForTarget
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int len = 0;
            int minLen = 0;
            int index = 0;

            var set = new Dictionary<int, int>();
            int sum = 0;
            int left = 0;

            while (index < nums.Length || set.Count > 0)
            {

                if (index < nums.Length)
                {
                    set.Add(index, nums[index]);
                    sum = sum + nums[index];
                    len++;
                    index++;
                }


                while (sum >= target)
                {
                    var v = 0;
                    if(minLen == 0 && len > 0)
                    {
                        minLen = len;
                    }

                    if (set.TryGetValue(left, out v))
                    {
                        minLen = Math.Min(minLen,len);
                        sum = sum - v;
                        set.Remove(left);
                        left++;
                        len--;
                    }
                }


                if (index >= nums.Length && sum < target)
                {
                    set.Clear();
                }
            }


            return minLen;

        }


        public static int MinSubArrayLen_best(int target, int[] nums)
        {
            int minLen = 0;
            int index = 0;
            int sum = 0;
            int left = 0;

            while (index < nums.Length)
            {
                sum = sum + nums[index];

                while (sum >= target)
                {
                    if (minLen == 0 && (index - left + 1) > 0)
                    {
                        minLen = index - left + 1;
                    }

                    minLen = Math.Min(minLen, index - left + 1);
                    sum = sum - nums[left];
                    left++;
                }

                index++;
            }

            return minLen;

        }
    }
}
