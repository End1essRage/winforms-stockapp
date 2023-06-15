using Autofac;
using Autofac.Core;
using StockApp.Data;
using StockApp.Models;
using StockApp.Services.HistoryService;
using StockApp.Services.ProductService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockApp
{
    public partial class MainForm : Form
    {
        private IProductRepository _repository;
        private IProductService _service;
        private Autofac.IContainer _container;
        private int currentStatusId = 1;
        public MainForm(Autofac.IContainer container)
        {
            _repository = container.Resolve<IProductRepository>();
            _service = container.Resolve<IProductService>();
            _container = container;
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private async void FillTable()
        {
            _repository = _container.Resolve<IProductRepository>();
            var products = await _repository.GetListByStatus(currentStatusId);

            ProductTable.Rows.Clear();
            ProductTable.Columns[4].Visible = currentStatusId == 3 ? false : true;

            foreach (var product in products)
            {
                ProductTable.Rows.Add(product.Id, product.Name, product.Description, product.Status.Name);
            }

            (ProductTable.Columns[4] as DataGridViewButtonColumn).Text = currentStatusId == 1 ? "На склад" : "Продать";
            (ProductTable.Columns[4] as DataGridViewButtonColumn).UseColumnTextForButtonValue = true;

        }

        private async void AcceptedButtom_Click(object sender, EventArgs e)
        {
            currentStatusId = 1;
            FillTable();
        }

        private async void StockedButton_Click(object sender, EventArgs e)
        {
            currentStatusId = 2;
            FillTable();
        }

        private async void SoldButton_Click(object sender, EventArgs e)
        {
            currentStatusId = 3;
            FillTable();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            CreateProductForm form = new CreateProductForm(_repository, _container.Resolve<IHistoryService>());

            form.Show();
            form.FormClosed += OnFormClosed;
        }

        public void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            FillTable();
        }

        private async void ProductTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductTable.Columns[Math.Abs(e.ColumnIndex)] is DataGridViewButtonColumn)
            {
                int productId = (int)ProductTable.Rows[e.RowIndex].Cells[0].Value;

                await _service.ChangeProductStatus(productId);

                FillTable();

                WarningForm warn = new WarningForm("Status changed successfully");
                warn.Show();
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm(_container.Resolve<IHistoryService>());
            rf.Show();
        }
    }
}
