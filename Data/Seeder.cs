using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Data
{
    public class Seeder
    {
        private DataContext _context;

        public Seeder(DataContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            _context.Statuses.Add(new StockApp.Models.Status { Name = "Принят" });
            _context.Statuses.Add(new StockApp.Models.Status { Name = "На склад" });
            _context.Statuses.Add(new StockApp.Models.Status { Name = "Продан" });

            _context.Products.Add(new Product { Name = "Name1", Description = "Description1", StatusId = 1 });
            _context.Products.Add(new Product { Name = "Name2", Description = "Description2", StatusId = 2 });
            _context.Products.Add(new Product { Name = "Name3", Description = "Description3", StatusId = 2 });
            _context.Products.Add(new Product { Name = "Name4", Description = "Description4", StatusId = 1 });
            _context.Products.Add(new Product { Name = "Name5", Description = "Description5", StatusId = 3 });

            _context.SaveChangesAsync();
        }
    }
}
