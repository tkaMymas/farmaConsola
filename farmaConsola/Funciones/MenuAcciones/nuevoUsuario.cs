using System;

namespace farmaConsola.Funciones.MenuAcciones
{
    internal class NuevoUsuario
    {
        public static void nuUsuario()
        {
            Console.WriteLine("\n===============================");
            Console.WriteLine(" Ingrese su nueva acreditación");
            Console.WriteLine("===============================\n");

            SistemaIngreso.Ingreso();
        }
    }
}
