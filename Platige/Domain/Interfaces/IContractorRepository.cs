using Platige.Application.DTOs;
using Platige.Domain.Entities;

namespace Platige.Domain.Interfaces
{
    public interface IContractorRepository
    {
        Task<List<Contractor>> GetAllContractors();

        Task<Contractor?> GetContractorById(int contractorId);

        Task AddContractor(Contractor contractor);

        Task AddContractors(List<Contractor> contractors);

        Task UpdateContractor(Contractor contractor);

        Task DeleteContractor(int contractorId);
    }
}
