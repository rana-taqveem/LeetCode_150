using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_150
{
    public class LongestSSNoRepeating
    {
        public static int LengthOfLongestSubstring(string s)
        {

            int maxLen = 0;
            if (s.Length > 1)
            {
                char[] c = s.ToCharArray();
                var set = new HashSet<char>();
                int index = 1;
                int markerIndex = 0;
                int len = 1;
                char marker = c[0];
                set.Add(marker);
                bool maxLenSet = false;

                while (markerIndex < c.Length && index < c.Length)   // T, T
                {
                    if (marker != c[index] && !set.Contains(c[index]))  // T, T, F
                    {
                        len++;   // 2, 3,
                        set.Add(c[index]);
                    }
                    else
                    {
                        if (len > maxLen)
                        {
                            maxLen = len; // 3
                            maxLenSet = true;
                        }

                        markerIndex++;
                        index = markerIndex + 1;
                        marker = c[markerIndex];
                        set.Clear();
                        set.Add(marker);
                        len = 1;
                    }

                    index++; // 2, 3

                }

                if (!maxLenSet || len > maxLen)
                    maxLen = len;
            }
            else
            {
                maxLen = s.Length;
            }

            return maxLen;


        }
    }
}
