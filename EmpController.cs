using Microsoft.AspNetCore.Mvc;
using Mvctask.Models;

namespace Mvctask.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Singleemp()
        {
            List<Empdata> list1 = Empdata.getsingle();
            return View(list1);
        }

        public IActionResult Allemp()
        {
            List<Empdata> list=Empdata.Getallempdata();
            return View(list);
        }

        public IActionResult insertdata()
        {
            return View();
        }
    }
}
