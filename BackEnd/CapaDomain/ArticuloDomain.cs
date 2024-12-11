using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class ArticuloDomain
    {
        private readonly ArticuloRepository _ArticuloRepository;

        public ArticuloDomain(ArticuloRepository ArticuloRepository)
        {
           
                _ArticuloRepository = ArticuloRepository;     
        }

        public IEnumerable<Articulo> ObtenerArticuloTodos()
        {
            try
            {
                return _ArticuloRepository.ObtenerArticuloTodos();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public int InsertarArticulo(Articulo oArticulo)
        {
            try
            {
                return _ArticuloRepository.InsertarArticulo(oArticulo);
            }
            catch (Exception)
            {
                throw;
            }
            
        }


        public int ActualizarArticulo(Articulo oArticulo)
        {
            try
            {
                return _ArticuloRepository.ActualizarArticulo(oArticulo);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarArticulo(Articulo oArticulo)
        {
            try
            {
                return _ArticuloRepository.EliminarArticulo(oArticulo);
            }
            catch (Exception)
            {
                throw;
            }

        }




    }
}
