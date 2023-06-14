using Microsoft.EntityFrameworkCore;
using StockApp.Data;
using StockApp.Models;
using StockApp.Services.HistoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Services.ProductService
{
    public class ProductService : IProductService
    {
        private IHistoryService _historyService;
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository, IHistoryService historyService) 
        {
            _productRepository = productRepository;
            _historyService = historyService;
        }

        public async Task ChangeProductStatus(int productId)
        {
            var product = await _productRepository.GetById(productId);
            product.StatusId++;

            await _historyService.CreateNewHistoryElement(productId, product.StatusId);
            await _historyService.SaveChanges();

            await _productRepository.Update(product);
            await _productRepository.SaveChanges();
        }
    }
}
