using System;

namespace Panaderia{
    public class MostrarClientes{
        public static void Ejecutar()
        {
            foreach (var item in ClienteRepositorio.ListaClientes())
            {
                item.Imprimir();
            }
        }
    }
}