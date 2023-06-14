namespace StockApp
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HistoryTable = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            StatusFilter = new ComboBox();
            DPickerFrom = new DateTimePicker();
            DPickerTo = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            TPickerFrom = new DateTimePicker();
            TPickerTo = new DateTimePicker();
            ApplyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)HistoryTable).BeginInit();
            SuspendLayout();
            // 
            // HistoryTable
            // 
            HistoryTable.AllowUserToAddRows = false;
            HistoryTable.AllowUserToDeleteRows = false;
            HistoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryTable.Columns.AddRange(new DataGridViewColumn[] { Product, Status, DateTime });
            HistoryTable.Location = new Point(24, 100);
            HistoryTable.Name = "HistoryTable";
            HistoryTable.ReadOnly = true;
            HistoryTable.RowTemplate.Height = 25;
            HistoryTable.Size = new Size(409, 443);
            HistoryTable.TabIndex = 0;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // DateTime
            // 
            DateTime.HeaderText = "DateTime";
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            DateTime.Width = 130;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(453, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // StatusFilter
            // 
            StatusFilter.FormattingEnabled = true;
            StatusFilter.Items.AddRange(new object[] { "Все", "Принят", "На складе", "Продан" });
            StatusFilter.Location = new Point(24, 42);
            StatusFilter.Name = "StatusFilter";
            StatusFilter.Size = new Size(121, 23);
            StatusFilter.TabIndex = 2;
            // 
            // DPickerFrom
            // 
            DPickerFrom.Location = new Point(160, 42);
            DPickerFrom.Name = "DPickerFrom";
            DPickerFrom.Size = new Size(128, 23);
            DPickerFrom.TabIndex = 3;
            // 
            // DPickerTo
            // 
            DPickerTo.Location = new Point(303, 42);
            DPickerTo.Name = "DPickerTo";
            DPickerTo.Size = new Size(130, 23);
            DPickerTo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 24);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 5;
            label1.Text = "От";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 24);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 6;
            label2.Text = "До";
            // 
            // TPickerFrom
            // 
            TPickerFrom.Location = new Point(160, 71);
            TPickerFrom.Name = "TPickerFrom";
            TPickerFrom.Size = new Size(84, 23);
            TPickerFrom.TabIndex = 7;
            // 
            // TPickerTo
            // 
            TPickerTo.Location = new Point(303, 71);
            TPickerTo.Name = "TPickerTo";
            TPickerTo.Size = new Size(83, 23);
            TPickerTo.TabIndex = 8;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(24, 73);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(121, 23);
            ApplyButton.TabIndex = 9;
            ApplyButton.Text = "Применить";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 561);
            Controls.Add(ApplyButton);
            Controls.Add(TPickerTo);
            Controls.Add(TPickerFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DPickerTo);
            Controls.Add(DPickerFrom);
            Controls.Add(StatusFilter);
            Controls.Add(HistoryTable);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)HistoryTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HistoryTable;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DateTime;
        private MenuStrip menuStrip1;
        private ComboBox StatusFilter;
        private DateTimePicker DPickerFrom;
        private DateTimePicker DPickerTo;
        private Label label1;
        private Label label2;
        private DateTimePicker TPickerFrom;
        private DateTimePicker TPickerTo;
        private Button ApplyButton;
    }
}