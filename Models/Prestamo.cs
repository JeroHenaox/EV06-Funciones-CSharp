namespace EV06_Funciones_CSharp.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int LibroId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionEsperada { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public EstadoPrestamo Estado { get; set; } = EstadoPrestamo.Activo;

        public Prestamo()
        {
        }

        public Prestamo(
            int id,
            int usuarioId,
            int libroId,
            DateTime fechaPrestamo,
            DateTime fechaDevolucionEsperada)
        {
            Id = id;
            UsuarioId = usuarioId;
            LibroId = libroId;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucionEsperada = fechaDevolucionEsperada;
            FechaDevolucion = null;
            Estado = EstadoPrestamo.Activo;
        }

        public bool EstaVencido()
        {
            return FechaDevolucion == null &&
                   DateTime.Today > FechaDevolucionEsperada.Date;
        }

        public int DiasTranscurridos()
        {
            return (DateTime.Today - FechaPrestamo.Date).Days;
        }

        public string ResumenCorto()
        {
            return $"Préstamo {Id} - Usuario: {UsuarioId} - Libro: {LibroId}";
        }

        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                   $"Usuario: {UsuarioId}\n" +
                   $"Libro: {LibroId}\n" +
                   $"Fecha del préstamo: {FechaPrestamo:dd/MM/yyyy}\n" +
                   $"Fecha esperada de devolución: {FechaDevolucionEsperada:dd/MM/yyyy}\n" +
                   $"Fecha de devolución: {(FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString("dd/MM/yyyy") : "Pendiente")}\n" +
                   $"Estado: {Estado}\n" +
                   $"Vencido: {EstaVencido()}\n" +
                   $"Días transcurridos: {DiasTranscurridos()}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}