using Platige.Application.Services;

namespace Platige.Presentation.Reports
{
    public partial class FormInvoicesMonthlyReport : Form
    {
        private readonly InvoiceService _invoiceService;

        public FormInvoicesMonthlyReport(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;

            InitializeComponent();

            this.Load += async (s, e) => await LoadInvoicesMonthly();
        }

        private async Task LoadInvoicesMonthly()
        {
            try
            {
                var invoiceSummaries = await _invoiceService.GetInvoiceSummaries();

                dgvInvoiceSummaries.DataSource = new BindingSource { DataSource = invoiceSummaries };

                dgvInvoiceSummaries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInvoiceSummaries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvInvoiceSummaries.MultiSelect = false;

                dgvInvoiceSummaries.Columns["YearMonth"].HeaderText = "Miesiąc";
                dgvInvoiceSummaries.Columns["TotalNetValue"].HeaderText = "Suma faktur netto";
                dgvInvoiceSummaries.Columns["TotalGrossValue"].HeaderText = "Suma faktur brutto";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas pobierania danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
