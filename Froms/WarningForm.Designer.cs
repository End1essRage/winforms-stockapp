﻿namespace StockApp
{
    partial class WarningForm
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
            WarningLabel = new Label();
            OkButton = new Button();
            SuspendLayout();
            // 
            // WarningLabel
            // 
            WarningLabel.AutoSize = true;
            WarningLabel.Location = new Point(85, 51);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(131, 15);
            WarningLabel.TabIndex = 0;
            WarningLabel.Text = "label1label1label1label1";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(115, 106);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // WarningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 141);
            Controls.Add(OkButton);
            Controls.Add(WarningLabel);
            Name = "WarningForm";
            Text = "WarningForm";
            Load += WarningForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WarningLabel;
        private Button OkButton;
    }
}