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
            if (letra is "F" or "A")
            {
                return true;
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

        private void PrecioFinal()
        {
            
        }
        
        
        
    }
}