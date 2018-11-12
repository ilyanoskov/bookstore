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
        public ICollection<Book> Books { get; set; }
    }
}