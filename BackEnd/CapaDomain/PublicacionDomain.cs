using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
   public class PublicacionDomain
    {
        private readonly PublicacionRepository _PublicacionRepository;

        public PublicacionDomain(PublicacionRepository PublicacionRepository)
        {

            _PublicacionRepository = PublicacionRepository;
        }

        public IEnumerable<Publicacion> ObtenerPublicacionTodos()
        {
            try
            {
                return _PublicacionRepository.ObtenerPublicacionTodos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int InsertarPublicacion(Publicacion oPublicacion)
        {
            try
            {
                return _PublicacionRepository.InsertarPublicacion(oPublicacion);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int ActualizarPublicacion(Publicacion oPublicacion)
        {
            try
            {
                return _PublicacionRepository.ActualizarPublicacion(oPublicacion);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarPublicacion(Publicacion oPublicacion)
        {
            try
            {
                return _PublicacionRepository.EliminarPublicacion(oPublicacion);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
