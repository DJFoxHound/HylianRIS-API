using Hylian.RIS.API.Services.Interfaces;
using Hylian.RIS.API.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Hylian.RIS.API.Services
{
    public static class ServicesInjector
    {

        public static void InjectServices(IServiceCollection serviceCollection, string dbConnectionString)
        {
            RepositoryInjector.InjectRepository(serviceCollection, dbConnectionString);

            serviceCollection.AddScoped<IResultPocService, ResultPocService>();
            /*serviceCollection.AddScoped<IAccountService, AccountService>();
            serviceCollection.AddScoped<IAddressService, AddressService>();
            serviceCollection.AddScoped<IAgeRestrictionService, AgeRestrictionService>();
            serviceCollection.AddScoped<IBreedService, BreedService>();
            serviceCollection.AddScoped<IContactTypeService, ContactTypeService>();
            serviceCollection.AddScoped<ICountryService, CountryService>();
            serviceCollection.AddScoped<ICrewMemberService, CrewMemberService>();
            serviceCollection.AddScoped<ICrewTypeService, CrewTypeService>();
            serviceCollection.AddScoped<IDistanceService, DistanceService>();
            serviceCollection.AddScoped<IDogService, DogService>();
            serviceCollection.AddScoped<IJerseyService, JerseyService>();
            serviceCollection.AddScoped<ILanguageService, LanguageService>();
            serviceCollection.AddScoped<IOrganisationService, OrganisationService>();
            serviceCollection.AddScoped<IPersonService, PersonService>();
            serviceCollection.AddScoped<IRaceClassService, RaceClassService>();
            serviceCollection.AddScoped<IRaceCompetitionService, RaceCompetitionService>();
            serviceCollection.AddScoped<IRaceEventService, RaceEventService>();
            serviceCollection.AddScoped<IRaceLicenseService, RaceLicenseService>();
            serviceCollection.AddScoped<IRaceService, RaceService>();
            serviceCollection.AddScoped<IRaceTrackService, RaceTrackService>();
            serviceCollection.AddScoped<IRaceTypeService, RaceTypeService>();
            serviceCollection.AddScoped<IRoleService, RoleService>();
            serviceCollection.AddScoped<IRunService, RunService>();
            serviceCollection.AddScoped<IRunResultTypeService, RunResultTypeService>();
            serviceCollection.AddScoped<ISexService, SexService>();
            serviceCollection.AddScoped<ITrackRecordService, TrackRecordService>();
            serviceCollection.AddScoped<ITrackSurfaceService, TrackSurfaceService>();*/
        }
    }
}
