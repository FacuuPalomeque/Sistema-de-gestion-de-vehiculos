using System;

namespace SistemaVehiculos
{
    public abstract class Vehiculo
    {
        private string marca;
        private string modelo;
        private int velocidad;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidad = 0;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Vehículo: " + Marca + " " + Modelo);
            Console.WriteLine("Velocidad actual: " + Velocidad + " km/h");
        }

        public abstract void Acelerar();

        public abstract void Frenar();
    }
}