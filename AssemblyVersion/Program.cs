//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Madhon">
//     Company (c) 2018 Madhon
// </copyright>
//-----------------------------------------------------------------------

namespace AssemblyVersionProg
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Main entry point class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point Method
        /// </summary>
        /// <param name="args">Assembly file to parse and display version from</param>
        private static void Main(string[] args)
        {
            Assembly a = Assembly.LoadFrom(args[0]);
            Console.WriteLine(a.FullName);
        }
    }
}