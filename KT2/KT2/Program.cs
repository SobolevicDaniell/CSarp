using System;

namespace KT2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TestDictionary<int, string> testDictionary = new TestDictionary<int, string>();
            testDictionary.Add(0, "t1");
            testDictionary.Add(1, "t2");
            testDictionary.Add(2, "t3");
            testDictionary.Add(3, "t4");
            Console.WriteLine(testDictionary.FindKey(1).Value);
            Console.WriteLine(testDictionary.FindValue("t3").Key);
        }
    }
}