using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArte_StrokesLaw
{
    class Usuario : IMetodos
    {
        public string nombre { get; set; }
        public string username { get; set; }
        public string contraseña { get; set; }
        public string email { get; set; }
        public int edad { get; set; }

        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre completo: "+nombre+"\nUsername: "+username+"\nCorreo Electrónico: "+email+"\nContraseña: **********" +"\nEdad: "+edad);
        }
    }
}
