using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;
using MultiShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Shop()
        {
            List<Clothes> clothes = _context.Clothes.Include(c => c.ClothesInformation).Include(c => c.ClothesImages).Include(c => c.ClothesCategories).ToList();
            return View(clothes);
        }
    }
}
