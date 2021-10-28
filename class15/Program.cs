using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace class15
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadora lava1 = new Lavadora(10,30, "azul", "D");
            Lavadora lava2 = new Lavadora(3);
            Television tv = new Television(50, true);
            Television tv1 = new Television(10, 50, "Rojo", "F");
            float total = 0;

            List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();
            
            electrodomesticos.Add(lava1);
            electrodomesticos.Add(lava2);
            electrodomesticos.Add(tv);
            electrodomesticos.Add(tv1);
            

          
                foreach (Electrodomestico electro in electrodomesticos)
                {
                        electro.PrecioFinal();
                        if (electro is Lavadora)
                        {
                            Console.WriteLine("*      Lavdora::");
                        }

                        if (electro is Television)
                        {
                            Console.WriteLine("*      Television::");
                        }
                        Console.WriteLine("ID: " + electro.GetHashCode() + " ");
                        Console.WriteLine("Precio: $ " + electro.PrecioFinal());
                }
                
                foreach (Electrodomestico electro in electrodomesticos)
                {
                    
                    total = total + electro.PrecioFinal();

                }
                
                Console.WriteLine("****************************");
                Console.WriteLine();
                Console.WriteLine("TOTAL: $ " + total);
                   


            




        }
    }
}