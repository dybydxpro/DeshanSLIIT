using DeshanSLIIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeshanSLIIT.Controllers
{
    public class TestController : Controller
    {
        private readonly AppDatabaseContexts _database;
        public TestController(AppDatabaseContexts database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            IEnumerable<Test> test = _database.Tests.ToList();
            return View(test);
        }
    }
}
