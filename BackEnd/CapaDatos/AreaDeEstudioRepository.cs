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
    public class AreaDeEstudioRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public AreaDeEstudioRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de AreaDeEstudioss
        public IEnumerable<AreaDeEstudio> ObtenerAreaDeEstudioTodos()
        {
            var AreaDeEstudioss = new List<AreaDeEstudio>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<AreaDeEstudio> lstFound = new List<AreaDeEstudio>();
                var query = "USP_seleccionar_AreaDeEstudio_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<AreaDeEstudio>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insertar_AreaDeEstudio";
                var param = new DynamicParameters();
                param.Add("@cAreadeEstudio", oAreaDeEstudio.cAreadeEstudio);
                param.Add("@cDescripcion ", oAreaDeEstudio.cDescripcion);
                param.Add("@cImagen", oAreaDeEstudio.cImagen);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }

        public int ActualizarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_AreaDeEstudio";
                var param = new DynamicParameters();
                param.Add("@nIdArea", oAreaDeEstudio.nIdArea);
                param.Add("@cAreadeEstudio", oAreaDeEstudio.cAreadeEstudio);
                param.Add("@cDescripcion ", oAreaDeEstudio.cDescripcion);
                param.Add("@cImagen", oAreaDeEstudio.cImagen);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }


        public int EliminarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_AreaDeEstudio";
                var param = new DynamicParameters();
                param.Add("@nIdArea", oAreaDeEstudio.nIdArea);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public IEnumerable<AreaDeEstudio> ObtenerAreaDeEstudioTodo()
        {
            throw new NotImplementedException();
        }
    }
}
