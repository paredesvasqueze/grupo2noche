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
    public class RolRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public RolRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Rols
        public IEnumerable<Rol> ObtenerRolTodos()
        {
            var Rols = new List<Rol>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Rol> lstFound = new List<Rol>();
                var query = "USP_seleccionar_Rol_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Rol>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarRol(Rol oRol)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insertar_Rol";
                var param = new DynamicParameters();
                param.Add("@cTipodeRol", oRol.cTipodeRol);             
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }


        public int ActualizarRol(Rol oRol)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Rol";
                var param = new DynamicParameters();
                param.Add("@nIdRol", oRol.nIdRol);
                param.Add("@cTipodeRol", oRol.cTipodeRol);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

         public int EliminarRol(Rol oRol)
         {
              using (var connection = _conexionSingleton.GetConnection())
              {
                   connection.Open();

                   var query = "USP_Eliminar_Rol";
                   var param = new DynamicParameters();
                   param.Add("@nIdRol", oRol.nIdRol);
                   return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
              }


         }


    }
}
