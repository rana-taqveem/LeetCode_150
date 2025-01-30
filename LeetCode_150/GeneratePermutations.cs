using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            var map2 = new HashSet<string>();
            map2.Add(string.Join("", words));


            var map3 = new HashSet<string>();
            map3.Add(string.Join("", words));

            //int counter = 0;
            //int counter_loop = 0;

            //// Create a stopwatch instance
            //Stopwatch stopwatch1 = new Stopwatch();

            //// Start the stopwatch
            //stopwatch1.Start();
            //Generate_1(words, map, ref counter, ref counter_loop);
            //stopwatch1.Stop();
            //Console.WriteLine($"Execution Time 1: {stopwatch1.ElapsedMilliseconds} ms");

            //Console.WriteLine("Generate_1 RR Count: " + counter);
            //Console.WriteLine("Generate_1 Loop Count: " + counter_loop);


            //int counter1 = 0;
            //int counter_loop1 = 0;


            //Stopwatch stopwatch2 = new Stopwatch();
            //// Start the stopwatch
            //stopwatch2.Start();
            //Generate_2(words, map2, ref counter1, ref counter_loop1);
            //stopwatch2.Stop();
            //Console.WriteLine($"Execution Time 2: {stopwatch2.ElapsedMilliseconds} ms");

            //Console.WriteLine("Generate_2 RR Count: " + counter1);
            //Console.WriteLine("Generate_2 Loop Count: " + counter_loop1);


            int counter3 = 0;
            int counter_loop3 = 0;
            //// Start the stopwatch

            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            Generate_gpt(words, map3, ref counter3, ref counter_loop3, 0);
            stopwatch3.Stop();
            Console.WriteLine($"Execution Time 3: {stopwatch3.ElapsedMilliseconds} ms");


            //Console.WriteLine("Generate_gpt RR Count: " + counter3);
            //Console.WriteLine("Generate_gpt Loop Count: " + counter_loop3);

            return map;


        }

        private static void Generate_1(string[] words, HashSet<string> map, ref int c, ref int cl)
        {
            int index = 0;
            int marker = 0;

            c++;
            while (index < words.Length - 1)
            {
                cl++;
                var currentPermutation = new string[words.Length];
                var currentPermutationString = String.Empty;
                Swap(words, index+1, marker);

                for (int j = 0; j < words.Length; j++)
                {
                    currentPermutation[j] = words[j];
                    currentPermutationString += words[j];
                }

                if (!map.Contains(currentPermutationString))
                {
                    map.Add(currentPermutationString);
                    Generate_1(currentPermutation, map, ref c, ref cl);
                }

                index++;
                marker++;
            }

        }

        private static void Generate_2(string[] words, HashSet<string> map, ref int c, ref int cl)
        {
            int index = 0;
            int marker = 0;
            c++;
            while (index < words.Length - 1)
            {
                cl++;
                Swap(words, index + 1, marker);

                var currentPermutationString = string.Join("", words);
                if (!map.Contains(currentPermutationString))
                {
                    map.Add(currentPermutationString);
                    Generate_2(words, map, ref c, ref cl);
                }

                Swap(words, index + 1, marker);

                index++;
                marker++;
            }

        }

        private static void Generate_gpt(string[] words, HashSet<string> wordsList, ref int c, ref int cl, int currentIndex = 0)
        {
            c++;
            // Base case: If currentIndex reaches the end, add the permutation to the list
            if (currentIndex == words.Length)
            {
                wordsList.Add(string.Join("", words));
                return;
            }

            // Generate permutations by swapping elements
            for (int i = currentIndex; i < words.Length; i++)
            {
                cl++;
                Swap(words, currentIndex, i);          // Swap currentIndex with i
                Generate_gpt(words, wordsList,  ref c, ref cl, currentIndex + 1); // Recurse with next index
                Swap(words, currentIndex, i);          // Backtrack to restore the original order
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
