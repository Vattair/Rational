using System;
using RationalLib;

namespace RationalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational32 u = new Rational32(1, 2);
            var w = new Rational32(0, 0);
            Console.WriteLine(u);
            Console.WriteLine(w);
        }
    }
}
