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


        public static int LengthOfLongestSubstring_2(string s)
        {

            int maxLen = 0;
            if (s.Length > 1)
            {
                char[] c = s.ToCharArray();
                var set = new Dictionary<char, int>();
                int index = 0;
                int lastMarker = 0;
                int len = 0;

                while (index < c.Length)   // T, T
                {
                    if (set.TryGetValue(c[index], out lastMarker))
                    {
                        index = lastMarker + 1;
                        if (len > maxLen)
                        {
                            maxLen = len;
                        }

                        set.Clear();
                        len = 0;
                        lastMarker = 0;

                    }
                    else
                    {
                        set.Add(c[index], index);
                        index++;
                        len++;
                    }

                }

                if(len >  maxLen) maxLen = len;

            }
            


            return maxLen;

        }


        public static int LengthOfLongestSubstring_3(string s)
        {
            int maxLen = 0;
            var set = new HashSet<char>();
            int index = 0;
            int left = 0;
            int len = 0;

            while (index < s.Length)   // T, T
            {
                while (set.Contains(s[index]))
                {
                    set.Remove(s[left]);
                    left++;

                }

                set.Add((s[index]));
                maxLen = Math.Max(maxLen, index - left + 1);
                index++;

            }

            return maxLen;
        }

    }
}
