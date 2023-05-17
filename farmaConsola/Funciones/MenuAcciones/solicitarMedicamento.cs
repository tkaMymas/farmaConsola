using System;

namespace farmaConsola.Funciones.MenuAcciones
{
    internal class SolicitarMedicamento
    {
        private static int accion_menu_solicitar = 0;

        public static int cantidadParacetamol = 0;
        public static int cantidadAspirina = 0;
        public static int cantidadSalbutamol = 0;

        public static void SoMedicamentos()
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine("  SOLICITAR MEDICAMENTOS");
            Console.WriteLine("==========================\n");
            Console.WriteLine("Lista de medicamentos:\n(1) Paracetamol\n(2) Aspirina\n(3) Salbutamol\n");
            Console.WriteLine("(4) Salir al Menú\n");
            Console.Write("Ingreso: ");

            try
            {
                accion_menu_solicitar = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nIngrese una acción válida.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nIngrese un dígito más bajo.");
            }

            switch (accion_menu_solicitar)
            {
                case 1:
                    SoParacetamol();
                    break;
                case 2:
                    SoAspirina();
                    break;
                case 3:
                    SoSalbutamol();
                    break;
                case 4:
                    SistemaMenu.Menu();
                    break;
                default:
                    SoMedicamentos();
                    break;
            }
        }

        public static void SoParacetamol()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Paracetamol.");
            Console.Write("Unidades Disponibles: ");
            Console.WriteLine(ConsultarMedicamentos.uniParacetamol + " Uds.");
            Console.WriteLine("Precio Unidad: 1$.");

            Console.Write("\nIngreso: ");
            cantidadParacetamol = int.Parse(Console.ReadLine());
            CalcularFactura();
        }

        public static void SoAspirina()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Aspirina.");
            Console.Write("Unidades Disponibles: ");
            Console.WriteLine(ConsultarMedicamentos.uniAspirina + " Uds.");
            Console.WriteLine("Precio Unidad: 1.45$.");

            Console.Write("\nIngreso: ");
            cantidadAspirina = int.Parse(Console.ReadLine());
            CalcularFactura();
        }

        public static void SoSalbutamol()
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("Nombre: Salbutamol.");
            Console.Write("Unidades Disponibles: ");
            Console.WriteLine(ConsultarMedicamentos.uniSalbutamol + " Uds.");
            Console.WriteLine("Precio Unidad: 1.95$.");

            Console.Write("\nIngreso: ");
            cantidadSalbutamol = int.Parse(Console.ReadLine());
            CalcularFactura();
        }

        public static void CalcularFactura()
        {
            double precioPagar = 0;

            if (cantidadParacetamol != 0 && cantidadParacetamol <= ConsultarMedicamentos.uniParacetamol)
            {
                ConsultarMedicamentos.uniParacetamol = ConsultarMedicamentos.uniParacetamol - cantidadParacetamol;
                precioPagar = cantidadParacetamol * 1;

                Console.WriteLine("\n===========");
                Console.WriteLine("  FACTURA");
                Console.WriteLine("===========");

                Console.WriteLine("\n==============================");
                Console.WriteLine("Medicamento: Paracetamol.");
                Console.Write("Unidades a Comprar: ");
                Console.WriteLine(cantidadParacetamol + " Uds.");
                Console.WriteLine($"Precio a Pagar: {precioPagar}$");
                Console.WriteLine("==============================\n");

                SistemaMenu.TeclaRegresar();
                SoMedicamentos();
            }
            else if (cantidadAspirina != 0 && cantidadAspirina <= ConsultarMedicamentos.uniAspirina)
            {
                ConsultarMedicamentos.uniAspirina = ConsultarMedicamentos.uniAspirina - cantidadAspirina;
                precioPagar = cantidadAspirina * 1.45;

                Console.WriteLine("\n===========");
                Console.WriteLine("  FACTURA");
                Console.WriteLine("===========");

                Console.WriteLine("\n==============================");
                Console.WriteLine("Medicamento: Aspirina.");
                Console.Write("Unidades a Comprar: ");
                Console.WriteLine(cantidadAspirina + " Uds.");
                Console.WriteLine($"Precio a Pagar: {precioPagar}$");
                Console.WriteLine("==============================\n");

                SistemaMenu.TeclaRegresar();
                SoMedicamentos();
            }
            else if (cantidadSalbutamol != 0 && cantidadSalbutamol <= ConsultarMedicamentos.uniSalbutamol)
            {
                ConsultarMedicamentos.uniSalbutamol = ConsultarMedicamentos.uniSalbutamol - cantidadSalbutamol;
                precioPagar = cantidadSalbutamol * 1.95;

                Console.WriteLine("\n===========");
                Console.WriteLine("  FACTURA");
                Console.WriteLine("===========");

                Console.WriteLine("\n==============================");
                Console.WriteLine("Medicamento: Salbutamol.");
                Console.Write("Unidades a Comprar: ");
                Console.WriteLine(cantidadSalbutamol + " Uds.");
                Console.WriteLine($"Precio a Pagar: {precioPagar}$");
                Console.WriteLine("==============================\n");

                SistemaMenu.TeclaRegresar();
                SoMedicamentos();
            }
            else
            {
                Console.WriteLine("\nAcción Inválida.");
                SoMedicamentos();
            }
        }
    }
}
