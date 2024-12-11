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
    public class AutorRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public AutorRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Autors
        public IEnumerable<Autor> ObtenerAutorTodos()
        {
            var Autors = new List<Autor>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Autor> lstFound = new List<Autor>();
                var query = "USP_seleccionar_Autor_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Autor>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "usp_Insertar_Autor";
                var param = new DynamicParameters();
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cNacionalidad", oAutor.cNacionalidad);
                param.Add("@cEspecialidad", oAutor.cEspecialidad);                
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }

        public int ActualizarAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Autor";
                var param = new DynamicParameters();
                param.Add("@nIdAutor", oAutor.nIdAutor);
                param.Add("@cNombre", oAutor.cNombre);
                param.Add("@cNacionalidad", oAutor.cNacionalidad);
                param.Add("@cEspecialidad", oAutor.cEspecialidad);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int EliminarAutor(Autor oAutor)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_Autor";
                var param = new DynamicParameters();
                param.Add("@nIdAutor", oAutor.nIdAutor);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }



    }
}
