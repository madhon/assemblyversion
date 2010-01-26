using System;
using System.Reflection;

namespace AssemblyVersionProg
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Assembly a = Assembly.LoadFrom(args[0]);
            Console.WriteLine(a.FullName);
        }
    }
}