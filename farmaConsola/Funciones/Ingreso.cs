using System;
using farmaConsola.Funciones;

namespace farmaConsola.Funciones
{
    public class SistemaIngreso
    {
        public static void Ingreso()
        {
            Console.WriteLine("\n=====================");
            Console.WriteLine("  INGRESE SUS DATOS");
            Console.WriteLine("=====================\n");
            Console.WriteLine("Ingrese su nombre");
            Console.Write("Ingreso: ");
            farmaConsola.SistemaFarmacia.nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese su documento");
            Console.Write("Ingreso: ");
            try
            {
                farmaConsola.SistemaFarmacia.documento = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nIngrese un valor numérico válido.\n");
                Ingreso();
            }
            SistemaMenu.Menu();
        }
    }
}
