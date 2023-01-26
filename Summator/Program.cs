using System;
using System.IO;

namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Summator.Test_SumTwoNumbers();
            Console.WriteLine( "Sum equals " + Summator.Sum(new int[] { 1, 2, 3}));
            Console.WriteLine( "Average sum is: " + Summator.Average(new int[] { 4, 5, 6 }));
        }
    }
}