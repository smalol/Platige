namespace Platige.Presentation.Reports
{
    partial class FormInvoicesMonthlyReport
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
            dgvInvoiceSummaries = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceSummaries).BeginInit();
            SuspendLayout();
            // 
            // dgvInvoiceSummaries
            // 
            dgvInvoiceSummaries.AllowUserToAddRows = false;
            dgvInvoiceSummaries.AllowUserToDeleteRows = false;
            dgvInvoiceSummaries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoiceSummaries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceSummaries.Dock = DockStyle.Fill;
            dgvInvoiceSummaries.Location = new Point(0, 0);
            dgvInvoiceSummaries.MultiSelect = false;
            dgvInvoiceSummaries.Name = "dgvInvoiceSummaries";
            dgvInvoiceSummaries.ReadOnly = true;
            dgvInvoiceSummaries.RowHeadersWidth = 51;
            dgvInvoiceSummaries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoiceSummaries.Size = new Size(800, 450);
            dgvInvoiceSummaries.TabIndex = 26;
            // 
            // FormInvoicesMonthlyReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvInvoiceSummaries);
            Name = "FormInvoicesMonthlyReport";
            Text = "Faktury miesięcznie";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceSummaries).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInvoiceSummaries;
    }
}