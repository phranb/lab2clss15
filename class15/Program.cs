using System;
using System.Diagnostics;

namespace class15
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico electro = new Electrodomestico(0, 30, "azul", "A");
            
            Console.WriteLine(electro.Color);
            Console.WriteLine(electro.ConsumoEnergia);
            
            Console.WriteLine(electro.PrecioFinal());
            
        }
    }
}