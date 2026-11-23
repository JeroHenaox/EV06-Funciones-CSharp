
using System;
using System.Collections.Generic;
using System.Linq;
using EV06_Funciones_CSharp.Models;

namespace EV06_Funciones_CSharp.Services
{
    public class PrestamoService
    {
        private List<Prestamo> prestamos = new List<Prestamo>();

        // Agregar préstamo
        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }

        // Eliminar préstamo por ID
        public bool EliminarPrestamo(int id)
        {
            Prestamo? prestamo = BuscarPorId(id);

            if (prestamo == null)
            {
                return false;
            }

            return prestamos.Remove(prestamo);
        }

        // Obtener todos los préstamos
        public List<Prestamo> ObtenerTodos()
        {
            return new List<Prestamo>(prestamos);
        }

        // Buscar préstamo por ID
        public Prestamo? BuscarPorId(int id)
        {
            return prestamos.FirstOrDefault(p => p.Id == id);
        }

        // Buscar préstamos por estado
        public List<Prestamo> BuscarPorEstado(EstadoPrestamo estado)
        {
            return prestamos.Where(p =>
                ObtenerEstadoActual(p) == estado).ToList();
        }

        // Ordenar por fecha límite de devolución
        public List<Prestamo> OrdenarPorFechaLimite()
        {
            return prestamos.OrderBy(p =>
                p.FechaDevolucionEsperada).ToList();
        }

        // Obtener estado actual considerando vencimientos
        private EstadoPrestamo ObtenerEstadoActual(Prestamo prestamo)
        {
            if (prestamo.FechaDevolucion.HasValue ||
                prestamo.Estado == EstadoPrestamo.Devuelto)
            {
                return EstadoPrestamo.Devuelto;
            }

            if (prestamo.EstaVencido())
            {
                return EstadoPrestamo.Vencido;
            }

            return EstadoPrestamo.Activo;
        }

        // KPI: total de préstamos
        public int TotalPrestamos()
        {
            return prestamos.Count;
        }

        // KPI: préstamos activos
        public int TotalActivos()
        {
            return BuscarPorEstado(EstadoPrestamo.Activo).Count;
        }

        // KPI: préstamos vencidos
        public int TotalVencidos()
        {
            return BuscarPorEstado(EstadoPrestamo.Vencido).Count;
        }

        // KPI: préstamos devueltos
        public int TotalDevueltos()
        {
            return BuscarPorEstado(EstadoPrestamo.Devuelto).Count;
        }

        // KPI: promedio de días de préstamo
        public double PromedioDiasPrestamo()
        {
            if (prestamos.Count == 0)
            {
                return 0;
            }

            return prestamos.Average(p =>
            {
                DateTime fechaFinal =
                    p.FechaDevolucion ?? DateTime.Today;

                return Math.Max(0,
                    (fechaFinal.Date - p.FechaPrestamo.Date).Days);
            });
        }
    }
}
