using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace ClassesVsRecords
{
    [MemoryDiagnoser]
    public class ClassVsRecord
    {
        [Benchmark]
        public void CreatePerson()
        {
            List<Person> persons = new();
            for (int i = 0; i < 1000; i++)
            {
                persons.Add(new Person()
                {
                    Name = i.ToString(),
                    Age = i
                });
            }
        }

        [Benchmark]
        public void CreatePersonRecord()
        {
            List<PersonRecord> persons = new();
            for (int i = 0; i < 1000; i++)
            {
                persons.Add(new PersonRecord(i.ToString(), i));
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public record PersonRecord(string Name, int Age);
}
