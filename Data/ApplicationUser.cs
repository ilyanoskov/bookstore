using Microsoft.AspNetCore.Identity;
using Bookstore.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace Bookstore.Data
{
    [Authorize(Roles = "Member")]
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public virtual ICollection<Book> Basket { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        override public string Email { get; set; }
        public string Address { get; set; }
        private string password { get; set; }
        private ICollection<Book> Purchase_History { get; set; }

    }
}