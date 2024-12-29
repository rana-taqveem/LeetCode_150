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
            int num2_index = 0;
            int num1_index = 0;
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
                    if (num1_index < m && num2_index < n)
                    {
                        if (nums2[num2_index] == nums1[num1_index])
                        {
                            result[index] = nums1[num1_index];
                            result[index + 1] = nums2[num2_index];
                            num1_index++; // 2
                            num2_index++; // 1
                            index = index + 2; //3
                        }
                    }

                    if (num2_index < n)
                    {
                        if (num1_index == m)
                        {
                            result[index] = nums2[num2_index];
                            num2_index++; // 2, 3
                            index++; //5, 6
                        }
                        else if (nums2[num2_index] < nums1[num1_index])
                        {
                            result[index] = nums2[num2_index];
                            num2_index++;
                            index++;
                        }

                    }

                    if (num1_index < m)
                    {
                        if (num2_index == n)
                        {
                            result[index] = nums1[num1_index];
                            num1_index++;
                            index++;
                        }
                        else if (nums1[num1_index] < nums2[num2_index])
                        {

                            result[index] = nums1[num1_index];
                            num1_index++; // 3
                            index++;  // 4,
                        }

                    }

                }

                for (int i = 0; i < m + n; i++)
                    nums1[i] = result[i];
            }
        }
    }
}
