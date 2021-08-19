using BenchmarkDotNet.Attributes;
using System;

namespace EnumsToString
{
    [MemoryDiagnoser]
    public class EnumsParsing
    {
        public enum MyEnum
        {
            Option1,
            Option2,
            Option3,
            Option4,
            Option5,
            Option6,
            Option7,
            Option8,
            Option9,
            Option10,
        }

        [Benchmark]
        public string DefaultToString()
        {
            return MyEnum.Option10.ToString();
        }


        [Benchmark]
        public string ManualSwitchExpressionToString()
        {
            return GetEnumValue(MyEnum.Option10);
        }

        [Benchmark]
        public string ManualSwitchTostring()
        {
            return GetEnumSwitchValue(MyEnum.Option10);
        }

        public static string GetEnumValue(MyEnum value)
        {
            return value switch
            {
                MyEnum.Option1 => nameof(MyEnum.Option1),
                MyEnum.Option2 => nameof(MyEnum.Option2),
                MyEnum.Option3 => nameof(MyEnum.Option3),
                MyEnum.Option4 => nameof(MyEnum.Option4),
                MyEnum.Option5 => nameof(MyEnum.Option5),
                MyEnum.Option6 => nameof(MyEnum.Option6),
                MyEnum.Option7 => nameof(MyEnum.Option7),
                MyEnum.Option8 => nameof(MyEnum.Option8),
                MyEnum.Option9 => nameof(MyEnum.Option9),
                MyEnum.Option10 => nameof(MyEnum.Option10),
                _ => throw new NotImplementedException("Value not implemented")
            };
        }

        public static string GetEnumSwitchValue(MyEnum value)
        {
            switch (value)
            {
                case MyEnum.Option1:
                    return nameof(MyEnum.Option1);                    
                case MyEnum.Option2:
                    return nameof(MyEnum.Option2);
                case MyEnum.Option3:
                    return nameof(MyEnum.Option3);
                case MyEnum.Option4:
                    return nameof(MyEnum.Option4);
                case MyEnum.Option5:
                    return nameof(MyEnum.Option5);
                case MyEnum.Option6:
                    return nameof(MyEnum.Option6);
                case MyEnum.Option7:
                    return nameof(MyEnum.Option7);
                case MyEnum.Option8:
                    return nameof(MyEnum.Option8);
                case MyEnum.Option9:
                    return nameof(MyEnum.Option9);
                case MyEnum.Option10:
                    return nameof(MyEnum.Option10);
                default:
                    throw new NotImplementedException("Value not implemented");
            }
        }
    }
}
