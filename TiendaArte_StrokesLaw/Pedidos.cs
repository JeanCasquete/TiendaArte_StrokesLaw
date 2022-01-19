using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArte_StrokesLaw
{
    class Pedidos : Articulo, IMetodos
    {
        public string numeropedido { get; set; }       
        public string descripcionpedido { get; set; }
        public string confirmacion { get; set; }
        public override void Mostrar()
        {
            Console.WriteLine("Número de pedido: " + numeropedido +"\nDescripción: " + descripcionpedido + "\nConfirmacion de pedido: " + confirmacion);
        }
    }
}
