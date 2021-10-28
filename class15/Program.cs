using System;
using System.Diagnostics;

namespace class15
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico electro = new Electrodomestico(200, 10, "azul", "F");
            
            Console.WriteLine(electro.Color);
            Console.WriteLine(electro.ConsumoEnergia);
            
        }
    }
}