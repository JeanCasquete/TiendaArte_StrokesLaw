using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArte_StrokesLaw
{
    //Clase padre Pago y caracteristicas.
    class Pago : IMetodos
    {
        public string id { get; set; }

        //Metodo polimorfico mostrar datos 
        public virtual void Mostrar()
        {

        }
    }
}
