using Microsoft.EntityFrameworkCore;
using Platige.Domain.Entities;
using Platige.Domain.Interfaces;
using System.Diagnostics.Contracts;

namespace Platige.Infrastructure.Data.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly AppDbContext _context;

        public InvoiceRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Invoice>> GetAllInvoices()
        {
            return await _context.Invoices.Include(f => f.Contractor).ToListAsync();
        }

        public async Task<Invoice?> GetInvoiceById(int invoiceId)
        {
            return await _context.Invoices.Include(f => f.Contractor).FirstOrDefaultAsync(f => f.Id == invoiceId);
        }

        public async Task AddInvoice(Invoice invoice)
        {
            await _context.Invoices.AddAsync(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task AddInvoices(List<Invoice> invoices)
        {
            await _context.Invoices.AddRangeAsync(invoices);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateInvoice(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInvoice(int invoiceId)
        {
            var invoice = await _context.Invoices.FindAsync(invoiceId);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();
            }
        }
    }
}
