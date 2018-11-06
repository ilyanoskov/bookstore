using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Category
    {
        public int id { get; set; }
        public string genre { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }


    public class BookCategory
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}