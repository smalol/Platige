using Microsoft.Extensions.DependencyInjection;
using Platige.Domain.Entities;
using Platige.Domain.Interfaces;

namespace Platige.Presentation.Invoices
{
    public partial class FormInvoicesList : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IInvoiceRepository _invoiceRepository;

        public FormInvoicesList(IServiceProvider serviceProvider, IInvoiceRepository invoiceRepository)
        {
            _serviceProvider = serviceProvider;
            _invoiceRepository = invoiceRepository;

            InitializeComponent();

            this.Load += async (s, e) => await LoadInvoices();
        }

        private async Task LoadInvoices()
        {
            try
            {
                var invoices = await _invoiceRepository.GetAllInvoices();
                dgvInvoices.DataSource = new BindingSource { DataSource = invoices };

                dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvInvoices.MultiSelect = false;

                dgvInvoices.Columns["Id"].Visible = false;
                dgvInvoices.Columns["Number"].HeaderText = "Numer faktury";
                dgvInvoices.Columns["NetValue"].HeaderText = "Kwota netto";
                dgvInvoices.Columns["Currency"].HeaderText = "Waluta";
                dgvInvoices.Columns["VatRate"].HeaderText = "Stawka VAT";
                dgvInvoices.Columns["SaleDate"].HeaderText = "Data sprzedaży";
                dgvInvoices.Columns["Description"].HeaderText = "Opis";
                dgvInvoices.Columns["ContractorId"].Visible = false;
                dgvInvoices.Columns["Contractor"].Visible = false;

                if (dgvInvoices.Columns["ContractorNipName"] == null)
                {
                    var contractorColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "ContractorNipName",
                        HeaderText = "Kontrahent",
                    };
                    dgvInvoices.Columns.Add(contractorColumn);
                }

                foreach (DataGridViewRow row in dgvInvoices.Rows)
                {
                    var invoice = row.DataBoundItem as Invoice;
                    if (invoice != null)
                    {
                        row.Cells["ContractorNipName"].Value = $"{invoice.Contractor?.NIP} {invoice.Contractor?.Name}";
                    }
                }

                if (dgvInvoices.Columns["EditButtonColumn"] == null)
                {
                    var editButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "EditButtonColumn",
                        HeaderText = "",
                        Text = "Edytuj",
                        UseColumnTextForButtonValue = true
                    };
                    dgvInvoices.Columns.Add(editButtonColumn);
                }

                if (dgvInvoices.Columns["DeleteButtonColumn"] == null)
                {
                    var deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "DeleteButtonColumn",
                        HeaderText = "",
                        Text = "Usuń",
                        UseColumnTextForButtonValue = true
                    };
                    dgvInvoices.Columns.Add(deleteButtonColumn);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas pobierania danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInvoices.Columns["EditButtonColumn"].Index && e.RowIndex >= 0)
            {
                var invoice = dgvInvoices.Rows[e.RowIndex].DataBoundItem as Invoice;
                if (invoice != null)
                {
                    var addNewInvoiceForm = _serviceProvider.GetRequiredService<FormAddEditInvoice>();
                    addNewInvoiceForm.SetInvoice(invoice);

                    addNewInvoiceForm.ShowDialog();

                    await LoadInvoices();
                }
            }

            if (e.ColumnIndex == dgvInvoices.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                var invoice = dgvInvoices.Rows[e.RowIndex].DataBoundItem as Invoice;
                if (invoice != null)
                {
                    var result = MessageBox.Show($"Czy na pewno chcesz usunąć fakturę [{invoice.Number}]?",
                                                 "Potwierdzenie usunięcia",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            await _invoiceRepository.DeleteInvoice(invoice.Id);
                            await LoadInvoices();

                            MessageBox.Show("Faktura została usunięta.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Wystąpił błąd podczas usuwania faktury:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
