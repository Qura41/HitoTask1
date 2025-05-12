using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using static HitoTaskArray1.ArrayMethods;
using static HitoTaskArray1.IO;

namespace HitoTaskArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInputReader reader = new ConsoleInputReader();
            
            Menu(reader);

            Console.ReadKey();
        }
    }
}