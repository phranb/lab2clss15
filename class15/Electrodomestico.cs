namespace class15
{
    public class Electrodomestico
    {
        protected float precioBase = 100;
        protected float peso = 5;
        protected string color = "blanco";
        protected char consumoEnergia = 'F';

        public Electrodomestico()
        {
            
        }

        public Electrodomestico(float precioBase, float peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }

        public Electrodomestico(float precioBase, float peso, string color, char consumoEnergia)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.color = color;
            this.consumoEnergia = consumoEnergia;
        }
        
        
    }
}