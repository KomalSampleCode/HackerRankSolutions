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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
            decimal countNegativeNumbers = arr.Where(x => x < 0).Count();
            decimal countPostiveNumbers = arr.Where(x => x > 0).Count();
            decimal countForZero = arr.Where(x => x == 0).Count();

            Console.WriteLine((countPostiveNumbers / arr.Count).ToString("N6"));
            Console.WriteLine((countNegativeNumbers / arr.Count).ToString("N6"));
            Console.WriteLine((countForZero / arr.Count).ToString("N6"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
