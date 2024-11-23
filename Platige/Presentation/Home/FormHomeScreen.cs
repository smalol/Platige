using Microsoft.Extensions.DependencyInjection;
using Platige.Domain.Entities;
using Platige.Domain.Interfaces;
using Platige.Infrastructure.Data.Repositories;
using Platige.Infrastructure.Export;
using Platige.Presentation.Contractors;
using Platige.Presentation.Invoices;
using Platige.Presentation.Reports;

namespace Platige.Presentation.Home
{
    public partial class FormHomeScreen : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IContractorRepository _contractorRepository;
        private readonly IInvoiceRepository _invoiceRepository;

        public FormHomeScreen(IServiceProvider serviceProvider, IContractorRepository contractorRepository, IInvoiceRepository invoiceRepository)
        {
            _serviceProvider = serviceProvider;
            _contractorRepository = contractorRepository;
            _invoiceRepository = invoiceRepository;

            InitializeComponent();
        }

        private void FormHomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnAddNewContractor_Click(object sender, EventArgs e)
        {
            var addNewContractorForm = _serviceProvider.GetRequiredService<FormAddEditContractor>();
            addNewContractorForm.SetContractor(null);

            addNewContractorForm.ShowDialog();
        }

        private void BtnGenerateContractors_Click(object sender, EventArgs e)
        {
            var generateContractorsForm = _serviceProvider.GetRequiredService<FormGenerateContractors>();
            generateContractorsForm.ShowDialog();
        }

        private void BtnContractorsList_Click(object sender, EventArgs e)
        {
            var contractorsListForm = _serviceProvider.GetRequiredService<FormContractorsList>();
            contractorsListForm.ShowDialog();
        }

        private async void BtnContractorsExport_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Pliki XML (*.xml)|*.xml";
                saveFileDialog.Title = "Eksportuj do pliku";
                saveFileDialog.DefaultExt = "csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    var contractors = await _contractorRepository.GetAllContractors();

                    try
                    {
                        if (Path.GetExtension(saveFileDialog.FileName).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                        {
                            CsvExporter.ExportContractorsToCsv(contractors, filePath);
                        }
                        else if (Path.GetExtension(saveFileDialog.FileName).Equals(".xml", StringComparison.OrdinalIgnoreCase))
                        {
                            XmlExporter.ExportContractorsToXml(contractors, filePath);
                        }

                        MessageBox.Show("Dane zostały wyeksportowane.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas eksportu danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnAddNewInvoice_Click(object sender, EventArgs e)
        {
            var addNewInvoiceForm = _serviceProvider.GetRequiredService<FormAddEditInvoice>();
            addNewInvoiceForm.SetInvoice(null);

            addNewInvoiceForm.ShowDialog();
        }

        private void BtnGenerateInvoices_Click(object sender, EventArgs e)
        {
            var generateInvoicesForm = _serviceProvider.GetRequiredService<FormGenerateInvoices>();
            generateInvoicesForm.ShowDialog();
        }

        private void BtnInvoicesList_Click(object sender, EventArgs e)
        {
            var invoicesListForm = _serviceProvider.GetRequiredService<FormInvoicesList>();
            invoicesListForm.ShowDialog();
        }

        private async void BtnInvoicesExport_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Pliki XML (*.xml)|*.xml";
                saveFileDialog.Title = "Eksportuj do pliku";
                saveFileDialog.DefaultExt = "csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    var invoices = await _invoiceRepository.GetAllInvoices();

                    try
                    {
                        if (Path.GetExtension(saveFileDialog.FileName).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                        {
                            CsvExporter.ExportInvoicesToCsv(invoices, filePath);
                        }
                        else if (Path.GetExtension(saveFileDialog.FileName).Equals(".xml", StringComparison.OrdinalIgnoreCase))
                        {
                            XmlExporter.ExportInvoicesToXml(invoices, filePath);
                        }

                        MessageBox.Show("Dane zostały wyeksportowane.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił błąd podczas eksportu danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnContractorInvoicesReport_Click(object sender, EventArgs e)
        {
            var contractorInvoicesReportForm = _serviceProvider.GetRequiredService<FormContractorInvoicesReport>();
            contractorInvoicesReportForm.ShowDialog();
        }

        private void BtnInvoicesMonthlyReport_Click(object sender, EventArgs e)
        {
            var invoicesMonthlyReportForm = _serviceProvider.GetRequiredService<FormInvoicesMonthlyReport>();
            invoicesMonthlyReportForm.ShowDialog();
        }

        private void BtnCountryContractorsReport_Click(object sender, EventArgs e)
        {
            var countryContractorsReportForm = _serviceProvider.GetRequiredService<FormCountryContractorsReport>();
            countryContractorsReportForm.ShowDialog();
        }
    }
}
