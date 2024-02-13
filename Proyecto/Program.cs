class Program
{
    static string[] estudiantes = new string[10];

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenú Principal:");
            Console.WriteLine("1. Inicializar Vectores");
            Console.WriteLine("2. Incluir Estudiantes");
            Console.WriteLine("3. Consultar Estudiantes");
            Console.WriteLine("4. Modificar Estudiantes");
            Console.WriteLine("5. Eliminar Estudiantes");
            Console.WriteLine("6. Submenú Reportes");
            Console.WriteLine("7. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    InicializarVectores();
                    break;
                case "2":
                    IncluirEstudiante();
                    break;
                case "3":
                    ConsultarEstudiantes();
                    break;
                case "4":
                    ModificarEstudiantes();
                    break;
                case "5":
                    EliminarEstudiantes();
                    break;
                case "6":
                    SubmenuReportes();
                    break;
                case "7":
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void InicializarVectores()
    {
        estudiantes = new string[10];
        Console.WriteLine("Vectores inicializados con éxito.");
    }

    static void SubmenuReportes()
    {
        while (true)
        {
            Console.WriteLine("\nSubmenú Reportes:");
            Console.WriteLine("1. Reporte Estudiantes por Condición");
            Console.WriteLine("2. Reporte Todos los datos");
            Console.WriteLine("3. Regresar al Menú Principal");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Generando reporte de estudiantes por condición...");
                    break;
                case "2":
                    Console.WriteLine("Generando reporte con todos los datos de los estudiantes...");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }
}
