using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
   public class ComentarioDomain
    {
        private readonly ComentarioRepository _ComentarioRepository;

        public ComentarioDomain(ComentarioRepository ComentarioRepository)
        {

            _ComentarioRepository = ComentarioRepository;
        }

        public IEnumerable<Comentario> ObtenerComentarioTodos()
        {
            try
            {
                return _ComentarioRepository.ObtenerComentarioTodos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int InsertarComentario(Comentario oComentario)
        {
            try
            {
                return _ComentarioRepository.InsertarComentario(oComentario);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int ActualizarComentario(Comentario oComentario)
        {
            try
            {
                return _ComentarioRepository.ActualizarComentario(oComentario);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarComentario(Comentario oComentario)
        {
            try
            {
                return _ComentarioRepository.EliminarComentario(oComentario);
            }
            catch (Exception)
            {
                throw;
            }

        }




    }
}
