using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Data
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAll(); 
        public Task<List<Product>> GetListByStatus(int statusId);
        public Task<Product> GetById(int id);
        public Task CreateNew(Product product);
        public Task DeleteById(int id);
        public Task Update(Product product);
        public Task SaveChanges();
        public int GetNewId();
    }
}
