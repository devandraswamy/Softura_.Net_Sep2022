using Airwing.Models;
using Microsoft.AspNetCore.Mvc;

namespace Airwing.Controllers
{
    public class LoginController : Controller
    {
        private readonly AirwingdbContext db;
        private readonly ISession session;
        public LoginController(AirwingdbContext _db ,IHttpContextAccessor httpContextAccessor)  //constructor
        {
            db = _db;
            session = httpContextAccessor.HttpContext.Session;

        }
        public IActionResult Userlogin() //login
        {
            return View();
        }
        [HttpPost]

        public IActionResult Userlogin(Airwingusertb d) //Geeting input From the input tag
        {
            var log= (from i in db.Airwingusertbs//linq function used to select and cmd using in sql
                      where i.Userloginid == d.Userloginid && i.Password == d.Password
                      select i).SingleOrDefault();
            if (log != null)
            {
                HttpContext.Session.SetString("uname", d.Userloginid);
                return RedirectToAction("search", "Flight");
            }
            else
            {
                return View();
            }
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult register(Airwingusertb e)
        {
            db.Airwingusertbs.Add(e);
            db.SaveChanges();
            return RedirectToAction("userlogin");
        }
        //Scaffold-DbContext "Server=DESKTOP-DMQ8EIK\SQLEXPRESS;Database=Airwingdb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("userlogin");

        }
    }
}
