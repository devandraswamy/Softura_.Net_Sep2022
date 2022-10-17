using Airwing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Airwing.Controllers
{
    public class FlightController : Controller
    {
        private readonly AirwingdbContext db;
        public FlightController(AirwingdbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> search(string searchString ,string searchString2)
        {
            var movies = from m in db.Flightdatatbs
                         select m;

            if (!String.IsNullOrEmpty(searchString)&& !String.IsNullOrEmpty(searchString2))
            {
                movies = movies.Where(s => s.Flightfrom!.Contains(searchString));
                    movies.Where(d2=>d2.Flightto!.Contains(searchString2));
               
            }
            
                return View(movies.ToList());
            
            
        }

        public IActionResult searchform()
        {
            return View();
        }
        [HttpPost]
        public IActionResult searchform(Flightdatatb ft)
        {
            var data = (from i in db.Flightdatatbs
                        where i.Flightfrom == ft.Flightfrom && i.Flightto == ft.Flightto
                        select i).SingleOrDefault();
            if (data != null)
            {
                
                return RedirectToAction("search", "Flight");
            }
            else
            {
                return View();
            }

            return View();
        }

        public IActionResult details(int id)
        {
            Flightdatatb e = db.Flightdatatbs.Find(id);
            return View(e);
        }

        //public IActionResult payment(int seats)
        //{
        //    //var pay=(from i in db.Flightdatatbs
        //    //         where i.FlightSeats.                  )

        //    var movies = from m in db.Flightdatatbs
                        
        //    return View();
        //}

        public IActionResult airtd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult airtd( Flightdatatb e)
        {
            db.Flightdatatbs.Add(e);
            db.SaveChanges();
            return RedirectToAction("userlogin");
        }
        public IActionResult payment()
        {
            return View();
        }

    }
}
