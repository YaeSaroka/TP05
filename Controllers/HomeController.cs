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
    public IActionResult Creditos()
    {
        return View("Creditos");
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
            sala= Escape.GetEstadoJuego();
            bool estado_juego= Escape.ResolverSala(sala, clave);
            if(sala==4&&estado_juego==false){
                ViewBag.Error=true;
                return View("victoria");
            }
            else if(estado_juego==true)
            {
                return View("Habitacion_"+Escape.GetEstadoJuego());
            }
            else 
            {
                ViewBag.Error=false;
                return View("Habitacion_"+Escape.GetEstadoJuego());
            }  
            
            
        }
    }

}
