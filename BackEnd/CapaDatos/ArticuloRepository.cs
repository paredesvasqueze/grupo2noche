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
    public class ArticuloRepository
    {
        private readonly ConexionSingleton _conexionSingleton;

        // Constructor que recibe el singleton de conexión
        public ArticuloRepository(ConexionSingleton conexionSingleton)
        {
            _conexionSingleton = conexionSingleton;
        }

        // Método para obtener una lista de Articulos
        public IEnumerable<Articulo> ObtenerArticuloTodos()
        {
            var Articulos = new List<Articulo>();

            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                IEnumerable<Articulo> lstFound = new List<Articulo>();
                var query = "USP_seleccionar_Articulo_Todo";
                var param = new DynamicParameters();
                //param.Add("@nConstGrupo", nConstGrupo, dbType: DbType.Int32);
                lstFound = SqlMapper.Query<Articulo>(connection, query, param, commandType: CommandType.StoredProcedure);
                return lstFound;              
                
            }
        }

        public int InsertarArticulo(Articulo oArticulo)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();
                
                var query = "USP_insertar_Articulo";
                var param = new DynamicParameters();
                param.Add("@cTituloArticulo", oArticulo.cTituloArticulo);
                param.Add("@dFechaArticulo", oArticulo.dFechaArticulo);
                param.Add("@cTexto", oArticulo.cTexto);
                param.Add("@nVolumen", oArticulo.nVolumen);
                param.Add("@nIdPublicacion", oArticulo.nIdPublicacion);
                param.Add("@cIdPublicacion", oArticulo.cIdPublicacion);

                param.Add("@dFechaRegistro", oArticulo.dFechaRegistro);
                param.Add("@cAutor", oArticulo.cAutor);
                param.Add("@nIdArea", oArticulo.nIdArea);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);                
            }


        }


        public int ActualizarArticulo(Articulo oArticulo)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Actualizar_Articulo";
                var param = new DynamicParameters();
                param.Add("@nIdArticulo", oArticulo.nIdArticulo);
                param.Add("@cTituloArticulo", oArticulo.cTituloArticulo);
                param.Add("@dFechaArticulo", oArticulo.dFechaArticulo);
                param.Add("@cTexto", oArticulo.cTexto);
                param.Add("@nVolumen", oArticulo.nVolumen);
                param.Add("@nIdPublicacion", oArticulo.nIdPublicacion);
                param.Add("@cIdPublicacion", oArticulo.cIdPublicacion);

                param.Add("@dFechaRegistro", oArticulo.dFechaRegistro);
                param.Add("@cAutor", oArticulo.cAutor);
                param.Add("@nIdArea", oArticulo.nIdArea);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }

        public int EliminarArticulo(Articulo oArticulo)
        {
            using (var connection = _conexionSingleton.GetConnection())
            {
                connection.Open();

                var query = "USP_Eliminar_Articulo";
                var param = new DynamicParameters();
                param.Add("@nIdArticulo", oArticulo.nIdArticulo);
                return (int)SqlMapper.ExecuteScalar(connection, query, param, commandType: CommandType.StoredProcedure);
            }


        }



    }
}
