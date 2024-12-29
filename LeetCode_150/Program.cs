namespace LeetCode_150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int[] nums2 = [2, 5, 6];
            int m = 3, n = 3;

            MergeSortedArray.Merge(nums1,m, nums2, n);
        }
    }
}
