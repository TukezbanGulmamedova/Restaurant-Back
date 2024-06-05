using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restaurant.Data;
using restaurant.ViewModels;

namespace restaurant.Controllers
{
    public class ProductController:Controller
    {

        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Product()
        {
           var products=(await _context.Products
                .Include(x=>x.Category)
                .Include(x => x.ProductImages)
                .OrderByDescending(x => x.Id).Take(20).ToListAsync());
            var categories = await _context.Categories.Include(x => x.Products).ToListAsync();

            ProductVm productVm = new ProductVm()
            {
                Products = products,
                Categories = categories
            };
            return View(productVm);  
        }

    }
}
