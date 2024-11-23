using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Platige.Domain.Interfaces;
using Platige.Infrastructure.Data.Configuration;
using Platige.Infrastructure.Data;
using Platige.Infrastructure.Data.Repositories;
using Platige.Presentation.Home;
using Platige.Presentation.Contractors;
using Platige.Presentation.Invoices;
using Platige.Presentation.Reports;
using Platige.Application.Services;

namespace Platige
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                ConfigureServices(services);
                ConfigureDbContext(services);
            })
            .Build();

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();

            var dbConnectionForm = host.Services.GetRequiredService<FormDbConnection>();
            dbConnectionForm.Show();
            System.Windows.Forms.Application.Run();
        }

        private static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            // Register repositories
            services.AddScoped<IContractorRepository, ContractorRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();

            // Register services
            services.AddScoped<ContractorService>();
            services.AddScoped<InvoiceService>();

            // Register forms
            services.AddTransient<FormDbConnection>();
            services.AddTransient<FormHomeScreen>();
            services.AddTransient<FormAddEditContractor>();
            services.AddTransient<FormGenerateContractors>();
            services.AddTransient<FormContractorsList>();
            services.AddTransient<FormAddEditInvoice>();
            services.AddTransient<FormGenerateInvoices>();
            services.AddTransient<FormInvoicesList>();
            services.AddTransient<FormContractorInvoicesReport>();
            services.AddTransient<FormInvoicesMonthlyReport>();
            services.AddTransient<FormCountryContractorsReport>();

            return services;
        }

        private static IServiceCollection ConfigureDbContext(IServiceCollection services)
        {
            services.AddSingleton<ConnectionStringProvider>();

            services.AddScoped<AppDbContext>(provider =>
            {
                var connectionStringProvider = provider.GetRequiredService<ConnectionStringProvider>();
                var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(connectionStringProvider.ConnectionString)
                    .Options;

                return new AppDbContext(options);
            });

            return services;
        }
    }
}