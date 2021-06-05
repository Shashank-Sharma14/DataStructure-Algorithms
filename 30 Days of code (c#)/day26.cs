using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] returnDate = new string[3];

        string[] dueDate = new string[3];

        returnDate = Console.ReadLine().Split(' ');
        dueDate = Console.ReadLine().Split(' ');

      
        if (int.Parse(dueDate[2]) > int.Parse(returnDate[2]))
        {
            Console.WriteLine("0");
        }
        else if (int.Parse(dueDate[2]) < int.Parse(returnDate[2]))
        {
            Console.Write("10000");
        }
        else if (int.Parse(dueDate[1]) < int.Parse(returnDate[1]))
        {
            Console.WriteLine(500 * (int.Parse(returnDate[1]) - int.Parse(dueDate[1])));
        }
        else if (int.Parse(dueDate[0]) < int.Parse(returnDate[0]))
        {
            Console.WriteLine(15 * (int.Parse(returnDate[0]) - int.Parse(dueDate[0])));
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
