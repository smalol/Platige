using Platige.Application.DTOs;
using Platige.Domain.Interfaces;
namespace Platige.Application.Services
{
    public class InvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<List<MonthlyInvoiceSummary>> GetInvoiceSummaries()
        {
            var invoices = await _invoiceRepository.GetAllInvoices();

            return invoices
                .GroupBy(i => i.SaleDate.ToString("yyyy.MM"))
                .Select(g => new MonthlyInvoiceSummary
                {
                    YearMonth = g.Key,
                    TotalNetValue = g.Sum(i => i.NetValue),
                    TotalGrossValue = g.Sum(i => i.NetValue + (i.NetValue * i.VatRate / 100))
                })
                .OrderByDescending(summary => summary.YearMonth)
                .ToList();
        }
    }
}
