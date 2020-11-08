using System;
using GetHashCode_eEquals.Entities;

namespace GetHashCode_eEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente a = new Cliente { Nome = "Maria", Email = "maria@gmail.com" };
            Cliente b = new Cliente { Nome = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
