using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class PublicacionAutorDomain
    {
        private readonly PublicacionAutorRepository _PublicacionAutorRepository;

        public PublicacionAutorDomain(PublicacionAutorRepository PublicacionAutorRepository)
        {

            _PublicacionAutorRepository = PublicacionAutorRepository;
        }

        public IEnumerable<PublicacionAutor> ObtenerPublicacionAutorTodos()
        {
            try
            {
                return _PublicacionAutorRepository.ObtenerPublicacionAutorTodos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int InsertarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            try
            {
                return _PublicacionAutorRepository.InsertarPublicacionAutor(oPublicacionAutor);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int ActualizarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            try
            {
                return _PublicacionAutorRepository.ActualizarPublicacionAutor(oPublicacionAutor);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            try
            {
                return _PublicacionAutorRepository.EliminarPublicacionAutor(oPublicacionAutor);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
