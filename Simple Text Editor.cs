using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int nOperations = Convert.ToInt32(Console.ReadLine());
        
        List<string> strings = new();
        
        for (int i = 0; i < nOperations; i++)
        {
            string operation = Console.ReadLine();
            
            int operationType = Convert.ToInt32(operation.Split(' ')[0]);
            //Console.WriteLine(operation);
            
            int size = strings.Count;
            
            string S = "";
            
            if (size > 0)
            {
                S = strings[size - 1];
            }
            
            switch (operationType)
            {
                case 1:
                    
                    strings.Add(append(S, operation.Split(' ')[1]));                    
                    break;
                    
                case 2:
                
                    strings.Add(delete(S, Convert.ToInt32(operation.Split(' ')[1])));
                    break;
                    
                case 3:
                
                    Console.WriteLine(print (S, Convert.ToInt32(operation.Split(' ')[1])));
                    break;
                    
                case 4:
                
                    strings.RemoveAt(size - 1);
                    break;
            }
            //size = strings.Count;
            //Console.WriteLine(strings[size - 1]);
        }
    }
    
    public static string append (string S, string stringToAdd)
    {
        S = S + stringToAdd;
        
        return S;
    }
    
    public static string delete (string S, int nCharsToDelete)
    {
        int size = S.Length;
        
        return S.Substring(0, Math.Min(size-nCharsToDelete, size));
        
    }
    
    public static char print (string S, int charPosition)
    {
        
        return S[charPosition - 1];
    }
} 
