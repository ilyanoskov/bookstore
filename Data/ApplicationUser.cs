using Microsoft.AspNetCore.Identity;

namespace Bookstore.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}