using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArte_StrokesLaw
{
    //Clase carrito, hereda de Articulo.
    class Carrito : Articulo, IMetodos
    {
        //public string nombre { get; set; }
        //public string id { get; set; }

        //Metodo polimorfico mostrar datos 
        public override void Mostrar()
        {
            Console.WriteLine("\nArtículo: " + nombre + "\nDescripción: " +descripcion+ "\nPrecio Final: $" + precio);
            
        }

       
    }
}
