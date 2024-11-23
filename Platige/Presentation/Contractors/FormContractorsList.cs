using Microsoft.Extensions.DependencyInjection;
using Platige.Domain.Entities;
using Platige.Domain.Interfaces;

namespace Platige.Presentation.Contractors
{
    public partial class FormContractorsList : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IContractorRepository _contractorRepository;

        public FormContractorsList(IServiceProvider serviceProvider, IContractorRepository contractorRepository)
        {
            _serviceProvider = serviceProvider;
            _contractorRepository = contractorRepository;

            InitializeComponent();

            this.Load += async (s, e) => await LoadContractors();
        }

        private async Task LoadContractors()
        {
            try
            {
                var contractors = await _contractorRepository.GetAllContractors();
                dgvContractors.DataSource = new BindingSource { DataSource = contractors };

                dgvContractors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvContractors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvContractors.MultiSelect = false;

                dgvContractors.Columns["Id"].Visible = false;
                dgvContractors.Columns["Type"].HeaderText = "Rodzaj";
                dgvContractors.Columns["Name"].HeaderText = "Nazwa";
                dgvContractors.Columns["ShortName"].HeaderText = "Nazwa skrócona";
                dgvContractors.Columns["Country"].HeaderText = "Kraj";
                dgvContractors.Columns["Address"].HeaderText = "Adres";
                dgvContractors.Columns["NIP"].HeaderText = "Numer NIP";
                dgvContractors.Columns["IsActive"].HeaderText = "Aktywna";
                dgvContractors.Columns["Invoices"].Visible = false;

                if (dgvContractors.Columns["EditButtonColumn"] == null)
                {
                    var editButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "EditButtonColumn",
                        HeaderText = "",
                        Text = "Edytuj",
                        UseColumnTextForButtonValue = true
                    };
                    dgvContractors.Columns.Add(editButtonColumn);
                }

                if (dgvContractors.Columns["DeleteButtonColumn"] == null)
                {
                    var deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "DeleteButtonColumn",
                        HeaderText = "",
                        Text = "Usuń",
                        UseColumnTextForButtonValue = true
                    };
                    dgvContractors.Columns.Add(deleteButtonColumn);
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas pobierania danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DgvContractors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvContractors.Columns["EditButtonColumn"].Index && e.RowIndex >= 0)
            {
                var contractor = dgvContractors.Rows[e.RowIndex].DataBoundItem as Contractor;
                if (contractor != null)
                {
                    var addNewContractorForm = _serviceProvider.GetRequiredService<FormAddEditContractor>();
                    addNewContractorForm.SetContractor(contractor);

                    addNewContractorForm.ShowDialog();

                    await LoadContractors();
                }
            }

            if (e.ColumnIndex == dgvContractors.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                var contractor = dgvContractors.Rows[e.RowIndex].DataBoundItem as Contractor;
                if (contractor != null)
                {
                    var result = MessageBox.Show($"Czy na pewno chcesz usunąć kontrahenta [{contractor.Name}] oraz wszystkie faktury do niego przypisane?",
                                                 "Potwierdzenie usunięcia",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            await _contractorRepository.DeleteContractor(contractor.Id);
                            await LoadContractors();

                            MessageBox.Show("Kontrahent został usunięty.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Wystąpił błąd podczas usuwania kontrahenta:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
