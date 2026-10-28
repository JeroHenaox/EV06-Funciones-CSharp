ShowMainMenu();

static void ShowMainMenu()
{
    int opcion = 0;

    while (opcion != 6)
    {
        Console.WriteLine();
        Console.WriteLine("========== BIBLIOTECA ADSO ==========");
        Console.WriteLine("1. Libros");
        Console.WriteLine("2. Usuarios");
        Console.WriteLine("3. Préstamos");
        Console.WriteLine("4. Búsquedas y reportes");
        Console.WriteLine("5. Guardar / Cargar datos");
        Console.WriteLine("6. Salir");
        Console.WriteLine("=====================================");
        Console.Write("Seleccione una opción: ");

        string entrada = Console.ReadLine() ?? "";

        if (int.TryParse(entrada, out opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Módulo de libros seleccionado.");
                    break;

                case 2:
                    Console.WriteLine("Módulo de usuarios seleccionado.");
                    break;

                case 3:
                    Console.WriteLine("Módulo de préstamos seleccionado.");
                    break;

                case 4:
                    Console.WriteLine("Módulo de búsquedas y reportes seleccionado.");
                    break;

                case 5:
                    Console.WriteLine("Módulo de guardar y cargar datos seleccionado.");
                    break;

                case 6:
                    Console.WriteLine("Saliendo del menú principal.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Seleccione un número del 1 al 6.");
                    opcion = 0;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número.");
            opcion = 0;
        }
    }
}

