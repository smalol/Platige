using Platige.Domain.Entities;
using System.Text;

namespace Platige.Infrastructure.Export
{
    public class CsvExporter
    {
        public static void ExportContractorsToCsv(IEnumerable<Contractor> contractors, string filePath)
        {
            var csvBuilder = new StringBuilder();
            
            csvBuilder.AppendLine("ID;Type;Name;ShortName;Country;Address;NIP;IsActive");

            foreach (var contractor in contractors)
            {
                csvBuilder.AppendLine($"{contractor.Id};{contractor.Type};{contractor.Name};{contractor.ShortName};{contractor.Country};{contractor.Address};{contractor.NIP};{contractor.IsActive}");
            }

            File.WriteAllText(filePath, csvBuilder.ToString(), Encoding.UTF8);
        }

        public static void ExportInvoicesToCsv(IEnumerable<Invoice> invoices, string filePath)
        {
            var csvBuilder = new StringBuilder();

            csvBuilder.AppendLine("ID;Number;NetValue;Currency;VatRate;SaleDate;Description;ContractorID");

            foreach (var invoice in invoices)
            {
                csvBuilder.AppendLine($"{invoice.Id};{invoice.Number};{invoice.NetValue};{invoice.Currency};{invoice.VatRate};{invoice.SaleDate};{invoice.Description};{invoice.ContractorId}");
            }

            File.WriteAllText(filePath, csvBuilder.ToString(), Encoding.UTF8);
        }
    }
}
