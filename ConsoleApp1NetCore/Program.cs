using System;
using ClassLibraryDotNetFW;

namespace ConsoleApp1NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello World!";
            Console.WriteLine(text.StartsWithUpper());

            Console.WriteLine(StringLibrary.GetTimeObject());
        }
    }
}
