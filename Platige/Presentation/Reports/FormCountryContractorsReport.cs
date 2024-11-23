using Platige.Application.Services;
using Platige.Domain.Interfaces;

namespace Platige.Presentation.Reports
{
    public partial class FormCountryContractorsReport : Form
    {
        private readonly ContractorService _contractorService;

        public FormCountryContractorsReport(ContractorService contractorService)
        {
            _contractorService = contractorService;

            InitializeComponent();

            this.Load += async (s, e) => await LoadCountryContractors();
        }

        private async Task LoadCountryContractors()
        {
            try
            {
                var contractors = await _contractorService.GetCountryContractorsCount();
                
                dgvCountryContractors.DataSource = new BindingSource { DataSource = contractors };

                dgvCountryContractors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCountryContractors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCountryContractors.MultiSelect = false;

                dgvCountryContractors.Columns["Country"].HeaderText = "Kraj";
                dgvCountryContractors.Columns["ContractorsCount"].HeaderText = "Ilość kontrahentów";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas pobierania danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
