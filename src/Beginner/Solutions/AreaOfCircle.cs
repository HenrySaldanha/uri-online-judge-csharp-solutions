/*
   * URI Online Judge | 1002
   * The formula to calculate the area of a circumference is defined as A = π . R2. Considering to this problem that π = 3.14159:
   * Calculate the area using the formula given in the problem description.
*/
using System;

namespace Uri.Projects.Beginner.Solutions
{
    public class AreaOfCircle
    {
        private const double PI = 3.14159;
        public string GetSolutionResponse()
        {
            var radius = ReadAndParseDoubleValue();
            var solutionStringFormat = GetSolutionStringFormat();
            var solutionResponseValue = CircumferenceCalculate(radius);

            return string.Format(solutionStringFormat, solutionResponseValue);
        }

        public double ReadAndParseDoubleValue()
        {
            var value = Console.ReadLine();
            return double.Parse(value);
        }

        public string GetSolutionStringFormat() => "A={0}";

        public double CircumferenceCalculate(double radius) => Math.Round(PI * Math.Pow(radius, 2), 4);

    }
}
