using Platige.Application.DTOs;
using Platige.Domain.Interfaces;

namespace Platige.Application.Services
{
    public class ContractorService
    {
        private readonly IContractorRepository _contractorRepository;

        public ContractorService(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;
        }

        public async Task<List<CountryContractorsCount>> GetCountryContractorsCount()
        {
            var contractors = await _contractorRepository.GetAllContractors();

            return contractors
                .GroupBy(c => c.Country)
                .Select(g => new CountryContractorsCount
                {
                    Country = g.Key,
                    ContractorsCount = g.Count()
                }).ToList();
        }
    }
}
