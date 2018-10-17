using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;
using Bookstore1.Data;

namespace Bookstore1.Controllers
{
    public class ManagerController : Controller
    {

        // GET: Manager
        public async Task<IActionResult> Index()
        {
            return View();
        }

      
    }
}
