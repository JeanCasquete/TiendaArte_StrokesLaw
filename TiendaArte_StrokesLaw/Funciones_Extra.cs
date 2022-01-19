using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaArte_StrokesLaw
{
    class Funciones_Extra
    {
        public int masopciones;
        public string direcci { get; set; }
        public void notificaciones()
        {
            //Console.Clear();
            Console.WriteLine(" Aquí encontraras tus notifaciones ");
            Console.WriteLine("  Estas son tus notificaciones: ");
            Console.WriteLine("    **TU PEDIDO HA SIDO ENVIADO");
        }
        public virtual void direcciones()
        {
                Console.Clear();
                Console.WriteLine("DIRECCIONES");
                Console.WriteLine(" Agrega tu direccion");           
                direcci= Console.ReadLine();
                Console.WriteLine(" La direccion " +direcci +"fue agregada correctamente");                  
        }
           
         
    }
}
