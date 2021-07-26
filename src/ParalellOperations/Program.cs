using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParalellOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ParalellOperation>();

            Console.ReadKey();
        }
    }
}
