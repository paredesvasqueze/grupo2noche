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
    public class UsuarioRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public UsuarioRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Usuarios
        public IEnumerable<Usuario> ObtenerUsuarioTodos()
        {
            var Usuarios = new List<Usuario>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Usuario> lstFound = new List<Usuario>();
                var query = "USP_seeccionar_Usuario_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Usuario>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarUsuario(Usuario oUsuario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insertar_Usuario";
                var param = new DynamicParameters();
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cApellido", oUsuario.cApellido);
                param.Add("@cEmail", oUsuario.cEmail);
                param.Add("@nTelefono", oUsuario.nTelefono);
                param.Add("@cContrasena", oUsuario.cContrasena);
                param.Add("@cDireccion", oUsuario.cDireccion);
                param.Add("@nIdRol", oUsuario.nIdRol);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }

        public int ActualizarUsuario(Usuario oUsuario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Usuario";
                var param = new DynamicParameters();
                param.Add("@nIdUsuario", oUsuario.nIdUsuario);
                param.Add("@cNombre", oUsuario.cNombre);
                param.Add("@cApellido", oUsuario.cApellido);
                param.Add("@cEmail", oUsuario.cEmail);
                param.Add("@nTelefono", oUsuario.nTelefono);
                param.Add("@cContrasena", oUsuario.cContrasena);
                param.Add("@cDireccion", oUsuario.cDireccion);
                param.Add("@nIdRol", oUsuario.nIdRol);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int EliminarUsuario(Usuario oUsuario)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_Usuario";
                var param = new DynamicParameters();
                param.Add("@nIdUsuario", oUsuario.nIdUsuario);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }


    }
}
