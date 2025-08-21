using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        return View("Index");
    }
    public IActionResult VerTareas(int IdUsuario){


        return View();
    }
     public IActionResult ModTareas(){
        return View();
    }
     public IActionResult ModTareasGuardar(){
        return View();
    }
     public IActionResult AgTareas(){
        return View();
    }
    public IActionResult AgTareasGuardar(){
        return View();
    }
    public IActionResult MosTarea(){
        return View();
    }
    public IActionResult ETarea(){
        return View();
    }
    public IActionResult ETareaGuardar(){
        return View();
    }
    public IActionResult VerTarea()
    {
        return View();
    }
    public IActionResult VerTareas(){
        return View();
    }
    public IActionResult FinTarea(){
        return View();
    }
    public IActionResult FinTareaGuardar(){
        return View();
    }
}
