using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Snacks.Data;
using Snacks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Snacks.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SnacksContext db;  
        public IndexModel(SnacksContext db) => this.db = db;
        public List<Product> Products { get; set; } = new List<Product>();  
        public Product FeaturedProduct { get; set; }  
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
        }
    }
}
