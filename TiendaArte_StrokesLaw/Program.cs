using System;
using System.Collections.Generic;

namespace TiendaArte_StrokesLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro user1 = new Registro();
            Login login1 = new Login();
            Articulo articulo1 = new Articulo();
            Articulo articulo2 = new Articulo();
            TarjetaCredito tarj1 = new TarjetaCredito();
            Carrito carrito = new Carrito();
            Pedidos pedido = new Pedidos();           
            
            //Declaración de variables por utilizar.
            double neg1;
            int opcion, opcion1, opcion2, opcion3;
            opcion = 0;
            neg1=0;
            //Mediante un do while procesamos el ingreso a la aplicación.
            do
            {
                //Pequeño menú inicial donde elegir registrarse si el usuario es nuevo o iniciar sesion si ya tiene cuenta.
                Console.WriteLine("\nBIENVENIDO A Law Art Shop :");
                Console.WriteLine("\n****************************");
                Console.WriteLine(" 1. Registrarse");
                Console.WriteLine(" 2. Iniciar Sesión");
                Console.WriteLine("****************************");
                Console.WriteLine("\nIngresa 1 para registrarte.");
                Console.WriteLine("Ingresa 2 para iniciar sesión.");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                //Con un switch y los casos realizamos el registro o el login.
                switch (opcion)
                {
                    //En el primer caso al ingresar el 1 se procede a crear la cuenta.
                    case 1:
                        Console.WriteLine("\n**** Creación de una nueva Cuenta ****");
                        Console.WriteLine("\nIngresa tu Nombre y apellido:");
                        user1.nombre = Console.ReadLine();
                        Console.WriteLine("\nIngresa tu edad:");
                        user1.edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nIngresa tu username:");
                        user1.username = Console.ReadLine();
                        Console.WriteLine("\nIngresa tu correo electronico:");
                        user1.email = Console.ReadLine();
                        Console.WriteLine("\nIngresa tu contraseña:");
                        user1.contraseña = Console.ReadLine();
                        if (user1.edad >= 16)
                        {
                            Console.Clear();
                            Console.WriteLine("**** LISTO! ****");
                            Console.WriteLine("Te has registrado correctamente!");
                            Console.WriteLine("Ahora debes Iniciar Sesión");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Tienes que ser mayor de 15 años para crear una cuenta.");
                            Console.WriteLine("Presiona 1 para salir");
                            neg1 = int.Parse(Console.ReadLine());
                        }                                             
                        break;
                    //En el segundo caso al ingresar el 2 se procede al login de la cuenta.
                    case 2:
                        Console.WriteLine("Procede a Iniciar sesión");
                        Console.WriteLine("Presiona una Tecla para continuar");
                        break;
                    //Declaramos un mensaje de error al utilizar mal el menú inicial, mediante el default del switch.
                    default:
                        Console.WriteLine("¡ERROR! \n¡Ingrese una opción correcta! .. presiona una tecla para continuar");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (!((opcion == 1) || (opcion == 2)));     
            if (neg1 == 1)
            {               
                Console.WriteLine("Hasta luego, necesitas ser mayor de 15 años.");
            }
            else
            {
                //Apartado de inicio de sesión, con username y contraseña.
                Console.WriteLine("\n**** INICIAR SESIÓN ****");
                Console.WriteLine("\n--> Usuario");
                login1.username = Console.ReadLine();
                Console.WriteLine("\n--> Contraseña");
                login1.contraseña = Console.ReadLine();
                do
                {
                    //Menú principal de la aplicación, con diferentes opciones y funciones.
                    Console.Clear();
                    Console.WriteLine("\nBienvenid@ " + login1.username+ ". Tenemos todas las piezas de arte que deseas y seueñas.");
                    Console.WriteLine(" 1. Catálogo de artículos");
                    Console.WriteLine(" 2. Perfil");
                    Console.WriteLine(" 3. Opciones de gestión");
                    Console.WriteLine(" 4. Salir");                    
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        //Opción 1 Catálogo de artículos con productos disponibles.
                        case 1:
                          
                            do
                            {
                                Console.WriteLine("\n**** CATÁLOGO DE ARTICULOS ****");
                                Console.WriteLine("\n**** Prodcuto 1 ****");
                                articulo1.nombre = "Poster de The Batman 2022";
                                articulo1.id = "P224";
                                articulo1.categoria = "Poster";
                                articulo1.descripcion = "Poster de la pelicula The Batman de 2022, pintado a mano en oleo.";
                                articulo1.precio = 24.99;
                                articulo1.stock = 34;
                                articulo1.Mostrar();
                                Console.WriteLine("\n**** Prodcuto 2 ****");
                                articulo2.nombre = "Cuadro paisaje urbano de Barcelona por la noche.";
                                articulo2.id = "Q312";
                                articulo2.categoria = "Cuadro";
                                articulo2.descripcion = "Cuadro en lienzo que refleja la magnficiencia de la ciudad de Barcelona en el anochecer";
                                articulo2.precio = 49.99;
                                articulo2.stock = 10;
                                articulo2.Mostrar();
                      //Pequeño menú de compra de productos.
                                Console.WriteLine("\n**** COMPRAR ****");
                                Console.WriteLine("\nPara comprar el artículo");
                                Console.WriteLine("Presiona 1 para el primer producto");
                                Console.WriteLine("Presiona 2 para el segundo producto.");
                                Console.WriteLine("\n****Presiona 3 para regresar****");
                                opcion1 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                switch (opcion1)
                                {
                     ////Carrito de compras con detalles del producto 1.              
                                    case 1:
                                        Console.WriteLine("\n**** CARRITO ****");
                                        Console.WriteLine("\nProducto 1 ha sido añadido al carrito");
                                        carrito.nombre = articulo1.nombre;
                                        carrito.descripcion = articulo1.descripcion;
                                        carrito.precio = articulo1.precio;                                        
                                        carrito.Mostrar();
                    //Apartado de pedidos, detalle de pedido y confirmación de pedido.
                                        Console.WriteLine("\n**** PEDIDO ****");
                                        Console.WriteLine("\nSu pedido ha sido realizado");
                                        pedido.numeropedido = "5584";
                                        pedido.descripcionpedido = "1 " +articulo1.nombre;
                                        pedido.confirmacion = "EL PAGO HA SIDO CONFIRMADO, SU PEDIDO SE HA ENVIADO";
                                        pedido.Mostrar();
                                        Console.ReadKey();
                                        break;
                                    case 2:
                    //Carrito de compras con detalles del producto 2
                                        Console.WriteLine("\n**** CARRITO ****");
                                        Console.WriteLine("\nProducto 2 ha sido añadido al carrito");
                                        carrito.nombre = articulo2.nombre;
                                        carrito.descripcion = articulo2.descripcion;
                                        carrito.precio = articulo2.precio;
                                        carrito.Mostrar();
                    //Apartado de pedidos, detalle de pedido y confirmación de pedido.             
                                        Console.WriteLine("\n**** PEDIDO ****");
                                        Console.WriteLine("\nSu pedido ha sido realizado");
                                        pedido.numeropedido = "5584";
                                        pedido.descripcionpedido = "1 " + articulo2.nombre;
                                        pedido.confirmacion = "EL PAGO HA SIDO CONFIRMADO, SU PEDIDO SE HA ENVIADO";
                                        pedido.Mostrar();
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        break;
                                }
                                Console.ReadKey();
                            } while (opcion1 != 3);
                            break;
                        case 2:

                            Console.WriteLine("\n**** PERFIL ****");
                            login1.nombre = user1.nombre;
                            login1.edad = user1.edad;
                            login1.username = user1.username;
                            login1.email = user1.email;
                            login1.Mostrar();
                            Console.WriteLine("\n****Presiona una tecla para regresar****");
                            break;                        
                        case 3:

                            do
                            {                                
                                Console.WriteLine("\n**** OPCIONES DE GESTIÓN ****");
                                Console.WriteLine("  1. Metodos de pago");
                                Console.WriteLine("  2. Notificaciones");                                
                                Console.WriteLine("  3. Regresar");
                                opcion2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                switch (opcion2)
                                {
                                    case 1:      
                                        
                                        do
                                        {                                           
                                            Console.WriteLine("\n**** GESTIONAR METODOS DE PAGO ****");
                                            Console.WriteLine("\n  1. Añadir Tarjeta de credito");
                                            Console.WriteLine("  2. Ver mis tarjetas");                                            
                                            Console.WriteLine("  3. Regresar");
                                            opcion3 = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            switch (opcion3)
                                            {
                                                case 1:                                                   
                                                    tarj1.agregartarjeta();                                                    
                                                    break;

                                                case 2:                                                                                                        
                                                    tarj1.Mostrar();                                                    
                                                    
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    break;
                                            }

                                        } while (opcion3 != 3);

                                        break;
                                    case 2:

                                        Console.Clear();
                                        Console.WriteLine("\n Aquí encontraras tus notifaciones ");
                                        Console.WriteLine("  Estas son tus notificaciones: ");
                                        Console.WriteLine("    **TU PEDIDO HA SIDO ENVIADO **");
                                        break;
                                    case 3:
                                        Console.Clear();
                                        break;
                                }
                            } while (opcion2 != 3);                                                     
                            break;
                        case 4:
                            Console.Clear();
                            break;
                    }
                    Console.ReadKey();
                } while (opcion != 4);
            }      
        }
    }
}
