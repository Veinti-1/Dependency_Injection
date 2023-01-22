using System;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
     

            var serviceColection = new ServiceCollection();
            serviceColection.AddScoped<Interface1, MiServicio>();
            serviceColection.AddTransient<Interface2, MiServicioJugador>();
            //serviceColection.AddTransient<Interface3, MiServicio>();

            var serviceProvider = serviceColection.BuildServiceProvider();

            while (true)
            {
                Console.WriteLine("Ingrese nombre jugador 1:");
                string nom1 = Console.ReadLine();
                Console.WriteLine("Ingrese nombre jugador 2:");
                string nom2 = Console.ReadLine();
                Console.WriteLine("Iniciar partido");
                Console.ReadKey();
                Console.Clear();

                Partido miPartido = new Partido(serviceProvider.GetService<Interface1>());
                Console.WriteLine(miPartido.ServiceIniciar(serviceProvider, nom1, nom2));
                Console.WriteLine("Turno:  |   Jugador 1   |   Puntaje J1   |   Jugador 2    |   Puntaje J2");
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("   " + Convert.ToString(i).PadRight(5) + "|" + miPartido.ServiceTurno());
                }
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(miPartido.ServiceTerminar());

                Console.WriteLine("Nuevo partido? (S/N)");
                string nuevo = Console.ReadLine().ToLower();
                if (nuevo != "s")
                {
                    break;
                }
                Console.Clear();
            }
            

            Console.ReadKey();
        }
    }
}

