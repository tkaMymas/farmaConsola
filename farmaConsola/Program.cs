using System;
using farmaConsola.Funciones;
using farmaConsola.Funciones.MenuAcciones;

namespace farmaConsola
{
    public class SistemaFarmacia
    {
        public static string nombre = "";
        public static int documento = 0;

        static void Main()
        {
            Console.WriteLine("====================");
            Console.WriteLine("  COP FAARMACEUTIC");
            Console.WriteLine("====================\n");

            SistemaIngreso.Ingreso();
        }
    }
}