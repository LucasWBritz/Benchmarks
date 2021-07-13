using BenchmarkDotNet.Running;
using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateParsing>();

            Console.ReadKey();
        }
    }
}
