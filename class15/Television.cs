namespace class15
{
    public class Television : Electrodomestico
    {
        private float resolucion = 20;
        private bool tdt = false;

        public Television() : base()
        {
            
        }

        public Television(float precioBase, float peso, string color, string consumoEnergia) : base(precioBase, peso, color, consumoEnergia)
        {
            
        }

        public Television(float resolucion, bool tdt) : base()
        {
            this.resolucion = resolucion;
            this.tdt = tdt;
            if (resolucion > 40)
            {
                precioBase = precioBase * 1.30F;
            }

            if (tdt)
            {
                precioBase = precioBase * 1.50F;
            }
        }

        public float Resolucion
        {
            get => resolucion;
        }

        public bool Tdt
        {
            get => tdt;
        }
        
    }
}