using System;

namespace farmaConsola.Funciones.MenuAcciones
{
    internal class InformacionPersonal
    {
        public static void infoPersonal()
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("  INFORMACIÓN PERSONAL");
            Console.WriteLine("========================\n");

            Console.Write("Nombre: ");
            Console.WriteLine(farmaConsola.SistemaFarmacia.nombre);

            Console.Write("Documento: ");
            Console.WriteLine(farmaConsola.SistemaFarmacia.documento);

            Console.Write("\nPresione la tecla ENTER para volver al Menú...");
            Console.ReadKey();
            Console.WriteLine();

            SistemaMenu.Menu();
        }
    }
}
