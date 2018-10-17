using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Microsoft.AspNetCore.Authorization;

namespace Bookstore1.Models
{
    [Authorize(Roles = "Member")]
    public class Customer : IdentityUser
    {
        //public int id { get; set; }
        private List<Book> Basket { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        override public string Email { get; set; }
        public string Address { get; set; }
        private string password { get; set; }
        private List<Book> Purchase_History { get; set; }
    }
}
