namespace Platige.Presentation.Invoices
{
    partial class FormGenerateInvoices
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
            nudInvoicesNumber = new NumericUpDown();
            lblInvoicesNumber = new Label();
            btnGeneruj = new Button();
            ((System.ComponentModel.ISupportInitialize)nudInvoicesNumber).BeginInit();
            SuspendLayout();
            // 
            // nudInvoicesNumber
            // 
            nudInvoicesNumber.Location = new Point(266, 24);
            nudInvoicesNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudInvoicesNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInvoicesNumber.Name = "nudInvoicesNumber";
            nudInvoicesNumber.Size = new Size(102, 27);
            nudInvoicesNumber.TabIndex = 20;
            nudInvoicesNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblInvoicesNumber
            // 
            lblInvoicesNumber.AutoSize = true;
            lblInvoicesNumber.Location = new Point(29, 26);
            lblInvoicesNumber.Name = "lblInvoicesNumber";
            lblInvoicesNumber.Size = new Size(211, 20);
            lblInvoicesNumber.TabIndex = 19;
            lblInvoicesNumber.Text = "Ilość faktur do wygenerowania";
            // 
            // btnGeneruj
            // 
            btnGeneruj.Location = new Point(132, 87);
            btnGeneruj.Name = "btnGeneruj";
            btnGeneruj.Size = new Size(156, 50);
            btnGeneruj.TabIndex = 18;
            btnGeneruj.Text = "Generuj";
            btnGeneruj.UseVisualStyleBackColor = true;
            btnGeneruj.Click += BtnGeneruj_Click;
            // 
            // FormGenerateInvoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 199);
            Controls.Add(nudInvoicesNumber);
            Controls.Add(lblInvoicesNumber);
            Controls.Add(btnGeneruj);
            MaximizeBox = false;
            Name = "FormGenerateInvoices";
            Text = "Generuj faktury";
            ((System.ComponentModel.ISupportInitialize)nudInvoicesNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudInvoicesNumber;
        private Label lblInvoicesNumber;
        private Button btnGeneruj;
    }
}