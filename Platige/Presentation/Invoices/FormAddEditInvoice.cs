using Platige.Domain.Entities;
using Platige.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Platige.Presentation.Invoices
{
    public partial class FormAddEditInvoice : Form
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IContractorRepository _contractorRepository;
        private Invoice? _invoice;

        public FormAddEditInvoice(IInvoiceRepository invoiceRepository, IContractorRepository contractorRepository)
        {
            _invoiceRepository = invoiceRepository;
            _contractorRepository = contractorRepository;

            InitializeComponent();
        }

        public void SetInvoice(Invoice? invoice)
        {
            _invoice = invoice;
            InitializeForm();
        }

        private async void InitializeForm()
        {
            Text = _invoice == null ? "Dodaj nową fakturę" : "Edycja faktury";
            btnSave.Text = _invoice == null ? "Dodaj" : "Zapisz";

            var contractors = await _contractorRepository.GetAllContractors();
            if (contractors.Count == 0)
            {
                MessageBox.Show($"Brak konrahentów. Proszę pierw dodać kontrahentów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }


            cbContractors.DataSource = contractors;
            cbContractors.DisplayMember = "Name";
            cbContractors.ValueMember = "Id";
            cbContractors.Format += (s, e) =>
            {
                if (e.ListItem is Contractor contractor)
                {
                    e.Value = $"[{contractor.NIP}]   {contractor.Name}";
                }
            };

            if (_invoice != null)
            {
                tbNumber.Text = _invoice.Number;
                tbNetValue.Text = _invoice.NetValue.ToString();
                tbCurrency.Text = _invoice.Currency;
                nudVatRate.Value = _invoice.VatRate;
                dtpSaleDate.Value = _invoice.SaleDate;
                tbDescription.Text = _invoice.Description;
                cbContractors.SelectedItem = _invoice.Contractor;
            }
            else
            {
                dtpSaleDate.Value = DateTime.Now;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (_invoice == null)
            {
                _invoice = new Invoice
                {
                    Number = this.tbNumber.Text.Trim(),
                    NetValue = decimal.Parse(this.tbNetValue.Text.Trim()),
                    Currency = this.tbCurrency.Text.Trim(),
                    VatRate = this.nudVatRate.Value,
                    SaleDate = this.dtpSaleDate.Value.Date,
                    Description = this.tbDescription.Text.Trim(),
                    Contractor = (Contractor)cbContractors.SelectedItem!,
                };
            }
            else
            {
                _invoice.Number = this.tbNumber.Text.Trim();
                _invoice.NetValue = decimal.Parse(this.tbNetValue.Text.Trim());
                _invoice.Currency = this.tbCurrency.Text.Trim();
                _invoice.VatRate = this.nudVatRate.Value;
                _invoice.SaleDate = this.dtpSaleDate.Value.Date;
                _invoice.Description = this.tbDescription.Text.Trim();
                _invoice.Contractor = (Contractor)cbContractors.SelectedItem!;
            }

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(_invoice);

            if (!Validator.TryValidateObject(_invoice, context, validationResults, true))
            {
                string errorMessages = string.Join("\n", validationResults.Select(vr => vr.ErrorMessage));
                MessageBox.Show($"Błąd walidacji danych:\n{errorMessages}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_invoice.Id == 0)
                {
                    await _invoiceRepository.AddInvoice(_invoice);
                    MessageBox.Show("Faktura została dodana do bazy danych.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _invoiceRepository.UpdateInvoice(_invoice);
                    MessageBox.Show("Zmiany zostały zapisane w bazie danych.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisu do bazy danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbNetValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != decimalSeparator)
            {
                e.Handled = true;
            }

            TextBox? textBox = sender as TextBox;
            if (e.KeyChar == decimalSeparator && textBox != null && textBox.Text.Contains(decimalSeparator))
            {
                e.Handled = true;
            }

            if(!char.IsControl(e.KeyChar) && e.KeyChar != decimalSeparator && textBox != null && textBox.Text.Contains(decimalSeparator) && textBox.Text.IndexOf(decimalSeparator) <= textBox.Text.Length - 3)
            {
                e.Handled = true;
            }
        }
    }
}
