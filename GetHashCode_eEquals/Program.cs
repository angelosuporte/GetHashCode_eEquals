using System;
using GetHashCode_eEquals.Entities;
using System.Collections.Generic;

namespace GetHashCode_eEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Produto> conjuntoItem = new HashSet<Produto>();
            conjuntoItem.Add(new Produto("TV", 900.0));
            conjuntoItem.Add(new Produto("Notebook", 1200.0));

            HashSet<Ponto> conjuntoCartesiano = new HashSet<Ponto>();
            conjuntoCartesiano.Add(new Ponto(3, 4));
            conjuntoCartesiano.Add(new Ponto(5, 10));

            Produto prod = new Produto("Notebook", 1200.0);
            Console.WriteLine(conjuntoItem.Contains(prod));

        }
    }
}
