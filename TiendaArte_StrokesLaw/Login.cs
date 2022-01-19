using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArte_StrokesLaw
{
    class Login : Usuario, IMetodos
    {      
        public override void Mostrar()
        {
            Console.WriteLine("---Tu información---");
            base.Mostrar();
        }
    }
}
