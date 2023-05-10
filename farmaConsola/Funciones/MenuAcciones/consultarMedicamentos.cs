using System;
using farmaConsola;

namespace farmaConsola.Funciones.MenuAcciones
{
    internal class ConsultarMedicamentos
    {
        public static int uniParacetamol = 25;
        public static int uniAspirina = 20;
        public static int uniSalbutamol = 20;

        private static int accion_menu_medicamentos = 0;

        public static void CoMedicamentos()
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine("  CONSULTAR MEDICAMENTOS");
            Console.WriteLine("==========================\n");
            Console.WriteLine("(1) Paracetamol\n(2) Aspirina\n(3) Salbutamol\n");
            Console.WriteLine("(4) Salir al Menú\n");
            Console.Write("Ingreso: ");

            try
            {
                accion_menu_medicamentos = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nIngrese una acción válida.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nIngrese un dígito más bajo.");
            }

            switch (accion_menu_medicamentos)
            {
                case 1:
                    Paracetamol();
                    break;
                case 2:
                    Aspirina();
                    break;
                case 3:
                    Salbutamol();
                    break;
                case 4:
                    SistemaMenu.Menu();
                    break;
                default:
                    CoMedicamentos();
                    break;
            }
        }

        public static void Paracetamol()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Paracetamol.");
            Console.Write("\nUnidades: ");
            Console.WriteLine(uniParacetamol + " Uds.");

            Console.WriteLine("\nDescripción: Reduce la fiebre, se usa para tratar diversas dolencias como fiebres, " +
                "\ndolor de cabeza, dolores musculares, artritis, dolor de espalda o resfriados.");

            SistemaMenu.TeclaRegresar();
            CoMedicamentos();
        }

        public static void Aspirina()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Aspirina.");
            Console.Write("\nUnidades: ");
            Console.WriteLine(uniAspirina + " Uds.");

            Console.WriteLine("\nDescripción: Reduce las sustancias en el cuerpo que producen " +
                "dolor, fiebre e inflamación.");

            SistemaMenu.TeclaRegresar();
            CoMedicamentos();
        }

        public static void Salbutamol()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Salbutamol.");
            Console.Write("\nUnidades: ");
            Console.WriteLine(uniSalbutamol + " Uds.");

            Console.WriteLine("\nDescripción: Se usa como prevención de broncoespasmos en pacientes " +
                "\ncon asma, bronquitis, enfisema y otras enfermedades del pulmón.");

            SistemaMenu.TeclaRegresar();
            CoMedicamentos();
        }
    }
}
