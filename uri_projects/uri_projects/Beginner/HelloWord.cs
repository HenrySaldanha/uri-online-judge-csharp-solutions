/*
   * Your first program in any programming language is usually "Hello World!". 
   * In this first problem all you have to do is print this message on the screen.
*/
using System;

namespace Uri.Projects.Beginner
{
    public class HelloWord
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new Solution().GetSolution());
        }
    }

    public class Solution
    {
        public string GetSolution() => "Hello World!\n";
    }
}
