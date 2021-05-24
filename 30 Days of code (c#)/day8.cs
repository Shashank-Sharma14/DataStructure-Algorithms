using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        var noOfTestCases = int.Parse(Console.ReadLine());
        var info = new Dictionary<string, string>(); ;

        for (int i = 0; i < noOfTestCases; i++)
        {
            var content = Console.ReadLine();
            var data = content.Split(' ');
            info.Add(data[0], data[1]);
        }
        var search = "";
        while ((search = Console.ReadLine()) != null)
        {
            if (info.ContainsKey(search))
            {
                Console.WriteLine(search + "=" + info[search]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
