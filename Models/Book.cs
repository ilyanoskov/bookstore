using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public int Pulication_year { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public string Resume { get; set; }
        public string Type { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
        public int Stock { get; set; }
    }
}