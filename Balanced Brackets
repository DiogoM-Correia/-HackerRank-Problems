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
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        List<string> openBrackets = new List<string> ();
        Dictionary<string, string> bracketPairs = new Dictionary<string, string>{
            ["{"]="}", 
            ["("]=")",
            ["["]="]"};
        string isBalanced = "YES";
        int curentOpenBracketsSize = 0;
        
        for(int i = 0; i < s.Length; i ++)
        {
            //Save in a new string to now always consult the list 
            string currentChar = s.ElementAt(i).ToString();
            
            if (bracketPairs.Keys.Contains(currentChar))
            {
                //Add open bracket to list 
                openBrackets.Add(currentChar);
                curentOpenBracketsSize ++;
            }            
            else if (bracketPairs.Values.Contains(currentChar))
            {
                //If 0 means there is no open bracket for this
                if (curentOpenBracketsSize == 0)
                {
                    return "NO";
                }
                else
                {
                    string correpondingOpenBracket = bracketPairs.Where(s => s.Value == currentChar).First()                                .Key.ToString();
                    
                    //If they are different means it's unbanlanced
                    //Else remove closing bracket from list and update counter
                    if (openBrackets[curentOpenBracketsSize-1] != correpondingOpenBracket)
                    {
                        return "NO";
                    }
                    else 
                    {
                        openBrackets.RemoveAt(curentOpenBracketsSize-1);
                        curentOpenBracketsSize--;
                    }
                }
            }
        }
        
        //If there are open brackets in without closing
        if (curentOpenBracketsSize > 0)
        {
            return "NO";
        }
        
        return isBalanced;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
