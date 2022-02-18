using Hylian.RIS.API.Services.Interfaces;
using Hylian.RIS.API.Repository.Interfaces;
using Hylian.RIS.API.ViewModels;
using System.Text;

namespace Hylian.RIS.API.Services
{
    internal class OrganisationService : IOrganisationService
    {
        private readonly IOrganisationRepository _organisationRepository;

        public OrganisationService(IOrganisationRepository organisationRepository)
        {
            _organisationRepository = organisationRepository;
        }

        public async Task<bool> IsValidID(Guid id)
        {
            return await _organisationRepository.IsValidID(id);
        }
    }
}