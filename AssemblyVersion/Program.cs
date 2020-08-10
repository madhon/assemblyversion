//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Madhon">
//     Company (c) 2018-2020 Madhon
// </copyright>
//-----------------------------------------------------------------------

namespace AssemblyVersionProg
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Main entry point class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main entry point Method
        /// </summary>
        /// <param name="args">Assembly file to parse and display version from</param>
        public static void Main(string[] args)
        {
            var a = Assembly.LoadFrom(args[0]);
            Console.WriteLine(a.FullName);
        }
    }
}