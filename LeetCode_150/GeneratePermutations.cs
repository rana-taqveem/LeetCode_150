using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_150
{
    public class GeneratePermutations
    {
        public static HashSet<string> GeneratePerm(string[] words)
        {
            var wordsList = new HashSet<string>();
            wordsList.Add(string.Join("", words));
            Generate_2(words, wordsList);

            return wordsList;


        }

        private static void Generate_1(string[] words, HashSet<string> wordsList)
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

                if (!wordsList.Contains(currentPermutationString))
                {
                    wordsList.Add(currentPermutationString);
                    Generate_1(currentPermutation, wordsList);
                }

                index++;
                marker++;
            }

        }

        private static void Generate_2(string[] words, HashSet<string> wordsList)
        {
            int index = 0;
            int marker = 0;
            while (index < words.Length - 1)
            {
                Swap(words, index + 1, marker);

                var currentPermutationString = string.Join("", words);
                if (!wordsList.Contains(currentPermutationString))
                {
                    wordsList.Add(currentPermutationString);
                    Generate_2(words, wordsList);
                }

                Swap(words, index + 1, marker);

                index++;
                marker++;
            }

        }

        private static void Swap(string[] words, int index, int marker)
        {
            var temp = words[index];
            words[index] = words[marker];
            words[marker] = temp;
        }
    }
}
