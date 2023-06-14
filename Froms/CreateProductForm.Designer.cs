namespace StockApp
{
    partial class CreateProductForm
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
            NameBox = new TextBox();
            NameLabel = new Label();
            DescriptionLabel = new Label();
            DescriptionBox = new TextBox();
            AcceptButton = new Button();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(138, 87);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(197, 23);
            NameBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 87);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(59, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Название";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(12, 131);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(62, 15);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "Описание";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(138, 131);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(197, 23);
            DescriptionBox.TabIndex = 3;
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(122, 213);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(140, 23);
            AcceptButton.TabIndex = 4;
            AcceptButton.Text = "Accept";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 248);
            Controls.Add(AcceptButton);
            Controls.Add(DescriptionBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameBox);
            Name = "CreateProductForm";
            Text = "CreateProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox NameBox;
        private Label NameLabel;
        private Label DescriptionLabel;
        private TextBox DescriptionBox;
        private Button AcceptButton;
    }
}