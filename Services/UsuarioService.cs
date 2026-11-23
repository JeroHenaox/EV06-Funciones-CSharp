using System;
using System.Collections.Generic;
using System.Linq;
using EV06_Funciones_CSharp.Models;

namespace EV06_Funciones_CSharp.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();

        // Agregar usuario
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        // Eliminar usuario por ID
        public bool EliminarUsuario(int id)
        {
            Usuario? usuario = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario == null)
            {
                return false;
            }

            return usuarios.Remove(usuario);
        }

        // Obtener todos los usuarios
        public List<Usuario> ObtenerTodos()
        {
            return new List<Usuario>(usuarios);
        }

        // Buscar por documento
        public Usuario? BuscarPorDocumento(string documento)
        {
            return usuarios.FirstOrDefault(u =>
                u.Documento.Equals(documento, StringComparison.OrdinalIgnoreCase));
        }

        // Buscar por nombre
        public List<Usuario> BuscarPorNombre(string nombre)
        {
            return usuarios.Where(u =>
                u.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Ordenar por nombre
        public List<Usuario> OrdenarPorNombre()
        {
            return usuarios.OrderBy(u => u.Nombre).ToList();
        }

        // Total de usuarios
        public int TotalUsuarios()
        {
            return usuarios.Count;
        }

        // Usuarios activos
        public int TotalActivos()
        {
            return usuarios.Count(u => u.Activo);
        }

        // Usuarios inactivos
        public int TotalInactivos()
        {
            return usuarios.Count(u => !u.Activo);
        }
    }
}