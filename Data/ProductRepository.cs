using Microsoft.EntityFrameworkCore;
using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockApp.Data
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task CreateNew(Product product)
        {
            await _context.Products.AddAsync(product);        
        }

        public async Task DeleteById(int id)
        {
            var product = await GetById(id);
            _context.Products.Remove(product);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.Include(p => p.Status).ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.Include(p => p.Status).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetListByStatus(int statusId)
        {
            return await _context.Products.Include(p => p.Status).Where(p => p.StatusId == statusId).ToListAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public int GetNewId()
        {
            int maxId = _context.Products.Max(p => p.Id);
            return ++maxId;
        }
    }
}
