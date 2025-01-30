using System.Collections.Generic;
using System;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //int[] nums1 = [1, 2, 3, 0, 0, 0];

            //int[] nums2 = [2, 5, 6];

            //int[] nums1 = [2, 0, 0, 0];

            //var l1 = new ListNode();
            //l1.val = 2;

            //l1.next = new ListNode();
            //l1.next.val = 4;

            //l1.next.next = new ListNode();
            //l1.next.next.val = 3;


            //var l2 = new ListNode();
            //l2.val = 5;

            //l2.next = new ListNode();
            //l2.next.val = 6;

            //l2.next.next = new ListNode();
            //l2.next.next.val = 4;

            //int[] nums = { 2, 2, 4 };

            //var res = MinSubArrayLenForTarget.MinSubArrayLen_2(4, nums);

            //var re = LongestSSNoRepeating.LengthOfLongestSubstring_3("pwwkew");
            //AddTwoNumbers.Execute(l1, l2);

            //int[] nums2 = [1, 1, 5];
            //int m = 1, n = 3;

            //MergeSortedArray.Merge_2(nums1,m, nums2, n);


            //string[] words = { "a", "b", "c", "d", "e", "f", "g" };

            //string[] words = { "a", "b", "c" };

            //GeneratePermutations.GeneratePerm(words);

            //GeneratePermutations.Permute([ 1]);


            int res = RemoveDuplicateSortedArray.RemoveDuplicateFromSortedArray([2,3,3,4]);
            Console.WriteLine("[2,3,3,4]: " + res.ToString());
            res = RemoveDuplicateSortedArray.RemoveDuplicateFromSortedArray([2, 3]);
            Console.WriteLine("[2,3]: " + res.ToString());
            res = RemoveDuplicateSortedArray.RemoveDuplicateFromSortedArray([3, 3]);
            Console.WriteLine("[3, 3]: " + res.ToString());
            res = RemoveDuplicateSortedArray.RemoveDuplicateFromSortedArray([1, 2, 2]);
            Console.WriteLine("[1, 2, 2], 2: " + res.ToString());

            res = RemoveDuplicateSortedArray.RemoveDuplicateFromSortedArray([1, 1, 1, 2, 2, 3, 4, 4, 5]);
            Console.WriteLine("[1, 1, 1, 2, 2, 3, 4, 4, 5]: " + res.ToString());

            res = RemoveDuplicateSortedArray.RemoveDuplicateFromSortedArray([0, 0, 0, 0, 1, 1, 2, 2, 2, 2, 3, 4, 40]);
            Console.WriteLine("[0, 0, 0, 0, 1, 1, 2, 2, 2, 2, 3, 4, 40]: " +  res.ToString());
            



        }


       
    }
}
