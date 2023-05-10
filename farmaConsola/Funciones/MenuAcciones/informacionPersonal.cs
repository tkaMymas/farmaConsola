using System;

namespace farmaConsola.Funciones.MenuAcciones
{
    internal class InformacionPersonal
    {
        public static void InfoPersonal()
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("  INFORMACIÓN PERSONAL");
            Console.WriteLine("========================\n");

            Console.Write("Nombre: ");
            Console.WriteLine(farmaConsola.SistemaFarmacia.nombre);

            Console.Write("Documento: ");
            Console.WriteLine(farmaConsola.SistemaFarmacia.documento);

            SistemaMenu.TeclaRegresar();

            SistemaMenu.Menu();
        }
    }
}
