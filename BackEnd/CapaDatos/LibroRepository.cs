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
    public class LibroRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public LibroRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Libros
        public IEnumerable<Libro> ObtenerLibroTodos()
        {
            var Libros = new List<Libro>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Libro> lstFound = new List<Libro>();
                var query = "USP_seleccionar_Libro_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Libro>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarLibro(Libro oLibro)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_Insertar_Libro";
                var param = new DynamicParameters();
                param.Add("@cTituloLibro ", oLibro.cTituloLibro);
                param.Add("@cEditorial", oLibro.cEditorial);
                param.Add("@nPaginas", oLibro.nPaginas);
                param.Add("@cIdioma", oLibro.cIdioma);
                param.Add("@nIdGenero", oLibro.nIdGenero);
                param.Add("@nIdPublicacion ", oLibro.nIdPublicacion);
                param.Add("@cIdPublicacion ", oLibro.cIdPublicacion);


              
                param.Add("@dFechaRegistro", oLibro.dFechaRegistro);
                param.Add("@cAutor", oLibro.cAutor);
                param.Add("@nIdArea", oLibro.nIdArea);

                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }


        public int ActualizarLibro(Libro oLibro)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Libro";
                var param = new DynamicParameters();
                param.Add("@nIdLibro", oLibro.nIdLibro);
                param.Add("@cTituloLibro ", oLibro.cTituloLibro);
                param.Add("@cEditorial", oLibro.cEditorial);
                param.Add("@nPaginas", oLibro.nPaginas);
                param.Add("@cIdioma", oLibro.cIdioma);
                param.Add("@nIdGenero", oLibro.nIdGenero);
                param.Add("@nIdPublicacion ", oLibro.nIdPublicacion);
                param.Add("@cIdPublicacion ", oLibro.cIdPublicacion);

                param.Add("@dFechaRegistro", oLibro.dFechaRegistro);
                param.Add("@cAutor", oLibro.cAutor);
                param.Add("@nIdArea", oLibro.nIdArea);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int EliminarLibro(Libro oLibro)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_Genero";
                var param = new DynamicParameters();
                param.Add("@nIdLibro", oLibro.nIdLibro);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

    }
}
