using StockApp.Data;
using StockApp.Models;
using StockApp.Services.HistoryService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    public partial class CreateProductForm : Form
    {
        private IProductRepository _repository;
        private IHistoryService _historyService;
        public CreateProductForm(IProductRepository repository, IHistoryService historyService)
        {
            _repository = repository;
            _historyService = historyService;
            InitializeComponent();
        }

        private async void AcceptButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                var warn = new WarningForm("Имя товара не может быть пустым");
                warn.Show();
            }

            var product = new Product { Name = NameBox.Text, Description = DescriptionBox.Text, StatusId = 1 };

            await _historyService.CreateNewHistoryElement(_repository.GetNewId(), product.StatusId);
            await _historyService.SaveChanges();

            await _repository.CreateNew(product);
            await _repository.SaveChanges();

            Close();
        }
    }
}
