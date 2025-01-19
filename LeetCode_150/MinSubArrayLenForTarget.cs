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
    }
}
