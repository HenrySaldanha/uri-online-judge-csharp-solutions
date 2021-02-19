/*
   * URI Online Judge | 1001
   * Read 2 variables, named A and B and make the sum of these two variables, assigning its result to the variable X. Print X as shown below. 
   * Print endline after the result otherwise you will get “Presentation Error”.
*/
using System;

namespace Uri.Projects.Beginner.Solutions
{
    public class ExtremelyBasic
    {
        public string GetSolutionResponse()
        {
            var firstValue = ReadAndParseIntValue();
            var secondValue = ReadAndParseIntValue();
            var solutionStringFormat = GetSolutionStringFormat();
            var solutionResponseValue = SumValues(firstValue, secondValue);

            return string.Format(solutionStringFormat, solutionResponseValue);
        }

        public int ReadAndParseIntValue()
        {
            var value = Console.ReadLine();
            return int.Parse(value);
        }

        public string GetSolutionStringFormat() => "X = {0}";

        public int SumValues(int a, int b) => a + b;
    }
}
