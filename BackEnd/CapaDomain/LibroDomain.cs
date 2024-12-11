using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class LibroDomain
    {
        private readonly LibroRepository _LibroRepository;

        public LibroDomain(LibroRepository LibroRepository)
        {

            _LibroRepository = LibroRepository;
        }

        public IEnumerable<Libro> ObtenerLibroTodos()
        {
            try
            {
                return _LibroRepository.ObtenerLibroTodos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int InsertarLibro(Libro oLibro)
        {
            try
            {
                return _LibroRepository.InsertarLibro(oLibro);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int ActualizarLibro(Libro oLibro)
        {
            try
            {
                return _LibroRepository.ActualizarLibro(oLibro);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarLibro(Libro oLibro)
        {
            try
            {
                return _LibroRepository.EliminarLibro(oLibro);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
