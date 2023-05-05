using System;
using farmaConsola.Funciones;

namespace farmaConsola.Funciones
{
    public class SistemaIngreso
    {
        public static void Ingreso()
        {
            Console.WriteLine("Ingrese sus datos antes de continuar\n");
            Console.WriteLine("Ingrese su Nombre");
            Console.Write("Ingreso: ");
            farmaConsola.SistemaFarmacia.nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese su Documento");
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
