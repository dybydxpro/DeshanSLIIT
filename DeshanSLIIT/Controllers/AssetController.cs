using DeshanSLIIT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DeshanSLIIT.Controllers
{
    public class AssetController : Controller
    {
        private readonly AppDatabaseContexts _database;
        public AssetController(AppDatabaseContexts database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            IEnumerable<Asset> data = _database.Assets.ToList();
            return View(data);
        }

        public IActionResult Cart()
        {
            IEnumerable<Cart> data = _database.Carts.ToList();
            return View(data);
        }

        public IActionResult TransferTable()
        {
            IEnumerable<Transfer> data = _database.Transfers.ToList();
            return View(data);
        }

        public IActionResult TransferTableByID(int? id)
        {
            IEnumerable<Transfer> data = _database.Transfers.Where(r => r.TID == id).ToList();
            return View(data);
        }

        public IActionResult SetToCart(int? id)
        {
            var data = _database.Assets.Find(id);
            var obj = new Cart();
            obj.AssetID = data.Id;
            obj.Name = data.Name;
            obj.ISBN = data.ISBN;
            _database.Carts.Add(obj);
            _database.SaveChanges();
            return RedirectToAction("Index");
        }

        //Oparation
        public IActionResult TransferAssets(TransferDetails td)
        {
            IEnumerable<Cart> Cartobj = _database.Carts.ToList();
            if (Cartobj == null)
            {
                return NotFound();
            }

            int nextTID = MaxTID();
            foreach (var item in Cartobj)
            {
                int tempID = item.Id;
                var data = new Transfer();
                data.TID = nextTID;
                data.CartID = item.Id;
                data.Name = item.Name;
                data.ISBN = item.ISBN;
                data.Location = td.Location;
                data.Category = td.CatData.CategoryType;
                _database.Transfers.Add(data);
                _database.SaveChanges();
                Delete(tempID);
            }
            return RedirectToAction("Index");
        }

        //Oparation
        public IActionResult TransferAction()
        {
            List<Category> categories = _database.Categories.ToList();
            ViewBag.CategoryList = new SelectList(categories, "Id", "CategoryType");
            return View();
        }

        public void Delete(int? id)
        {
            var obj = _database.Carts.Find(id);
            _database.Carts.Remove(obj);
            _database.SaveChanges();
        }

        public int MaxTID()
        {
            var maxId = (_database.Transfers.Select(q => (int?)q.TID).Max() ?? 0) + 1;
            return maxId;
        }
    }
}
