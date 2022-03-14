using DeshanSLIIT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DeshanSLIIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllController : ControllerBase
    {
        private readonly AppDatabaseContexts _database;
        public AllController(AppDatabaseContexts database)
        {
            _database = database;
        }

        [HttpGet("getCatData")]
        public async Task<ActionResult<List<AppDatabaseContexts>>> CatForDropdown()
        {
            //IEnumerable<Category> data =await _database.Categories.ToListAsync();
            var data = await _database.Categories.Select(m => m.CategoryType).ToListAsync();
            return Ok(data);
        }
    }
}
