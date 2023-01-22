using System;
namespace Dependency_Injection
{
    public class MiServicioJugador : Interface2
    {
        string nombre;
        bool saque;
        int puntos;
        public MiServicioJugador()
        {
            puntos = 0;
            saque = false;
        }

        public void addPuntos()
        {
            puntos++;
        }

        public string getDatos()
        {
            return nombre + "|" + puntos;
        }

        public void setName(string _nombre)
        {
            nombre = _nombre;
        }

        public string showState()
        {
            throw new NotImplementedException();
        }


    }
}

