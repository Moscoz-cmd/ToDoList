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
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "Update Tareas where tarea = @ptarea";
            tarea = connection.QueryFirstOrDefault<Tareas>(query, new {pIdTareas = tarea.IdTareas, pTitulo = tarea.Titulo, pDescripcion = tarea.Descripcion, pFecha = tarea.Fecha, pFinalizada = tarea.Finalizada});
        }
    }
    public static void Etarea(int IdTarea)
    {   
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "Delete From Tareas where IdTarea = @pIdtarea";
            connection.Execute(query, new {IdTarea});
        }
    }

    public static Tareas Vtarea(int IdTarea)
    {   Tareas tarea=null;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Tareas WHERE IdTarea = @pIdTarea ";
            tarea = connection.QueryFirstOrDefault<Tareas>(query, new {pIdTareas = tarea.IdTareas, pTitulo = tarea.Titulo, pDescripcion = tarea.Descripcion, pFecha = tarea.Fecha, pFinalizada = tarea.Finalizada});

        }
        return tarea;
    }
    public static List<Tareas> Vtareas(int IdUsuario)
    {
        List<Tareas>tareas=new List<Tareas>();
        string query = "SELECT * from Tareas where IdUsuario = @pIdUsuario";
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            tareas = connection.Query<List<Tareas>>(query, new{pIdUsuario = IdUsuario});
        }
        return tareas;
    }
    public static void FinTarea(int IdTarea)
    {
        using(SqlConnection connection = new SqlConnection(_connectionString))

        {
            string query = "Update Finalizada FROM Tareas where IdTarea= @pIdTarea ";
            connection.Execute(query, new {pIdTarea = IdTarea});
        }
    }
}