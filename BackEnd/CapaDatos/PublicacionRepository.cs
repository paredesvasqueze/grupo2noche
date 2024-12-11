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
    public class PublicacionRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public PublicacionRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Publicacions
        public IEnumerable<Publicacion> ObtenerPublicacionTodos()
        {
            var Publicacions = new List<Publicacion>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Publicacion> lstFound = new List<Publicacion>();
                var query = "USP_seleccionar_Publicacion_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Publicacion>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarPublicacion(Publicacion oPublicacion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insertar_Publicacion";
                var param = new DynamicParameters();
                param.Add("@cIdPublicacion", oPublicacion.cIdPublicacion);
                param.Add("@nTipoPublicacion", oPublicacion.nTipoPublicacion);
                param.Add("@dFechaRegistro", oPublicacion.dFechaRegistro);
                param.Add("@cAutor", oPublicacion.cAutor);
                param.Add("@nIdArea", oPublicacion.nIdArea);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }

        public int ActualizarPublicacion(Publicacion oPublicacion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Publicacion";
                var param = new DynamicParameters();
                param.Add("@nIdPublicacion", oPublicacion.nIdPublicacion); 
                param.Add("@cIdPublicacion", oPublicacion.cIdPublicacion);
                param.Add("@nTipoPublicacion", oPublicacion.nTipoPublicacion);
                param.Add("@dFechaRegistro", oPublicacion.dFechaRegistro);
                param.Add("@cAutor", oPublicacion.cAutor);
                param.Add("@nIdArea", oPublicacion.nIdArea);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int EliminarPublicacion(Publicacion oPublicacion)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_Publicacion";
                var param = new DynamicParameters();
                param.Add("@nIdPublicacion", oPublicacion.nIdPublicacion);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

    }
}
