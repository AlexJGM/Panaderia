using System;

namespace Panaderia{

    public class NuevoCliente{

    public static void Ejecutar()
        {
            string dni;
            string nombre;
            string apellidos;
            int telefono;
            string localidad;

            Console.WriteLine("Introduce su DNI:");
            dni = Console.ReadLine();

            Console.WriteLine("Introduce su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Introduce sus apellidos:");
            apellidos = Console.ReadLine();

            Console.WriteLine("Introduce su telefono:");
            telefono = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce su localidad:");
            localidad = Console.ReadLine();

            ClienteRepositorio.Guardar(new Cliente(dni, nombre, apellidos, telefono, localidad));
            Console.WriteLine("El cliente se ha dado de alta");
        }
    }
}