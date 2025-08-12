using Microsoft.Data.SqlClient;
using Dapper;
namespace ToDoList.Models;
// CONECTION STRING EN LA SIGUIENTE LINEA
// private static string_connectionString= @"Server=localhost; DataBase=NombreBase; Integrated Security=True; TrustServerCertificate=True;";
public static class BD
{
    private static string_connectionString == @"Server=localhost; DataBase=NombreBase; Integrated Security=True; TrustServerCertificate=True;";



    public static Usuario Login(string Username, string Contraseña)
    {
        Usuario usuario= new Usuario();
        using(SqlConnection connection = new SqlConnection(string_connectionString))

        {
            string query = "SELECT * FROM Usuario WHERE Username = @pUsername AND Contraseña = @pContraseña";
            usuario = connection.QueryFirstOrDefault<Usuario>(query, new { pUsername = Username, pContraseña = Contraseña });

        }
        return usuario;
    }
    public static void Registro(Usuario usu)
    {
        Usuario usuTemp=usu;
          using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query ="Select * from Usuario where Username = @pusuTemp.Username";
            usu = connection.QueryFirstOrDefault<Usuario>(query, new{pUsername=usuTemp.Username});
        }
        if(usuTemp==null)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
        {//Juanma haceme el insert porfis
            string query ="INSERT INTO Usuarios ";
        }
        }
    }
    public static void Atarea()
    {

        
    }

}