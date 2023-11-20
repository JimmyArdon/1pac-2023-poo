using ClinicaOptica.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ClinicaOptica.Servicios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly string connectionString;
        public RepositorioUsuario(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection").ToString();

        }

        public async Task Cita(Usuario cita)
        {

            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                (@"INSERT INTO Cita
           (Nombre ,Apellido ,Edad ,Email, NumeroTelefono, FechaCita, Clinica, Doctor)
                VALUES
           (@Nombre ,@Apellido ,@Edad, @Email, @NumeroTelefono, @FechaCita, @Clinica, @Doctor); 
            SELECT SCOPE_IDENTITY()",
            cita);
        }


    }
}
