using Platige.Core.Utilities;
using Platige.Domain.Entities;
using Platige.Domain.Interfaces;

namespace Platige.Presentation.Contractors
{
    public partial class FormGenerateContractors : Form
    {
        private readonly IContractorRepository _contractorRepository;

        public FormGenerateContractors(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;

            InitializeComponent();
        }

        private async void BtnGeneruj_Click(object sender, EventArgs e)
        {
            try
            {
               var contractors = new List<Contractor>();

                for (int i = 0; i < this.nudContractorsNumber.Value; i++)
                {
                    var contractor = new Contractor
                    {
                        Type = RandomHelper.GetRandomText(RandomHelper.GetRandomNumber(1, 20)),
                        Name = RandomHelper.GetRandomText(RandomHelper.GetRandomNumber(5, 50)),
                        ShortName = RandomHelper.GetRandomText(RandomHelper.GetRandomNumber(3, 20)),
                        Country = RandomHelper.GetRandomListValue(["Polska", "Włochy", "Niemcy", "Hiszpania", "Holandia", "UK", "Belgia", "Francja"]),
                        Address = RandomHelper.GetRandomText(RandomHelper.GetRandomNumber(10, 100)),
                        NIP = RandomHelper.GetRandomDigitString(10),
                        IsActive = RandomHelper.GetRandomBoolean(),
                    };

                    contractors.Add(contractor);
                }

                await _contractorRepository.AddContractors(contractors);

                MessageBox.Show($"Dodano {this.nudContractorsNumber.Value} kontrahentów.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas zapisu do bazy danych:\n{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
