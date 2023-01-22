using System;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{
	public class Partido
	{
        private readonly Interface1 _myService;

        public Partido(Interface1 myService)
        {
            _myService = myService;
        }


        public string ServiceIniciar(ServiceProvider serviceProvider, string nom1, string nom2)
        {
            return _myService.IniciarPartido(serviceProvider, nom1, nom2);
        }

        public string ServiceTurno()
        {
            return _myService.Turno();
        }

        public string ServiceTerminar()
        {
            return _myService.TerminarPartido();
        }

    }
}

