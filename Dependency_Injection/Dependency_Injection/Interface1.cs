using System;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{
    public interface Interface1
    {
        string showState();
        string IniciarPartido(ServiceProvider serviceProvider, string nom1, string nom2);
        string TerminarPartido();
        string Turno();
    }
}

