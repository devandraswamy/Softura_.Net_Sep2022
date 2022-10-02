using Microsoft.AspNetCore.Mvc;
using demo.Models;

namespace demo.Controllers
{
    public class welcomeController : Controller
    {
        public  string game(string name,int id=1)
        {
            return ($"Im Welcome {name} Controller {id}");
        }

        public IActionResult Details(string name, int visttime=1)
        {
            ViewData["n"] = "Welcome "+name;
            ViewData["vt"]= visttime;
            return View();
        }   
        public IActionResult info()
        {
            data d = new data();
            d.Name = "Devandarsawmy";
            d.Id = 5;
            d.Location = "Tamilnadu";
            return View(d);
        }

    }
}
