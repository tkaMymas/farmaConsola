using System;
using farmaConsola;

namespace farmaConsola.Funciones.MenuAcciones
{
    internal class ConsultarMedicamentos
    {
        public static int unidades = 0;

        private static int accionMenu = 0;

        public static void coMedicamentos()
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine("  CONSULTAR MEDICAMENTOS");
            Console.WriteLine("==========================\n");
            Console.WriteLine("(1) Paracetamol\n(2) Aspirina\n(3) Salbutamol\n");
            Console.WriteLine("(4) Salir al Menú\n");
            Console.Write("Ingreso: ");
            accionMenu = int.Parse(Console.ReadLine());

            switch (accionMenu)
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
                    Console.WriteLine("\nIngrese una acción válida.");
                    coMedicamentos();
                    break;
            }
        }

        public static void Paracetamol()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Paracetamol.");
            Console.Write("\nUnidades:\n");

            Console.WriteLine("\nDescripción: Reduce la fiebre, se usa para tratar diversas dolencias como fiebres, " +
                "\ndolor de cabeza, dolores musculares, artritis, dolor de espalda o resfriados.");

            SistemaMenu.TeclaRegresar();
            coMedicamentos();
        }

        public static void Aspirina()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Aspirina.");
            Console.Write("\nUnidades:\n");

            Console.WriteLine("\nDescripción: Reduce las sustancias en el cuerpo que producen " +
                "dolor, fiebre e inflamación.");

            SistemaMenu.TeclaRegresar();
            coMedicamentos();
        }

        public static void Salbutamol()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Salbutamol.");
            Console.Write("\nUnidades:\n");

            Console.WriteLine("\nDescripción: Se usa como prevención de broncoespasmos en pacientes " +
                "\ncon asma, bronquitis, enfisema y otras enfermedades del pulmón.");

            SistemaMenu.TeclaRegresar();
            coMedicamentos();
        }
    }
}
