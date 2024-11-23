using Platige.Domain.Entities;
using System.Text;
using System.Xml.Serialization;

namespace Platige.Infrastructure.Export
{
    public class XmlExporter
    {
        public static void ExportContractorsToXml(IEnumerable<Contractor> contractors, string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<Contractor>));

            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                serializer.Serialize(writer, contractors.ToList());
            }
        }

        public static void ExportInvoicesToXml(IEnumerable<Invoice> invoices, string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<Invoice>));

            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                serializer.Serialize(writer, invoices.ToList());
            }
        }
    }
}
