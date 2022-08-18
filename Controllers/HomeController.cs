using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using views.Models;
using QQSM.Models;

namespace QQSM.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Player()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Jugar(string nombre)
    {
        JuegoQQSM.IniciarJuego(nombre);
        ViewBag.PreguntaActual = JuegoQQSM.ObtenerProximaPregunta();
        ViewBag.RespuestaActual = JuegoQQSM.ObtenerRespuestas();
        ViewBag.Player = JuegoQQSM.DevolverJugador();
        ViewBag.ListaPozo = JuegoQQSM.ListarPozo();
        return View("Pregunta");
    }

     public IActionResult FinDelJuego()
     {
        ViewBag.infoPlayer = JuegoQQSM.DevolverJugador();
        ViewBag.pozoGanado = JuegoQQSM.ListarPozo();
        return View("PantallaFindelJuego");
     }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
