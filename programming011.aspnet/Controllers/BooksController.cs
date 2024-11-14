using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

using programming011.aspnet.Entities;
using programming011.aspnet.Models;

namespace programming011.aspnet.Controllers
{
    public class BooksController : Controller
    {
        public static List<Book> _books = new List<Book>()
        {
            new Book
            {
                Id = 1,
                AuthorName = "Nadir Sefiyev",
                Genre = "Dram",
                Title = "Dawn of C#",
                ReleaseYear = 2024,
                CoverImage = "favicon.ico",
                Description = "Lorem ipsum",
                Pages = 200
            },
            new Book
            {
                Id = 2,
                AuthorName = "Zumrat Seriyev",
                Genre = "Adventure",
                Title = "The secret island",
                ReleaseYear = 1978,
                CoverImage = "favicon.ico",
                Description = "Lorem ipsum",
                Pages = 200
            },
            new Book
            {
                Id = 3,
                AuthorName = "Farman Isbatov",
                Title = "Ways of online courses",
                Genre = "Education",
                ReleaseYear = 2024,
                CoverImage = "favicon.ico",
                Description = "Lorem ipsum",
                Pages = 200
            }
        };

        [TempData]
        public bool FromAddBook { get; set; }

        public IActionResult Index(bool fromAddBook)
        {
            var models = _books.Select(x => new BookModel
            {
                Id = x.Id,
                AuthorName = x.AuthorName,
                Name = x.Title,
                Genre = x.Genre,
                ReleaseYear = x.ReleaseYear,
            }).ToList();

            //ViewBag.FromAddBook = fromAddBook;
            //ViewData["FromAddBook"] = TempData["FromAddBook"];

            //if (TempData.TryGetValue("FromAddBook", out var addBook))
            //{
            //    ViewBag.FromAddBook = addBook;
            //}
            //else
            //{
            //    ViewBag.FromAddBook = false;
            //}

            ViewBag.FromAddBook = FromAddBook;

            return View(models);
        }

        public IActionResult Details(int bookId)
        {
            var book = _books.FirstOrDefault(x => x.Id == bookId);

            var model = new BookDetailedModel
            {
                Id = book.Id,
                AuthorName = book.AuthorName,
                CoverImage = book.CoverImage,
                Description = book.Description,
                Genre = book.Genre,
                Pages = book.Pages,
                ReleaseYear = book.ReleaseYear,
                Title = book.Title,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(AddBookModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            Book b = new Book
            {
                AuthorName = model.AuthorName,
                Description = model.Description,
                Genre = model.Genre,
                Pages = model.Pages,
                Title = model.Title,
                ReleaseYear = model.PublishedDate.Year
            };

            b.Id = _books.Count + 1;

            _books.Add(b);

            //TempData["FromAddBook"] = true;
            FromAddBook = true;

            //return RedirectToAction("Index", new { fromAddBook = true });
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
