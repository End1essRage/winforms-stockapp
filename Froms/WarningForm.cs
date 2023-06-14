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
    public partial class WarningForm : Form
    {
        private string WarningText = string.Empty;
        public WarningForm(string warnText)
        {
            WarningText = warnText;
            InitializeComponent();
        }

        private void WarningForm_Load(object sender, EventArgs e)
        {
            WarningLabel.Text = WarningText;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
