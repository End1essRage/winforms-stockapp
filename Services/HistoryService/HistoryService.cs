using Microsoft.EntityFrameworkCore;
using StockApp.Data;
using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Services.HistoryService
{
    public class HistoryService : IHistoryService
    {
        private DataContext _context;

        public HistoryService(DataContext context)
        {
            _context = context;
        }
        public async Task CreateNewHistoryElement(int productId, int statusId)
        {
            var history = new History() { ProductId = productId, ToStatusId = statusId, DateCreated = DateTime.Now };
            await _context.History.AddAsync(history);
        }

        public async Task<List<History>> GetHistoryElementsByFilter(int statusId, DateTime? from, DateTime? to)
        {
            IQueryable<History> query;

            if(statusId == 0)
                query = _context.History.Where(c => c.ToStatusId != statusId);
            else
                query = _context.History.Where(c => c.ToStatusId == statusId);


            if (from != null)
                query = query.Where(c => c.DateCreated >= from);
            if (to != null)
                query = query.Where(c => c.DateCreated <= to);

            return query.Include(p => p.Product).Include(s => s.ToStatus).OrderBy(x => x.DateCreated).ToList();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
