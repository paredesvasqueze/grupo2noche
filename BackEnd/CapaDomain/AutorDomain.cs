using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class AutorDomain
    {
        private readonly AutorRepository _AutorRepository;

        public AutorDomain(AutorRepository AutorRepository)
        {

            _AutorRepository = AutorRepository;
        }

        public IEnumerable<Autor> ObtenerAutorTodos()
        {
            try
            {
                return _AutorRepository.ObtenerAutorTodos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int InsertarAutor(Autor oAutor)
        {
            try
            {
                return _AutorRepository.InsertarAutor(oAutor);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int ActualizarAutor(Autor oAutor)
        {
            try
            {
                return _AutorRepository.ActualizarAutor(oAutor);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarAutor(Autor oAutor)
        {
            try
            {
                return _AutorRepository.EliminarAutor(oAutor);
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
