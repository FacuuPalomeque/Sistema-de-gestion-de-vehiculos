using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            int opcion;

            do
            {
                Console.WriteLine(" SISTEMA DE VEHÍCULOS ");
                Console.WriteLine("1 - Registrar Auto");
                Console.WriteLine("2 - Registrar Moto");
                Console.WriteLine("3 - Mostrar Vehículos");
                Console.WriteLine("4 - Acelerar Vehículos");
                Console.WriteLine("5 - Frenar Vehículos");
                Console.WriteLine("6 - Salir");
                Console.Write("Opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("Marca: ");
                        string marcaAuto = Console.ReadLine();

                        Console.Write("Modelo: ");
                        string modeloAuto = Console.ReadLine();

                        vehiculos.Add(
                            new Auto(marcaAuto, modeloAuto));

                        Console.WriteLine("Auto registrado.");
                        break;

                    case 2:

                        Console.Write("Marca: ");
                        string marcaMoto = Console.ReadLine();

                        Console.Write("Modelo: ");
                        string modeloMoto = Console.ReadLine();

                        vehiculos.Add(
                            new Moto(marcaMoto, modeloMoto));

                        Console.WriteLine("Moto registrada.");
                        break;

                    case 3:

                        Console.WriteLine(" LISTADO DE VEHÍCULOS");

                        foreach (Vehiculo vehiculo in vehiculos)
                        {
                            vehiculo.MostrarInformacion();
                            Console.WriteLine("--------------------");
                        }

                        break;

                    case 4:

                        Console.WriteLine("Acelerando vehículos...");

                        foreach (Vehiculo vehiculo in vehiculos)
                        {
                            vehiculo.Acelerar();
                            vehiculo.MostrarInformacion();
                            Console.WriteLine("--------------------");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Frenando vehículos...");

                        foreach (Vehiculo vehiculo in vehiculos)
                        {
                            vehiculo.Frenar();
                            vehiculo.MostrarInformacion();
                            Console.WriteLine("--------------------");
                        }

                        break;

                    case 6:

                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:

                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 6);
        }
    }
