using CapaEntidad;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ComentarioRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public ComentarioRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Comentarios
        public IEnumerable<Comentario> ObtenerComentarioTodos()
        {
            var Comentarios = new List<Comentario>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Comentario> lstFound = new List<Comentario>();
                var query = "USP_seleccionar_Comentario_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Comentario>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;

            }
        }

        public int InsertarComentario(Comentario oComentario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_insertar_Comentario";
                var param = new DynamicParameters();
                param.Add("@dFechaComentario", oComentario.dFechaComentario);
                param.Add("@nIdPublicacion", oComentario.nIdPublicacion);
                param.Add("@cIdPublicacion", oComentario.cIdPublicacion);
                param.Add("@nIdUsuario", oComentario.nIdUsuario);
                param.Add("@cComentario", oComentario.cComentario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }


        public int ActualizarComentario(Comentario oComentario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Comentario";
                var param = new DynamicParameters();
                param.Add("@dFechaComentario", oComentario.dFechaComentario);
                param.Add("@nIdPublicacion", oComentario.nIdPublicacion);
                param.Add("@cIdPublicacion", oComentario.cIdPublicacion);
                param.Add("@nIdUsuario", oComentario.nIdUsuario);
                param.Add("@cComentario", oComentario.cComentario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int EliminarComentario(Comentario oComentario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_Comentario";
                var param = new DynamicParameters();
                param.Add("@cComentario", oComentario.cComentario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }



    }
}
