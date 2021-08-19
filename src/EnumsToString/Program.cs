using BenchmarkDotNet.Running;
using System;

namespace EnumsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<EnumsParsing>();

            Console.ReadLine();
        }
    }
}
