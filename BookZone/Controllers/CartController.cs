using BookZone.Data;
using BookZone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookZone.Controllers
{
    public class CartController : Controller
    {

        private readonly AppDbContext _db;

        public CartController(AppDbContext db)
        {
            _db = db;

        }
        public ActionResult Index()
        {
            ViewBag.WarningMessage = "Are you sure you want to proceed? This action may have consequences.";
            return View();
          return View();
        }

        public IActionResult BookAdder(int id)
        {

            //var selectedBook = _db.Books.Include(a => a.Author).FirstOrDefault(a => a.Id == Id);
            //var AddedBooks = new List<Book>();
            //AddedBooks.Add(selectedBook);
            return View();
        }
    }
}
