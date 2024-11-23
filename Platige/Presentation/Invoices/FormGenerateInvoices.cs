using Platige.Core.Utilities;
using Platige.Domain.Entities;
using Platige.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platige.Presentation.Invoices
{
    public partial class FormGenerateInvoices : Form
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IContractorRepository _contractorRepository;
        
        public FormGenerateInvoices(IInvoiceRepository invoiceRepository, IContractorRepository contractorRepository)
        {
            _invoiceRepository = invoiceRepository;
            _contractorRepository = contractorRepository;

            InitializeComponent();
        }

        private async void BtnGeneruj_Click(object sender, EventArgs e)
        {
            try
            {
                var contractors = await _contractorRepository.GetAllContractors();
                if (contractors.Count == 0)
                {
                    MessageBox.Show($"Brak konrahentów. Proszę pierw dodać kontrahentów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else
                {
                    var invoices = new List<Invoice>();

                    for (int i = 0; i < this.nudInvoicesNumber.Value; i++)
                    {
                        var invoice = new Invoice
                        {
                            Number = RandomHelper.GetRandomText(RandomHelper.GetRandomNumber(1, 30)),
                            NetValue = RandomHelper.GetRandomDecimal(0, 1000000),
                            Currency = RandomHelper.GetRandomTextWithoutSpace(RandomHelper.GetRandomNumber(3, 3)).ToUpper(),
                            VatRate = RandomHelper.GetRandomNumber(0, 100),
                            SaleDate = RandomHelper.GetRandomDate(new DateTime(2021, 1, 1), DateTime.Now.Date),
                            Description = RandomHelper.GetRandomText(RandomHelper.GetRandomNumber(0, 100)),
                            Contractor = contractors[RandomHelper.GetRandomNumber(0, contractors.Count - 1)],
                        };

                        invoices.Add(invoice);
                    }

                    await _invoiceRepository.AddInvoices(invoices);

                    MessageBox.Show($"Dodano {this.nudInvoicesNumber.Value} faktur.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisu do bazy danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
