using Hylian.RIS.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hylian.RIS.API.Repository
{
    public static class RepositoryInjector
    {
        public static void InjectRepository(IServiceCollection serviceCollection, string dbConnectionString)
        {
            serviceCollection.AddDbContext<DbaseContext>(options => options.UseSqlServer(dbConnectionString, x => x.UseNetTopologySuite().MigrationsAssembly("HylianRIS-API")));

            serviceCollection.AddScoped<IAccountRepository, AccountRepository>();
            serviceCollection.AddScoped<IAddressRepository, AddressRepository>();
            serviceCollection.AddScoped<IAgeRestrictionRepository, AgeRestrictionRepository>();
            serviceCollection.AddScoped<IBreedRepository, BreedRepository>();
            serviceCollection.AddScoped<IContactTypeRepository, ContactTypeRepository>();
            serviceCollection.AddScoped<ICountryRepository, CountryRepository>();
            serviceCollection.AddScoped<ICrewMemberRepository, CrewMemberRepository>();
            serviceCollection.AddScoped<ICrewTypeRepository, CrewTypeRepository>();
            serviceCollection.AddScoped<IDistanceRepository, DistanceRepository>();
            serviceCollection.AddScoped<IDogRepository, DogRepository>();
            serviceCollection.AddScoped<IJerseyRepository, JerseyRepository>();
            serviceCollection.AddScoped<ILanguageRepository, LanguageRepository>();
            serviceCollection.AddScoped<IOrganisationRepository, OrganisationRepository>();
            serviceCollection.AddScoped<IPersonRepository, PersonRepository>();
            serviceCollection.AddScoped<IRaceClassRepository, RaceClassRepository>();
            serviceCollection.AddScoped<IRaceCompetitionRepository, RaceCompetitionRepository>();
            serviceCollection.AddScoped<IRaceEventRepository, RaceEventRepository>();
            serviceCollection.AddScoped<IRaceLicenseRepository, RaceLicenseRepository>();
            serviceCollection.AddScoped<IRaceRepository, RaceRepository>();
            serviceCollection.AddScoped<IRaceTrackRepository, RaceTrackRepository>();
            serviceCollection.AddScoped<IRaceTypeRepository, RaceTypeRepository>();
            serviceCollection.AddScoped<IRoleRepository, RoleRepository>();
            serviceCollection.AddScoped<IRunRepository, RunRepository>();
            serviceCollection.AddScoped<IRunResultTypeRepository, RunResultTypeRepository>();
            serviceCollection.AddScoped<ISexRepository, SexRepository>();
            serviceCollection.AddScoped<ITrackRecordRepository, TrackRecordRepository>();
            serviceCollection.AddScoped<ITrackSurfaceRepository, TrackSurfaceRepository>();
        }
    }
}
