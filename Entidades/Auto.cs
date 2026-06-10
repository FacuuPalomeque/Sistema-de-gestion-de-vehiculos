using System;



    public class Auto : Vehiculo
    {
        public Auto(string marca, string modelo)
            : base(marca, modelo)
        {
        }

        public override void Acelerar()
        {
            Velocidad += 20;
        }

        public override void Frenar()
        {
            Velocidad -= 10;

            if (Velocidad < 0)
            {
                Velocidad = 0;
            }
        }
    }
