using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class InvestigacionDomain
    {
        private readonly InvestigacionRepository _InvestigacionRepository;

        public InvestigacionDomain(InvestigacionRepository InvestigacionRepository)
        {

            _InvestigacionRepository = InvestigacionRepository;
        }

        public IEnumerable<Investigacion> ObtenerInvestigacionTodos()
        {
            try
            {
                return _InvestigacionRepository.ObtenerInvestigacionTodos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int InsertarInvestigacion(Investigacion oInvestigacion)
        {
            try
            {
                return _InvestigacionRepository.InsertarInvestigacion(oInvestigacion);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int ActualizarInvestigacion(Investigacion oInvestigacion)
        {
            try
            {
                return _InvestigacionRepository.ActualizarInvestigacion(oInvestigacion);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int EliminarInvestigacion(Investigacion oInvestigacion)
        {
            try
            {
                return _InvestigacionRepository.EliminarInvestigacion(oInvestigacion);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
