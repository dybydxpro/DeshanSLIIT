using DeshanSLIIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeshanSLIIT.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDatabaseContexts _database;
        public AuthController(AppDatabaseContexts database)
        {
            _database = database;
        }

        public IActionResult Index(Auth obj)
        {
            var user = _database.Auths.FirstOrDefault(x => x.Email == obj.Email && x.Password == obj.Password);
            HttpContext.Session.SetString("name", user.Name);
            if(user == null)
            {
                return View("Index");
            }
            else
            {
                ViewData["Message"] = HttpContext.Session.GetString("name");
                return View("Index1");
            }
        }

        public IActionResult Login()
        {
            return View("Index");
        }

    }
}
