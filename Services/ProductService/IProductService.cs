using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Services.ProductService
{
    public interface IProductService
    {
        public Task ChangeProductStatus(int productId);
    }
}
