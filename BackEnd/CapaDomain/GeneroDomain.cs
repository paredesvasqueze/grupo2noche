using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class GeneroDomain
    {
        private readonly GeneroRepository _GeneroRepository;

        public GeneroDomain(GeneroRepository GeneroRepository)
        {

            _GeneroRepository = GeneroRepository;
        }

        public IEnumerable<Genero> ObtenerGeneroTodos()
        {
            try
            {
                return _GeneroRepository.ObtenerGeneroTodos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int InsertarGenero(Genero oGenero)
        {
            try
            {
                return _GeneroRepository.InsertarGenero(oGenero);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int ActualizarGenero(Genero oGenero)
        {
            try
            {
                return _GeneroRepository.ActualizarGenero(oGenero);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarGenero(Genero oGenero)
        {
            try
            {
                return _GeneroRepository.EliminarGenero(oGenero);
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
