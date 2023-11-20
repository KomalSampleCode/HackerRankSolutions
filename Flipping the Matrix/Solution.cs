using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankWeekTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<int>> matrix = new List<List<int>>();
            matrix.Add(new List<int> { 112, 42, 83, 119 });
            matrix.Add(new List<int> { 56, 125, 56, 49 });
            matrix.Add(new List<int> { 15, 78, 101, 43 });
            matrix.Add(new List<int> { 62, 98, 114, 108 });

            int result = Result.flippingMatrix(matrix);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    class Result
    {

        public static int flippingMatrix(List<List<int>> matrix)
        {
            var result = 0;

            int[][] array = matrix.Select(x => x.ToArray()).ToArray();
            int n = matrix.Count() / 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    List<int> list = new List<int>();
                    var value1 = array[i][j];
                    var value2 = array[2 * n - i - 1][j];
                    var value3 = array[i][2 * n - j - 1];
                    var value4 = array[2 * n - i - 1][2 * n - j - 1];

                    list.Add(value1);
                    list.Add(value2);
                    list.Add(value3);
                    list.Add(value4);

                    result = result + list.Max();
                }
            }
            return result;
        }
    }
}
