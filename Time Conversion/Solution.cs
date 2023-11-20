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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var time = s.Substring(8);
        s = s.Replace(time,"");
        var hourtime1 = s.Substring(0,2);
        var hourtime = Convert.ToInt32(hourtime1);
        var newHourTime = string.Empty;
        if (time.ToLower() == "pm") {
            if (hourtime != 12) {
                newHourTime = (hourtime + 12).ToString();
            }
            else {
                newHourTime = hourtime1;
            }
        } else {
            if (hourtime == 12) {
                newHourTime = "00";
            } else {
                newHourTime = hourtime1;
            }
        }
        
        var result = s.Replace(hourtime1.ToString(), newHourTime);
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
