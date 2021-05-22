using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var noOfTest = Convert.ToInt32(Console.ReadLine());
        var words = new string[noOfTest];

        for (int i = 0; i < noOfTest; i++)
        {
            words[i] = Console.ReadLine();
        }

        seprateWords(words);
    }

    public static void seprateWords(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            var firstWord = "";
            var secondWord = "";
            var word = words[i];
            for (int j = 0; j < word.Length; j++)
            {
                if (j % 2 == 0)
                {
                    firstWord = firstWord + word[j];
                }
                else
                {
                    secondWord = secondWord + word[j];
                }
            }
            Console.WriteLine(firstWord + " " + secondWord);
        }
    }
}
