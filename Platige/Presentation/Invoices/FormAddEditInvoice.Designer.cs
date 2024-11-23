namespace Platige.Presentation.Invoices
{
    partial class FormAddEditInvoice
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
            btnSave = new Button();
            tbDescription = new TextBox();
            tbCurrency = new TextBox();
            tbNetValue = new TextBox();
            lblContractor = new Label();
            lblDescription = new Label();
            lblSaleDate = new Label();
            lblVatRate = new Label();
            lblCurrency = new Label();
            lblNetValue = new Label();
            tbNumber = new TextBox();
            lblNumber = new Label();
            cbContractors = new ComboBox();
            dtpSaleDate = new DateTimePicker();
            nudVatRate = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudVatRate).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(239, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 50);
            btnSave.TabIndex = 7;
            btnSave.Text = "Dodaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(136, 240);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(494, 27);
            tbDescription.TabIndex = 5;
            // 
            // tbCurrency
            // 
            tbCurrency.CharacterCasing = CharacterCasing.Upper;
            tbCurrency.Location = new Point(136, 103);
            tbCurrency.MaxLength = 3;
            tbCurrency.Name = "tbCurrency";
            tbCurrency.Size = new Size(494, 27);
            tbCurrency.TabIndex = 2;
            // 
            // tbNetValue
            // 
            tbNetValue.Location = new Point(136, 58);
            tbNetValue.MaxLength = 50;
            tbNetValue.Name = "tbNetValue";
            tbNetValue.Size = new Size(494, 27);
            tbNetValue.TabIndex = 1;
            tbNetValue.KeyPress += TbNetValue_KeyPress;
            // 
            // lblContractor
            // 
            lblContractor.AutoSize = true;
            lblContractor.Location = new Point(43, 288);
            lblContractor.Name = "lblContractor";
            lblContractor.Size = new Size(82, 20);
            lblContractor.TabIndex = 22;
            lblContractor.Text = "Kontrahent";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(86, 243);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(39, 20);
            lblDescription.TabIndex = 21;
            lblDescription.Text = "Opis";
            // 
            // lblSaleDate
            // 
            lblSaleDate.AutoSize = true;
            lblSaleDate.Location = new Point(14, 202);
            lblSaleDate.Name = "lblSaleDate";
            lblSaleDate.Size = new Size(111, 20);
            lblSaleDate.TabIndex = 20;
            lblSaleDate.Text = "Data sprzedaży";
            // 
            // lblVatRate
            // 
            lblVatRate.AutoSize = true;
            lblVatRate.Location = new Point(40, 154);
            lblVatRate.Name = "lblVatRate";
            lblVatRate.Size = new Size(85, 20);
            lblVatRate.TabIndex = 19;
            lblVatRate.Text = "Stawka VAT";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(70, 106);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(55, 20);
            lblCurrency.TabIndex = 18;
            lblCurrency.Text = "Waluta";
            // 
            // lblNetValue
            // 
            lblNetValue.AutoSize = true;
            lblNetValue.Location = new Point(36, 61);
            lblNetValue.Name = "lblNetValue";
            lblNetValue.Size = new Size(89, 20);
            lblNetValue.TabIndex = 17;
            lblNetValue.Text = "Kwota netto";
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(136, 15);
            tbNumber.MaxLength = 30;
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(494, 27);
            tbNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(71, 18);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(54, 20);
            lblNumber.TabIndex = 15;
            lblNumber.Text = "Numer";
            // 
            // cbContractors
            // 
            cbContractors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbContractors.FormattingEnabled = true;
            cbContractors.Location = new Point(136, 285);
            cbContractors.Name = "cbContractors";
            cbContractors.Size = new Size(494, 28);
            cbContractors.TabIndex = 6;
            // 
            // dtpSaleDate
            // 
            dtpSaleDate.Location = new Point(136, 197);
            dtpSaleDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpSaleDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpSaleDate.Name = "dtpSaleDate";
            dtpSaleDate.Size = new Size(494, 27);
            dtpSaleDate.TabIndex = 4;
            // 
            // nudVatRate
            // 
            nudVatRate.Location = new Point(136, 152);
            nudVatRate.Name = "nudVatRate";
            nudVatRate.Size = new Size(494, 27);
            nudVatRate.TabIndex = 3;
            // 
            // FormAddEditInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 438);
            Controls.Add(nudVatRate);
            Controls.Add(dtpSaleDate);
            Controls.Add(cbContractors);
            Controls.Add(btnSave);
            Controls.Add(tbDescription);
            Controls.Add(tbCurrency);
            Controls.Add(tbNetValue);
            Controls.Add(lblContractor);
            Controls.Add(lblDescription);
            Controls.Add(lblSaleDate);
            Controls.Add(lblVatRate);
            Controls.Add(lblCurrency);
            Controls.Add(lblNetValue);
            Controls.Add(tbNumber);
            Controls.Add(lblNumber);
            MaximizeBox = false;
            Name = "FormAddEditInvoice";
            Text = "Dodaj nową fakturę";
            ((System.ComponentModel.ISupportInitialize)nudVatRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox tbDescription;
        private TextBox tbCurrency;
        private TextBox tbNetValue;
        private Label lblContractor;
        private Label lblDescription;
        private Label lblSaleDate;
        private Label lblVatRate;
        private Label lblCurrency;
        private Label lblNetValue;
        private TextBox tbNumber;
        private Label lblNumber;
        private ComboBox cbContractors;
        private DateTimePicker dtpSaleDate;
        private NumericUpDown nudVatRate;
    }
}