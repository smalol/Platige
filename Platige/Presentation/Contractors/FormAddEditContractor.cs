using Platige.Domain.Entities;
using Platige.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Platige.Presentation.Contractors
{
    public partial class FormAddEditContractor : Form
    {
        private readonly IContractorRepository _contractorRepository;
        private Contractor? _contractor;

        public FormAddEditContractor(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;

            InitializeComponent();
        }

        public void SetContractor(Contractor? contractor)
        {
            _contractor = contractor;
            InitializeForm();
        }

        private void InitializeForm()
        {
            Text = _contractor == null ? "Dodaj nowego kontrahenta" : "Edycja kontrahenta";
            btnSave.Text = _contractor == null ? "Dodaj" : "Zapisz";

            if (_contractor != null)
            {
                tbType.Text = _contractor.Type;
                tbName.Text = _contractor.Name;
                tbShortName.Text = _contractor.ShortName;
                tbCountry.Text = _contractor.Country;
                tbAddress.Text = _contractor.Address;
                tbNIP.Text = _contractor.NIP;
                cbIsActive.Checked = _contractor.IsActive;
            }
        }

        private async void BtnSave_ClickAsync(object sender, EventArgs e)
        {
            if (_contractor == null)
            {
                _contractor = new Contractor
                {
                    Type = this.tbType.Text.Trim(),
                    Name = this.tbName.Text.Trim(),
                    ShortName = this.tbShortName.Text.Trim(),
                    Country = this.tbCountry.Text.Trim(),
                    Address = this.tbAddress.Text.Trim(),
                    NIP = this.tbNIP.Text.Trim(),
                    IsActive = this.cbIsActive.Checked,
                };
            }
            else
            {
                _contractor.Type = this.tbType.Text.Trim();
                _contractor.Name = this.tbName.Text.Trim();
                _contractor.ShortName = this.tbShortName.Text.Trim();
                _contractor.Country = this.tbCountry.Text.Trim();
                _contractor.Address = this.tbAddress.Text.Trim();
                _contractor.NIP = this.tbNIP.Text.Trim();
                _contractor.IsActive = this.cbIsActive.Checked;

            }

            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(_contractor);

            if (!Validator.TryValidateObject(_contractor, context, validationResults, true))
            {
                string errorMessages = string.Join("\n", validationResults.Select(vr => vr.ErrorMessage));
                MessageBox.Show($"Błąd walidacji danych:\n{errorMessages}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_contractor.Id == 0)
                {
                    await _contractorRepository.AddContractor(_contractor);
                    MessageBox.Show("Kontrahent został dodany do bazy danych.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _contractorRepository.UpdateContractor(_contractor);
                    MessageBox.Show("Zmiany zostały zapisane w bazie danych.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisu do bazy danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
