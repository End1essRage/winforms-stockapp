namespace StockApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            ProductTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Button = new DataGridViewButtonColumn();
            AcceptedButtom = new Button();
            StockedButton = new Button();
            SoldButton = new Button();
            AddProductButton = new Button();
            ReportButton = new Button();
            productBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ProductTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ProductTable
            // 
            ProductTable.AllowUserToAddRows = false;
            ProductTable.AllowUserToDeleteRows = false;
            ProductTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductTable.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Description, Status, Button });
            ProductTable.Location = new Point(12, 41);
            ProductTable.Name = "ProductTable";
            ProductTable.ReadOnly = true;
            ProductTable.RowTemplate.Height = 25;
            ProductTable.Size = new Size(543, 334);
            ProductTable.TabIndex = 0;
            ProductTable.CellClick += ProductTable_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Описание";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Button
            // 
            Button.HeaderText = "В следущий статус";
            Button.Name = "Button";
            Button.ReadOnly = true;
            // 
            // AcceptedButtom
            // 
            AcceptedButtom.Location = new Point(12, 12);
            AcceptedButtom.Name = "AcceptedButtom";
            AcceptedButtom.Size = new Size(75, 23);
            AcceptedButtom.TabIndex = 1;
            AcceptedButtom.Text = "Принят";
            AcceptedButtom.UseVisualStyleBackColor = true;
            AcceptedButtom.Click += AcceptedButtom_Click;
            // 
            // StockedButton
            // 
            StockedButton.Location = new Point(93, 12);
            StockedButton.Name = "StockedButton";
            StockedButton.Size = new Size(75, 23);
            StockedButton.TabIndex = 2;
            StockedButton.Text = "На склад";
            StockedButton.UseVisualStyleBackColor = true;
            StockedButton.Click += StockedButton_Click;
            // 
            // SoldButton
            // 
            SoldButton.Location = new Point(174, 12);
            SoldButton.Name = "SoldButton";
            SoldButton.Size = new Size(75, 23);
            SoldButton.TabIndex = 3;
            SoldButton.Text = "Продан";
            SoldButton.UseVisualStyleBackColor = true;
            SoldButton.Click += SoldButton_Click;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(614, 352);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(111, 23);
            AddProductButton.TabIndex = 4;
            AddProductButton.Text = "Добавить товар";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // ReportButton
            // 
            ReportButton.Location = new Point(630, 312);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(75, 23);
            ReportButton.TabIndex = 5;
            ReportButton.Text = "Отчет";
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += ReportButton_Click;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 410);
            Controls.Add(ReportButton);
            Controls.Add(AddProductButton);
            Controls.Add(SoldButton);
            Controls.Add(StockedButton);
            Controls.Add(AcceptedButtom);
            Controls.Add(ProductTable);
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductTable;
        private Button AcceptedButtom;
        private Button StockedButton;
        private Button SoldButton;
        private Button AddProductButton;
        private Button ReportButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Button;
        private BindingSource productBindingSource;
    }
}