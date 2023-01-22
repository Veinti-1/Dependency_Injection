using System;
namespace Dependency_Injection
{
    public class MiClase 
    {
        private readonly Interface1 _myService1;
        private readonly Interface2 _myService2;
        private readonly Interface3 _myService3;

       
        public MiClase(Interface1 myService) 
        {
            _myService1 = myService;
        }
        public MiClase(Interface2 myService)
        {
            _myService2 = myService;
        }
        public MiClase(Interface3 myService)
        {
            _myService3 = myService;
        }


    }
}

