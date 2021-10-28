using System;
using System.Collections;
using System.Collections.Generic;

namespace class15
{
    public class Electrodomestico
    {
        protected float precioBase = 100;
        protected float peso = 5;
        protected string color = "blanco";
        protected string consumoEnergia = "F";

        public Electrodomestico()
        {
            
        }

        public Electrodomestico(float precioBase, float peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }

        public Electrodomestico(float precioBase, float peso, string color, string consumoEnergia)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            if (ComprobarConsumoEnergetico(consumoEnergia))
            {
                this.consumoEnergia = consumoEnergia;
            }

            if (ComprobarColor(color))
            {
                this.color = color;
            }
        }

        public float PrecioBase
        {
            get => precioBase;
        }
        
        public float Peso
        {
            get => peso;
        }
        
        public string Color
        {
            get => color;
        }
        
        public string ConsumoEnergia
        {
            get => consumoEnergia;
        }

        private bool ComprobarConsumoEnergetico(string letra)
        {
            string[] misLetras = {"A", "B", "C", "D", "E", "F"};

            foreach (string element in misLetras)
            {
                if (element == letra)
                {
                    return true;
                }
            }

            return false;
        }

        private bool ComprobarColor(string color)
        {
            string aux = color.ToUpper();
            string[] colores = {"BLANCO", "NEGRO", "ROJO", "AZUL", "GRIS"};

            foreach (string miColor in colores)
            {
                if (aux == miColor)
                {
                    return true;
                }
            }

            return false;


        }

        public float PrecioFinal()
        {
            Hashtable consumoE = new Hashtable();
            Hashtable tamanio = new Hashtable();
        
            float result = PrecioBase;
            
            consumoE.Add("A", 100);
            consumoE.Add("B", 80);
            consumoE.Add("C", 60);
            consumoE.Add("D", 50);
            consumoE.Add("E", 30);
            consumoE.Add("F", 10);
            
            tamanio.Add("019", 10);
            tamanio.Add("2049", 50);
            tamanio.Add("5079", 80);
            tamanio.Add("80", 100);
            
            switch (ConsumoEnergia)
            {
                case "A" :
                    result = result + Convert.ToSingle(consumoE["A"]);
                    break;
                case "B" :
                    result = result + Convert.ToSingle(consumoE["B"]);
                    break;
                case "C" :
                    result = result + Convert.ToSingle(consumoE["C"]);
                    break;
                case "D" :
                    result = result + Convert.ToSingle(consumoE["D"]);
                    break;
                case "E" :
                    result = result + Convert.ToSingle(consumoE["E"]);
                    break;
                case "F" :
                    result = result + Convert.ToSingle(consumoE["F"]);
                    break;
            }
            
            if (Peso is >= 0 and <= 19)
            {
                result = result + Convert.ToSingle(tamanio["019"]);
                
            }if (Peso is >= 20 and <= 59)
            {
                result = result + Convert.ToSingle(tamanio["2049"]);
                
            } 
            if (Peso is >= 50 and <= 79)
            {
                result = result + Convert.ToSingle(tamanio["5079"]);
                
            } 
            if (Peso >= 80)
            {
                result = result + Convert.ToSingle(tamanio["80"]);
                
            }

            return result;
            

        }
        
        
        
    }
}