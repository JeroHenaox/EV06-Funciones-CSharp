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

        opcion = ReadOption(1, 6);

        switch (opcion)
        {
            case 1:
                ShowBooksMenu();
                break;
            case 2:
                Console.WriteLine("Módulo de usuarios pendiente de implementación.");
                break;
            case 3:
                Console.WriteLine("Módulo de préstamos pendiente de implementación.");
                break;
            case 4:
                Console.WriteLine("Módulo de búsquedas y reportes pendiente de implementación.");
                break;
            case 5:
                Console.WriteLine("Módulo de guardar y cargar datos pendiente de implementación.");
                break;
            case 6:
                Console.WriteLine("Saliendo del menú principal.");
                break;
        }
    }
}

static int ReadOption(int minimum, int maximum)
{
    int option = 0;
    bool valid = false;

    while (!valid)
    {
        Console.Write($"Seleccione una opción ({minimum}-{maximum}): ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out option))
        {
            if (option >= minimum && option <= maximum)
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("Opción fuera del rango permitido.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número.");
        }
    }

    return option;
}

static void ShowBooksMenu()
{
    int option = -1;

    while (option != 0)
    {
        Console.WriteLine();
        Console.WriteLine("========== MENÚ DE LIBROS ==========");
        Console.WriteLine("1. Registrar libro");
        Console.WriteLine("2. Listar libros");
        Console.WriteLine("3. Ver detalle de libro");
        Console.WriteLine("4. Actualizar libro");
        Console.WriteLine("5. Eliminar libro");
        Console.WriteLine("0. Volver al menú principal");
        Console.WriteLine("====================================");

        option = ReadOption(0, 5);

        switch (option)
        {
            case 1:
                RegisterBook();
                break;
            case 2:
                ListBooksMenu();
                break;
            case 3:
                ViewBookDetail();
                break;
            case 4:
                UpdateBookMenu();
                break;
            case 5:
                DeleteBook();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú principal.");
                break;
        }

        if (option != 0)
        {
            Pause();
        }
    }
}

static void RegisterBook()
{
    Console.WriteLine("Acción seleccionada: registrar libro.");
    Console.WriteLine("Simulación: solicitar título, autor, ISBN, año y categoría.");
}

static void ListBooksMenu()
{
    int option = -1;

    while (option != 0)
    {
        Console.WriteLine();
        Console.WriteLine("========== LISTAR LIBROS ==========");
        Console.WriteLine("1. Listar todos");
        Console.WriteLine("2. Listar disponibles");
        Console.WriteLine("3. Listar prestados");
        Console.WriteLine("0. Volver al menú de libros");
        Console.WriteLine("===================================");

        option = ReadOption(0, 3);

        switch (option)
        {
            case 1:
                ListBooksAll();
                break;
            case 2:
                ListBooksAvailable();
                break;
            case 3:
                ListBooksBorrowed();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú de libros.");
                break;
        }

        if (option != 0)
        {
            Pause();
        }
    }
}

static void ListBooksAll()
{
    Console.WriteLine("Acción seleccionada: listar todos los libros.");
    Console.WriteLine("Simulación: mostrar el listado completo de libros.");
}

static void ListBooksAvailable()
{
    Console.WriteLine("Acción seleccionada: listar libros disponibles.");
    Console.WriteLine("Simulación: mostrar los libros que no están prestados.");
}

static void ListBooksBorrowed()
{
    Console.WriteLine("Acción seleccionada: listar libros prestados.");
    Console.WriteLine("Simulación: mostrar los libros que están prestados.");
}

static void ViewBookDetail()
{
    Console.WriteLine("Acción seleccionada: ver detalle de libro.");
    Console.WriteLine("Simulación: consultar el libro por ID o ISBN.");
}

static void UpdateBookMenu()
{
    int option = -1;

    while (option != 0)
    {
        Console.WriteLine();
        Console.WriteLine("========== ACTUALIZAR LIBRO ==========");
        Console.WriteLine("1. Editar título");
        Console.WriteLine("2. Editar autor");
        Console.WriteLine("3. Editar año / categoría");
        Console.WriteLine("0. Volver al menú de libros");
        Console.WriteLine("======================================");

        option = ReadOption(0, 3);

        switch (option)
        {
            case 1:
                EditBookTitle();
                break;
            case 2:
                EditBookAuthor();
                break;
            case 3:
                EditBookYearCategory();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú de libros.");
                break;
        }

        if (option != 0)
        {
            Pause();
        }
    }
}

static void EditBookTitle()
{
    Console.WriteLine("Acción seleccionada: editar título del libro.");
    Console.WriteLine("Simulación: solicitar el ID del libro y el nuevo título.");
}

static void EditBookAuthor()
{
    Console.WriteLine("Acción seleccionada: editar autor del libro.");
    Console.WriteLine("Simulación: solicitar el ID del libro y el nuevo autor.");
}

static void EditBookYearCategory()
{
    Console.WriteLine("Acción seleccionada: editar año o categoría.");
    Console.WriteLine("Simulación: solicitar el ID del libro y los nuevos datos.");
}

static void DeleteBook()
{
    Console.WriteLine("Acción seleccionada: eliminar libro.");
    Console.WriteLine("Validar no permitir si está prestado.");
}

static void Pause()
{
    Console.WriteLine();
    Console.Write("Presione ENTER para continuar...");
    Console.ReadLine();
}
