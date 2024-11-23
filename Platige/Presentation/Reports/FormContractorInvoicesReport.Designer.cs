namespace Platige.Presentation.Reports
{
    partial class FormContractorInvoicesReport
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
            cbContractors = new ComboBox();
            lblContractor = new Label();
            dgvInvoices = new DataGridView();
            label1 = new Label();
            lblTotalNetValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // cbContractors
            // 
            cbContractors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbContractors.FormattingEnabled = true;
            cbContractors.Location = new Point(113, 24);
            cbContractors.Name = "cbContractors";
            cbContractors.Size = new Size(675, 28);
            cbContractors.TabIndex = 23;
            cbContractors.SelectedIndexChanged += CbContractors_SelectedIndexChanged;
            // 
            // lblContractor
            // 
            lblContractor.AutoSize = true;
            lblContractor.Location = new Point(18, 27);
            lblContractor.Name = "lblContractor";
            lblContractor.Size = new Size(82, 20);
            lblContractor.TabIndex = 24;
            lblContractor.Text = "Kontrahent";
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(0, 123);
            dgvInvoices.MultiSelect = false;
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(800, 327);
            dgvInvoices.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 26;
            label1.Text = "Suma faktur";
            // 
            // lblTotalNetValue
            // 
            lblTotalNetValue.AutoSize = true;
            lblTotalNetValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalNetValue.Location = new Point(113, 76);
            lblTotalNetValue.Name = "lblTotalNetValue";
            lblTotalNetValue.Size = new Size(40, 20);
            lblTotalNetValue.TabIndex = 27;
            lblTotalNetValue.Text = "0,00";
            // 
            // FormContractorInvoicesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalNetValue);
            Controls.Add(label1);
            Controls.Add(dgvInvoices);
            Controls.Add(cbContractors);
            Controls.Add(lblContractor);
            Name = "FormContractorInvoicesReport";
            Text = "Faktury kontrahenta";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbContractors;
        private Label lblContractor;
        private DataGridView dgvInvoices;
        private Label label1;
        private Label lblTotalNetValue;
    }
}