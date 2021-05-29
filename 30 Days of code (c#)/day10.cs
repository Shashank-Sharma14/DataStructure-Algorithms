using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int count = 0, max = 0, rem = 0;
        while (n != 0)
        {
            rem = n % 2;
            if (rem == 1)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            max = Math.Max(max, count);
            n = n / 2;
        }
        Console.WriteLine(max);
    }
}
