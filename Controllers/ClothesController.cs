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
    public class ClothesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClothesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            Clothes clothes = await _context.Clothes.Include(p => p.ClothesImages)
                .Include(p => p.ClothesInformation).Include(p => p.ClothesCategories).ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

            ViewBag.Clothes = await _context.Clothes.Include(p => p.ClothesImages).ToListAsync();
            if (clothes is null) return NotFound();
            return View(clothes);

        }
    }
}
