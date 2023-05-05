using System;

namespace farmaConsola.Funciones.MenuAcciones
{
    internal class InformacionPersonal
    {
        public static void infoPersonal()
        {
            Console.WriteLine("\n======================");
            Console.WriteLine(" Información Personal");
            Console.WriteLine("======================\n");
            Console.Write("Nombre: ");
            Console.WriteLine(farmaConsola.SistemaFarmacia.nombre);
            Console.Write("Documento: ");
            Console.WriteLine(farmaConsola.SistemaFarmacia.documento);

            SistemaMenu.Menu();
        }
    }
}
