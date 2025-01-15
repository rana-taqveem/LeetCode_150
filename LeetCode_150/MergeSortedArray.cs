using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_150
{
    public class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int[] result = new int[nums1.Length];
            int y = 0;
            int x = 0;
            int index = 0;

            if (m == 0 && n != 0)
            {
                for (int i = 0; i < n; i++)
                    nums1[i] = nums2[i];
            }

            if (m != 0 && n != 0)
            {
                while (index < m + n)
                {
                    if (x < m && y < n)
                    {
                        if (nums2[y] == nums1[x])
                        {
                            result[index] = nums1[x];
                            result[index + 1] = nums2[y];
                            x++; // 2
                            y++; // 1
                            index = index + 2; //3
                        }
                    }

                    if (y < n && (x == m || (nums2[y] < nums1[x])))
                    {
                        if (x == m || nums2[y] < nums1[x])
                        {
                            result[index] = nums2[y];
                            y++; // 2, 3
                            index++; //5, 6
                        }
                    }

                    if (x < m && (y == n || (nums1[x] < nums2[y])))
                    {
                        result[index] = nums1[x];
                        x++; // 3
                        index++;  // 4,
                    }

                }

                for (int i = 0; i < m + n; i++)
                    nums1[i] = result[i];
            }
        }



    

        public static void Merge_2(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = new int[nums1.Length];
            int x = m - 1;
            int y = n - 1;
            int z = m + n - 1;

            int index = 0;

            if (m == 0 && n != 0)
            {
                for (int i = 0; i < n; i++)
                    nums1[i] = nums2[i];
            }

            if (m != 0 && n != 0)
            {
                while (n > 0)
                {
                    if (x > -1 && nums1[x] > nums2[y])
                    {
                        nums1[z] = nums1[x];
                        nums1[x] = 0;
                        x = x - 1;
                    }
                    else
                    {
                        nums1[z] = nums2[y];
                        y = y - 1;
                        n = n - 1;
                    }

                    z--;

                    index++;
                }
            }
        }
        public static void Merge_1(int[] nums1, int m, int[] nums2, int n)
        {

            int[] result = new int[nums1.Length];
            int x = m-1;
            int y = 0;
            int index = 0;

            if (m == 0 && n != 0)
            {
                for (int i = 0; i < n; i++)
                    nums1[i] = nums2[i];
            }
            
            if (m != 0 && n != 0)
            {
                while (n > 0)
                {
                    if (x > -1 && nums1[x] > nums2[y])
                    {
                        nums1[x + 1] = nums1[x];
                        nums1[x] = 0;
                        x = x - 1;
                    }
                    else
                    {
                        nums1[x + 1] = nums2[y];
                        y = y + 1;
                        m = m + 1;
                        n = n - 1;
                        x = m - 1;
                    }

                    index++;
                }
            }
        }
    }
}
