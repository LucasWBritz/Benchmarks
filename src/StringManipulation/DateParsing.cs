using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    [MemoryDiagnoser]
    public class DateParsing
    {
        private readonly string _date = "13 07 2021";

        [Benchmark]
        public DateTime ParseDateUsingSubstring()
        {
            var day = _date.Substring(0, 2);
            var month = _date.Substring(3, 2);
            var year = _date.Substring(6);

            return new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
        }

        [Benchmark]
        public DateTime ParseDateUsingSpan()
        {
            ReadOnlySpan<char> dateSpan = _date;

            var day = dateSpan.Slice(0, 2);
            var month = dateSpan.Slice(3, 2);
            var year = dateSpan.Slice(6);

            return new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
        }

    }
}
