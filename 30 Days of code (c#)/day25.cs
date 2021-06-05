using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int noOfInput= int.Parse( Console.ReadLine());
        int[] input = new int[noOfInput];
        for (int i = 0; i < noOfInput; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < noOfInput; i++)
        {
            if (isPrime(input[i]))
               Console.WriteLine("Prime"); 
            else
                Console.WriteLine("Not prime");
        }
    }

    public static bool isPrime(int value)
    {
        if (value <= 1)
            return false;

        for (int i = 2; i <= value/i; i++)
        {
            if (value % i == 0)
                return false;
        }

        return true;
        
    }
}
