using System;
using System.Collections.Generic;

namespace ElsoOra
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsoSzamunk = 83;
            double elsoTortem = 83.67;
            string elsoSzovegem = "ElsoSzovegem";

            Console.WriteLine("Hello World!" + "Valami" + elsoSzovegem);
            Console.WriteLine("sor");
            Console.WriteLine("sor \n");
            Console.WriteLine("sor");

            List<int> lista = new List<int>();

            lista.Add(5);
            lista.Add(8);
            lista.Add(11);

            Console.WriteLine(lista[0]);
        }
    }
}
