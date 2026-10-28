Console.WriteLine("==================================");
Console.WriteLine(" SISTEMA DE GESTIÓN DE BIBLIOTECA");
Console.WriteLine("==================================");

ShowMainMenu();

static void ShowMainMenu()
{
    int opcion = 0;

    while (opcion != 6)
    {
        Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
        Console.WriteLine("1. Libros");
        Console.WriteLine("2. Usuarios");
        Console.WriteLine("3. Préstamos");
        Console.WriteLine("4. Búsquedas y reportes");
        Console.WriteLine("5. Guardar/Cargar datos");
        Console.WriteLine("6. Salir");
        Console.Write("Seleccione una opción: ");

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
                ShowSearchReportsMenu();
                break;
            case 5:
                Console.WriteLine("El módulo de guardar y cargar datos está pendiente.");
                Pause();
                break;
            case 6:
                Console.WriteLine("Saliendo del sistema...");
                break;
        }
    }
}

static void ShowBooksMenu()
{
    int opcion = -1;

    while (opcion != 0)
    {
        Console.WriteLine("\n===== MENÚ DE LIBROS =====");
        Console.WriteLine("1. Registrar libro");
        Console.WriteLine("2. Listar libros");
        Console.WriteLine("3. Consultar libro por ID o ISBN");
        Console.WriteLine("4. Actualizar libro");
        Console.WriteLine("5. Eliminar libro");
        Console.WriteLine("0. Volver al menú principal");
        Console.Write("Seleccione una opción: ");

        opcion = ReadOption(0, 5);

        switch (opcion)
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
                UpdateBook();
                break;
            case 5:
                DeleteBook();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú principal...");
                break;
        }
    }
}

static void ListBooksMenu()
{
    int opcion = -1;

    while (opcion != 0)
    {
        Console.WriteLine("\n===== LISTAR LIBROS =====");
        Console.WriteLine("1. Listar todos");
        Console.WriteLine("2. Listar disponibles");
        Console.WriteLine("3. Listar prestados");
        Console.WriteLine("0. Volver");
        Console.Write("Seleccione una opción: ");

        opcion = ReadOption(0, 3);

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Aquí se mostrarían todos los libros registrados.");
                Pause();
                break;
            case 2:
                Console.WriteLine("Aquí se mostrarían los libros disponibles.");
                Pause();
                break;
            case 3:
                Console.WriteLine("Aquí se mostrarían los libros prestados.");
                Pause();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú de libros...");
                break;
        }
    }
}

static void RegisterBook()
{
    Console.WriteLine("\n===== REGISTRAR LIBRO =====");
    Console.Write("Ingrese el título: ");
    string titulo = ReadRequiredText();

    Console.Write("Ingrese el autor: ");
    string autor = ReadRequiredText();

    Console.Write("Ingrese el ISBN: ");
    string isbn = ReadRequiredText();

    Console.Write("Ingrese el año de publicación: ");
    int anio = ReadOption(1, 2026);

    Console.Write("Ingrese la categoría: ");
    string categoria = ReadRequiredText();

    Console.WriteLine("\nLibro recibido correctamente.");
    Console.WriteLine($"Título: {titulo}");
    Console.WriteLine($"Autor: {autor}");
    Console.WriteLine($"ISBN: {isbn}");
    Console.WriteLine($"Año: {anio}");
    Console.WriteLine($"Categoría: {categoria}");
    Console.WriteLine("Nota: el registro es simulado; no se guarda en una base de datos.");
    Pause();
}

static void ViewBookDetail()
{
    Console.WriteLine("\n===== CONSULTAR LIBRO =====");
    Console.Write("Ingrese el ID o ISBN del libro: ");
    string identificador = ReadRequiredText();

    Console.WriteLine($"Se consultaría el libro con identificador: {identificador}");
    Console.WriteLine("La consulta es simulada.");
    Pause();
}

static void UpdateBook()
{
    Console.WriteLine("\n===== ACTUALIZAR LIBRO =====");
    Console.Write("Ingrese el ID o ISBN del libro: ");
    string identificador = ReadRequiredText();

    Console.WriteLine("1. Cambiar título");
    Console.WriteLine("2. Cambiar autor");
    Console.WriteLine("3. Cambiar año");
    Console.WriteLine("4. Cambiar categoría");
    Console.Write("Seleccione el dato que desea actualizar: ");

    int opcion = ReadOption(1, 4);

    Console.Write("Ingrese el nuevo valor: ");
    string nuevoValor = ReadRequiredText();

    Console.WriteLine($"Se actualizaría el dato seleccionado del libro {identificador}.");
    Console.WriteLine($"Nuevo valor: {nuevoValor}");
    Console.WriteLine("Actualización simulada.");
    Pause();
}

static void DeleteBook()
{
    Console.WriteLine("\n===== ELIMINAR LIBRO =====");
    Console.Write("Ingrese el ID o ISBN del libro: ");
    string identificador = ReadRequiredText();

    Console.Write("¿Confirma la eliminación? (S/N): ");
    string confirmacion = Console.ReadLine() ?? "";

    if (confirmacion.Equals("S", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Se simularía la eliminación del libro {identificador}.");
        Console.WriteLine("Validar no permitir si está prestado.");
    }
    else
    {
        Console.WriteLine("Eliminación cancelada.");
    }

    Pause();
}

static void ShowUsersMenu()
{
    int opcion = -1;

    while (opcion != 0)
    {
        Console.WriteLine("\n===== MENÚ DE USUARIOS =====");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Listar usuarios");
        Console.WriteLine("3. Consultar usuario por ID o documento");
        Console.WriteLine("4. Actualizar usuario");
        Console.WriteLine("5. Activar usuario");
        Console.WriteLine("6. Desactivar usuario");
        Console.WriteLine("7. Eliminar usuario");
        Console.WriteLine("0. Volver al menú principal");
        Console.Write("Seleccione una opción: ");

        opcion = ReadOption(0, 7);

        switch (opcion)
        {
            case 1:
                RegisterUser();
                break;
            case 2:
                Console.WriteLine("Aquí se mostrarían los usuarios registrados.");
                Pause();
                break;
            case 3:
                ViewUserDetail();
                break;
            case 4:
                UpdateUser();
                break;
            case 5:
                ChangeUserStatus("activar");
                break;
            case 6:
                ChangeUserStatus("desactivar");
                break;
            case 7:
                DeleteUser();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú principal...");
                break;
        }
    }
}

static void RegisterUser()
{
    Console.WriteLine("\n===== REGISTRAR USUARIO =====");
    Console.Write("Ingrese el nombre: ");
    string nombre = ReadRequiredText();

    Console.Write("Ingrese el documento: ");
    string documento = ReadRequiredText();

    Console.Write("Ingrese el correo o teléfono: ");
    string contacto = ReadRequiredText();

    Console.WriteLine("\nUsuario recibido correctamente.");
    Console.WriteLine($"Nombre: {nombre}");
    Console.WriteLine($"Documento: {documento}");
    Console.WriteLine($"Contacto: {contacto}");
    Console.WriteLine("Registro simulado; no se guarda en una base de datos.");
    Pause();
}

static void ViewUserDetail()
{
    Console.WriteLine("\n===== CONSULTAR USUARIO =====");
    Console.Write("Ingrese el ID o documento: ");
    string identificador = ReadRequiredText();

    Console.WriteLine($"Se consultaría el usuario con identificador: {identificador}");
    Console.WriteLine("La consulta es simulada.");
    Pause();
}

static void UpdateUser()
{
    Console.WriteLine("\n===== ACTUALIZAR USUARIO =====");
    Console.Write("Ingrese el ID o documento: ");
    string identificador = ReadRequiredText();

    Console.WriteLine("1. Cambiar nombre");
    Console.WriteLine("2. Cambiar contacto");
    Console.Write("Seleccione una opción: ");
    int opcion = ReadOption(1, 2);

    Console.Write("Ingrese el nuevo valor: ");
    string nuevoValor = ReadRequiredText();

    Console.WriteLine($"Se actualizaría el usuario {identificador}.");
    Console.WriteLine($"Nuevo valor: {nuevoValor}");
    Console.WriteLine("Actualización simulada.");
    Pause();
}

static void ChangeUserStatus(string accion)
{
    Console.WriteLine($"\n===== {accion.ToUpper()} USUARIO =====");
    Console.Write("Ingrese el ID o documento: ");
    string identificador = ReadRequiredText();

    Console.WriteLine($"Se simularía la acción de {accion} al usuario {identificador}.");
    Pause();
}

static void DeleteUser()
{
    Console.WriteLine("\n===== ELIMINAR USUARIO =====");
    Console.Write("Ingrese el ID o documento: ");
    string identificador = ReadRequiredText();

    Console.Write("¿Confirma la eliminación? (S/N): ");
    string confirmacion = Console.ReadLine() ?? "";

    if (confirmacion.Equals("S", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Se simularía la eliminación del usuario {identificador}.");
        Console.WriteLine("Validar no permitir si tiene préstamos activos.");
    }
    else
    {
        Console.WriteLine("Eliminación cancelada.");
    }

    Pause();
}

static void ShowLoansMenu()
{
    int opcion = -1;

    while (opcion != 0)
    {
        Console.WriteLine("\n===== MENÚ DE PRÉSTAMOS =====");
        Console.WriteLine("1. Crear préstamo");
        Console.WriteLine("2. Listar préstamos");
        Console.WriteLine("3. Consultar préstamo por ID");
        Console.WriteLine("4. Registrar devolución");
        Console.WriteLine("5. Eliminar préstamo");
        Console.WriteLine("0. Volver al menú principal");
        Console.Write("Seleccione una opción: ");

        opcion = ReadOption(0, 5);

        switch (opcion)
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
                Console.WriteLine("Volviendo al menú principal...");
                break;
        }
    }
}

static void ListLoansMenu()
{
    int opcion = -1;

    while (opcion != 0)
    {
        Console.WriteLine("\n===== LISTAR PRÉSTAMOS =====");
        Console.WriteLine("1. Listar todos");
        Console.WriteLine("2. Listar activos");
        Console.WriteLine("3. Listar cerrados");
        Console.WriteLine("0. Volver");
        Console.Write("Seleccione una opción: ");

        opcion = ReadOption(0, 3);

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Aquí se mostrarían todos los préstamos.");
                Pause();
                break;
            case 2:
                Console.WriteLine("Aquí se mostrarían los préstamos activos.");
                Pause();
                break;
            case 3:
                Console.WriteLine("Aquí se mostrarían los préstamos cerrados.");
                Pause();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú de préstamos...");
                break;
        }
    }
}

static void CreateLoan()
{
    Console.WriteLine("\n===== CREAR PRÉSTAMO =====");
    Console.Write("Ingrese el ID del usuario: ");
    string usuario = ReadRequiredText();

    Console.Write("Ingrese el ID o ISBN del libro: ");
    string libro = ReadRequiredText();

    Console.Write("Ingrese la fecha de devolución esperada (dd/mm/aaaa): ");
    string fecha = ReadRequiredText();

    Console.WriteLine("\nSolicitud de préstamo recibida.");
    Console.WriteLine($"Usuario: {usuario}");
    Console.WriteLine($"Libro: {libro}");
    Console.WriteLine($"Fecha esperada: {fecha}");
    Console.WriteLine("Validaciones sugeridas: usuario activo, libro disponible y fecha válida.");
    Console.WriteLine("Creación del préstamo simulada.");
    Pause();
}

static void ViewLoanDetail()
{
    Console.WriteLine("\n===== CONSULTAR PRÉSTAMO =====");
    Console.Write("Ingrese el ID del préstamo: ");
    string identificador = ReadRequiredText();

    Console.WriteLine($"Se consultaría el préstamo {identificador}.");
    Console.WriteLine("Consulta simulada.");
    Pause();
}

static void RegisterLoanReturn()
{
    Console.WriteLine("\n===== REGISTRAR DEVOLUCIÓN =====");
    Console.Write("Ingrese el ID del préstamo: ");
    string identificador = ReadRequiredText();

    Console.WriteLine($"Se registraría la devolución del préstamo {identificador}.");
    Console.WriteLine("El préstamo quedaría marcado como devuelto y el libro como disponible.");
    Console.WriteLine("Devolución simulada.");
    Pause();
}

static void DeleteLoan()
{
    Console.WriteLine("\n===== ELIMINAR PRÉSTAMO =====");
    Console.Write("Ingrese el ID del préstamo: ");
    string identificador = ReadRequiredText();

    Console.Write("¿Confirma la eliminación? (S/N): ");
    string confirmacion = Console.ReadLine() ?? "";

    if (confirmacion.Equals("S", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Se simularía la eliminación del préstamo {identificador}.");
        Console.WriteLine("Validar que no se eliminen préstamos activos sin resolver.");
    }
    else
    {
        Console.WriteLine("Eliminación cancelada.");
    }

    Pause();
}

static void ListAllLoans()
{
    Console.WriteLine("Aquí se mostrarían todos los préstamos.");
    Pause();
}

static void ListActiveLoans()
{
    Console.WriteLine("Aquí se mostrarían los préstamos activos.");
    Pause();
}

static void ListClosedLoans()
{
    Console.WriteLine("Aquí se mostrarían los préstamos cerrados.");
    Pause();
}

static void ShowSearchReportsMenu()
{
    int opcion = -1;

    while (opcion != 0)
    {
        Console.WriteLine("\n===== BÚSQUEDAS Y REPORTES =====");
        Console.WriteLine("1. Buscar libro");
        Console.WriteLine("2. Buscar usuario");
        Console.WriteLine("3. Reporte de préstamos por usuario");
        Console.WriteLine("4. Reporte de préstamos por libro");
        Console.WriteLine("5. Reporte de préstamos vencidos");
        Console.WriteLine("6. Reporte general");
        Console.WriteLine("0. Volver al menú principal");
        Console.Write("Seleccione una opción: ");

        opcion = ReadOption(0, 6);

        switch (opcion)
        {
            case 1:
                SearchBook();
                break;
            case 2:
                SearchUser();
                break;
            case 3:
                ReportLoansByUser();
                break;
            case 4:
                ReportLoansByBook();
                break;
            case 5:
                ReportOverdueLoans();
                break;
            case 6:
                ShowGeneralReport();
                break;
            case 0:
                Console.WriteLine("Volviendo al menú principal...");
                break;
        }
    }
}

static void SearchBook()
{
    Console.WriteLine("\n===== BUSCAR LIBRO =====");
    Console.WriteLine("1. Buscar por título");
    Console.WriteLine("2. Buscar por autor");
    Console.WriteLine("3. Buscar por ID o ISBN");
    Console.WriteLine("4. Buscar por categoría");
    Console.Write("Seleccione el criterio: ");

    int opcion = ReadOption(1, 4);

    Console.Write("Ingrese el texto de búsqueda: ");
    string criterio = ReadRequiredText();

    string tipo = opcion switch
    {
        1 => "título",
        2 => "autor",
        3 => "ID o ISBN",
        4 => "categoría",
        _ => "criterio"
    };

    Console.WriteLine($"Se buscarían libros por {tipo}: {criterio}");
    Console.WriteLine("Búsqueda simulada; no hay registros almacenados.");
    Pause();
}

static void SearchUser()
{
    Console.WriteLine("\n===== BUSCAR USUARIO =====");
    Console.WriteLine("1. Buscar por nombre");
    Console.WriteLine("2. Buscar por ID o documento");
    Console.Write("Seleccione el criterio: ");

    int opcion = ReadOption(1, 2);

    Console.Write("Ingrese el texto de búsqueda: ");
    string criterio = ReadRequiredText();

    string tipo = opcion == 1 ? "nombre" : "ID o documento";

    Console.WriteLine($"Se buscarían usuarios por {tipo}: {criterio}");
    Console.WriteLine("Búsqueda simulada; no hay registros almacenados.");
    Pause();
}

static void ReportLoansByUser()
{
    Console.WriteLine("\n===== REPORTE POR USUARIO =====");
    Console.Write("Ingrese el ID o documento del usuario: ");
    string usuario = ReadRequiredText();

    Console.WriteLine($"Se mostrarían los préstamos asociados al usuario {usuario}.");
    Console.WriteLine("Reporte simulado.");
    Pause();
}

static void ReportLoansByBook()
{
    Console.WriteLine("\n===== REPORTE POR LIBRO =====");
    Console.Write("Ingrese el ID o ISBN del libro: ");
    string libro = ReadRequiredText();

    Console.WriteLine($"Se mostrarían los préstamos asociados al libro {libro}.");
    Console.WriteLine("Reporte simulado.");
    Pause();
}

static void ReportOverdueLoans()
{
    Console.WriteLine("\n===== REPORTE DE PRÉSTAMOS VENCIDOS =====");
    Console.WriteLine("Aquí se mostrarían los préstamos cuya fecha de devolución ya pasó.");
    Console.WriteLine("Reporte simulado; no hay fechas ni préstamos almacenados.");
    Pause();
}

static void ShowGeneralReport()
{
    Console.WriteLine("\n===== REPORTE GENERAL =====");
    Console.WriteLine("Resumen de libros: pendiente de datos almacenados.");
    Console.WriteLine("Resumen de usuarios: pendiente de datos almacenados.");
    Console.WriteLine("Resumen de préstamos activos y cerrados: pendiente de datos almacenados.");
    Console.WriteLine("Reporte simulado.");
    Pause();
}

static int ReadOption(int minimum, int maximum)
{
    while (true)
    {
        string entrada = Console.ReadLine() ?? "";

        if (int.TryParse(entrada, out int opcion) &&
            opcion >= minimum &&
            opcion <= maximum)
        {
            return opcion;
        }

        Console.Write($"Opción inválida. Ingrese un número entre {minimum} y {maximum}: ");
    }
}

static string ReadRequiredText()
{
    while (true)
    {
        string texto = Console.ReadLine() ?? "";

        if (!string.IsNullOrWhiteSpace(texto))
        {
            return texto.Trim();
        }

        Console.Write("El campo no puede quedar vacío. Intente nuevamente: ");
    }
}

static void Pause()
{
    Console.WriteLine("\nPresione Enter para continuar...");
    Console.ReadLine();
}
