using System;
using System.Collections.Generic;

namespace Panaderia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String input;

            do
            {
                input = MostrarMenu();

                switch (input)
                {
                    case "1":
                        NuevoCliente.Ejecutar();
                    break;

                    case "2":
                        BajaCliente.Ejecutar();
                    break;

                    case "3":
                        MostrarClientes.Ejecutar();
                    break;

                    case "4":
                        NuevoPan.Ejecutar();
                    break;

                    case "5":
                        EliminarPan.Ejecutar();
                    break;

                    case "6":
                        MostrarPanes.Ejecutar();
                    break;

                    case "7":
                        NuevaFactura.Ejecutar();
                    break;

                    case "8":
                        MostrarFacturas.Ejecutar();
                    break;

                    case "9":
                        Console.WriteLine("Has salido del programa");
                    break;
                }
            } while (input != "9");
        }

        public static String MostrarMenu()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("               MENU                ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1.- Dar alta cliente");
            Console.WriteLine("2.- Dar baja cliente");
            Console.WriteLine("3.- Mostrar lista clientes");
            Console.WriteLine("4.- Añadir stock panes");
            Console.WriteLine("5.- Eliminar stock panes");
            Console.WriteLine("6.- Mostrar stock panes");
            Console.WriteLine("7.- Nueva factura");
            Console.WriteLine("8.- Mostrar facturas");
            Console.WriteLine("9.- Salir");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Introduce la opcion a realizar");
            return Console.ReadLine();
        }
    }
}