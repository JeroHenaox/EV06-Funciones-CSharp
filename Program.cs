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
                ShowUsersMenu();
                break;
            case 3:
                ShowLoansMenu();
                break;
            case 4:
                Console.WriteLine("Módulo de búsquedas y reportes pendiente de implementación.");
                Pause();
                break;
            case 5:
                Console.WriteLine("Módulo de guardar y cargar datos pendiente de implementación.");
                Pause();
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

static void ShowUsersMenu()
{
    int option = -1;

    while (option != 0)
    {
        Console.WriteLine();
        Console.WriteLine("========== MENÚ DE USUARIOS ==========");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Listar usuarios");
        Console.WriteLine("3. Consultar usuario");
        Console.WriteLine("4. Actualizar nombre");
        Console.WriteLine("5. Actualizar contacto");
        Console.WriteLine("6. Activar usuario");
        Console.WriteLine("7. Desactivar usuario");
        Console.WriteLine("8. Eliminar usuario");
        Console.WriteLine("0. Volver al menú principal");
        Console.WriteLine("======================================");

        option = ReadOption(0, 8);

        switch (option)
        {
            case 1:
                RegisterUser();
                break;
            case 2:
                ListUsers();
                break;
            case 3:
                ViewUserDetail();
                break;
            case 4:
                UpdateUserName();
                break;
            case 5:
                UpdateUserContact();
                break;
            case 6:
                ActivateUser();
                break;
            case 7:
                DeactivateUser();
                break;
            case 8:
                DeleteUser();
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

static void RegisterUser()
{
    Console.WriteLine("Acción seleccionada: registrar usuario.");
    Console.WriteLine("Simulación: solicitar nombre, documento y datos de contacto.");
    Console.WriteLine("Validar que los campos obligatorios no estén vacíos.");
}

static void ListUsers()
{
    Console.WriteLine("Acción seleccionada: listar usuarios.");
    Console.WriteLine("Simulación: mostrar los usuarios registrados.");
}

static void ViewUserDetail()
{
    Console.WriteLine("Acción seleccionada: consultar usuario.");
    Console.WriteLine("Simulación: buscar al usuario por ID o número de documento.");
}

static void UpdateUserName()
{
    Console.WriteLine("Acción seleccionada: actualizar nombre del usuario.");
    Console.WriteLine("Simulación: solicitar el ID del usuario y el nuevo nombre.");
}

static void UpdateUserContact()
{
    Console.WriteLine("Acción seleccionada: actualizar contacto.");
    Console.WriteLine("Simulación: solicitar el ID del usuario y sus nuevos datos de contacto.");
}

static void ActivateUser()
{
    Console.WriteLine("Acción seleccionada: activar usuario.");
    Console.WriteLine("Simulación: cambiar el estado del usuario a activo.");
}

static void DeactivateUser()
{
    Console.WriteLine("Acción seleccionada: desactivar usuario.");
    Console.WriteLine("Simulación: cambiar el estado del usuario a inactivo.");
}

static void DeleteUser()
{
    Console.WriteLine("Acción seleccionada: eliminar usuario.");
    Console.WriteLine("Validar no permitir si tiene préstamos activos.");
}

static void ShowLoansMenu()
{
    int option = -1;

    while (option != 0)
    {
        Console.WriteLine();
        Console.WriteLine("========== MENÚ DE PRÉSTAMOS ==========");
        Console.WriteLine("1. Crear préstamo");
        Console.WriteLine("2. Listar préstamos");
        Console.WriteLine("3. Consultar préstamo por ID");
        Console.WriteLine("4. Registrar devolución");
        Console.WriteLine("5. Eliminar préstamo");
        Console.WriteLine("0. Volver al menú principal");
        Console.WriteLine("=======================================");

        option = ReadOption(0, 5);

        switch (option)
        {
            case 1:
                CreateLoan();
                break;
            case 2:
                ListLoansMenu();
                break;
            case 3:
                ViewLoanDetail();
                break;
            case 4:
                RegisterLoanReturn();
                break;
            case 5:
                DeleteLoan();
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

static void CreateLoan()
{
    Console.WriteLine("Acción seleccionada: crear préstamo.");
    Console.WriteLine("Simulación: solicitar el ID del usuario y el ID del libro.");
    Console.WriteLine("Validar que el usuario esté activo y que el libro esté disponible.");
    Console.WriteLine("Validar que el usuario no tenga restricciones para solicitar préstamos.");
    Console.WriteLine("Simulación: registrar fecha de préstamo y fecha prevista de devolución.");
}

static void ListLoansMenu()
{
    int option = -1;

    while (option != 0)
    {
        Console.WriteLine();
        Console.WriteLine("========== LISTAR PRÉSTAMOS ==========");
        Console.WriteLine("1. Listar todos");
        Console.WriteLine("2. Listar préstamos activos");
        Console.WriteLine("3. Listar préstamos cerrados");
        Console.WriteLine("0. Volver al menú de préstamos");
        Console.WriteLine("======================================");

        option = ReadOption(0, 3);

        switch (option)
        {
            case 1:
                ListAllLoans();
                break;
            case 2:
                ListActiveLoans();
                break;
            case 3:
                ListClosedLoans();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú de préstamos.");
                break;
        }

        if (option != 0)
        {
            Pause();
        }
    }
}

static void ListAllLoans()
{
    Console.WriteLine("Acción seleccionada: listar todos los préstamos.");
    Console.WriteLine("Simulación: mostrar todos los préstamos registrados.");
}

static void ListActiveLoans()
{
    Console.WriteLine("Acción seleccionada: listar préstamos activos.");
    Console.WriteLine("Simulación: mostrar los préstamos que aún no han sido devueltos.");
}

static void ListClosedLoans()
{
    Console.WriteLine("Acción seleccionada: listar préstamos cerrados.");
    Console.WriteLine("Simulación: mostrar los préstamos que ya fueron devueltos.");
}

static void ViewLoanDetail()
{
    Console.WriteLine("Acción seleccionada: consultar préstamo por ID.");
    Console.WriteLine("Simulación: solicitar el ID y mostrar los datos del préstamo.");
}

static void RegisterLoanReturn()
{
    Console.WriteLine("Acción seleccionada: registrar devolución.");
    Console.WriteLine("Simulación: buscar el préstamo y verificar que siga activo.");
    Console.WriteLine("Simulación: marcar el préstamo como devuelto.");
    Console.WriteLine("Simulación: cambiar el estado del libro a disponible.");
}

static void DeleteLoan()
{
    Console.WriteLine("Acción seleccionada: eliminar préstamo.");
    Console.WriteLine("Validar que la eliminación no genere inconsistencias en el historial.");
    Console.WriteLine("Verificar el estado del préstamo y la disponibilidad del libro antes de eliminar.");
}

static void Pause()
{
    Console.WriteLine();
    Console.Write("Presione ENTER para continuar...");
    Console.ReadLine();
}
