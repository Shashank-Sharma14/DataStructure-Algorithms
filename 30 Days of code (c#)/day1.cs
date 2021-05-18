using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        var a = Int32.Parse(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        var c = Console.ReadLine();

        Console.WriteLine(i + a);
        Console.WriteLine("{0:F1}", (d + b));
        Console.WriteLine(s + c);
        // Declare second integer, double, and String variables.

        // Read and save an integer, double, and String to your variables.

        // Print the sum of both integer variables on a new line.

        // Print the sum of the double variables on a new line.

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
}