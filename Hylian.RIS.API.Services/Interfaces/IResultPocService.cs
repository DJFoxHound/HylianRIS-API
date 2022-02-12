using Hylian.RIS.API.ViewModels;

namespace Hylian.RIS.API.Services.Interfaces
{
    public interface IResultPocService
    {
        Task PostResult(RaceResult raceResult, string dir);
    }
}