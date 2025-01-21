using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_150
{
    public class GeneratePermutations
    {

        public static IList<IList<int>> Permute(int[] nums)
        {
            var map = new HashSet<string>();
            map.Add(string.Join("", nums));
            var permutations = new List<IList<int>>();
            permutations.Add(nums.ToList());
            Generate_For_Num(nums, map, permutations);

            return (IList < IList<int> > ) permutations;
        }

        public static HashSet<string> GeneratePerm(string[] words)
        {
            var map = new HashSet<string>();
            map.Add(string.Join("", words));
            Generate_2(words, map);

            return map;


        }

        private static void Generate_1(string[] words, HashSet<string> map)
        {
            int index = 0;
            int marker = 0;

            while (index < words.Length - 1)
            {
                var currentPermutation = new string[words.Length];
                var currentPermutationString = String.Empty;
                Swap(words, index, marker);

                for (int j = 0; j < words.Length; j++)
                {
                    currentPermutation[j] = words[j];
                    currentPermutationString += words[j];
                }

                if (!map.Contains(currentPermutationString))
                {
                    map.Add(currentPermutationString);
                    Generate_1(currentPermutation, map);
                }

                index++;
                marker++;
            }

        }

        private static void Generate_2(string[] words, HashSet<string> map)
        {
            int index = 0;
            int marker = 0;
            while (index < words.Length - 1)
            {
                Swap(words, index + 1, marker);

                var currentPermutationString = string.Join("", words);
                if (!map.Contains(currentPermutationString))
                {
                    map.Add(currentPermutationString);
                    Generate_2(words, map);
                }

                Swap(words, index + 1, marker);

                index++;
                marker++;
            }

        }

        private static void Generate_For_Num(int[] nums, HashSet<string> map, List<IList<int>> permutations)
        {
            int index = 0;
            int marker = 0;
            while (index < nums.Length - 1)
            {
                Swap(nums, index + 1, marker);

                var currentPermutationString = string.Join("", nums);
                if (!map.Contains(currentPermutationString))
                {
                    map.Add(currentPermutationString);
                    permutations.Add(nums.ToList<int>());
                    Generate_For_Num(nums, map, permutations);
                }

                Swap(nums, index + 1, marker);

                index++;
                marker++;
            }

        }

        private static void Swap<T>(T[] arr, int index, int marker)
        {
            var temp = arr[index];
            arr[index] = arr[marker];
            arr[marker] = temp;
        }
    }
}
