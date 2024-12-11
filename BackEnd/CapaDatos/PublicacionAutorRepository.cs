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
    public class PublicacionAutorRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public PublicacionAutorRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de PublicacionAutors
        public IEnumerable<PublicacionAutor> ObtenerPublicacionAutorTodos()
        {
            var PublicacionAutors = new List<PublicacionAutor>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<PublicacionAutor> lstFound = new List<PublicacionAutor>();
                var query = "USP_seleccionar_PublicacionAutor_Todos";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<PublicacionAutor>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insertar_PublicacionAutor";
                var param = new DynamicParameters();
                param.Add("@nIdPublicacion", oPublicacionAutor.nIdPublicacion);
                param.Add("@cIdPublicacion", oPublicacionAutor.cIdPublicacion);
                param.Add("@dnIdAutor", oPublicacionAutor.nIdAutor);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }

        public int ActualizarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_PublicacionAutor";
                var param = new DynamicParameters();
                param.Add("@nIdPublicacionAutor", oPublicacionAutor.nIdPublicacionAutor);
                param.Add("@nIdPublicacion", oPublicacionAutor.nIdPublicacion);
                param.Add("@cIdPublicacion", oPublicacionAutor.cIdPublicacion);
                param.Add("@dnIdAutor", oPublicacionAutor.nIdAutor);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int EliminarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_PublicacionAutor";
                var param = new DynamicParameters();
                param.Add("@nIdPublicacionAutor", oPublicacionAutor.nIdPublicacionAutor);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

    }
}
