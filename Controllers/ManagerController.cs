using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;
using Bookstore1.Data;
using Microsoft.AspNetCore.Authorization;

namespace Bookstore1.Controllers
{
    public class ManagerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManagerController(ApplicationDbContext context) { _context = context; }
        // GET: Manager
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        //public async Task<IActionResult> DisplayUsers()
        //{
        //    return View(await _context.Users.ToListAsync());
        //}

    }
}
