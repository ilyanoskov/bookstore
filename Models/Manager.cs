using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Manager
    {
        public int id { get; set; }
        public string name { get; set; }
        private string password { get; set; }
        private string email { get; set; }
    }
}