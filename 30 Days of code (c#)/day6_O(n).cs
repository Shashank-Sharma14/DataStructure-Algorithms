using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        StringBuilder sentence = new StringBuilder();
        StringBuilder even = new StringBuilder();
        StringBuilder odd = new StringBuilder();
        const char SPACE = ' ';
        int noOfTest = int.Parse(Console.ReadLine());

        for (int i = 0; i < noOfTest; i++)
        {
            sentence.Append($"{ Console.ReadLine() } ");
        }

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == SPACE)
            {
                Console.WriteLine($"{even.ToString()} {odd.ToString()}");
                even.Clear();
                odd.Clear();
                sentence.Remove(0, i + 1);
                i = -1;
            }
            else if (i % 2 == 0)
            {
                even.Append(sentence[i]);
            }
            else
            {
                odd.Append(sentence[i]);
            }

        }
    }

}
