using MayaMobile.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace MayaMobile.Models
{
    public class RepositorioUsuario : IrepositorioUsuario
    {
        private readonly string connectionString;
        public RepositorioUsuario(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection").ToString();

        }

        //public async Task CrearUsuario(Usuario crearUsuario)
        //{

        //    using var connection = new SqlConnection(connectionString);
        //    await connection.ExecuteAsync("sp_RegistrarUsuario",
        //        connection,
        //        commandType: System.Data.CommandType.StoredProcedure);
        //}
    }
}
