using System;
namespace Dependency_Injection
{
    public class Jugador
    {
        private readonly Interface2 _myService;
        public Jugador(Interface2 myService, string nombre)
        {
            _myService = myService;
            _myService.setName(nombre);
        }

        public string ServiceGetData()
        {
            return _myService.getDatos();
        }
        public void ServiceAddPuntos()
        {
            _myService.addPuntos();
        }

    }
}

