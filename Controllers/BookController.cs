using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyFirstProject.Data;
using MyFirstProject.Models;

namespace MyFirstProject.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Book> ObjBookList = _db.Book.ToList();
           return View(ObjBookList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book) {
            
            if (ModelState.IsValid)  {
                _db.Book.Add(book);
                _db.SaveChanges();
                TempData["sucess"] = "created sucessfully";
                return RedirectToAction("Index", "Book");
            }
            return View();

            
        }
        public IActionResult Edit( int Id)
        {
            if (Id == null || Id == 0 ) {
                return NotFound();
            }
            Book book = _db.Book.Find(Id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
          
            if (ModelState.IsValid)
            {
                _db.Book.Update(book);
                _db.SaveChanges();
                TempData["sucess"] = "updated sucessfully";
                return RedirectToAction("Index", "Book");
            }
            return View();


        }
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            Book book = _db.Book.Find(Id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteId(int? id)
        {
            Book book = _db.Book.Find(id);
           if (book == null)
            {
                return NotFound();
            }
                _db.Book.Remove(book);
                _db.SaveChanges();
            TempData["sucess"] = "deleted sucessfully";
            return RedirectToAction("Index", "Book");
            
            


        }




    }


    }

