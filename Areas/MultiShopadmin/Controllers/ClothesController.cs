using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.Areas.MultiShopadmin.Controllers
{
    [Area("MultiShopadmin")]

    public class ClothesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ClothesController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Clothes> model = 
                _context.Clothes.Include(p=>p.ClothesInformation)
                    .Include(p=>p.ClothesCategories)
                    .ThenInclude(u=>u.Category)
                    .Include(p=>p.ClothesImages).ToList();
            return View(model);
        }
    }
}
