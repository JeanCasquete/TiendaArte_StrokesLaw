using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArte_StrokesLaw
{
    class Carrito : Articulo, IMetodos
    {
        //public string nombre { get; set; }
        //public string id { get; set; }
            
        public override void Mostrar()
        {
            Console.WriteLine("\nArtículo: " + nombre + "\nDescripción: " +descripcion+ "\nPrecio Final: $" + precio);
            
        }

       
    }
}
