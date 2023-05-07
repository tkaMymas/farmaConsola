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
                              "\n(3) Información Personal\n(4) Nuevo Usuario\n(5) Salir\n");
            Console.Write("Ingreso: ");
            accionMenu = int.Parse(Console.ReadLine());

            switch (accionMenu)
            {
                case 1:
                    MenuAcciones.SolicitarMedicamento.soMedicamentos();
                    break;
                case 2:
                    MenuAcciones.ConsultarMedicamentos.coMedicamentos();
                    break;
                case 3:
                    MenuAcciones.InformacionPersonal.infoPersonal();
                    break;
                case 4:
                    SistemaIngreso.Ingreso();
                    break;
                case 5:
                    Console.WriteLine("\nCerrando Programa...");
                    break;
                default:
                    Console.WriteLine("\nIngrese una acción válida.");
                    Menu();
                    break;
            }
        }
    }
}
