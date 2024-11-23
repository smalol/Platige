using Microsoft.Extensions.DependencyInjection;
using Platige.Infrastructure.Data;

namespace Platige.Presentation.Home
{
    public partial class FormDbConnection : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public FormDbConnection(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private void BtnConnectCreateDb_Click(object sender, EventArgs e)
        {
            try
            {
                var serverName = this.tbServerName.Text;
                var dbName = this.tbDbName.Text;
                var user = this.tbUser.Text;
                var password = this.tbPassword.Text;
                
                var connectionString = $"Server={serverName};Database={dbName};User Id={user};Password={password};";
                
                DatabaseInitializer.CreateDatabase(connectionString, _serviceProvider);

                var homeScreenForm = _serviceProvider.GetRequiredService<FormHomeScreen>();
                homeScreenForm.Show();
                this.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas tworzenia lub łączenia się z bazą danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDbConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms.Count == 0)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
