using Platige.Domain.Entities;

namespace Platige.Domain.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<List<Invoice>> GetAllInvoices();

        Task<Invoice?> GetInvoiceById(int invoiceId);

        Task AddInvoice(Invoice invoice);

        Task AddInvoices(List<Invoice> invoices);

        Task UpdateInvoice(Invoice invoice);

        Task DeleteInvoice(int invoiceId);
    }
}
