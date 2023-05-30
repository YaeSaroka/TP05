using Microsoft.AspNetCore.Mvc;

namespace TP05.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
    public IActionResult Comenzar()
    {
        ViewBag.estadoJuego = Escape.GetEstadoJuego();
        return View("Habitacion_" + Escape.GetEstadoJuego());
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala != Escape.GetEstadoJuego()) return View("Habitacion_"+Escape.GetEstadoJuego());
        else
        {
            bool estado_juego= Escape.ResolverSala(sala, clave);
            if(sala ==4 && estado_juego==true){
                return View("victoria");
            }
            if(estado_juego==true) return View("Habitacion_"+Escape.GetEstadoJuego());
            else 
            {
                ViewBag.Error="LA CLAVE ES INCORRECTA :(";
            return View("Habitacion_"+Escape.GetEstadoJuego());
            }  
        }
    }
}
