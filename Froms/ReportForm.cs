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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockApp
{
    public partial class ReportForm : Form
    {
        private IHistoryService _historyService;

        private int CurrentStatus = 0;
        private DateTime? FilterDateFrom = null;
        private DateTime? FilterDateTo = null;
        public ReportForm(IHistoryService historyService)
        {
            _historyService = historyService;
            InitializeComponent();
        }

        private async void ReportForm_Load(object sender, EventArgs e)
        {
            FillHistoryTable(0);

            TPickerFrom.Format = DateTimePickerFormat.Time;
            TPickerFrom.ShowUpDown = true;
            TPickerTo.Format = DateTimePickerFormat.Time;
            TPickerTo.ShowUpDown = true;

            StatusFilter.SelectedIndex = 0;
        }

        private async void FillHistoryTable(int statusId)
        {
            List<History> lHistory = new List<History>();

            lHistory = await _historyService.GetHistoryElementsByFilter(statusId, FilterDateFrom, FilterDateTo);

            HistoryTable.Rows.Clear();

            foreach (var history in lHistory)
            {
                HistoryTable.Rows.Add(history.Product.Name, history.ToStatus.Name, history.DateCreated);
            }
        }

        private void FillStatusFilter()
        {
            StatusFilter.Items.Clear();
            StatusFilter.Items.Add(new ListViewItem("Все", 0));
            StatusFilter.Items.Add(new ListViewItem("Принят", 1));
            StatusFilter.Items.Add(new ListViewItem("На склад", 2));
            StatusFilter.Items.Add(new ListViewItem("Продан", 3));
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            FilterDateFrom = DPickerFrom.Value.Date + TPickerFrom.Value.TimeOfDay;
            FilterDateTo = DPickerTo.Value.Date + TPickerTo.Value.TimeOfDay;

            FillHistoryTable(StatusFilter.SelectedIndex);
        }
    }
}
