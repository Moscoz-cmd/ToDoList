using Microsoft.Data.SqlClient;
using Dapper;
namespace ToDoList.Models;
// CONECTION STRING EN LA SIGUIENTE LINEA
// private static string_connectionString= @"Server=localhost; DataBase=NombreBase; Integrated Security=True; TrustServerCertificate=True;";
public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=NombreBase; Integrated Security=True; TrustServerCertificate=True;";



    public static Usuario Login(string Username, string Contraseña)
    {
        Usuario usuario= new Usuario();
        using(SqlConnection connection = new SqlConnection(_connectionString))

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
        if(usuTemp!=null)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query ="INSERT "+usu+" INTO Usuarios ";
            connection.Execute(query, new {pIdUsuario = usu.IdUsuario, pNombre=usu.Nombre, pUsername = usu.Username, pContraseña = usu.Contraseña, pApellido = usu.Apellido, pFoto = usu.Foto, pultimoLogin = usu.ultimoLogin});
        }
        }
    }
    public static void Atarea(Tareas tarea)
    {
        using(SqlConnection connection = new SqlConnection(_connectionString))

        {
            string query = "Insert "+tarea+"Into Tareas";
            connection.Execute(query, new{pIdTareas = tarea.IdTareas, pTitulo = tarea.Titulo, pDescripcion = tarea.Descripcion, pFecha = tarea.Fecha, pFinalizada = tarea.Finalizada});            

        }
        
    }

    public static void Mtarea(Tareas tarea)
    {

    }
    public static void Etarea(int Idtarea)
    {

    }

    public static Tareas Vtarea(int IdTarea)
    {Tareas tarea=null;

        return tarea;
    }
    public static List<Tareas> Vtareas(int IdUsuario)
    {
        List<Tareas>tareas=new List<Tareas>();
        return tareas;
    }
    public static void FinTarea(int IdTarea)
    {

    }
    public static void ActTarea(int IdUsuario)
    {

    }
}