namespace EV06_Funciones_CSharp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty;
        public string Contacto { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;

        public Usuario()
        {
        }

        public Usuario(int id, string nombre, string documento, string contacto)
        {
            Id = id;
            Nombre = nombre;
            Documento = documento;
            Contacto = contacto;
            Activo = true;
        }

        public string ResumenCorto()
        {
            return $"{Nombre} - {Documento}";
        }

        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                   $"Nombre: {Nombre}\n" +
                   $"Documento: {Documento}\n" +
                   $"Contacto: {Contacto}\n" +
                   $"Activo: {Activo}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}