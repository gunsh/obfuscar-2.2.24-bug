using System;
using System.Reflection;
using Enum = ClassLibrary1.Enum;

namespace ConsoleApp12
{
    public class KeyFilterAttribute : Attribute
    {
        public object Key { get; }

        public KeyFilterAttribute(object key)
        {
            Key = key;
        }
    }

    class Program
    {
        public static void Test([KeyFilter(Enum.Value)] Program args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().GetParameters()[0].GetCustomAttribute<KeyFilterAttribute>().Key);
        }

        public static void Main(string[] args)
        {
            Test(null);
        }
    }
}
