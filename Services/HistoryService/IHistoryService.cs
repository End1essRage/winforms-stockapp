using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Services.HistoryService
{
    public interface IHistoryService
    {
        Task CreateNewHistoryElement(int productId, int statusId);
        Task<List<History>> GetHistoryElementsByFilter(int statusId, DateTime? from, DateTime? to);
        Task SaveChanges();
    }
}
