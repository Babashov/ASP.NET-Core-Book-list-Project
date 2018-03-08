using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookList.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Books.ToList());
        }
        //GET : Book/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST : Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Add(book);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
        //GET : Book/Details/5
        public async Task<IActionResult> Details(int?id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var Book = await _db.Books.SingleOrDefaultAsync(m => m.ID == id);

            if(Book == null)
            {
                return NotFound();
            }
            return View(Book);
        }

        //GET : Book/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var Book = await _db.Books.SingleOrDefaultAsync(m => m.ID == id);

            if(Book == null)
            {
                return NotFound();
            }
            return View(Book);
        }
        //POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Book book)
        {
            if(id != book.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(book);
               await _db.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
        //GET : Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var Book = await _db.Books.SingleOrDefaultAsync(m => m.ID == id);

            if(Book == null)
            {
                return NotFound();
            }

            return View(Book);
        }
        //Post : Books/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(int?id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var Book = await _db.Books.SingleOrDefaultAsync(m => m.ID == id);
            if(Book == null)
            {
                return NotFound();
            }
            _db.Books.Remove(Book);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
         
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                _db.Dispose();
            }
        }
    }
}