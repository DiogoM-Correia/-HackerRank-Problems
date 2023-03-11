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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        string newString = "";
        int alphabetSize = 26;
        
        if (k > 26)
        {
            k = k % 26;
        }
        
        for(int i = 0; i < s.Length; i++)
        {            
            char currentChar = (char) s[i];
            
            int newCharN = ((int)s[i]) + k;
            
            char updateString = ((char)newCharN);               
            
            //Small case
            if (currentChar >= 'a' && currentChar <= 'z')
            {            
                if (updateString > 'z')
                {
                    updateString = (char) (newCharN - alphabetSize);
                }
                newString +=  updateString.ToString();
            }
            else if (currentChar >= 'A' && currentChar <= 'Z')
            {
                if (updateString > 'Z')
                {
                    updateString = (char) (newCharN - alphabetSize);
                }
                newString +=  updateString.ToString();
            }
            else 
            {
                newString +=  s[i].ToString();
            }
        }
        return newString;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
