using System;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{
    public class MiServicio : Interface1
    {
        Jugador j1;
        Jugador j2;
        public MiServicio()
        {
           
        }

        public string IniciarPartido(ServiceProvider serviceProvider, string nom1, string nom2)
        {
            j1 = new Jugador(serviceProvider.GetService<Interface2>(), nom1);
            j2 = new Jugador(serviceProvider.GetService<Interface2>(), nom2);
            string dataJ1 = j1.ServiceGetData();
            string dataJ2 = j2.ServiceGetData();
            string[] datosJ1 = dataJ1.Split("|");
            string[] datosJ2 = dataJ2.Split("|");
            return datosJ1[0] + " VS " + datosJ2[0];
        }

        public string showState()
        {
            throw new NotImplementedException();
        }

        public string TerminarPartido()
        {
            string dataJ1 = j1.ServiceGetData();
            string dataJ2 = j2.ServiceGetData();
            string[] datosJ1 = dataJ1.Split("|");
            string[] datosJ2 = dataJ2.Split("|");
            string ganador;
            if (Convert.ToInt32(datosJ1[1]) > Convert.ToInt32(datosJ2[1]))
            {
                ganador = datosJ1[0];
            }
            else if (Convert.ToInt32(datosJ1[1]) < Convert.ToInt32(datosJ2[1]))
            {
                ganador = datosJ2[0];
            }
            else
            {
                ganador = datosJ1[0] +" y "+ datosJ2[0];
            }
            return datosJ1[0].PadRight(15) + "| " + datosJ1[1].PadRight(15) + "| " + datosJ2[0].PadRight(15) + "| " + datosJ2[1].PadRight(15) + "\nGanador: " + ganador;
        }

        public string Turno()
        {
            Random rnd = new Random();
            bool fiftyFifty = rnd.Next(0, 2) == 0;
            if (fiftyFifty)
            {
                j1.ServiceAddPuntos();
            }
            else
            {
                j2.ServiceAddPuntos();
            }
            string dataJ1 = j1.ServiceGetData();
            string dataJ2 = j2.ServiceGetData();
            string[] datosJ1 = dataJ1.Split("|");
            string[] datosJ2 = dataJ2.Split("|");

            return datosJ1[0].PadRight(15) + "| " + datosJ1[1].PadRight(15) + "| " + datosJ2[0].PadRight(15) +"| "+ datosJ2[1].PadRight(15);
        }
    }
}

