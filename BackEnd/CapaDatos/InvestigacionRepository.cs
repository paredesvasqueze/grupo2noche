using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using Dapper;

namespace CapaDatos
{
    public class InvestigacionRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public InvestigacionRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Investigacions
        public IEnumerable<Investigacion> ObtenerInvestigacionTodos()
        {
            var Investigacions = new List<Investigacion>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Investigacion> lstFound = new List<Investigacion>();
                var query = "USP_seleccionar_Investigacion_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Investigacion>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarInvestigacion(Investigacion oInvestigacion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insertar_Investigacion";
                var param = new DynamicParameters();
                param.Add("@cTituloInvestigacion", oInvestigacion.cTituloInvestigacion);
                param.Add("dAnioInves", oInvestigacion.dAnioInves);
                param.Add("@cInstitucion", oInvestigacion.cInstitucion);
                param.Add("@cEnlaceAcceso", oInvestigacion.cEnlaceAcceso);
                param.Add("@cResumen", oInvestigacion.cResumen);
                param.Add("@nIdPublicacion", oInvestigacion.nIdPublicacion);
                param.Add("@cIdPublicacion", oInvestigacion.cIdPublicacion);

                param.Add("@dFechaRegistro", oInvestigacion.dFechaRegistro);
                param.Add("@cAutor", oInvestigacion.cAutor);
                param.Add("@nIdArea", oInvestigacion.nIdArea);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }


        public int ActualizarInvestigacion(Investigacion oInvestigacion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Investigacion";
                var param = new DynamicParameters();
                param.Add("@nIdInvestigacion", oInvestigacion.nIdInvestigacion);
                param.Add("@cTituloInvestigacion", oInvestigacion.cTituloInvestigacion);
                param.Add("dAnioInves", oInvestigacion.dAnioInves);
                param.Add("@cInstitucion", oInvestigacion.cInstitucion);
                param.Add("@cEnlaceAcceso", oInvestigacion.cEnlaceAcceso);
                param.Add("@cResumen", oInvestigacion.cResumen);
                param.Add("@nIdPublicacion", oInvestigacion.nIdPublicacion);
                param.Add("@cIdPublicacion", oInvestigacion.cIdPublicacion);

                param.Add("@dFechaRegistro", oInvestigacion.dFechaRegistro);
                param.Add("@cAutor", oInvestigacion.cAutor);
                param.Add("@nIdArea", oInvestigacion.nIdArea);

                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int EliminarInvestigacion(Investigacion oInvestigacion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_Investigacion";
                var param = new DynamicParameters();
                param.Add("@nIdInvestigacion", oInvestigacion.nIdInvestigacion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }


    }
}
