using System;


    public class Moto : Vehiculo
    {
        public Moto(string marca, string modelo)
            : base(marca, modelo)
        {
        }

        public override void Acelerar()
        {
            Velocidad += 35;
        }

        public override void Frenar()
        {
            Velocidad -= 15;

            if (Velocidad < 0)
            {
                Velocidad = 0;
            }
        }
    }
