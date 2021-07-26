using BenchmarkDotNet.Attributes;
using System.Linq;

namespace ParalellOperations
{
    [MemoryDiagnoser]
    public class ParalellOperation
    {
        public static readonly int[] BillionValues = Enumerable.Range(1, 9999).Select(x => x).ToArray();

        [Benchmark]
        public void SequentialForeach()
        {
            int even = 0;
            foreach (var item in BillionValues)
            {
                if(item % 2 == 0)
                {
                    even++;
                }
            }
        }


        [Benchmark]
        public void SequentialFor()
        {
            int even = 0;
            for (int i = 0; i < BillionValues.Length; i++)
            {
                if (BillionValues[i] % 2 == 0)
                {
                    even++;
                }
            }            
        }

        [Benchmark]
        public void ParallelLinq()
        {
            int even = BillionValues.AsParallel().Where(x => x % 2 == 0).Count();
        }

        [Benchmark]
        public void Linq()
        {
            int even = BillionValues.Where(x => x % 2 == 0).Count();
        }
    }
}
