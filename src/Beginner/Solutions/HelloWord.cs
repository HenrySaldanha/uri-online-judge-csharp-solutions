/*
   * Your first program in any programming language is usually "Hello World!". 
   * In this first problem all you have to do is print this message on the screen.
*/
using System;

namespace Uri.Projects.Beginner.Solutions
{
    public class HelloWord
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new HelloWordSolution().GetSolution());
        }
    }

    public class HelloWordSolution
    {
        public string GetSolution() => "Hello World!";
    }
}
