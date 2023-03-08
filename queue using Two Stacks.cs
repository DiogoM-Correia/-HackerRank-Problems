using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static void moveTasks (ref Stack<int> queue2, ref Stack <int> queue1)
    {        
        queue1.Push(queue2.Pop()); 
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        var numberOfQueries = int.Parse(Console.ReadLine());
        var queue1 = new Stack<int>();
        var queue2 = new Stack<int>();
        bool isQueue1First = true;
        
        for (int i = 0; i < numberOfQueries; i++)
        {            
            var inputSplits = Console.ReadLine().Split(' ');
            var queryType = int.Parse(inputSplits[0]);
            
            if(queryType == 1)
            {            
                if (queue1.Count == 0 && queue2.Count == 0)
                {
                    queue1.Push(int.Parse(inputSplits[1]));
                    isQueue1First = true;
                }
                else
                {
                    queue2.Push(int.Parse(inputSplits[1]));
                }
            }
            else if (queryType == 2)
            {
                if (isQueue1First == true)
                {
                    queue1.Pop();
                    if (queue2.Count != 0 && queue1.Count == 0)
                        isQueue1First = false;
                }
                else
                {
                    if (queue2.Count > 0)
                    {
                        //moveTasks(ref queue2, ref queue1);
                        while (queue2.Count > 1)
                            moveTasks(ref queue2, ref queue1);
                            
                        queue2.Pop();
                        isQueue1First = true;
                    }

                }
            }
            else if (queryType == 3)
            {
                if (isQueue1First == true)
                    Console.WriteLine(queue1.Peek());
                else
                {
                    if (queue2.Count > 0)
                    {
                        while (queue2.Count > 0)
                            moveTasks(ref queue2, ref queue1);

                        isQueue1First = true;
                        Console.WriteLine(queue1.Peek());
                    }

                }
            }
            else
            {
                Console.WriteLine("Wrong query type!");
            }
            
        }
    }
} 
