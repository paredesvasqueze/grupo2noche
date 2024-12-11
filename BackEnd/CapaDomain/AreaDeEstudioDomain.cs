using CapaEntidad;
using CapaDatos;

namespace CapaDomain
{
    public class AreaDeEstudioDomain
    {
        private readonly AreaDeEstudioRepository _AreaDeEstudioRepository;

        public AreaDeEstudioDomain(AreaDeEstudioRepository AreaDeEstudioRepository)
        {
           
                _AreaDeEstudioRepository = AreaDeEstudioRepository;     
        }

        public IEnumerable<AreaDeEstudio> ObtenerAreaDeEstudioTodos()
        {
            try
            {
                return _AreaDeEstudioRepository.ObtenerAreaDeEstudioTodos();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public int InsertarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            try
            {
                return _AreaDeEstudioRepository.InsertarAreaDeEstudio(oAreaDeEstudio);
            }
            catch (Exception)
            {
                throw;
            }
            
        }


        public int ActualizarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            try
            {
                return _AreaDeEstudioRepository.ActualizarAreaDeEstudio(oAreaDeEstudio);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            try
            {
                return _AreaDeEstudioRepository.EliminarAreaDeEstudio(oAreaDeEstudio);
            }
            catch (Exception)
            {
                throw;
            }

        }





    }
}
