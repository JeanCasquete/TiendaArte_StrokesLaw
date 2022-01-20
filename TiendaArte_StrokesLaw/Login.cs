using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArte_StrokesLaw
{
    //Clase login de usuario, hereda de Usuario.
    class Login : Usuario, IMetodos
    {
        //Metodo polimorfico mostrar datos 
        public override void Mostrar()
        {
            Console.WriteLine("---Tu información---");
            base.Mostrar();
        }
    }
}
