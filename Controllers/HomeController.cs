using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bookstore.Data;
using System.Diagnostics;
using Bookstore.Models;
using PagedList.Core;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? CategoryId, string currentFilter, string searchString, int page = 1, int pageSize = 10)
        {
            PagedList<Bookstore.Models.Book> model;
            if (CategoryId == null)
            {
                 model = new PagedList<Bookstore.Models.Book>(_context.Book, page, pageSize);
                
            } else
            {
                model = new PagedList<Bookstore.Models.Book>(_context.Book.Where((arg) => arg.CategoryId == CategoryId), page, pageSize);
            }                

            //Search
                if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var books = from s in _context.Book
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Title.Contains(searchString)
                                       || s.Author.Contains(searchString));
                var books_model = new PagedList<Bookstore.Models.Book>(books, page, pageSize);
                return View("Index", books_model);
            }

            return View("Index", model);
        }

        public IActionResult Basket()
        {
            ViewData["Message"] = "Your Basket page";
            return View();
        }

        public IActionResult Purchase()
        {
            ViewData["Message"] = "Your Purchase page";
            return View();
        }




        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        //{
        //    ViewBag.CurrentSort = sortOrder;
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        //    ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

        //    // Search

        //    if (searchString != null)
        //    {
        //        page = 1;
        //    }
        //    else
        //    {
        //        searchString = currentFilter;
        //    }

        //    ViewBag.CurrentFilter = searchString;

        //    var books = from s in _context.Book
        //                select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        books = books.Where(s => s.Title.Contains(searchString)
        //                               || s.Author.Contains(searchString));
        //    }            
        //    switch (sortOrder)
        //    {
        //        case "name_desc":
        //            books = books.OrderByDescending(s => s.Title);
        //            break;
        //        case "Date":
        //            books = books.OrderBy(s => s.Price);
        //            break;
        //        case "date_desc":
        //            books = books.OrderByDescending(s => s.Price);
        //            break;
        //        default:  // Name ascending 
        //            books = books.OrderBy(s => s.Title);
        //            break;
        //    }

        //    //int pageSize = 10;
        //    //int pageNumber = (page ?? 1);
        //    //return View(books.ToPagedList(pageNumber, pageSize));
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
