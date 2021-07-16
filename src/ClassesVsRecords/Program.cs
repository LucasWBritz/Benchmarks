using BenchmarkDotNet.Running;
using System;

namespace ClassesVsRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ClassVsRecord>();

            Console.ReadKey();
        }
    }
}
