using Microsoft.EntityFrameworkCore;
using Platige.Application.DTOs;
using Platige.Domain.Entities;
using Platige.Domain.Interfaces;

namespace Platige.Infrastructure.Data.Repositories
{
    public class ContractorRepository : IContractorRepository
    {
        private readonly AppDbContext _context;

        public ContractorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contractor>> GetAllContractors()
        {
            return await _context.Contractors.ToListAsync();
        }

        public async Task<Contractor?> GetContractorById(int contractorId)
        {
            return await _context.Contractors
                                 .Include(c => c.Invoices)
                                 .FirstOrDefaultAsync(c => c.Id == contractorId);
        }

        public async Task AddContractor(Contractor contractor)
        {
            await _context.Contractors.AddAsync(contractor);
            await _context.SaveChangesAsync();
        }

        public async Task AddContractors(List<Contractor> contractors)
        {
            await _context.Contractors.AddRangeAsync(contractors);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateContractor(Contractor contractor)
        {
            _context.Contractors.Update(contractor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteContractor(int contractorId)
        {
            var contractor = await _context.Contractors.FindAsync(contractorId);
            if (contractor != null)
            {
                _context.Contractors.Remove(contractor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
