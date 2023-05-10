using System;
using farmaConsola.Funciones.MenuAcciones;

namespace farmaConsola.Funciones
{
    public class SistemaMenu
    {
        private static int accionMenu = 0;

        public static void Menu()
        {
            Console.WriteLine("\n====================");
            Console.WriteLine("  MENÚ DE ACCIONES");
            Console.WriteLine("====================\n");
            Console.WriteLine("(1) Solicitar Medicamento\n(2) Consultar Medicamentos" +
                              "\n(3) Información Personal\n(4) Nuevo Usuario\n");
            Console.WriteLine("(5) Salir del Programa\n");
            Console.Write("Ingreso: ");

            try
            {
                accionMenu = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nIngrese una acción válida.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nIngrese un dígito más bajo.");
            }

            switch (accionMenu)
            {
                case 1:
                    MenuAcciones.SolicitarMedicamento.SoMedicamentos();
                    break;
                case 2:
                    MenuAcciones.ConsultarMedicamentos.CoMedicamentos();
                    break;
                case 3:
                    MenuAcciones.InformacionPersonal.InfoPersonal();
                    break;
                case 4:
                    SistemaIngreso.Ingreso();
                    break;
                case 5:
                    Console.WriteLine("\nCerrando Programa...");
                    break;
                default:
                    Menu();
                    break;
            }
        }

        public static void TeclaRegresar()
        {
            Console.Write("\nPresione la tecla ENTER para volver al Menú...");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
