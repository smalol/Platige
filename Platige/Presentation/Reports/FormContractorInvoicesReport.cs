using Platige.Domain.Entities;
using Platige.Domain.Interfaces;

namespace Platige.Presentation.Reports
{
    public partial class FormContractorInvoicesReport : Form
    {
        private readonly IContractorRepository _contractorRepository;

        public FormContractorInvoicesReport(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;

            InitializeComponent();

            this.Load += async (s, e) => await LoadContractors();
        }

        private async Task LoadContractors()
        {
            var contractors = await _contractorRepository.GetAllContractors();

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
        }

        private async void CbContractors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbContractors.SelectedValue is int contractorId)
            {
                var contractor = await _contractorRepository.GetContractorById(contractorId);
                if (contractor?.Invoices != null)
                {
                    dgvInvoices.DataSource = contractor.Invoices.ToList();
                    dgvInvoices.Columns["Id"].Visible = false;
                    dgvInvoices.Columns["ContractorId"].Visible = false;
                    dgvInvoices.Columns["Contractor"].Visible = false;

                    lblTotalNetValue.Text = $"{contractor.Invoices.Sum(i => i.NetValue):C}";
                }
                else
                {
                    dgvInvoices.DataSource = new List<Invoice>();
                    lblTotalNetValue.Text = "0,00";
                }
            }
        }
    }
}
