namespace class15
{
    public class Lavadora : Electrodomestico
    {
        private float carga = 5;

        public Lavadora() : base()
        {
            
        }
        public Lavadora(float precioBase, float peso, string color, string consumoEnergia) : base( precioBase, peso, color, consumoEnergia)
        {
            
        }
        public Lavadora(float precioBase, float peso) : base(precioBase, peso){}
        
        public Lavadora(float carga)
        {
            this.carga = carga;
            if (carga > 30)
            {
                precioBase = precioBase + 50;
            }
        }

        public float Carga
        {
            get => carga;
        }
        

    }
}