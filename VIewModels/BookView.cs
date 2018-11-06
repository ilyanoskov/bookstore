using System.Collections.Generic;
using System.Linq;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookstore.ViewModels
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<SelectListItem> AllCategories { get; set; }

        private List<int> _selectedCategories;
        public List<int> SelectedCategogies
        {
            get
            {
                if (_selectedCategories == null)
                {
                    _selectedCategories = Book.BookCategories.Select(m => m.BookId).ToList();
                }
                return _selectedCategories;
            }
            set { _selectedCategories = value; }
        }
    }
}