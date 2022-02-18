
namespace Hylian.RIS.API.Services.Interfaces
{
    public interface IOrganisationService
    {
        Task<bool> IsValidID(Guid id);
    }
}