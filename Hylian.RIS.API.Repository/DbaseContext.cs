using Hylian.RIS.API.Domain;
using Hylian.RIS.API.Domain.Enumerators;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hylian.RIS.API.Repository
{
    public class DbaseContext: DbContext, IDbaseContext
    {
        public DbaseContext(DbContextOptions<DbaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ModelCreating
            AccountModelCreating(modelBuilder);
            AccountRoleModelCreating(modelBuilder);
            AddressModelCreating(modelBuilder);
            AgeRestrictionModelCreating(modelBuilder);
            BreedModelCreating(modelBuilder);
            ContactModelCreating(modelBuilder);
            ContactTypeModelCreating(modelBuilder);
            CountryModelCreating(modelBuilder);
            CrewMemberModelCreating(modelBuilder);
            CrewTypeModelCreating(modelBuilder);
            DistanceModelCreating(modelBuilder);
            DogModelCreating(modelBuilder);
            JerseyModelCreating(modelBuilder);
            LanguageModelCreating(modelBuilder);
            OrganisationModelCreating(modelBuilder);
            PersonModelCreating(modelBuilder);
            RaceModelCreating(modelBuilder);
            RaceClassModelCreating(modelBuilder);
            RaceEventModelCreating(modelBuilder);
            RaceCompetitionModelCreating(modelBuilder);
            RaceLicenseModelCreating(modelBuilder);
            RaceTrackModelCreating(modelBuilder);
            RoleModelCreating(modelBuilder);
            RunModelCreating(modelBuilder);
            RunResultModelCreating(modelBuilder);
            SexModelCreating(modelBuilder);
            TrackRecordCreating(modelBuilder);
            #endregion
            modelBuilder.HasDbFunction(() => DbFunctions.JsonValue(default, default));
            modelBuilder.HasDbFunction(() => DbFunctions.JsonQuery(default, default));
            
            Seed(modelBuilder);
        }

        #region ModelCreating
        private void AccountModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Account>().ToTable("Accounts");
            #endregion
            #region Relations
            modelBuilder.Entity<Account>()
                .HasMany(p => p.Roles)
                .WithOne(p => p.Account);

            modelBuilder.Entity<Account>()
                .HasMany(p => p.Persons)
                .WithOne(p => p.Account);
            #endregion
        }
        private void AccountRoleModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<AccountRole>().ToTable("AccountRoles")
                .HasKey(k => new { k.RoleID, k.AccountID, k.OrganisationID });
            #endregion
            #region Relations
            modelBuilder.Entity<AccountRole>()
                .HasOne(p => p.Organisation)
                .WithMany(p => p.Roles)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
        private void AddressModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Address>().ToTable("Addresses");
            #endregion
            #region Relations
            #endregion
        }
        private void AgeRestrictionModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<AgeRestriction>().ToTable("AgeRestrictions")
                .HasKey(k => new { k.BreedID, k.CompetitionID });
            #endregion
            #region Relations
            #endregion
        }
        private void BreedModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Breed>().ToTable("Breeds");
            modelBuilder.Entity<Breed>().Property(l => l._Names).HasColumnName("Names");
            modelBuilder.Entity<Breed>().Property(l => l._PluralNames).HasColumnName("PluralNames");
            #endregion
            #region Relations
            modelBuilder.Entity<Breed>()
            .HasMany(p => p.Classes)
            .WithMany(c => c.Breeds)
            .UsingEntity<Dictionary<string, object>>("BreedClasses",
                j => j
                    .HasOne<RaceClass>()
                    .WithMany()
                    .HasForeignKey("ClassID")
                    .HasConstraintName("FK_BreedClasses_Classes_ClassID")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j
                    .HasOne<Breed>()
                    .WithMany()
                    .HasForeignKey("BreedID")
                    .HasConstraintName("FK_BreedClasses_Breeds_BreedID")
                    .OnDelete(DeleteBehavior.Cascade)
                );

            modelBuilder.Entity<Breed>()
                .HasMany(p => p.AgeRestrictions)
                .WithOne(p => p.Breed);
            #endregion
        }
        private void ContactModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Contact>().ToTable("Contact")
                .HasIndex(i => new { i.OrganisationID, i.TypeID })
                .IsUnique();
            #endregion
            #region Relations
            #endregion
        }
        private void ContactTypeModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<ContactType>().ToTable("ContactTypes");
            #endregion
            #region Relations
            #endregion
        }
        private void CountryModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Country>().ToTable("Countries")
                .HasIndex(i => i.Code)
                .IsUnique();
            #endregion
            #region Relations
            #endregion
        }
        private void CrewMemberModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<CrewMember>().ToTable("CrewMembers")
                .HasKey(k => new { k.EventID, k.PersonID, k.CrewTypeID });
            #endregion
            #region Relations
            #endregion
        }
        private void CrewTypeModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<CrewType>().ToTable("CrewTypes");
            #endregion
            #region Relations
            #endregion
        }
        private void DistanceModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Distance>().ToTable("Distances")
                .HasIndex(i => i.Length)
                .IsUnique();
            modelBuilder.Entity<Distance>().Property(l => l._Names).HasColumnName("Names");
            #endregion
            #region Relations
            #endregion
        }
        private void DogModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Dog>().ToTable("Dogs");
            #endregion
            #region Relations
            modelBuilder.Entity<Dog>()
                .HasMany(p => p.Licenses)
                .WithOne(p => p.Dog);
            modelBuilder.Entity<Dog>()
                .HasMany(p => p.Runs)
                .WithOne(p => p.Dog);
            modelBuilder.Entity<Dog>()
                .HasOne(p => p.Owner)
                .WithMany(p => p.Dogs)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
        private void JerseyModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Jersey>().ToTable("Jerseys")
                .HasIndex(i => new { i.Number, i.CompetitionID })
                .IsUnique();
            modelBuilder.Entity<Jersey>().Property(l => l._Names).HasColumnName("Names");
            modelBuilder.Entity<Jersey>().Property(l => l._Codes).HasColumnName("Codes");
            #endregion
            #region Relations
            #endregion
        }
        private void LanguageModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Language>().ToTable("Languages")
                .HasIndex(i => i.Code)
                .IsUnique();
            #endregion

            #region Relations
            #endregion
        }
        private void OrganisationModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Organisation>().ToTable("Organisations");
            #endregion
            #region Relations
            modelBuilder.Entity<Organisation>()
                .HasMany(p => p.Contacts)
                .WithOne(p => p.Organisation);
            modelBuilder.Entity<Organisation>()
                .HasMany(p => p.Roles)
                .WithOne(p => p.Organisation);
            modelBuilder.Entity<Organisation>()
                .HasMany(p => p.Events)
                .WithOne(p => p.Organisation);
            #endregion
        }
        private void PersonModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Person>().ToTable("Persons");
            #endregion
            #region Relations
            modelBuilder.Entity<Person>()
                .HasMany(p => p.Dogs)
                .WithOne(p => p.Owner);
            #endregion
        }
        private void RaceModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Race>().ToTable("Races");
            #endregion
            #region Relations
            modelBuilder.Entity<Race>()
                .HasMany(p => p.Runs)
                .WithOne(p => p.Race);
            #endregion
        }
        private void RaceClassModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RaceClass>().ToTable("Classes");
            modelBuilder.Entity<RaceClass>().Property(l => l._Names).HasColumnName("Names");
            #endregion
            #region Relations
            modelBuilder.Entity<RaceClass>()
                .HasMany(p => p.Licenses)
                .WithOne(p => p.RaceClass);
            #endregion
        }
        private void RaceCompetitionModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RaceCompetition>().ToTable("Competitions")
                .HasIndex(i => i.Code)
                .IsUnique();
            modelBuilder.Entity<RaceCompetition>()
                .Property(e => e.RunnerTypes)
                .HasConversion(
                    v => string.Join(',',v),
                    v => v.Split(',',StringSplitOptions.TrimEntries).Select(x => (RunnerType)Enum.Parse(typeof(RunnerType),x)).ToList()
                );
            #endregion
            #region Relations
            modelBuilder.Entity<RaceCompetition>()
                .HasMany(p => p.AgeRestrictions)
                .WithOne(p => p.Competition);
            modelBuilder.Entity<RaceCompetition>()
                .HasMany(p => p.Licenses)
                .WithOne(p => p.Competition);
            modelBuilder.Entity<RaceCompetition>()
                .HasMany(p => p.Jerseys)
                .WithOne(p => p.Competition);
            modelBuilder.Entity<RaceCompetition>()
                .HasMany(p => p.Events)
                .WithOne(p => p.Competition);
            modelBuilder.Entity<RaceCompetition>()
            .HasMany(p => p.RaceTypes)
            .WithMany(c => c.Competitions)
            .UsingEntity<Dictionary<string, object>>("CompetitionTypes",
                j => j
                    .HasOne<RaceType>()
                    .WithMany()
                    .HasForeignKey("TypeID")
                    .HasConstraintName("FK_CompetitionTypes_Types_TypeID")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j
                    .HasOne<RaceCompetition>()
                    .WithMany()
                    .HasForeignKey("CompetitionID")
                    .HasConstraintName("FK_CompetitionTypes_Competitions_CompetitionID")
                    .OnDelete(DeleteBehavior.Cascade)
                );
            #endregion
        }
        private void RaceEventModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RaceEvent>().ToTable("Events");
            modelBuilder.Entity<RaceEvent>().Property(l => l._Names).HasColumnName("Names");
            #endregion
            #region Relations
            modelBuilder.Entity<RaceEvent>()
                .HasMany(p => p.Crew)
                .WithOne(p => p.Event);
            modelBuilder.Entity<RaceEvent>()
            .HasMany(p => p.Participants)
            .WithMany(c => c.Events)
            .UsingEntity<Dictionary<string, object>>("Participants",
                j => j
                    .HasOne<Dog>()
                    .WithMany()
                    .HasForeignKey("DogID")
                    .HasConstraintName("FK_Participants_Dogs_DogID")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j
                    .HasOne<RaceEvent>()
                    .WithMany()
                    .HasForeignKey("EventID")
                    .HasConstraintName("FK_Participants_Events_EventID")
                    .OnDelete(DeleteBehavior.Cascade)
                );
            modelBuilder.Entity<RaceEvent>()
                .HasMany(p => p.Races)
                .WithOne(p => p.Event);
            modelBuilder.Entity<RaceEvent>()
                .HasOne(p => p.Organisation)
                .WithMany(p => p.Events)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
        private void RaceLicenseModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RaceLicense>().ToTable("RaceLicenses");
            #endregion
            #region Relations
            modelBuilder.Entity<RaceLicense>()
                .HasOne(p => p.Competition)
                .WithMany(p => p.Licenses)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
        private void RaceTrackModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RaceTrack>().ToTable("Tracks")
                .HasIndex(i => i.Code)
                .IsUnique();
            #endregion
            #region Relations
            modelBuilder.Entity<RaceTrack>()
            .HasMany(p => p.Competitions)
            .WithMany(c => c.Tracks)
            .UsingEntity<Dictionary<string, object>>("CompetitionTracks",
                j => j
                    .HasOne<RaceCompetition>()
                    .WithMany()
                    .HasForeignKey("CompetitionID")
                    .HasConstraintName("FK_CompetitionTracks_Competitions_CompetitionID")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j
                    .HasOne<RaceTrack>()
                    .WithMany()
                    .HasForeignKey("TrackID")
                    .HasConstraintName("FK_CompetitionTracks_Tracks_TrackID")
                    .OnDelete(DeleteBehavior.Cascade)
                );
            modelBuilder.Entity<RaceTrack>()
            .HasMany(p => p.Distances)
            .WithMany(c => c.Tracks)
            .UsingEntity<Dictionary<string, object>>("TrackDistances",
                j => j
                    .HasOne<Distance>()
                    .WithMany()
                    .HasForeignKey("DistanceID")
                    .HasConstraintName("FK_TrackDistances_Distances_DistanceID")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j
                    .HasOne<RaceTrack>()
                    .WithMany()
                    .HasForeignKey("TrackID")
                    .HasConstraintName("FK_TrackDistances_Tracks_TrackID")
                    .OnDelete(DeleteBehavior.Cascade)
                );
            modelBuilder.Entity<RaceTrack>()
            .HasMany(p => p.Organisations)
            .WithMany(c => c.RaceTracks)
            .UsingEntity<Dictionary<string, object>>("TrackOrganisations",
                j => j
                    .HasOne<Organisation>()
                    .WithMany()
                    .HasForeignKey("OrganisationID")
                    .HasConstraintName("FK_TrackOrganisations_Organisations_OrganisationID")
                    .OnDelete(DeleteBehavior.Cascade),
                j => j
                    .HasOne<RaceTrack>()
                    .WithMany()
                    .HasForeignKey("TrackID")
                    .HasConstraintName("FK_TrackOrganisations_Tracks_TrackID")
                    .OnDelete(DeleteBehavior.Restrict)
                );
            modelBuilder.Entity<RaceTrack>()
                .HasMany(p => p.Events)
                .WithOne(p => p.Track);
            modelBuilder.Entity<RaceTrack>()
                .HasMany(p => p.TrackRecords)
                .WithOne(p => p.Track);
            #endregion
        }
        private void RoleModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Role>().ToTable("Roles");
            #endregion
            #region Relations
            modelBuilder.Entity<Role>()
                .HasMany(p => p.Accounts)
                .WithOne(p => p.Role);
            #endregion
        }
        private void RunModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Run>().ToTable("Runs");
            #endregion
            #region Relations
            modelBuilder.Entity<Run>()
                .HasOne(p => p.Race)
                .WithMany(p => p.Runs)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
        private void RunResultModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RunResultType>().ToTable("RunResultTypes")
                .HasIndex(i => i.Code)
                .IsUnique();
            #endregion
            #region Relations
            modelBuilder.Entity<RunResultType>()
                .HasIndex(p => p.Code)
                .IsUnique();
            #endregion
        }
        private void SexModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<Sex>().ToTable("Sexes")
                .HasIndex(i => i.Code)
                .IsUnique();
            modelBuilder.Entity<Sex>().Property(l => l._Names).HasColumnName("Names");
            modelBuilder.Entity<Sex>().Property(l => l._PluralNames).HasColumnName("PluralNames");
            #endregion
            #region Relations
            #endregion
        }
        private void TrackRecordCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<TrackRecord>().ToTable("TrackRecords")
                .HasIndex(i => new { i.TrackID, i.DistanceID, i.BreedID, i.SexID })
                .IsUnique();
            #endregion
            #region Relations
            #endregion
        }
        #endregion
        #region DbSets
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<AgeRestriction> AgeRestrictions { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<CrewType> CrewTypes { get; set; }
        public DbSet<Distance> Distances { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Jersey> Jerseys { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceClass> RaceClasses { get; set; }
        public DbSet<RaceCompetition> Competitions { get; set; }
        public DbSet<RaceEvent> Events { get; set; }
        public DbSet<RaceLicense> Licenses { get; set; }
        public DbSet<RaceTrack> RaceTracks { get; set; }
        public DbSet<RaceType> RaceTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Run> Runs { get; set; }
        public DbSet<RunResultType> RunResultTypes { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<TrackRecord> TrackRecords { get; set; }
        #endregion
        #region Seeding
        private void Seed(ModelBuilder modelBuilder)
        {
            SeedBreeds(modelBuilder);
            SeedSexes(modelBuilder);
            SeedCountries(modelBuilder);
            SeedLanguages(modelBuilder);
            SeedDistances(modelBuilder);
            SeedRaceTypes(modelBuilder);
            SeedRunResultTypes(modelBuilder);
            SeedCrewTypes(modelBuilder);
            SeedCompetitions(modelBuilder);
            SeedAgeRestrictions(modelBuilder);
            SeedJerseys(modelBuilder);
            SeedRaceClasses(modelBuilder);
            SeedAddresses(modelBuilder);
        }

        private void SeedBreeds(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Breed>().HasData(new List<Breed>(){
                new Breed() { ID = new Guid("7F991E29-2E61-48E7-B97A-50F90A573CAC"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Afghan Hound"}, new LanguageText() { LanguageCode="nl",Text="Afgaanse Windhond"}, new LanguageText() { LanguageCode="fr",Text="Levrier Afghan"}, new LanguageText() { LanguageCode="de",Text="Afghanischer Windhund"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Afghan Hound"}, new LanguageText() { LanguageCode="nl",Text="Afgaanse Windhond"}, new LanguageText() { LanguageCode="fr",Text="Levrier Afghan"}, new LanguageText() { LanguageCode="de",Text="Afghanischer Windhund"} }},
                new Breed() { ID = new Guid("4E469CFA-B1F1-452A-B983-70A803AAD06C"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Azawakh"}, new LanguageText() { LanguageCode="nl",Text="Azawakh"}, new LanguageText() { LanguageCode="fr",Text="Azawakh"}, new LanguageText() { LanguageCode="de",Text="Azawakh"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Azawakh"}, new LanguageText() { LanguageCode="nl",Text="Azawakh"}, new LanguageText() { LanguageCode="fr",Text="Azawakh"}, new LanguageText() { LanguageCode="de",Text="Azawakh"} }},
                new Breed() { ID = new Guid("677F5EFC-E697-4E8D-9FFE-DDF61394D595"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Basenji"}, new LanguageText() { LanguageCode="nl",Text="Basenji"}, new LanguageText() { LanguageCode="fr",Text="Basenji"}, new LanguageText() { LanguageCode="de",Text="Basenji"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Basenji"}, new LanguageText() { LanguageCode="nl",Text="Basenji"}, new LanguageText() { LanguageCode="fr",Text="Basenji"}, new LanguageText() { LanguageCode="de",Text="Basenji"} }},
                new Breed() { ID = new Guid("33BBE8C5-D286-4E45-91A0-0EC52CDEA9C8"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Borzoi"}, new LanguageText() { LanguageCode="nl",Text="Barzoi"}, new LanguageText() { LanguageCode="fr",Text="Barzoi"}, new LanguageText() { LanguageCode="de",Text="Barsoi"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Borzoi"}, new LanguageText() { LanguageCode="nl",Text="Barzoi"}, new LanguageText() { LanguageCode="fr",Text="Barzoi"}, new LanguageText() { LanguageCode="de",Text="Barsoi"} }},
                new Breed() { ID = new Guid("6786B78B-611E-430A-A589-65DF5C302E11"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cirneco dell’Etna"}, new LanguageText() { LanguageCode="nl",Text="Cirneco dell’Etna"}, new LanguageText() { LanguageCode="fr",Text="Cirneco de l’Etna"}, new LanguageText() { LanguageCode="de",Text="Cirneco dell’Etna"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cirneco dell’Etna"}, new LanguageText() { LanguageCode="nl",Text="Cirneco dell’Etna"}, new LanguageText() { LanguageCode="fr",Text="Cirneco de l’Etna"}, new LanguageText() { LanguageCode="de",Text="Cirneco dell’Etna"} }},
                new Breed() { ID = new Guid("D670C778-A372-455B-9570-05A1FC330023"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Deerhound"}, new LanguageText() { LanguageCode="nl",Text="Deerhound"}, new LanguageText() { LanguageCode="fr",Text="Deerhounds"}, new LanguageText() { LanguageCode="de",Text="Schottischer Hirschhund"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Deerhound"}, new LanguageText() { LanguageCode="nl",Text="Deerhound"}, new LanguageText() { LanguageCode="fr",Text="Deerhounds"}, new LanguageText() { LanguageCode="de",Text="Schottischer Hirschhund"} }},
                new Breed() { ID = new Guid("0B50FF12-D15F-4995-9F0F-4B21E96F862B"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Greyhound"}, new LanguageText() { LanguageCode="nl",Text="Greyhound"}, new LanguageText() { LanguageCode="fr",Text="Levrier Anglais"}, new LanguageText() { LanguageCode="de",Text="Greyhound"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Greyhound"}, new LanguageText() { LanguageCode="nl",Text="Greyhound"}, new LanguageText() { LanguageCode="fr",Text="Levrier Anglais"}, new LanguageText() { LanguageCode="de",Text="Greyhound"} }},
                new Breed() { ID = new Guid("42AC8B3A-BBFB-4243-B104-D608EFDCF7B4"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Hungarian Greyhound - Magyar Agar"}, new LanguageText() { LanguageCode="nl",Text="Hongaarse Windhond - Magyar Agar"}, new LanguageText() { LanguageCode="fr",Text="Levrier Hongrois - Magyar Agar"}, new LanguageText() { LanguageCode="de",Text="Ungarischer Wundhund - Magyar Agar"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Hungarian Greyhound - Magyar Agar"}, new LanguageText() { LanguageCode="nl",Text="Hongaarse Windhond - Magyar Agar"}, new LanguageText() { LanguageCode="fr",Text="Levrier Hongrois - Magyar Agar"}, new LanguageText() { LanguageCode="de",Text="Ungarischer Wundhund - Magyar Agar"} }},
                new Breed() { ID = new Guid("59BEC42E-A9B1-44B4-BF6C-57566D8CF8BB"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Irish Wolfhound"}, new LanguageText() { LanguageCode="nl",Text="Ierse Wolfshond"}, new LanguageText() { LanguageCode="fr",Text="Levrier Irlandais"}, new LanguageText() { LanguageCode="de",Text="Irischer Wolfshund"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Irish Wolfhound"}, new LanguageText() { LanguageCode="nl",Text="Ierse Wolfshond"}, new LanguageText() { LanguageCode="fr",Text="Levrier Irlandais"}, new LanguageText() { LanguageCode="de",Text="Irischer Wolfshund"} }},
                new Breed() { ID = new Guid("A52BCB82-9D9D-41A7-AD2D-F1B037E937A3"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Italian Greyhound"}, new LanguageText() { LanguageCode="nl",Text="Italiaanse Windhond - PLI"}, new LanguageText() { LanguageCode="fr",Text="Levrette d'Italie - PLI"}, new LanguageText() { LanguageCode="de",Text="Italienisches Windspiel"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Italian Greyhound"}, new LanguageText() { LanguageCode="nl",Text="Italiaanse Windhond - PLI"}, new LanguageText() { LanguageCode="fr",Text="Levrette d'Italie - PLI"}, new LanguageText() { LanguageCode="de",Text="Italienisches Windspiel"} }},
                new Breed() { ID = new Guid("B64AFE74-5FC1-4D42-BB9C-F2FDD65E90A7"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Italian Greyhound Sprinter"}, new LanguageText() { LanguageCode="nl",Text="Italiaanse Windhond - PLI Sprinter"}, new LanguageText() { LanguageCode="fr",Text="Levrette d'Italie - PLI Sprinters"}, new LanguageText() { LanguageCode="de",Text="Italienisches Windspiel Sprinters"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Italian Greyhound Sprinter"}, new LanguageText() { LanguageCode="nl",Text="Italiaanse Windhond - PLI Sprinter"}, new LanguageText() { LanguageCode="fr",Text="Levrette d'Italie - PLI Sprinters"}, new LanguageText() { LanguageCode="de",Text="Italienisches Windspiel Sprinters"} }},
                new Breed() { ID = new Guid("1EC110CC-7F70-4060-93EF-58727FCBAEB9"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Pharao Hound"}, new LanguageText() { LanguageCode="nl",Text="Pharao Hound"}, new LanguageText() { LanguageCode="fr",Text="Chien du Pharaon"}, new LanguageText() { LanguageCode="de",Text="Pharaonenhund"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Pharao Hound"}, new LanguageText() { LanguageCode="nl",Text="Pharao Hound"}, new LanguageText() { LanguageCode="fr",Text="Chien du Pharaon"}, new LanguageText() { LanguageCode="de",Text="Pharaonenhund"} }},
                new Breed() { ID = new Guid("72A99B45-1069-4576-AE00-242B563C6BAD"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Polish Greyhound - Chart Polski"}, new LanguageText() { LanguageCode="nl",Text="Poolse Windhond - Chart Polski"}, new LanguageText() { LanguageCode="fr",Text="Levrier Polonais - Chart Polski"}, new LanguageText() { LanguageCode="de",Text="Polnischer Windhund - Chart Polski"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Polish Greyhound - Chart Polski"}, new LanguageText() { LanguageCode="nl",Text="Poolse Windhond - Chart Polski"}, new LanguageText() { LanguageCode="fr",Text="Levrier Polonais - Chart Polski"}, new LanguageText() { LanguageCode="de",Text="Polnischer Windhund - Chart Polski"} }},
                new Breed() { ID = new Guid("3A366646-A678-4706-A7EB-9EB1CC1B4961"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Saluki"}, new LanguageText() { LanguageCode="nl",Text="Saluki"}, new LanguageText() { LanguageCode="fr",Text="Saluki"}, new LanguageText() { LanguageCode="de",Text="Saluki"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Saluki"}, new LanguageText() { LanguageCode="nl",Text="Saluki"}, new LanguageText() { LanguageCode="fr",Text="Saluki"}, new LanguageText() { LanguageCode="de",Text="Saluki"} }},
                new Breed() { ID = new Guid("453ABB88-6912-42C2-9F77-90582D1D467F"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Sloughi"}, new LanguageText() { LanguageCode="nl",Text="Sloughi"}, new LanguageText() { LanguageCode="fr",Text="Sloughi"}, new LanguageText() { LanguageCode="de",Text="Sloughi"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Sloughi"}, new LanguageText() { LanguageCode="nl",Text="Sloughi"}, new LanguageText() { LanguageCode="fr",Text="Sloughi"}, new LanguageText() { LanguageCode="de",Text="Sloughi"} }},
                new Breed() { ID = new Guid("5E04BDAF-A785-456B-A18E-CC4922A1E776"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Spanish Greyhound - Galgo Espagnol"}, new LanguageText() { LanguageCode="nl",Text="Spaanse Windhond - Galgo Espagnol"}, new LanguageText() { LanguageCode="fr",Text="Levier Espagnol - Galgo Espagnol"}, new LanguageText() { LanguageCode="de",Text="Spanischer Windhund - Galgo Espagnol"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Spanish Greyhound - Galgo Espagnol"}, new LanguageText() { LanguageCode="nl",Text="Spaanse Windhond - Galgo Espagnol"}, new LanguageText() { LanguageCode="fr",Text="Levier Espagnol - Galgo Espagnol"}, new LanguageText() { LanguageCode="de",Text="Spanischer Windhund - Galgo Espagnol"} }},
                new Breed() { ID = new Guid("C1D0390A-A688-498E-A1F1-782ED18B2787"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Whippet"}, new LanguageText() { LanguageCode="nl",Text="Whippet"}, new LanguageText() { LanguageCode="fr",Text="Whippet"}, new LanguageText() { LanguageCode="de",Text="Whippet"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Whippet"}, new LanguageText() { LanguageCode="nl",Text="Whippet"}, new LanguageText() { LanguageCode="fr",Text="Whippet"}, new LanguageText() { LanguageCode="de",Text="Whippet"} }},
                new Breed() { ID = new Guid("2BB65B3A-0D1C-4D8E-AA2D-1648358DF96C"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Whippet Sprinter"}, new LanguageText() { LanguageCode="nl",Text="Whippet Sprinter"}, new LanguageText() { LanguageCode="fr",Text="Whippet Sprinter"}, new LanguageText() { LanguageCode="de",Text="Whippet Sprinter"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Whippet Sprinter"}, new LanguageText() { LanguageCode="nl",Text="Whippet Sprinter"}, new LanguageText() { LanguageCode="fr",Text="Whippet Sprinter"}, new LanguageText() { LanguageCode="de",Text="Whippet Sprinter"} }},
                new Breed() { ID = new Guid("02B86E36-0CCD-435B-B665-6C7B2B246244"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Podenco Iberico"}, new LanguageText() { LanguageCode="nl",Text="Podenco Iberico"}, new LanguageText() { LanguageCode="fr",Text="Podenco Iberico"}, new LanguageText() { LanguageCode="de",Text="Podenco Iberico"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Podenco Iberico"}, new LanguageText() { LanguageCode="nl",Text="Podenco Iberico"}, new LanguageText() { LanguageCode="fr",Text="Podenco Iberico"}, new LanguageText() { LanguageCode="de",Text="Podenco Iberico"} }},
            });
        }
        private void SeedSexes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sex>().HasData(new List<Sex>(){
                new Sex() { ID = new Guid("818FF154-7208-4F28-880E-19F48CCB94AD"), Code="M", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Male"}, new LanguageText() { LanguageCode="nl",Text="Reu"}, new LanguageText() { LanguageCode="fr",Text="Male"}, new LanguageText() { LanguageCode="de",Text="Hund"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "Males" }, new LanguageText() { LanguageCode = "nl", Text = "Reuen" }, new LanguageText() { LanguageCode = "fr", Text = "Males" }, new LanguageText() { LanguageCode = "de", Text = "Rüden" } } },
                new Sex() { ID = new Guid("3EB13E00-2006-40BD-A15F-AECB206A5C72"), Code="F", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bitch"}, new LanguageText() { LanguageCode="nl",Text="Teef"}, new LanguageText() { LanguageCode="fr",Text="Femelle"}, new LanguageText() { LanguageCode="de",Text="Hündin"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bitches"}, new LanguageText() { LanguageCode="nl",Text="Teven"}, new LanguageText() { LanguageCode="fr",Text="Femelles"}, new LanguageText() { LanguageCode="de",Text="Hündinnen"} } },
                new Sex() { ID = new Guid("83B150FE-89C0-4FE2-947E-18198244963F"), Code="X", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Mixed"}, new LanguageText() { LanguageCode="nl",Text="Gemengd"}, new LanguageText() { LanguageCode="fr",Text="Mixe"}, new LanguageText() { LanguageCode="de",Text="Gesmischt"} }, PluralNames = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Mixed"}, new LanguageText() { LanguageCode="nl",Text="Gemengd"}, new LanguageText() { LanguageCode="fr",Text="Mixe"}, new LanguageText() { LanguageCode="de",Text="Gesmischt"} } }        
            });
        }
        private void SeedCountries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new List<Country>(){
                new Country() { ID = new Guid("6465214D-59D3-43B8-A4BE-551C97580858"), Code = "AFG", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Afghanistan"}, new LanguageText() { LanguageCode="nl",Text="Afghanistan"}, new LanguageText() { LanguageCode="fr",Text="Afghanistan"}, new LanguageText() { LanguageCode="de",Text="Afghanistan"} }},
                new Country() { ID = new Guid("C6D7509D-FEC0-4CB3-B03D-4B8BD72B8FCF"), Code = "ALB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Albania"}, new LanguageText() { LanguageCode="nl",Text="Albanië"}, new LanguageText() { LanguageCode="fr",Text="Albanie"}, new LanguageText() { LanguageCode="de",Text="Albanien"} }},
                new Country() { ID = new Guid("A54BAB81-9678-4992-AD04-AA18C87120C7"), Code = "DZA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Algeria"}, new LanguageText() { LanguageCode="nl",Text="Algerije"}, new LanguageText() { LanguageCode="fr",Text="Algérie"}, new LanguageText() { LanguageCode="de",Text="Algerien"} }},
                new Country() { ID = new Guid("4DFCA244-8C66-40B0-82BC-7076542AD027"), Code = "AND", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Andorra"}, new LanguageText() { LanguageCode="nl",Text="Andorra"}, new LanguageText() { LanguageCode="fr",Text="Andorre"}, new LanguageText() { LanguageCode="de",Text="Andorra"} }},
                new Country() { ID = new Guid("DD5F860F-9D88-4253-8B82-878BD8287A84"), Code = "AGO", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Angola"}, new LanguageText() { LanguageCode="nl",Text="Angola"}, new LanguageText() { LanguageCode="fr",Text="Angola"}, new LanguageText() { LanguageCode="de",Text="Angola"} }},
                new Country() { ID = new Guid("7D0F5947-FD33-46F4-B57E-4A1A910C0B77"), Code = "ATG", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Antigua and Barbuda"}, new LanguageText() { LanguageCode="nl",Text="Antigua en Barbuda"}, new LanguageText() { LanguageCode="fr",Text="Antigua-et-Barbuda"}, new LanguageText() { LanguageCode="de",Text="Antigua und Barbuda"} }},
                new Country() { ID = new Guid("E89F370F-B87B-4234-A392-42E4FF43DEB1"), Code = "ARG", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Argentina"}, new LanguageText() { LanguageCode="nl",Text="Argentinië"}, new LanguageText() { LanguageCode="fr",Text="Argentine"}, new LanguageText() { LanguageCode="de",Text="Argentinien"} }},
                new Country() { ID = new Guid("7CB33A38-E968-4A9D-A0F2-37F89C8B6D6A"), Code = "ARM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Armenia"}, new LanguageText() { LanguageCode="nl",Text="Armenië"}, new LanguageText() { LanguageCode="fr",Text="Arménie"}, new LanguageText() { LanguageCode="de",Text="Armenien"} }},
                new Country() { ID = new Guid("6B2325C8-9F2B-40C7-A1BD-9D022E51522B"), Code = "AUS", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Australia"}, new LanguageText() { LanguageCode="nl",Text="Australië"}, new LanguageText() { LanguageCode="fr",Text="Australie"}, new LanguageText() { LanguageCode="de",Text="Australien"} }},
                new Country() { ID = new Guid("B5CA2166-5CFD-4449-BCB8-1112FE2A850C"), Code = "AUT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Austria"}, new LanguageText() { LanguageCode="nl",Text="Oostenrijk"}, new LanguageText() { LanguageCode="fr",Text="Autriche"}, new LanguageText() { LanguageCode="de",Text="Österreich"} }},
                new Country() { ID = new Guid("C90C38CF-7408-4D17-A976-30D3D7CFD80C"), Code = "AZE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Azerbaijan"}, new LanguageText() { LanguageCode="nl",Text="Azerbeidzjan"}, new LanguageText() { LanguageCode="fr",Text="Azerbaïdjan"}, new LanguageText() { LanguageCode="de",Text="Aserbaidschan"} }},
                new Country() { ID = new Guid("69CE0187-9AAD-4904-B2E1-AC999485B4C8"), Code = "BHS", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bahamas"}, new LanguageText() { LanguageCode="nl",Text="Bahama's"}, new LanguageText() { LanguageCode="fr",Text="Bahamas"}, new LanguageText() { LanguageCode="de",Text="Bahamas"} }},
                new Country() { ID = new Guid("50ABE28E-6664-43B7-956C-F12BE24B7811"), Code = "BHR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bahrain"}, new LanguageText() { LanguageCode="nl",Text="Bahrein"}, new LanguageText() { LanguageCode="fr",Text="Bahreïn"}, new LanguageText() { LanguageCode="de",Text="Bahrain"} }},
                new Country() { ID = new Guid("BC4A3E7F-1C47-47F1-B881-0D671564FD4C"), Code = "BGD", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bangladesh"}, new LanguageText() { LanguageCode="nl",Text="Bangladesh"}, new LanguageText() { LanguageCode="fr",Text="Bangladesh"}, new LanguageText() { LanguageCode="de",Text="Bangladesch"} }},
                new Country() { ID = new Guid("35C08100-EDE7-4970-BA51-EB5B1168E71D"), Code = "BRB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Barbados"}, new LanguageText() { LanguageCode="nl",Text="Barbados"}, new LanguageText() { LanguageCode="fr",Text="Barbade"}, new LanguageText() { LanguageCode="de",Text="Barbados"} }},
                new Country() { ID = new Guid("FBB84182-C3F1-422E-B98F-CA09E8AD0D69"), Code = "BLR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Belarus"}, new LanguageText() { LanguageCode="nl",Text="Wit-Rusland"}, new LanguageText() { LanguageCode="fr",Text="Belarus"}, new LanguageText() { LanguageCode="de",Text="Weißrussland"} }},
                new Country() { ID = new Guid("0AFEC050-198A-4248-B736-E5BD611550A9"), Code = "BEL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Belgium"}, new LanguageText() { LanguageCode="nl",Text="België"}, new LanguageText() { LanguageCode="fr",Text="Belgique"}, new LanguageText() { LanguageCode="de",Text="Belgien"} }},
                new Country() { ID = new Guid("87E22DD2-FAC7-43BB-97ED-7F6ABA95CEBE"), Code = "BLZ", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Belize"}, new LanguageText() { LanguageCode="nl",Text="Belize"}, new LanguageText() { LanguageCode="fr",Text="Belize"}, new LanguageText() { LanguageCode="de",Text="Belize"} }},
                new Country() { ID = new Guid("6A779A8B-003F-4A05-9876-6D7F2C3BA060"), Code = "BEN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Benin"}, new LanguageText() { LanguageCode="nl",Text="Benin"}, new LanguageText() { LanguageCode="fr",Text="Bénin"}, new LanguageText() { LanguageCode="de",Text="Benin"} }},
                new Country() { ID = new Guid("CAABCA5C-597F-4AD8-A93C-56F095C7F096"), Code = "BTN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bhutan"}, new LanguageText() { LanguageCode="nl",Text="Bhutan"}, new LanguageText() { LanguageCode="fr",Text="Bhoutan"}, new LanguageText() { LanguageCode="de",Text="Bhutan"} }},
                new Country() { ID = new Guid("360E18BD-6832-4FB6-BD06-381A8CF17D36"), Code = "BOL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bolivia"}, new LanguageText() { LanguageCode="nl",Text="Bolivia"}, new LanguageText() { LanguageCode="fr",Text="Bolivie"}, new LanguageText() { LanguageCode="de",Text="Bolivien"} }},
                new Country() { ID = new Guid("820F90BC-2670-43E6-B4BC-DC543A9B6DDA"), Code = "BIH", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bosnia and Herzegovina"}, new LanguageText() { LanguageCode="nl",Text="Bosnië en Herzegovina"}, new LanguageText() { LanguageCode="fr",Text="Bosnie-Herzégovine"}, new LanguageText() { LanguageCode="de",Text="Bosnien und Herzegowina"} }},
                new Country() { ID = new Guid("45E5153A-9C30-4951-A724-1326E549E420"), Code = "BWA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Botswana"}, new LanguageText() { LanguageCode="nl",Text="Botswana"}, new LanguageText() { LanguageCode="fr",Text="Botswana"}, new LanguageText() { LanguageCode="de",Text="Botswana"} }},
                new Country() { ID = new Guid("EC4EBC6A-A4C1-4897-B793-F17C93E173E9"), Code = "BRA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Brazil"}, new LanguageText() { LanguageCode="nl",Text="Brazilië"}, new LanguageText() { LanguageCode="fr",Text="Brésil"}, new LanguageText() { LanguageCode="de",Text="Brasilien"} }},
                new Country() { ID = new Guid("8BFE495D-BB0E-4819-B792-1372913F825B"), Code = "BRN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Brunei"}, new LanguageText() { LanguageCode="nl",Text="Brunei"}, new LanguageText() { LanguageCode="fr",Text="Brunei"}, new LanguageText() { LanguageCode="de",Text="Brunei"} }},
                new Country() { ID = new Guid("340B58E3-0E57-42AB-92CA-7A774902FBF3"), Code = "BGR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Bulgaria"}, new LanguageText() { LanguageCode="nl",Text="Bulgarije"}, new LanguageText() { LanguageCode="fr",Text="Bulgarie"}, new LanguageText() { LanguageCode="de",Text="Bulgarien"} }},
                new Country() { ID = new Guid("1E6A616F-D9F5-4744-947B-8E37839EBFA2"), Code = "BFA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Burkina Faso"}, new LanguageText() { LanguageCode="nl",Text="Burkina Faso"}, new LanguageText() { LanguageCode="fr",Text="Burkina Faso"}, new LanguageText() { LanguageCode="de",Text="Burkina Faso"} }},
                new Country() { ID = new Guid("32CB7E58-C98B-4AB3-8923-6952D4326970"), Code = "BDI", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Burundi"}, new LanguageText() { LanguageCode="nl",Text="Burundi"}, new LanguageText() { LanguageCode="fr",Text="Burundi"}, new LanguageText() { LanguageCode="de",Text="Burundi"} }},
                new Country() { ID = new Guid("E42E318A-026B-4008-A775-6949A99A1EFF"), Code = "KHM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cambodia"}, new LanguageText() { LanguageCode="nl",Text="Cambodja"}, new LanguageText() { LanguageCode="fr",Text="Cambodge"}, new LanguageText() { LanguageCode="de",Text="Kambodscha"} }},
                new Country() { ID = new Guid("589F9EE4-3750-4370-A27C-6508670848C8"), Code = "CMR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cameroon"}, new LanguageText() { LanguageCode="nl",Text="Kameroen"}, new LanguageText() { LanguageCode="fr",Text="Cameroun"}, new LanguageText() { LanguageCode="de",Text="Kamerun"} }},
                new Country() { ID = new Guid("1E368542-5666-4CDA-A572-E177F2408D26"), Code = "CAN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Canada"}, new LanguageText() { LanguageCode="nl",Text="Canada"}, new LanguageText() { LanguageCode="fr",Text="Canada"}, new LanguageText() { LanguageCode="de",Text="Kanada"} }},
                new Country() { ID = new Guid("37F0D470-847E-4F5B-9EBB-193288A58708"), Code = "CPV", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cape Verde"}, new LanguageText() { LanguageCode="nl",Text="Kaapverdië"}, new LanguageText() { LanguageCode="fr",Text="Cap-Vert"}, new LanguageText() { LanguageCode="de",Text="Kap Verde"} }},
                new Country() { ID = new Guid("B87B82AB-72A4-4D3F-8B36-2869096187F7"), Code = "CAF", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Central African Republic"}, new LanguageText() { LanguageCode="nl",Text="Centraal-Afrikaanse Republiek"}, new LanguageText() { LanguageCode="fr",Text="République centrafricaine"}, new LanguageText() { LanguageCode="de",Text="Zentral­afrikanische Republik"} }},
                new Country() { ID = new Guid("0B4C2720-07B9-456E-BF80-39C77E9B7EE2"), Code = "TCD", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Chad"}, new LanguageText() { LanguageCode="nl",Text="Tsjaad"}, new LanguageText() { LanguageCode="fr",Text="Tchad"}, new LanguageText() { LanguageCode="de",Text="Tschad"} }},
                new Country() { ID = new Guid("5372FDAA-99EA-40A6-9FF2-FBA37E6C55EA"), Code = "CHL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Chile"}, new LanguageText() { LanguageCode="nl",Text="Chili"}, new LanguageText() { LanguageCode="fr",Text="Chili"}, new LanguageText() { LanguageCode="de",Text="Chile"} }},
                new Country() { ID = new Guid("FF464088-9616-43ED-9B1B-38F302EDC8EE"), Code = "CHN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="China"}, new LanguageText() { LanguageCode="nl",Text="China"}, new LanguageText() { LanguageCode="fr",Text="Chine"}, new LanguageText() { LanguageCode="de",Text="China"} }},
                new Country() { ID = new Guid("1DF4A070-D82A-4FAB-9C24-61AB6014ED75"), Code = "COL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Colombia"}, new LanguageText() { LanguageCode="nl",Text="Colombia"}, new LanguageText() { LanguageCode="fr",Text="Colombie"}, new LanguageText() { LanguageCode="de",Text="Kolumbien"} }},
                new Country() { ID = new Guid("0088049B-C496-43F1-B6A6-5ABC8E2762BB"), Code = "COM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Comoros"}, new LanguageText() { LanguageCode="nl",Text="Comoren"}, new LanguageText() { LanguageCode="fr",Text="Comores"}, new LanguageText() { LanguageCode="de",Text="Komoren"} }},
                new Country() { ID = new Guid("5FFA6C6E-8835-4237-824B-96DEEA84CC4C"), Code = "COD", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Democratic Republic of the Congo"}, new LanguageText() { LanguageCode="nl",Text="Democratische Republiek Congo"}, new LanguageText() { LanguageCode="fr",Text="République démocratique du Congo"}, new LanguageText() { LanguageCode="de",Text="Demokratische Republik Kongo"} }},
                new Country() { ID = new Guid("66FE58A6-A1EC-43DB-84FE-1E88FDDBE01F"), Code = "COG", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Republic of Congo"}, new LanguageText() { LanguageCode="nl",Text="Republiek Congo"}, new LanguageText() { LanguageCode="fr",Text="Congo"}, new LanguageText() { LanguageCode="de",Text="Republik Kongo"} }},
                new Country() { ID = new Guid("B2D673E9-8749-4E2C-8F41-F723D93B0D71"), Code = "COK", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cook Islands"}, new LanguageText() { LanguageCode="nl",Text="Cookeilanden"}, new LanguageText() { LanguageCode="fr",Text="Îles Cook"}, new LanguageText() { LanguageCode="de",Text="Cookinseln"} }},
                new Country() { ID = new Guid("6C8032D8-384F-44B2-A2A2-864003CEADBA"), Code = "CRI", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Costa Rica"}, new LanguageText() { LanguageCode="nl",Text="Costa Rica"}, new LanguageText() { LanguageCode="fr",Text="Costa Rica"}, new LanguageText() { LanguageCode="de",Text="Costa Rica"} }},
                new Country() { ID = new Guid("F0270845-1810-40F1-B3AC-BF111C42892D"), Code = "CIV", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cote d'Ivoire"}, new LanguageText() { LanguageCode="nl",Text="Ivoorkust"}, new LanguageText() { LanguageCode="fr",Text="Côte d'Ivoire"}, new LanguageText() { LanguageCode="de",Text="Elfenbeinküste"} }},
                new Country() { ID = new Guid("024D4F47-56D4-4267-A298-BD54D6F80634"), Code = "HRV", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Croatia"}, new LanguageText() { LanguageCode="nl",Text="Kroatië"}, new LanguageText() { LanguageCode="fr",Text="Croatie"}, new LanguageText() { LanguageCode="de",Text="Kroatien"} }},
                new Country() { ID = new Guid("D99823EF-9BBF-404A-9F12-72217DC66A20"), Code = "CUB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cuba"}, new LanguageText() { LanguageCode="nl",Text="Cuba"}, new LanguageText() { LanguageCode="fr",Text="Cuba"}, new LanguageText() { LanguageCode="de",Text="Kuba"} }},
                new Country() { ID = new Guid("DAEC9832-78F3-4351-B1C1-F87311F37669"), Code = "CYP", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Cyprus"}, new LanguageText() { LanguageCode="nl",Text="Cyprus"}, new LanguageText() { LanguageCode="fr",Text="Chypre"}, new LanguageText() { LanguageCode="de",Text="Zypern"} }},
                new Country() { ID = new Guid("2335932D-DECC-46AE-A4E0-066E1B7756C3"), Code = "CZE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Czech Republic"}, new LanguageText() { LanguageCode="nl",Text="Tsjechië"}, new LanguageText() { LanguageCode="fr",Text="République tchèque"}, new LanguageText() { LanguageCode="de",Text="Tschechien"} }},
                new Country() { ID = new Guid("84305281-52DC-4A09-B9BE-318920ADAB26"), Code = "DNK", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Denmark"}, new LanguageText() { LanguageCode="nl",Text="Denemarken"}, new LanguageText() { LanguageCode="fr",Text="Danemark"}, new LanguageText() { LanguageCode="de",Text="Dänemark"} }},
                new Country() { ID = new Guid("0DE606DB-21C0-4BB1-BC40-FC2B1CC088A3"), Code = "DJI", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Djibouti"}, new LanguageText() { LanguageCode="nl",Text="Djibouti"}, new LanguageText() { LanguageCode="fr",Text="Djibouti"}, new LanguageText() { LanguageCode="de",Text="Dschibuti"} }},
                new Country() { ID = new Guid("867D3CBC-C8E9-45E1-9B64-60968BF9C828"), Code = "DMA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Dominica"}, new LanguageText() { LanguageCode="nl",Text="Dominica"}, new LanguageText() { LanguageCode="fr",Text="Dominique"}, new LanguageText() { LanguageCode="de",Text="Dominica"} }},
                new Country() { ID = new Guid("BF78508B-5679-4B91-8958-EFA23AD055C2"), Code = "DOM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Dominican Republic"}, new LanguageText() { LanguageCode="nl",Text="Dominicaanse Republiek"}, new LanguageText() { LanguageCode="fr",Text="République dominicaine"}, new LanguageText() { LanguageCode="de",Text="Dominikanische Republik"} }},
                new Country() { ID = new Guid("3AAA355A-22CB-4F64-A8BD-836E6C8F0768"), Code = "TLS", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="East Timor"}, new LanguageText() { LanguageCode="nl",Text="Oost-Timor"}, new LanguageText() { LanguageCode="fr",Text="Timor oriental"}, new LanguageText() { LanguageCode="de",Text="Osttimor"} }},
                new Country() { ID = new Guid("B981D442-5509-43A2-B3A1-AFFA64972664"), Code = "ECU", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Ecuador"}, new LanguageText() { LanguageCode="nl",Text="Ecuador"}, new LanguageText() { LanguageCode="fr",Text="Équateur"}, new LanguageText() { LanguageCode="de",Text="Ecuador"} }},
                new Country() { ID = new Guid("E7584EEA-F033-4F5A-A609-B5CE29ADE267"), Code = "EGY", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Egypt"}, new LanguageText() { LanguageCode="nl",Text="Egypte"}, new LanguageText() { LanguageCode="fr",Text="Égypte"}, new LanguageText() { LanguageCode="de",Text="Ägypten"} }},
                new Country() { ID = new Guid("BF29F7CA-0DA0-4B9A-9423-A78E26B0BCEF"), Code = "SLV", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="El Salvador"}, new LanguageText() { LanguageCode="nl",Text="El Salvador"}, new LanguageText() { LanguageCode="fr",Text="El Salvador"}, new LanguageText() { LanguageCode="de",Text="El Salvador"} }},
                new Country() { ID = new Guid("A6461B00-6F3F-45F6-90F6-765B898EEEE6"), Code = "GNQ", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Equatorial Guinea"}, new LanguageText() { LanguageCode="nl",Text="Equatoriaal-Guinea"}, new LanguageText() { LanguageCode="fr",Text="Guinée équatoriale"}, new LanguageText() { LanguageCode="de",Text="Äquatorialguinea"} }},
                new Country() { ID = new Guid("E6E6B40D-2D78-4F35-90D5-FC5AC28A5CBD"), Code = "ERI", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Eritrea"}, new LanguageText() { LanguageCode="nl",Text="Eritrea"}, new LanguageText() { LanguageCode="fr",Text="Érythrée"}, new LanguageText() { LanguageCode="de",Text="Eritrea"} }},
                new Country() { ID = new Guid("DF097EE1-7B51-49E5-919F-A065617025F5"), Code = "EST", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Estonia"}, new LanguageText() { LanguageCode="nl",Text="Estland"}, new LanguageText() { LanguageCode="fr",Text="Estonie"}, new LanguageText() { LanguageCode="de",Text="Estland"} }},
                new Country() { ID = new Guid("E624C6E2-4937-4422-A083-D502C772859C"), Code = "ETH", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Ethiopia"}, new LanguageText() { LanguageCode="nl",Text="Ethiopië"}, new LanguageText() { LanguageCode="fr",Text="Éthiopie"}, new LanguageText() { LanguageCode="de",Text="Äthiopien"} }},
                new Country() { ID = new Guid("C0084B10-3755-44CF-8552-5D2D8269ECAC"), Code = "FJI", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Fiji"}, new LanguageText() { LanguageCode="nl",Text="Fiji"}, new LanguageText() { LanguageCode="fr",Text="Fidji"}, new LanguageText() { LanguageCode="de",Text="Fidschi"} }},
                new Country() { ID = new Guid("55FEC7E8-93B9-4F79-8C61-342F6CA28855"), Code = "FIN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Finland"}, new LanguageText() { LanguageCode="nl",Text="Finland"}, new LanguageText() { LanguageCode="fr",Text="Finlande"}, new LanguageText() { LanguageCode="de",Text="Finnland"} }},
                new Country() { ID = new Guid("ED554A7B-BCE3-4A10-BF4B-A113A71533C3"), Code = "FRA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="France"}, new LanguageText() { LanguageCode="nl",Text="Frankrijk"}, new LanguageText() { LanguageCode="fr",Text="France"}, new LanguageText() { LanguageCode="de",Text="Frankreich"} }},
                new Country() { ID = new Guid("AB9803DC-81C9-4F40-AB6D-88AFA03CA3AD"), Code = "GAB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Gabon"}, new LanguageText() { LanguageCode="nl",Text="Gabon"}, new LanguageText() { LanguageCode="fr",Text="Gabon"}, new LanguageText() { LanguageCode="de",Text="Gabun"} }},
                new Country() { ID = new Guid("F522DCD6-6129-40B9-8265-8015696FFBAE"), Code = "GMB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Gambia"}, new LanguageText() { LanguageCode="nl",Text="Gambia"}, new LanguageText() { LanguageCode="fr",Text="Gambie"}, new LanguageText() { LanguageCode="de",Text="Gambia"} }},
                new Country() { ID = new Guid("7D4FD8EE-BA53-430D-B79D-14A6C0CAC865"), Code = "GEO", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Georgia"}, new LanguageText() { LanguageCode="nl",Text="Georgië"}, new LanguageText() { LanguageCode="fr",Text="Géorgie"}, new LanguageText() { LanguageCode="de",Text="Georgien"} }},
                new Country() { ID = new Guid("21D61853-43C2-422F-993B-EF96FA75AFEA"), Code = "DEU", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Germany"}, new LanguageText() { LanguageCode="nl",Text="Duitsland"}, new LanguageText() { LanguageCode="fr",Text="Allemagne"}, new LanguageText() { LanguageCode="de",Text="Deutschland"} }},
                new Country() { ID = new Guid("FE9C3C1B-3425-43BE-8203-B081D7951F9E"), Code = "GHA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Ghana"}, new LanguageText() { LanguageCode="nl",Text="Ghana"}, new LanguageText() { LanguageCode="fr",Text="Ghana"}, new LanguageText() { LanguageCode="de",Text="Ghana"} }},
                new Country() { ID = new Guid("5D47BF68-8A66-4456-99B3-E93268E7278B"), Code = "GRC", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Greece"}, new LanguageText() { LanguageCode="nl",Text="Griekenland"}, new LanguageText() { LanguageCode="fr",Text="Grèce"}, new LanguageText() { LanguageCode="de",Text="Griechenland"} }},
                new Country() { ID = new Guid("E22E68CC-F3BE-43AF-918C-1C177FCAA595"), Code = "GRD", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Grenada"}, new LanguageText() { LanguageCode="nl",Text="Grenada"}, new LanguageText() { LanguageCode="fr",Text="Grenade"}, new LanguageText() { LanguageCode="de",Text="Grenada"} }},
                new Country() { ID = new Guid("1836BCE0-C94B-40F3-81D7-21EDC7E9A74E"), Code = "GTM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Guatemala"}, new LanguageText() { LanguageCode="nl",Text="Guatemala"}, new LanguageText() { LanguageCode="fr",Text="Guatemala"}, new LanguageText() { LanguageCode="de",Text="Guatemala"} }},
                new Country() { ID = new Guid("525C2D6B-C2DA-49E9-A351-69AF276813A7"), Code = "GIN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Guinea"}, new LanguageText() { LanguageCode="nl",Text="Guinee"}, new LanguageText() { LanguageCode="fr",Text="Guinée"}, new LanguageText() { LanguageCode="de",Text="Guinea"} }},
                new Country() { ID = new Guid("47101E8F-234E-4F58-9AA7-CCFAD2F77A1F"), Code = "GNB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Guinea-Bissau"}, new LanguageText() { LanguageCode="nl",Text="Guinee-Bissau"}, new LanguageText() { LanguageCode="fr",Text="Guinée-Bissau"}, new LanguageText() { LanguageCode="de",Text="Guinea-Bissau"} }},
                new Country() { ID = new Guid("3FCE84D1-BCFF-4C3A-AFD5-A52E98A7D95F"), Code = "GUY", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Guyana"}, new LanguageText() { LanguageCode="nl",Text="Guyana"}, new LanguageText() { LanguageCode="fr",Text="Guyana"}, new LanguageText() { LanguageCode="de",Text="Guyana"} }},
                new Country() { ID = new Guid("AE568287-2DAE-4C3C-BADA-FD10064397C6"), Code = "HTI", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Haiti"}, new LanguageText() { LanguageCode="nl",Text="Haïti"}, new LanguageText() { LanguageCode="fr",Text="Haïti"}, new LanguageText() { LanguageCode="de",Text="Haiti"} }},
                new Country() { ID = new Guid("4409E415-5916-4401-BDD4-18F95552E757"), Code = "HND", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Honduras"}, new LanguageText() { LanguageCode="nl",Text="Honduras"}, new LanguageText() { LanguageCode="fr",Text="Honduras"}, new LanguageText() { LanguageCode="de",Text="Honduras"} }},
                new Country() { ID = new Guid("B272A659-8EAD-4951-98E2-06F3225F182E"), Code = "HUN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Hungary"}, new LanguageText() { LanguageCode="nl",Text="Hongarije"}, new LanguageText() { LanguageCode="fr",Text="Hongrie"}, new LanguageText() { LanguageCode="de",Text="Ungarn"} }},
                new Country() { ID = new Guid("EA4D1817-9B1C-4F24-BCDE-2940737A5A5E"), Code = "ISL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Iceland"}, new LanguageText() { LanguageCode="nl",Text="IJsland"}, new LanguageText() { LanguageCode="fr",Text="Islande"}, new LanguageText() { LanguageCode="de",Text="Island"} }},
                new Country() { ID = new Guid("FE45A47F-0BB4-4132-AA0E-CC73E7284D2A"), Code = "IND", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="India"}, new LanguageText() { LanguageCode="nl",Text="India"}, new LanguageText() { LanguageCode="fr",Text="Inde"}, new LanguageText() { LanguageCode="de",Text="Indien"} }},
                new Country() { ID = new Guid("71FBA808-D9B6-4AB2-A2E4-5411BAC561E6"), Code = "IDN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Indonesia"}, new LanguageText() { LanguageCode="nl",Text="Indonesië"}, new LanguageText() { LanguageCode="fr",Text="Indonésie"}, new LanguageText() { LanguageCode="de",Text="Indonesien"} }},
                new Country() { ID = new Guid("A31EDEBA-BF50-4BB5-888C-ACCF7C1D7ABE"), Code = "IRN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Iran"}, new LanguageText() { LanguageCode="nl",Text="Iran"}, new LanguageText() { LanguageCode="fr",Text="Iran"}, new LanguageText() { LanguageCode="de",Text="Iran"} }},
                new Country() { ID = new Guid("CBAE60F0-2D5C-4128-BBFD-3E90723F2826"), Code = "IRQ", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Iraq"}, new LanguageText() { LanguageCode="nl",Text="Irak"}, new LanguageText() { LanguageCode="fr",Text="Irak"}, new LanguageText() { LanguageCode="de",Text="Irak"} }},
                new Country() { ID = new Guid("F992C83B-0CA4-45AA-BB41-BF740EE53610"), Code = "IRL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Ireland"}, new LanguageText() { LanguageCode="nl",Text="Ierland"}, new LanguageText() { LanguageCode="fr",Text="Irlande"}, new LanguageText() { LanguageCode="de",Text="Irland"} }},
                new Country() { ID = new Guid("128D4B8B-CAC9-4349-A8C9-A17CA4839D1B"), Code = "ISR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Israel"}, new LanguageText() { LanguageCode="nl",Text="Israël"}, new LanguageText() { LanguageCode="fr",Text="Israël"}, new LanguageText() { LanguageCode="de",Text="Israel"} }},
                new Country() { ID = new Guid("636A4461-F0F8-4538-9C9F-5F8FB826D9F3"), Code = "ITA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Italy"}, new LanguageText() { LanguageCode="nl",Text="Italië"}, new LanguageText() { LanguageCode="fr",Text="Italie"}, new LanguageText() { LanguageCode="de",Text="Italien"} }},
                new Country() { ID = new Guid("F725E114-C733-4BB4-BA24-57A5758355DB"), Code = "JAM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Jamaica"}, new LanguageText() { LanguageCode="nl",Text="Jamaica"}, new LanguageText() { LanguageCode="fr",Text="Jamaïque"}, new LanguageText() { LanguageCode="de",Text="Jamaika"} }},
                new Country() { ID = new Guid("C6C176BD-8704-4739-8CD0-2750369167BE"), Code = "JPN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Japan"}, new LanguageText() { LanguageCode="nl",Text="Japan"}, new LanguageText() { LanguageCode="fr",Text="Japon"}, new LanguageText() { LanguageCode="de",Text="Japan"} }},
                new Country() { ID = new Guid("BF1F1A38-1904-4B87-AB5C-4888DD2E24F1"), Code = "JOR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Jordan"}, new LanguageText() { LanguageCode="nl",Text="Jordanië"}, new LanguageText() { LanguageCode="fr",Text="Jordanie"}, new LanguageText() { LanguageCode="de",Text="Jordanien"} }},
                new Country() { ID = new Guid("458E4B31-3F55-4DEF-9FEA-8080ACFC17CE"), Code = "KAZ", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Kazakhstan"}, new LanguageText() { LanguageCode="nl",Text="Kazachstan"}, new LanguageText() { LanguageCode="fr",Text="Kazakhstan"}, new LanguageText() { LanguageCode="de",Text="Kasachstan"} }},
                new Country() { ID = new Guid("8A45CEEF-61A3-4973-8053-B27FFBD14A10"), Code = "KEN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Kenya"}, new LanguageText() { LanguageCode="nl",Text="Kenia"}, new LanguageText() { LanguageCode="fr",Text="Kenya"}, new LanguageText() { LanguageCode="de",Text="Kenia"} }},
                new Country() { ID = new Guid("EE1830F5-68FC-4E6B-83D3-F224C8F076D4"), Code = "KIR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Kiribati"}, new LanguageText() { LanguageCode="nl",Text="Kiribati"}, new LanguageText() { LanguageCode="fr",Text="Kiribati"}, new LanguageText() { LanguageCode="de",Text="Kiribati"} }},
                new Country() { ID = new Guid("9D7F4E5C-90B2-42CA-973E-5360021CE1CD"), Code = "UNK", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Kosovo"}, new LanguageText() { LanguageCode="nl",Text="Kosovo"}, new LanguageText() { LanguageCode="fr",Text="Kosovo"}, new LanguageText() { LanguageCode="de",Text="Kosovo"} }},
                new Country() { ID = new Guid("DE4D22ED-1945-46AB-A21D-C7A467B428C3"), Code = "KWT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Kuwait"}, new LanguageText() { LanguageCode="nl",Text="Koeweit"}, new LanguageText() { LanguageCode="fr",Text="Koweït"}, new LanguageText() { LanguageCode="de",Text="Kuwait"} }},
                new Country() { ID = new Guid("2EB24FAB-B67A-405A-A4A4-A82B471203F2"), Code = "KGZ", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Kyrgyzstan"}, new LanguageText() { LanguageCode="nl",Text="Kirgizië"}, new LanguageText() { LanguageCode="fr",Text="Kirghizie"}, new LanguageText() { LanguageCode="de",Text="Kirgisistan"} }},
                new Country() { ID = new Guid("4B6BD9F1-F806-4571-BCD7-73851542CA25"), Code = "LAO", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Laos"}, new LanguageText() { LanguageCode="nl",Text="Laos"}, new LanguageText() { LanguageCode="fr",Text="Laos"}, new LanguageText() { LanguageCode="de",Text="Laos"} }},
                new Country() { ID = new Guid("CA50ADBC-6613-489F-8DA1-2BBC6846867B"), Code = "LVA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Latvia"}, new LanguageText() { LanguageCode="nl",Text="Letland"}, new LanguageText() { LanguageCode="fr",Text="Lettonie"}, new LanguageText() { LanguageCode="de",Text="Lettland"} }},
                new Country() { ID = new Guid("BB33A24B-0498-4E86-B5BF-A0A73B066D42"), Code = "LBN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Lebanon"}, new LanguageText() { LanguageCode="nl",Text="Libanon"}, new LanguageText() { LanguageCode="fr",Text="Liban"}, new LanguageText() { LanguageCode="de",Text="Libanon"} }},
                new Country() { ID = new Guid("812664AE-DABA-492F-A571-9694F4FF46F8"), Code = "LSO", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Lesotho"}, new LanguageText() { LanguageCode="nl",Text="Lesotho"}, new LanguageText() { LanguageCode="fr",Text="Lesotho"}, new LanguageText() { LanguageCode="de",Text="Lesotho"} }},
                new Country() { ID = new Guid("970AAF9B-7A90-4021-B942-F1B73C1812F8"), Code = "LBR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Liberia"}, new LanguageText() { LanguageCode="nl",Text="Liberia"}, new LanguageText() { LanguageCode="fr",Text="Liberia"}, new LanguageText() { LanguageCode="de",Text="Liberia"} }},
                new Country() { ID = new Guid("2CA4AB2C-CD60-475B-AD4F-131970200E2C"), Code = "LBY", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Libya"}, new LanguageText() { LanguageCode="nl",Text="Libië"}, new LanguageText() { LanguageCode="fr",Text="Libye"}, new LanguageText() { LanguageCode="de",Text="Libyen"} }},
                new Country() { ID = new Guid("1A6629F0-3DF6-4F4D-9366-652D7BABC3EB"), Code = "LIE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Liechtenstein"}, new LanguageText() { LanguageCode="nl",Text="Liechtenstein"}, new LanguageText() { LanguageCode="fr",Text="Liechtenstein"}, new LanguageText() { LanguageCode="de",Text="Liechtenstein"} }},
                new Country() { ID = new Guid("C0559341-609B-48CE-8406-1A305C227689"), Code = "LTU", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Lithuania"}, new LanguageText() { LanguageCode="nl",Text="Litouwen"}, new LanguageText() { LanguageCode="fr",Text="Lituanie"}, new LanguageText() { LanguageCode="de",Text="Litauen"} }},
                new Country() { ID = new Guid("3E5BAE0B-6C7F-4B1F-A80B-4F77DF42483C"), Code = "LUX", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Luxembourg"}, new LanguageText() { LanguageCode="nl",Text="Luxemburg"}, new LanguageText() { LanguageCode="fr",Text="Luxembourg"}, new LanguageText() { LanguageCode="de",Text="Luxemburg"} }},
                new Country() { ID = new Guid("C9763D47-DF87-43FB-A940-BC4DFA350CA8"), Code = "MKD", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Macedonia"}, new LanguageText() { LanguageCode="nl",Text="Macedonië"}, new LanguageText() { LanguageCode="fr",Text="Macédoine"}, new LanguageText() { LanguageCode="de",Text="Mazedonien"} }},
                new Country() { ID = new Guid("AAFB8C3D-C285-4B1F-9969-C005EA01B43A"), Code = "MDG", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Madagascar"}, new LanguageText() { LanguageCode="nl",Text="Madagaskar"}, new LanguageText() { LanguageCode="fr",Text="Madagascar"}, new LanguageText() { LanguageCode="de",Text="Madagaskar"} }},
                new Country() { ID = new Guid("4CCC1C73-4E7E-48AA-9850-8DDCBF58A34B"), Code = "MWI", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Malawi"}, new LanguageText() { LanguageCode="nl",Text="Malawi"}, new LanguageText() { LanguageCode="fr",Text="Malawi"}, new LanguageText() { LanguageCode="de",Text="Malawi"} }},
                new Country() { ID = new Guid("7B2893F9-3A38-4B4B-A1AF-24C3351AD5AE"), Code = "MYS", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Malaysia"}, new LanguageText() { LanguageCode="nl",Text="Maleisië"}, new LanguageText() { LanguageCode="fr",Text="Malaisie"}, new LanguageText() { LanguageCode="de",Text="Malaysia"} }},
                new Country() { ID = new Guid("698FD329-EBBA-408F-95C0-6B2EBF18BB76"), Code = "MDV", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Maldives"}, new LanguageText() { LanguageCode="nl",Text="Maldiven"}, new LanguageText() { LanguageCode="fr",Text="Maldives"}, new LanguageText() { LanguageCode="de",Text="Malediven"} }},
                new Country() { ID = new Guid("61060A1E-8565-417A-BEEA-2212562384EF"), Code = "MLI", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Mali"}, new LanguageText() { LanguageCode="nl",Text="Mali"}, new LanguageText() { LanguageCode="fr",Text="Mali"}, new LanguageText() { LanguageCode="de",Text="Mali"} }},
                new Country() { ID = new Guid("512F874E-6379-4F77-878B-75AD565A10CE"), Code = "MLT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Malta"}, new LanguageText() { LanguageCode="nl",Text="Malta"}, new LanguageText() { LanguageCode="fr",Text="Malte"}, new LanguageText() { LanguageCode="de",Text="Malta"} }},
                new Country() { ID = new Guid("B6D3AEF8-DEFE-4DD1-9B19-FBF68E7BDE01"), Code = "MHL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Marshall Islands"}, new LanguageText() { LanguageCode="nl",Text="Marshalleilanden"}, new LanguageText() { LanguageCode="fr",Text="Îles Marshall"}, new LanguageText() { LanguageCode="de",Text="Marshallinseln"} }},
                new Country() { ID = new Guid("874B4262-CD0B-4498-AAD7-58987A270AD7"), Code = "MRT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Mauritania"}, new LanguageText() { LanguageCode="nl",Text="Mauritanië"}, new LanguageText() { LanguageCode="fr",Text="Mauritanie"}, new LanguageText() { LanguageCode="de",Text="Mauretanien"} }},
                new Country() { ID = new Guid("98F990E4-D4D6-4F6C-9684-B3BD9B8D3771"), Code = "MUS", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Mauritius"}, new LanguageText() { LanguageCode="nl",Text="Mauritius"}, new LanguageText() { LanguageCode="fr",Text="Maurice"}, new LanguageText() { LanguageCode="de",Text="Mauritius"} }},
                new Country() { ID = new Guid("A66C6B3C-D42B-4222-A80B-241111D41C91"), Code = "MEX", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Mexico"}, new LanguageText() { LanguageCode="nl",Text="Mexico["}, new LanguageText() { LanguageCode="fr",Text="Mexique"}, new LanguageText() { LanguageCode="de",Text="Mexiko"} }},
                new Country() { ID = new Guid("9C678BD9-8CB8-48D4-BF3C-094B5F20D718"), Code = "FSM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Micronesia"}, new LanguageText() { LanguageCode="nl",Text="Micronesia"}, new LanguageText() { LanguageCode="fr",Text="Micronésie"}, new LanguageText() { LanguageCode="de",Text="Mikronesien"} }},
                new Country() { ID = new Guid("AB096653-13EE-402D-9DC2-3563C775105E"), Code = "MDA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Moldova"}, new LanguageText() { LanguageCode="nl",Text="Moldavië"}, new LanguageText() { LanguageCode="fr",Text="Moldavie"}, new LanguageText() { LanguageCode="de",Text="Moldawien"} }},
                new Country() { ID = new Guid("D07C2307-E98C-4B30-AD77-E7E1CA617EAB"), Code = "MCO", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Monaco"}, new LanguageText() { LanguageCode="nl",Text="Monaco"}, new LanguageText() { LanguageCode="fr",Text="Monaco"}, new LanguageText() { LanguageCode="de",Text="Monaco"} }},
                new Country() { ID = new Guid("22FDE9E8-1192-4C27-908F-F1A3732FEDCF"), Code = "MNG", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Mongolia"}, new LanguageText() { LanguageCode="nl",Text="Mongolië"}, new LanguageText() { LanguageCode="fr",Text="Mongolie"}, new LanguageText() { LanguageCode="de",Text="Mongolei"} }},
                new Country() { ID = new Guid("728A9808-27F0-4D1C-B933-F5FF10A3F5D5"), Code = "MNE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Montenegro"}, new LanguageText() { LanguageCode="nl",Text="Montenegro"}, new LanguageText() { LanguageCode="fr",Text="Monténégro"}, new LanguageText() { LanguageCode="de",Text="Montenegro"} }},
                new Country() { ID = new Guid("E1EDA6DA-B9FC-4A7B-8C97-86FDFF05EA0C"), Code = "MAR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Morocco"}, new LanguageText() { LanguageCode="nl",Text="Marokko"}, new LanguageText() { LanguageCode="fr",Text="Maroc"}, new LanguageText() { LanguageCode="de",Text="Marokko"} }},
                new Country() { ID = new Guid("692BFF96-9A0A-4EBB-BF3C-4700CBB43472"), Code = "MOZ", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Mozambique"}, new LanguageText() { LanguageCode="nl",Text="Mozambique"}, new LanguageText() { LanguageCode="fr",Text="Mozambique"}, new LanguageText() { LanguageCode="de",Text="Mosambik"} }},
                new Country() { ID = new Guid("926044F4-29E3-49DD-8755-3523EC024A06"), Code = "MMR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Myanmar"}, new LanguageText() { LanguageCode="nl",Text="Myanmar"}, new LanguageText() { LanguageCode="fr",Text="Myanmar"}, new LanguageText() { LanguageCode="de",Text="Myanmar"} }},
                new Country() { ID = new Guid("9DFDAAC8-F10C-4E5D-AB83-5A972338E8D6"), Code = "NAM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Namibia"}, new LanguageText() { LanguageCode="nl",Text="Namibië"}, new LanguageText() { LanguageCode="fr",Text="Namibie"}, new LanguageText() { LanguageCode="de",Text="Namibia"} }},
                new Country() { ID = new Guid("9C870B2C-FCE6-401D-ABBF-385F07EFC55D"), Code = "NRU", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Nauru"}, new LanguageText() { LanguageCode="nl",Text="Nauru"}, new LanguageText() { LanguageCode="fr",Text="Nauru"}, new LanguageText() { LanguageCode="de",Text="Nauru"} }},
                new Country() { ID = new Guid("382959C4-E338-431F-8347-23F442F9A499"), Code = "NPL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Nepal"}, new LanguageText() { LanguageCode="nl",Text="Nepal"}, new LanguageText() { LanguageCode="fr",Text="Népal"}, new LanguageText() { LanguageCode="de",Text="Nepal"} }},
                new Country() { ID = new Guid("ADE8E58E-F037-48AA-8FAE-5BEDCB6AD0D8"), Code = "NLD", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Netherlands"}, new LanguageText() { LanguageCode="nl",Text="Nederland"}, new LanguageText() { LanguageCode="fr",Text="Pays-Bas"}, new LanguageText() { LanguageCode="de",Text="Niederlande"} }},
                new Country() { ID = new Guid("2FAA60F0-3823-4016-9B81-3CA8683223C4"), Code = "NZL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="New Zealand"}, new LanguageText() { LanguageCode="nl",Text="Nieuw-Zeeland"}, new LanguageText() { LanguageCode="fr",Text="Nouvelle-Zélande"}, new LanguageText() { LanguageCode="de",Text="Neuseeland"} }},
                new Country() { ID = new Guid("AC1FC25D-BA93-4FFC-8F90-80F3ACF39FE1"), Code = "NIC", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Nicaragua"}, new LanguageText() { LanguageCode="nl",Text="Nicaragua"}, new LanguageText() { LanguageCode="fr",Text="Nicaragua"}, new LanguageText() { LanguageCode="de",Text="Nicaragua"} }},
                new Country() { ID = new Guid("A5C3D0A4-EF39-4B78-A5D3-061679991010"), Code = "NER", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Niger"}, new LanguageText() { LanguageCode="nl",Text="Niger"}, new LanguageText() { LanguageCode="fr",Text="Niger"}, new LanguageText() { LanguageCode="de",Text="Niger"} }},
                new Country() { ID = new Guid("C80C294A-3F5E-41AD-AB88-F9EFEF59B167"), Code = "NGA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Nigeria"}, new LanguageText() { LanguageCode="nl",Text="Nigeria"}, new LanguageText() { LanguageCode="fr",Text="Nigéria"}, new LanguageText() { LanguageCode="de",Text="Nigeria"} }},
                new Country() { ID = new Guid("B62995E3-1EC7-4655-A3A8-E865181B3F2C"), Code = "NIU", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Niue"}, new LanguageText() { LanguageCode="nl",Text="Niue"}, new LanguageText() { LanguageCode="fr",Text="Niue"}, new LanguageText() { LanguageCode="de",Text="Niue"} }},
                new Country() { ID = new Guid("F9955C31-D822-41EA-89A6-5907E360B3E5"), Code = "PRK", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="North Korea"}, new LanguageText() { LanguageCode="nl",Text="Noord-Korea"}, new LanguageText() { LanguageCode="fr",Text="Corée du Nord"}, new LanguageText() { LanguageCode="de",Text="Nord Korea"} }},
                new Country() { ID = new Guid("A06867E9-6999-4664-AD17-C72A436264DC"), Code = "NOR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Norway"}, new LanguageText() { LanguageCode="nl",Text="Noorwegen"}, new LanguageText() { LanguageCode="fr",Text="Norvège"}, new LanguageText() { LanguageCode="de",Text="Norwegen"} }},
                new Country() { ID = new Guid("69369BEE-72FF-45C3-9D93-AAF728CCD7B4"), Code = "OMN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Oman"}, new LanguageText() { LanguageCode="nl",Text="Oman"}, new LanguageText() { LanguageCode="fr",Text="Oman"}, new LanguageText() { LanguageCode="de",Text="Oman"} }},
                new Country() { ID = new Guid("54985A37-0EF9-46DB-8E70-CFC4325E2ECF"), Code = "PAK", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Pakistan"}, new LanguageText() { LanguageCode="nl",Text="Pakistan"}, new LanguageText() { LanguageCode="fr",Text="Pakistan"}, new LanguageText() { LanguageCode="de",Text="Pakistan"} }},
                new Country() { ID = new Guid("26A0C02F-FD03-4066-A0BF-2ADA5E3345BB"), Code = "PLW", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Palau"}, new LanguageText() { LanguageCode="nl",Text="Palau"}, new LanguageText() { LanguageCode="fr",Text="Palaos"}, new LanguageText() { LanguageCode="de",Text="Palau"} }},
                new Country() { ID = new Guid("81ED0A51-BC59-49DD-850C-4D85E0E74945"), Code = "PSE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Palestine"}, new LanguageText() { LanguageCode="nl",Text="Palestina"}, new LanguageText() { LanguageCode="fr",Text="État de Palestine"}, new LanguageText() { LanguageCode="de",Text="Palästina"} }},
                new Country() { ID = new Guid("A6978482-B773-45AB-9460-B46CE81A4808"), Code = "PAN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Panama"}, new LanguageText() { LanguageCode="nl",Text="Panama"}, new LanguageText() { LanguageCode="fr",Text="Panama"}, new LanguageText() { LanguageCode="de",Text="Panama"} }},
                new Country() { ID = new Guid("4B8DD925-23E9-4606-A687-0CA0E564A058"), Code = "PNG", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Papua New Guinea"}, new LanguageText() { LanguageCode="nl",Text="Papoea-Nieuw-Guinea"}, new LanguageText() { LanguageCode="fr",Text="Papouasie-Nouvelle-Guinée"}, new LanguageText() { LanguageCode="de",Text="Papua-Neuguinea"} }},
                new Country() { ID = new Guid("EC3C1B33-4C55-4B4A-8F4E-C49CCD0A89C9"), Code = "PRY", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Paraguay"}, new LanguageText() { LanguageCode="nl",Text="Paraguay"}, new LanguageText() { LanguageCode="fr",Text="Paraguay"}, new LanguageText() { LanguageCode="de",Text="Paraguay"} }},
                new Country() { ID = new Guid("9D23BB42-EE31-409B-90C2-0A5AB88485F4"), Code = "PER", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Peru"}, new LanguageText() { LanguageCode="nl",Text="Peru"}, new LanguageText() { LanguageCode="fr",Text="Pérou"}, new LanguageText() { LanguageCode="de",Text="Peru"} }},
                new Country() { ID = new Guid("F4537BB4-C120-4F5C-AC8D-7157E6988FD8"), Code = "PHL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Philippines"}, new LanguageText() { LanguageCode="nl",Text="Filipijnen"}, new LanguageText() { LanguageCode="fr",Text="Philippines"}, new LanguageText() { LanguageCode="de",Text="Philippinen"} }},
                new Country() { ID = new Guid("7C6CF509-7148-4AB2-9AA6-AFC1061ADF49"), Code = "POL", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Poland"}, new LanguageText() { LanguageCode="nl",Text="Polen"}, new LanguageText() { LanguageCode="fr",Text="Pologne"}, new LanguageText() { LanguageCode="de",Text="Polen"} }},
                new Country() { ID = new Guid("B97FED10-BCBC-4653-8D2A-76E8C85B826A"), Code = "PRT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Portugal"}, new LanguageText() { LanguageCode="nl",Text="Portugal"}, new LanguageText() { LanguageCode="fr",Text="Portugal"}, new LanguageText() { LanguageCode="de",Text="Portugal"} }},
                new Country() { ID = new Guid("E4D020A4-9CB4-400F-9A11-576ED7062362"), Code = "QAT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Qatar"}, new LanguageText() { LanguageCode="nl",Text="Qatar"}, new LanguageText() { LanguageCode="fr",Text="Qatar"}, new LanguageText() { LanguageCode="de",Text="Katar"} }},
                new Country() { ID = new Guid("2FB9D022-96D0-4C19-919F-3F368FDCE39A"), Code = "ROU", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Romania"}, new LanguageText() { LanguageCode="nl",Text="Roemenië"}, new LanguageText() { LanguageCode="fr",Text="Roumanie"}, new LanguageText() { LanguageCode="de",Text="Rumänien"} }},
                new Country() { ID = new Guid("69E8F68B-4845-4CC3-A710-12887FD7E8DE"), Code = "RUS", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Russia"}, new LanguageText() { LanguageCode="nl",Text="Rusland"}, new LanguageText() { LanguageCode="fr",Text="Russie"}, new LanguageText() { LanguageCode="de",Text="Russland"} }},
                new Country() { ID = new Guid("0A258AC6-6730-459E-BA76-6DBEDEC19339"), Code = "RWA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Rwanda"}, new LanguageText() { LanguageCode="nl",Text="Rwanda"}, new LanguageText() { LanguageCode="fr",Text="Rwanda"}, new LanguageText() { LanguageCode="de",Text="Ruanda"} }},
                new Country() { ID = new Guid("A89DB47F-C03D-4766-866A-F1A7507BC38F"), Code = "KNA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Saint Kitts and Nevis"}, new LanguageText() { LanguageCode="nl",Text="Saint Kitts en Nevis"}, new LanguageText() { LanguageCode="fr",Text="Saint-Christophe-et-Niévès"}, new LanguageText() { LanguageCode="de",Text="St. Kitts und Nevis"} }},
                new Country() { ID = new Guid("98C804B8-442A-4C47-A1D8-53CC23AD1B26"), Code = "LCA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Saint Lucia"}, new LanguageText() { LanguageCode="nl",Text="Saint Lucia"}, new LanguageText() { LanguageCode="fr",Text="Sainte-Lucie"}, new LanguageText() { LanguageCode="de",Text="St. Lucia"} }},
                new Country() { ID = new Guid("4404A755-535C-4723-9C12-ADB52DD267E1"), Code = "VCT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Saint Vincent and the Grenadines"}, new LanguageText() { LanguageCode="nl",Text="Saint Vincent en de Grenadines"}, new LanguageText() { LanguageCode="fr",Text="Saint-Vincent-et-les Grenadines"}, new LanguageText() { LanguageCode="de",Text="St. Vincent und die Grenadinen"} }},
                new Country() { ID = new Guid("7B6191C2-DC99-4A28-B7C2-6646AB4DB166"), Code = "WSM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Samoa"}, new LanguageText() { LanguageCode="nl",Text="Samoa"}, new LanguageText() { LanguageCode="fr",Text="Samoa"}, new LanguageText() { LanguageCode="de",Text="Samoa"} }},
                new Country() { ID = new Guid("9BC93D03-6C4E-4B76-9CA2-1ED7A6B5C743"), Code = "SMR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="San Marino"}, new LanguageText() { LanguageCode="nl",Text="San Marino"}, new LanguageText() { LanguageCode="fr",Text="Saint-Marin"}, new LanguageText() { LanguageCode="de",Text="San Marino"} }},
                new Country() { ID = new Guid("8EFE5473-19A5-4109-B2D3-91C02A975209"), Code = "STP", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Sao Tome and Principe"}, new LanguageText() { LanguageCode="nl",Text="Sao Tomé en Principe"}, new LanguageText() { LanguageCode="fr",Text="Sao Tomé-et-Principe"}, new LanguageText() { LanguageCode="de",Text="São Tomé und Príncipe"} }},
                new Country() { ID = new Guid("10795CAC-9D91-41C2-B5D0-658B02B07F95"), Code = "SAU", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Saudi Arabia"}, new LanguageText() { LanguageCode="nl",Text="Saoedi-Arabië"}, new LanguageText() { LanguageCode="fr",Text="Arabie saoudite"}, new LanguageText() { LanguageCode="de",Text="Saudi-Arabien"} }},
                new Country() { ID = new Guid("9CBE6D4F-EF9E-4CA0-A18C-CDBDDA840267"), Code = "SEN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Senegal"}, new LanguageText() { LanguageCode="nl",Text="Senegal"}, new LanguageText() { LanguageCode="fr",Text="Sénégal"}, new LanguageText() { LanguageCode="de",Text="Senegal"} }},
                new Country() { ID = new Guid("F3EDC011-9A2F-4AD4-8C00-2193BD4D5F49"), Code = "SRB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Serbia"}, new LanguageText() { LanguageCode="nl",Text="Servië"}, new LanguageText() { LanguageCode="fr",Text="Serbie"}, new LanguageText() { LanguageCode="de",Text="Serbien"} }},
                new Country() { ID = new Guid("B338193D-AB3F-48DC-825F-4A69D8AF8B3B"), Code = "SYC", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Seychelles"}, new LanguageText() { LanguageCode="nl",Text="Seychellen"}, new LanguageText() { LanguageCode="fr",Text="Seychelles"}, new LanguageText() { LanguageCode="de",Text="Seychellen"} }},
                new Country() { ID = new Guid("0426A22D-45D2-4341-9B03-9532B07E5A86"), Code = "SLE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Sierra Leone"}, new LanguageText() { LanguageCode="nl",Text="Sierra Leone"}, new LanguageText() { LanguageCode="fr",Text="Sierra Leone"}, new LanguageText() { LanguageCode="de",Text="Sierra Leone"} }},
                new Country() { ID = new Guid("AEFCACE9-48D4-41A3-BE3B-2047A9A50797"), Code = "SGP", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Singapore"}, new LanguageText() { LanguageCode="nl",Text="Singapore"}, new LanguageText() { LanguageCode="fr",Text="Singapour"}, new LanguageText() { LanguageCode="de",Text="Singapur"} }},
                new Country() { ID = new Guid("DF6F5842-00EE-4AB4-8A8E-A892B22658F1"), Code = "SVK", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Slovakia"}, new LanguageText() { LanguageCode="nl",Text="Slowakije"}, new LanguageText() { LanguageCode="fr",Text="Slovaquie"}, new LanguageText() { LanguageCode="de",Text="Slowakei"} }},
                new Country() { ID = new Guid("4440FC3C-EB2E-4423-8DD7-086F31A596CC"), Code = "SVN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Slovenia"}, new LanguageText() { LanguageCode="nl",Text="Slovenië"}, new LanguageText() { LanguageCode="fr",Text="Slovénie"}, new LanguageText() { LanguageCode="de",Text="Slowenien"} }},
                new Country() { ID = new Guid("08387049-6564-4C12-B882-14001F383F43"), Code = "SLB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Solomon Islands"}, new LanguageText() { LanguageCode="nl",Text="Salomonseilanden"}, new LanguageText() { LanguageCode="fr",Text="Îles Salomon"}, new LanguageText() { LanguageCode="de",Text="Salomonen"} }},
                new Country() { ID = new Guid("72470CDC-B05B-4D01-A835-7259EF29A9FA"), Code = "SOM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Somalia"}, new LanguageText() { LanguageCode="nl",Text="Somalië"}, new LanguageText() { LanguageCode="fr",Text="Somalie"}, new LanguageText() { LanguageCode="de",Text="Somalia"} }},
                new Country() { ID = new Guid("C0629D48-DA5F-43C1-BE22-1CD02C417A7B"), Code = "ZAF", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="South Africa"}, new LanguageText() { LanguageCode="nl",Text="Zuid-Afrika"}, new LanguageText() { LanguageCode="fr",Text="Afrique du Sud"}, new LanguageText() { LanguageCode="de",Text="Südafrika"} }},
                new Country() { ID = new Guid("9750618F-9644-4B3B-9235-AE27B86DD82D"), Code = "KOR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="South Korea"}, new LanguageText() { LanguageCode="nl",Text="Zuid-Korea"}, new LanguageText() { LanguageCode="fr",Text="Corée du Sud"}, new LanguageText() { LanguageCode="de",Text="Süd Korea"} }},
                new Country() { ID = new Guid("754C4DC7-779E-457C-A5EA-EB44156431AD"), Code = "SSD", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="South Sudan"}, new LanguageText() { LanguageCode="nl",Text="Zuid-Soedan"}, new LanguageText() { LanguageCode="fr",Text="Soudan du Sud"}, new LanguageText() { LanguageCode="de",Text="Südsudan"} }},
                new Country() { ID = new Guid("D1AA5ED9-A10E-4046-A00C-939298D9D0F4"), Code = "ESP", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Spain"}, new LanguageText() { LanguageCode="nl",Text="Spanje"}, new LanguageText() { LanguageCode="fr",Text="Espagne"}, new LanguageText() { LanguageCode="de",Text="Spanien"} }},
                new Country() { ID = new Guid("B882EDC8-3799-4592-A4DB-0C785A8EC9F6"), Code = "LKA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Sri Lanka"}, new LanguageText() { LanguageCode="nl",Text="Sri Lanka"}, new LanguageText() { LanguageCode="fr",Text="Sri Lanka"}, new LanguageText() { LanguageCode="de",Text="Sri Lanka"} }},
                new Country() { ID = new Guid("2F00E5F7-9825-4135-BB46-B819136E5555"), Code = "SDN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Sudan"}, new LanguageText() { LanguageCode="nl",Text="Soedan"}, new LanguageText() { LanguageCode="fr",Text="Soudan"}, new LanguageText() { LanguageCode="de",Text="Sudan"} }},
                new Country() { ID = new Guid("C3152AD1-5190-4DEC-9FF8-6D91CB5A66C2"), Code = "SUR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Suriname"}, new LanguageText() { LanguageCode="nl",Text="Suriname"}, new LanguageText() { LanguageCode="fr",Text="Suriname"}, new LanguageText() { LanguageCode="de",Text="Suriname"} }},
                new Country() { ID = new Guid("53724950-D2F6-401F-B40B-72E0DF1F6552"), Code = "SWZ", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Swaziland"}, new LanguageText() { LanguageCode="nl",Text="Swaziland"}, new LanguageText() { LanguageCode="fr",Text="Swaziland"}, new LanguageText() { LanguageCode="de",Text="Swasiland"} }},
                new Country() { ID = new Guid("27E1B987-A017-4519-BDF6-2652420F9B37"), Code = "SWE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Sweden"}, new LanguageText() { LanguageCode="nl",Text="Zweden"}, new LanguageText() { LanguageCode="fr",Text="Suède"}, new LanguageText() { LanguageCode="de",Text="Schweden"} }},
                new Country() { ID = new Guid("DB4A240B-D8F8-4684-BF18-808FA051B965"), Code = "CHE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Switzerland"}, new LanguageText() { LanguageCode="nl",Text="Zwitserland"}, new LanguageText() { LanguageCode="fr",Text="Suisse"}, new LanguageText() { LanguageCode="de",Text="Schweiz"} }},
                new Country() { ID = new Guid("238FD90F-B7A7-4134-A1FB-8A717F8F1BB9"), Code = "SYR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Syria"}, new LanguageText() { LanguageCode="nl",Text="Syrië"}, new LanguageText() { LanguageCode="fr",Text="Syrie"}, new LanguageText() { LanguageCode="de",Text="Syrien"} }},
                new Country() { ID = new Guid("10B94735-2A5C-4994-9462-1C5227A5F84A"), Code = "TWN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Taiwan"}, new LanguageText() { LanguageCode="nl",Text="Taiwan"}, new LanguageText() { LanguageCode="fr",Text="Taïwan"}, new LanguageText() { LanguageCode="de",Text="Taiwan"} }},
                new Country() { ID = new Guid("6A4BBB0A-F7AE-4C29-8DC8-3AC049E2DF4E"), Code = "TJK", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Tajikistan"}, new LanguageText() { LanguageCode="nl",Text="Tadzjikistan"}, new LanguageText() { LanguageCode="fr",Text="Tadjikistan"}, new LanguageText() { LanguageCode="de",Text="Tadschikistan"} }},
                new Country() { ID = new Guid("DFA91655-2EE8-4413-BE84-FF591051EFDD"), Code = "TZA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Tanzania"}, new LanguageText() { LanguageCode="nl",Text="Tanzania"}, new LanguageText() { LanguageCode="fr",Text="Tanzanie"}, new LanguageText() { LanguageCode="de",Text="Tansania"} }},
                new Country() { ID = new Guid("B1CB9A3A-6A81-4979-8C28-4E5715DD562F"), Code = "THA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Thailand"}, new LanguageText() { LanguageCode="nl",Text="Thailand"}, new LanguageText() { LanguageCode="fr",Text="Thaïlande"}, new LanguageText() { LanguageCode="de",Text="Thailand"} }},
                new Country() { ID = new Guid("BDF9E765-E93B-4308-AD06-3238BC009833"), Code = "TGO", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Togo"}, new LanguageText() { LanguageCode="nl",Text="Togo"}, new LanguageText() { LanguageCode="fr",Text="Togo"}, new LanguageText() { LanguageCode="de",Text="Togo"} }},
                new Country() { ID = new Guid("7CAD010A-2901-4172-B532-6BABDEC346BE"), Code = "TON", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Tonga"}, new LanguageText() { LanguageCode="nl",Text="Tonga"}, new LanguageText() { LanguageCode="fr",Text="Tonga"}, new LanguageText() { LanguageCode="de",Text="Tonga"} }},
                new Country() { ID = new Guid("FBDA5250-10DD-4AE4-9C33-169D5E22EA20"), Code = "TTO", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Trinidad and Tobago"}, new LanguageText() { LanguageCode="nl",Text="Trinidad en Tobago"}, new LanguageText() { LanguageCode="fr",Text="Trinité-et-Tobago"}, new LanguageText() { LanguageCode="de",Text="Trinidad und Tobago"} }},
                new Country() { ID = new Guid("3063A56E-3633-4FCB-B11A-41E138B7D91F"), Code = "TUN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Tunisia"}, new LanguageText() { LanguageCode="nl",Text="Tunesië"}, new LanguageText() { LanguageCode="fr",Text="Tunisie"}, new LanguageText() { LanguageCode="de",Text="Tunesien"} }},
                new Country() { ID = new Guid("27FA03E1-3386-4F68-8BF7-8360224D3C23"), Code = "TUR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Turkey"}, new LanguageText() { LanguageCode="nl",Text="Turkije"}, new LanguageText() { LanguageCode="fr",Text="Turquie"}, new LanguageText() { LanguageCode="de",Text="Türkei"} }},
                new Country() { ID = new Guid("72DC83BC-6F5C-4ADC-A226-03CAA8A3CB33"), Code = "TKM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Turkmenistan"}, new LanguageText() { LanguageCode="nl",Text="Turkmenistan"}, new LanguageText() { LanguageCode="fr",Text="Turkménistan"}, new LanguageText() { LanguageCode="de",Text="Turkmenistan"} }},
                new Country() { ID = new Guid("C0FA519D-C094-4F9A-89D6-12E14A52A2B8"), Code = "TUV", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Tuvalu"}, new LanguageText() { LanguageCode="nl",Text="Tuvalu"}, new LanguageText() { LanguageCode="fr",Text="Tuvalu"}, new LanguageText() { LanguageCode="de",Text="Tuvalu"} }},
                new Country() { ID = new Guid("CB872447-BABE-4542-9B17-9675148E52BC"), Code = "UGA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Uganda"}, new LanguageText() { LanguageCode="nl",Text="Oeganda"}, new LanguageText() { LanguageCode="fr",Text="Ouganda"}, new LanguageText() { LanguageCode="de",Text="Uganda"} }},
                new Country() { ID = new Guid("1B977D51-4832-493D-B163-7D3188777CC8"), Code = "UKR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Ukraine"}, new LanguageText() { LanguageCode="nl",Text="Oekraïne"}, new LanguageText() { LanguageCode="fr",Text="Ukraine"}, new LanguageText() { LanguageCode="de",Text="Ukraine"} }},
                new Country() { ID = new Guid("DA5A4D8B-917D-4E70-B500-B21ED772609F"), Code = "ARE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="United Arab Emirates"}, new LanguageText() { LanguageCode="nl",Text="Verenigde Arabische Emiraten"}, new LanguageText() { LanguageCode="fr",Text="Émirats Arabes Unis"}, new LanguageText() { LanguageCode="de",Text="Vereinigte Arabische Emirate"} }},
                new Country() { ID = new Guid("C3BDE949-09F9-47D7-99E2-1897B71290F9"), Code = "GBR", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="United Kingdom"}, new LanguageText() { LanguageCode="nl",Text="Verenigd Koninkrijk"}, new LanguageText() { LanguageCode="fr",Text="Royaume-Uni"}, new LanguageText() { LanguageCode="de",Text="Vereinigtes Königreich"} }},
                new Country() { ID = new Guid("FBBAD9A4-D3A2-4EC7-8AD1-8137FDBD59EB"), Code = "USA", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="United States of America"}, new LanguageText() { LanguageCode="nl",Text="Verenigde Staten"}, new LanguageText() { LanguageCode="fr",Text="États-Unis"}, new LanguageText() { LanguageCode="de",Text="Vereinigte Staaten"} }},
                new Country() { ID = new Guid("71439AA6-1A20-4373-B368-C44DD833FEDB"), Code = "URY", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Uruguay"}, new LanguageText() { LanguageCode="nl",Text="Uruguay"}, new LanguageText() { LanguageCode="fr",Text="Uruguay"}, new LanguageText() { LanguageCode="de",Text="Uruguay"} }},
                new Country() { ID = new Guid("A9DF6D05-7A19-4A1E-980B-081247FFAABE"), Code = "UZB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Uzbekistan"}, new LanguageText() { LanguageCode="nl",Text="Oezbekistan"}, new LanguageText() { LanguageCode="fr",Text="Ouzbékistan"}, new LanguageText() { LanguageCode="de",Text="Usbekistan"} }},
                new Country() { ID = new Guid("CBC2C59C-8479-4568-AB97-5A6AC02E6DFF"), Code = "VUT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Vanuatu"}, new LanguageText() { LanguageCode="nl",Text="Vanuatu"}, new LanguageText() { LanguageCode="fr",Text="Vanuatu"}, new LanguageText() { LanguageCode="de",Text="Vanuatu"} }},
                new Country() { ID = new Guid("A09E426C-3FD3-4295-AAC7-F02376B55427"), Code = "VAT", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Vatican City"}, new LanguageText() { LanguageCode="nl",Text="Vaticaanstad"}, new LanguageText() { LanguageCode="fr",Text="Vatican"}, new LanguageText() { LanguageCode="de",Text="Vatikanstadt"} }},
                new Country() { ID = new Guid("C284464A-4175-425F-BD6C-5AFE9A4C5F4A"), Code = "VEN", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Venezuela"}, new LanguageText() { LanguageCode="nl",Text="Venezuela"}, new LanguageText() { LanguageCode="fr",Text="Venezuela"}, new LanguageText() { LanguageCode="de",Text="Venezuela"} }},
                new Country() { ID = new Guid("3BC08968-5503-4B68-9342-81FCCA0C6B63"), Code = "VNM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Vietnam"}, new LanguageText() { LanguageCode="nl",Text="Vietnam"}, new LanguageText() { LanguageCode="fr",Text="Viêt Nam"}, new LanguageText() { LanguageCode="de",Text="Vietnam"} }},
                new Country() { ID = new Guid("189B5EC1-8EDD-4D3F-9E94-9A37D9C7FA68"), Code = "YEM", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Yemen"}, new LanguageText() { LanguageCode="nl",Text="Jemen"}, new LanguageText() { LanguageCode="fr",Text="Yémen"}, new LanguageText() { LanguageCode="de",Text="Jemen"} }},
                new Country() { ID = new Guid("CDCF33FB-E869-4499-AF7F-3673AB1E8D45"), Code = "ZMB", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Zambia"}, new LanguageText() { LanguageCode="nl",Text="Zambia"}, new LanguageText() { LanguageCode="fr",Text="Zambie"}, new LanguageText() { LanguageCode="de",Text="Sambia"} }},
                new Country() { ID = new Guid("01EA759E-57F0-4DC9-9817-504D06B864D4"), Code = "ZWE", Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Zimbabwe"}, new LanguageText() { LanguageCode="nl",Text="Zimbabwe"}, new LanguageText() { LanguageCode="fr",Text="Zimbabwe"}, new LanguageText() { LanguageCode="de",Text="Simbabwe"} } }
            });
        }
        private void SeedLanguages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(new List<Language>(){
                new Language() { ID = new Guid("A5DB799B-B67C-481F-B9C1-0497C55B05B6"), Code="bg", Name = "Bǎlgarski", Translated = false },
                new Language() { ID = new Guid("B59548E3-D2CE-471E-9763-63606A7D8F22"), Code="cs", Name = "Čeština", Translated = false },
                new Language() { ID = new Guid("CD273EB2-5159-4AB0-862A-1491085CB7FD"), Code="da", Name = "Dansk", Translated = false },
                new Language() { ID = new Guid("68CB6204-2BC9-4F0C-B5D5-7DAC9D2E8A80"), Code="de", Name = "Deutsch", Translated = true },
                new Language() { ID = new Guid("B547AC64-2E43-4293-9A8E-C253927F5280"), Code="el", Name = "Ελληνικά", Translated = false },
                new Language() { ID = new Guid("66FA4291-0B61-4D7B-96C7-EF5AEFE3669E"), Code="en", Name = "English", Translated = true },
                new Language() { ID = new Guid("C5B79B83-AF19-45CE-8347-3E4052F4E367"), Code="es", Name = "Espagnol", Translated = false },
                new Language() { ID = new Guid("2F815813-93AF-406B-BA6F-7103DF25EDD7"), Code="et", Name = "Eesti", Translated = false },
                new Language() { ID = new Guid("96C6E3BE-81FB-4788-AF8E-11E3054D1269"), Code="fi", Name = "Suomen", Translated = false },
                new Language() { ID = new Guid("A1C3C927-8FD9-4C03-AB14-10E4A2F50C0E"), Code="fr", Name = "Français", Translated = true },
                new Language() { ID = new Guid("B86E859E-693B-4DC5-AC56-5F7ED7E88841"), Code="ga", Name = "Gaeilge", Translated = false },
                new Language() { ID = new Guid("8E65746B-B206-444A-9584-4D354EA72EB1"), Code="hr", Name = "Hrvatski", Translated = false },
                new Language() { ID = new Guid("68FD9EB7-87B5-4E3B-99D3-8681EBE4F31A"), Code="hu", Name = "Magyar", Translated = false },
                new Language() { ID = new Guid("C0B4CAE0-ECCA-4213-AD88-FF38D19A537C"), Code="it", Name = "Italiano", Translated = false },
                new Language() { ID = new Guid("184F350A-12D7-413B-A582-7DEC0493EEE0"), Code="lt", Name = "Lietuvių", Translated = false },
                new Language() { ID = new Guid("E16269BE-FBCB-4813-8EE0-6D496A78DFEF"), Code="lv", Name = "Latviešu", Translated = false },
                new Language() { ID = new Guid("F849FF9C-080F-4EB1-B286-A16B6CCA58B8"), Code="mt", Name = "Malti", Translated = false },
                new Language() { ID = new Guid("23B9A00E-A261-4FAC-AA4B-8D9DB81BEE44"), Code="nl", Name = "Nederlands", Translated = true },
                new Language() { ID = new Guid("AA8C88A7-C083-4FB2-ACAE-616A8B853011"), Code="pl", Name = "Polski", Translated = false },
                new Language() { ID = new Guid("3995E0C7-C3EE-4EA3-84C2-D35E93B51C9E"), Code="pt", Name = "Português", Translated = false },
                new Language() { ID = new Guid("1A45DCB1-94E9-4D29-8CB0-AAA47CD702A7"), Code="ro", Name = "Română", Translated = false },
                new Language() { ID = new Guid("417DB2B0-E4DB-481B-AE4F-C9F256DEE6F2"), Code="ru", Name = "Русский", Translated = false },
                new Language() { ID = new Guid("E2F328B0-2E42-4A2E-B73B-F8B39D500622"), Code="sk", Name = "Slovenčina", Translated = false },
                new Language() { ID = new Guid("0F1D7A6A-1A39-4CEC-BBDE-CDF640110838"), Code="sl", Name = "Slovenski", Translated = false },
                new Language() { ID = new Guid("3D0CD848-B194-47E4-8602-A37AF4C91CC3"), Code="sv", Name = "Svenska", Translated = false }
            });
        }
        private void SeedDistances(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Distance>().HasData(new List<Distance>(){
                new Distance() { ID = new Guid("440F210C-E1F0-4AA1-9AC8-71E5CDC6B214"), Length=275, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="275m"}, new LanguageText() { LanguageCode="nl",Text="275m"}, new LanguageText() { LanguageCode="fr",Text="275m"}, new LanguageText() { LanguageCode="de",Text="275m"}}, IsOfficial = true },
                new Distance() { ID = new Guid("D9AE6E63-1EB3-4C53-AB2C-94471E183120"), Length=345, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="345m"}, new LanguageText() { LanguageCode="nl",Text="345m"}, new LanguageText() { LanguageCode="fr",Text="345m"}, new LanguageText() { LanguageCode="de",Text="345m"}}, IsOfficial = true },
                new Distance() { ID = new Guid("AA13072D-7B03-4F77-BAEE-7DB5B76AA524"), Length=480, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="480m"}, new LanguageText() { LanguageCode="nl",Text="480m"}, new LanguageText() { LanguageCode="fr",Text="480m"}, new LanguageText() { LanguageCode="de",Text="480m"}}, IsOfficial = true },
                new Distance() { ID = new Guid("197A1B1B-077C-460B-B235-0D2136DF18D1"), Length=200, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Piece from Clock"}, new LanguageText() { LanguageCode="nl",Text="Stukje vanaf de Klok"}, new LanguageText() { LanguageCode="fr",Text="Pièce partir de l'horloge"}, new LanguageText() { LanguageCode="de",Text="Stück vom Takt"}}, IsOfficial = false },
                new Distance() { ID = new Guid("8CF38BF9-6E49-45CA-A5BF-41367413B979"), Length=150, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Piece from Red Post"}, new LanguageText() { LanguageCode="nl",Text="Stukje vanaf de Rode Paal"}, new LanguageText() { LanguageCode="fr",Text="Pièce au pôle rouge"}, new LanguageText() { LanguageCode="de",Text="Stück vom roten Pol"}}, IsOfficial = false },
                new Distance() { ID = new Guid("BFE7B982-D7A0-4622-90C3-7BDDAE99A01D"), Length=100, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Straight"}, new LanguageText() { LanguageCode="nl",Text="Recht stukje"}, new LanguageText() { LanguageCode="fr",Text="Pièce à droite"}, new LanguageText() { LanguageCode="de",Text="Richtiges Stück"}}, IsOfficial = false },
                new Distance() { ID = new Guid("4CA3BC50-8EAB-4B6E-A62F-6EB549BC5A9E"), Length=50, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Piece from Jury House"}, new LanguageText() { LanguageCode="nl",Text="Stukje vanaf Juryhuis"}, new LanguageText() { LanguageCode="fr",Text="Pièce de la Maison du Jury"}, new LanguageText() { LanguageCode="de",Text="Stück vom Jury Hause"}}, IsOfficial = false },
            });
        }
        private void SeedRaceTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceType>().HasData(new List<RaceType>(){
                new RaceType() { ID = new Guid("14E7F603-92D6-437B-B93D-56300C5A4D92"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Preliminary"}, new LanguageText() { LanguageCode="nl",Text="Voorloop"}, new LanguageText() { LanguageCode="fr",Text="Préliminaire"}, new LanguageText() { LanguageCode="de",Text="Vorläuf"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("E72D9DFB-0E30-4E37-96F8-3DC002EA963D"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="2nd Preliminary"}, new LanguageText() { LanguageCode="nl",Text="2e Voorloop"}, new LanguageText() { LanguageCode="fr",Text="2ième Préliminaire"}, new LanguageText() { LanguageCode="de",Text="2e Vorläuf"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("63114685-C48A-4F44-A910-8C6979B5B687"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="2nd Chance"}, new LanguageText() { LanguageCode="nl",Text="Herkansing"}, new LanguageText() { LanguageCode="fr",Text="Resit"}, new LanguageText() { LanguageCode="de",Text="Wiederholung"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("D64D05A6-EABC-4820-9011-047FDDED0A84"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Semi Final"}, new LanguageText() { LanguageCode="nl",Text="Halve Finale"}, new LanguageText() { LanguageCode="fr",Text="Demi-finale"}, new LanguageText() { LanguageCode="de",Text="Halbfinale"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("8CA11BBB-CE66-4B79-95D9-EE0AC650561E"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Final"}, new LanguageText() { LanguageCode="nl",Text="Finale"}, new LanguageText() { LanguageCode="fr",Text="Finale"}, new LanguageText() { LanguageCode="de",Text="Finale"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("EE86BFCA-4C3F-437E-84C2-60D236573059"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="B-Final"}, new LanguageText() { LanguageCode="nl",Text="B-Finale"}, new LanguageText() { LanguageCode="fr",Text="Finale B"}, new LanguageText() { LanguageCode="de",Text="B-Finale"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("5A6454FE-9BBE-4AA8-BE8D-1937D61A29FC"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="C-Final"}, new LanguageText() { LanguageCode="nl",Text="C-Finale"}, new LanguageText() { LanguageCode="fr",Text="Finale C"}, new LanguageText() { LanguageCode="de",Text="C-Finale"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("F5F7A330-213D-4843-80DA-61BE75D400E8"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="D-Final"}, new LanguageText() { LanguageCode="nl",Text="D-Finale"}, new LanguageText() { LanguageCode="fr",Text="Finale D"}, new LanguageText() { LanguageCode="de",Text="D-Finale"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("6B10B543-DB0D-423D-B597-0C5C2B5B2FD4"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Training"}, new LanguageText() { LanguageCode="nl",Text="Training"}, new LanguageText() { LanguageCode="fr",Text="Formation"}, new LanguageText() { LanguageCode="de",Text="Training"}}, IsOfficial = false },
                new RaceType() { ID = new Guid("88DDFAF8-A5A4-4212-935E-BED616972426"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Licence Trial"}, new LanguageText() { LanguageCode="nl",Text="Goed Rond"}, new LanguageText() { LanguageCode="fr",Text="Essai de licence"}, new LanguageText() { LanguageCode="de",Text="Lizenzversuch" }}, IsOfficial = false },
                new RaceType() { ID = new Guid("3B6DD69C-8903-4DF4-BC04-34ED8802BFB5"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Demo run"}, new LanguageText() { LanguageCode="nl",Text="Demostratierit"}, new LanguageText() { LanguageCode="fr",Text="Course de Démostration"}, new LanguageText() { LanguageCode="de",Text="Demo-Läuf"}}, IsOfficial = true },
                new RaceType() { ID = new Guid("D7625773-FE4B-46A0-A2C6-5F3B3CAF64E9"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Solo run"}, new LanguageText() { LanguageCode="nl",Text="Solorit"}, new LanguageText() { LanguageCode="fr",Text="Course Solitaire"}, new LanguageText() { LanguageCode="de",Text="Einzelläuf"}}, IsOfficial = true },
            });
        }
        private void SeedRunResultTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RunResultType>().HasData(new List<RunResultType>(){
                new RunResultType() { ID = new Guid("04AF5196-9108-432D-B9D0-6A6EE540ED16"), Code = "OK", Order = 0, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="OK"}, new LanguageText() {LanguageCode="nl",Text="OK"}, new LanguageText() {LanguageCode="fr",Text="Bon"}, new LanguageText() {LanguageCode="de",Text="OK"} }},
                new RunResultType() { ID = new Guid("6ED4BD7D-EF60-4528-9D71-E4915D810A04"), Code = "DNS", Order = 3, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Did Not Start"}, new LanguageText() { LanguageCode="nl",Text="Niet Gestart"}, new LanguageText() { LanguageCode="fr",Text="Pas Commencé"}, new LanguageText() { LanguageCode="de",Text="Nicht Gestartet"} }},
                new RunResultType() { ID = new Guid("DBE4699A-3B22-4DD1-B86B-AB44BB600CFB"), Code = "DNF", Order = 2, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Did Not Finish"}, new LanguageText() { LanguageCode="nl",Text="Niet Gefinisht"}, new LanguageText() { LanguageCode="fr",Text="Pas fini"}, new LanguageText() { LanguageCode="de",Text="Nicht Beendet"} }},
                new RunResultType() { ID = new Guid("F5EEA2B5-C69B-49F3-9F54-B5B9876AB6B4"), Code = "DIS", Order = 4, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Disqualified"}, new LanguageText() { LanguageCode="nl",Text="Gediskwalificeerd"}, new LanguageText() { LanguageCode="fr",Text="Disqualifié"}, new LanguageText() { LanguageCode="de",Text="Disqualifiziert"} }},
                new RunResultType() { ID = new Guid("B5F052CF-2818-4A58-8C57-01ABB088B04B"), Code = "NR", Order = 1, Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="No Result"}, new LanguageText() { LanguageCode="nl",Text="Geen Resultaat"}, new LanguageText() { LanguageCode="fr",Text="Pas de résultat"}, new LanguageText() { LanguageCode="de",Text="Kein Ergebnis"} } }
            });
        }
        private void SeedCrewTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CrewType>().HasData(new List<CrewType>(){
                new CrewType() { ID = new Guid("40C6A00D-11BE-422F-8470-90AA8894D7EC"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Race leader"}, new LanguageText() { LanguageCode="nl",Text="Renleider"}, new LanguageText() { LanguageCode="fr",Text="Chef de course"}, new LanguageText() { LanguageCode="de",Text="Rennführer"} } },
                new CrewType() { ID = new Guid("E1A12EBD-8A70-44FD-973D-B2EE5FEBA09F"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Turn comissioner"}, new LanguageText() { LanguageCode="nl",Text="Bochtcommissaris"}, new LanguageText() { LanguageCode="fr",Text="Commissaire de courbure"}, new LanguageText() { LanguageCode="de",Text="BendKommisar"} } },
                new CrewType() { ID = new Guid("153D2723-5769-4A03-A496-0A65B461DCF3"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Time observation"}, new LanguageText() { LanguageCode="nl",Text="Tijdwaarneming"}, new LanguageText() { LanguageCode="fr",Text="Chronométrage"}, new LanguageText() { LanguageCode="de",Text="Zeitnahme"} } },
                new CrewType() { ID = new Guid("BC32177B-1649-44A9-B55A-66486C586674"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Jury"}, new LanguageText() { LanguageCode="nl",Text="Jury"}, new LanguageText() { LanguageCode="fr",Text="Jury"}, new LanguageText() { LanguageCode="de",Text="Jury"} } },
                new CrewType() { ID = new Guid("5AF3404E-403D-4A03-B258-E49BA035DDAD"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Hare Control"}, new LanguageText() { LanguageCode="nl",Text="Haastechniek"}, new LanguageText() { LanguageCode="fr",Text="Technique de Lièvre"}, new LanguageText() { LanguageCode="de",Text="Hasetechnik" } } },
                new CrewType() { ID = new Guid("F7DFA36A-BD7D-468E-ABA1-0A9171D67AF7"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Finish"}, new LanguageText() { LanguageCode="nl",Text="Finish"}, new LanguageText() { LanguageCode="fr",Text="Arrivée"}, new LanguageText() { LanguageCode="de",Text="Ziel"} } },
                new CrewType() { ID = new Guid("2EB77547-E033-4595-BAE7-F82F6EFA58AC"), Names = new List<LanguageText>() { new LanguageText() { LanguageCode="en",Text="Collaborator"}, new LanguageText() { LanguageCode="nl",Text="Finish"}, new LanguageText() { LanguageCode="fr",Text="Collaborateur"}, new LanguageText() { LanguageCode="de",Text="Mitarbeiter"} } },
            });
        }
        private void SeedCompetitions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceCompetition>().HasData(new List<RaceCompetition>(){
                new RaceCompetition() { ID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Name = "FCI", Code = "FCI", RunnerTypes = new List<RunnerType>(){ RunnerType.Normal, RunnerType.Wide }, IsProfessional = false }
            });
        }
        private void SeedAgeRestrictions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgeRestriction>().HasData(new List<AgeRestriction>(){
                new AgeRestriction() { BreedID = new Guid("7F991E29-2E61-48E7-B97A-50F90A573CAC"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("4E469CFA-B1F1-452A-B983-70A803AAD06C"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("677F5EFC-E697-4E8D-9FFE-DDF61394D595"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 15, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("33BBE8C5-D286-4E45-91A0-0EC52CDEA9C8"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("6786B78B-611E-430A-A589-65DF5C302E11"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 15, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("D670C778-A372-455B-9570-05A1FC330023"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("0B50FF12-D15F-4995-9F0F-4B21E96F862B"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("42AC8B3A-BBFB-4243-B104-D608EFDCF7B4"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("59BEC42E-A9B1-44B4-BF6C-57566D8CF8BB"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("A52BCB82-9D9D-41A7-AD2D-F1B037E937A3"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 15, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("B64AFE74-5FC1-4D42-BB9C-F2FDD65E90A7"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 15, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("1EC110CC-7F70-4060-93EF-58727FCBAEB9"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("72A99B45-1069-4576-AE00-242B563C6BAD"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("3A366646-A678-4706-A7EB-9EB1CC1B4961"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("453ABB88-6912-42C2-9F77-90582D1D467F"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("5E04BDAF-A785-456B-A18E-CC4922A1E776"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("C1D0390A-A688-498E-A1F1-782ED18B2787"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 15, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("2BB65B3A-0D1C-4D8E-AA2D-1648358DF96C"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 15, MaxAge = 96, TillEndOfYear = true },
                new AgeRestriction() { BreedID = new Guid("02B86E36-0CCD-435B-B665-6C7B2B246244"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), MinAge = 18, MaxAge = 96, TillEndOfYear = true },
            });
        }
        private void SeedJerseys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jersey>().HasData(new List<Jersey>(){
                new Jersey() { ID = new Guid("834DB893-4D73-4142-AAC8-8BEB0B334BFF"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Number = 1, Codes = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="R"}, new LanguageText() {LanguageCode ="nl",Text ="R"}, new LanguageText() {LanguageCode ="fr",Text ="R"}, new LanguageText() {LanguageCode ="de",Text ="R"} }, Names = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="Red"}, new LanguageText() {LanguageCode ="nl",Text ="Rood"}, new LanguageText() {LanguageCode ="fr",Text ="Rouge"}, new LanguageText() {LanguageCode ="de",Text ="Rot"} } },
                new Jersey() { ID = new Guid("F5570613-57C4-423B-B45F-C87F03995099"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Number = 2, Codes = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="B"}, new LanguageText() {LanguageCode ="nl",Text ="B"}, new LanguageText() {LanguageCode ="fr",Text ="B"}, new LanguageText() {LanguageCode ="de",Text ="B"} }, Names = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="Blue"}, new LanguageText() {LanguageCode ="nl",Text ="Blauw"}, new LanguageText() {LanguageCode ="fr",Text ="Bleu"}, new LanguageText() {LanguageCode ="de",Text ="Blau"} } },
                new Jersey() { ID = new Guid("23B3C4E1-51AB-44F3-B40A-8C4BEAD40636"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Number = 3, Codes = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="W"}, new LanguageText() {LanguageCode ="nl",Text ="W"}, new LanguageText() {LanguageCode ="fr",Text ="BC"}, new LanguageText() {LanguageCode ="de",Text ="W"} }, Names = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="White"}, new LanguageText() {LanguageCode ="nl",Text ="Wit"}, new LanguageText() {LanguageCode ="fr",Text ="Blanc"}, new LanguageText() {LanguageCode ="de",Text ="Weiß"} } },
                new Jersey() { ID = new Guid("04446811-485D-4C1B-A759-40F372983B08"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Number = 4, Codes = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="BK"}, new LanguageText() {LanguageCode ="nl",Text ="Z"}, new LanguageText() {LanguageCode ="fr",Text ="N"}, new LanguageText() {LanguageCode ="de",Text ="S"} }, Names = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="Black"}, new LanguageText() {LanguageCode ="nl",Text ="Zwart"}, new LanguageText() {LanguageCode ="fr",Text ="Noir"}, new LanguageText() {LanguageCode ="de",Text ="Schwarz"} } },
                new Jersey() { ID = new Guid("C2C8DD39-E395-468B-8BE9-90580013C659"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Number = 5, Codes = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="Y"}, new LanguageText() {LanguageCode ="nl",Text ="G"}, new LanguageText() {LanguageCode ="fr",Text ="J"}, new LanguageText() {LanguageCode ="de",Text ="G"} }, Names = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="Yellow"}, new LanguageText() {LanguageCode ="nl",Text ="Geel"}, new LanguageText() {LanguageCode ="fr",Text ="Jaune"}, new LanguageText() {LanguageCode ="de",Text ="Gelb"} } },
                new Jersey() { ID = new Guid("935CFA45-62D1-483D-8DD3-5264B57B7F09"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Number = 6, Codes = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="BK/W"}, new LanguageText() {LanguageCode ="nl",Text ="Z/W"}, new LanguageText() {LanguageCode ="fr",Text ="N/BC"}, new LanguageText() {LanguageCode ="de",Text ="S/W"} }, Names = new List<LanguageText>() { new LanguageText() { LanguageCode ="en",Text ="B/W Stripes"}, new LanguageText() {LanguageCode ="nl",Text ="Z/W Gestreept"}, new LanguageText() {LanguageCode ="fr",Text ="N/Bc Rayé"}, new LanguageText() {LanguageCode ="de",Text ="S/W Gestreift"} } },
            });
        }
        private void SeedRaceClasses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceClass>().HasData(new List<RaceClass>(){
                new RaceClass() { ID = new Guid("C37F460F-E121-433F-8B4E-A04C9B8498E6"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "O", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "Open"}, new LanguageText() { LanguageCode = "nl", Text = "Open"}, new LanguageText() { LanguageCode = "fr", Text = "Ouverte"}, new LanguageText() { LanguageCode = "de", Text = "Open"} }, ClassType = ClassType.Mixed },
                new RaceClass() { ID = new Guid("4FE73B6E-3041-41DD-800D-785221165C71"), MixedClassID = new Guid("C37F460F-E121-433F-8B4E-A04C9B8498E6"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "O", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "Open FCI-CACIL" }, new LanguageText() { LanguageCode = "nl", Text = "Open FCI-CACIL" }, new LanguageText() { LanguageCode = "fr", Text = "Ouverte FCI-CACIL" }, new LanguageText() { LanguageCode = "de", Text = "Open FCI-CACIL"} }, ClassType = ClassType.FCICACIL },
                new RaceClass() { ID = new Guid("9C7865EB-56DE-4DD8-8491-2161649D3AAF"), MixedClassID = new Guid("C37F460F-E121-433F-8B4E-A04C9B8498E6"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "O", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "Open CSS"}, new LanguageText() { LanguageCode = "nl", Text = "Open CSS" }, new LanguageText() { LanguageCode = "fr", Text = "Ouverte CSS" }, new LanguageText() { LanguageCode = "de", Text = "Open CSS" } }, ClassType = ClassType.CSS },
                new RaceClass() { ID = new Guid("CA9590FF-1714-4D98-8EE1-FC7BCBC1B836"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "A", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "A-Class"}, new LanguageText() { LanguageCode = "nl", Text = "A-Klasse"}, new LanguageText() { LanguageCode = "fr", Text = "A-Class"}, new LanguageText() { LanguageCode = "de", Text = "A-Klasse"} }, ClassType = ClassType.Mixed },
                new RaceClass() { ID = new Guid("827C18C9-8D10-4CCA-915F-61699560A5EA"), MixedClassID = new Guid("CA9590FF-1714-4D98-8EE1-FC7BCBC1B836"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "A", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "A-Class FCI-CACIL" }, new LanguageText() { LanguageCode = "nl", Text = "A-Klasse FCI-CACIL" }, new LanguageText() { LanguageCode = "fr", Text = "A-Class FCI-CACIL" }, new LanguageText() { LanguageCode = "de", Text = "A-Klasse FCI-CACIL" } }, ClassType = ClassType.FCICACIL },
                new RaceClass() { ID = new Guid("C730BA8C-4D8C-46FD-BDF9-207963321BD6"), MixedClassID = new Guid("CA9590FF-1714-4D98-8EE1-FC7BCBC1B836"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "A", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "A-Class CSS" }, new LanguageText() { LanguageCode = "nl", Text = "A-Klasse CSS" }, new LanguageText() { LanguageCode = "fr", Text = "A-Class CSS" }, new LanguageText() { LanguageCode = "de", Text = "A-Klasse CSS" } }, ClassType = ClassType.CSS },
                new RaceClass() { ID = new Guid("CE6D34B8-D832-4308-A163-CD97E82FCE43"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "B", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "B-Class"}, new LanguageText() { LanguageCode = "nl", Text = "B-Klasse"}, new LanguageText() { LanguageCode = "fr", Text = "B-Class"}, new LanguageText() { LanguageCode = "de", Text = "B-Klasse"} }, ClassType = ClassType.Mixed },
                new RaceClass() { ID = new Guid("3A1B3C22-C1C6-44D7-9608-39FBE92480E7"), MixedClassID = new Guid("CE6D34B8-D832-4308-A163-CD97E82FCE43"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "B", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "B-Class FCI-CACIL" }, new LanguageText() { LanguageCode = "nl", Text = "B-Klasse FCI-CACIL" }, new LanguageText() { LanguageCode = "fr", Text = "B-Class FCI-CACIL" }, new LanguageText() { LanguageCode = "de", Text = "B-Klasse FCI-CACIL" } }, ClassType = ClassType.FCICACIL },
                new RaceClass() { ID = new Guid("D32848B7-4CEA-4201-958D-6578A0019950"), MixedClassID = new Guid("CE6D34B8-D832-4308-A163-CD97E82FCE43"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "B", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "B-Class CSS" }, new LanguageText() { LanguageCode = "nl", Text = "B-Klasse CSS" }, new LanguageText() { LanguageCode = "fr", Text = "B-Class CSS" }, new LanguageText() { LanguageCode = "de", Text = "B-Klasse CSS" } }, ClassType = ClassType.CSS },
                new RaceClass() { ID = new Guid("3E9108A4-D235-44EF-B0FB-92E8D5E16878"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "C", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "C-Class"}, new LanguageText() { LanguageCode = "nl", Text = "C-Klasse"}, new LanguageText() { LanguageCode = "fr", Text = "C-Class"}, new LanguageText() { LanguageCode = "de", Text = "C-Klasse"} }, ClassType = ClassType.Mixed },
                new RaceClass() { ID = new Guid("F9AFDB87-B524-4356-9743-EBB38144AAF6"), MixedClassID = new Guid("3E9108A4-D235-44EF-B0FB-92E8D5E16878"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "C", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "C-Class FCI-CACIL" }, new LanguageText() { LanguageCode = "nl", Text = "C-Klasse FCI-CACIL" }, new LanguageText() { LanguageCode = "fr", Text = "C-Class FCI-CACIL" }, new LanguageText() { LanguageCode = "de", Text = "C-Klasse FCI-CACIL" } }, ClassType = ClassType.FCICACIL },
                new RaceClass() { ID = new Guid("20DFF530-754D-46ED-9CDC-69080A683B22"), MixedClassID = new Guid("3E9108A4-D235-44EF-B0FB-92E8D5E16878"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "C", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "C-Class CSS" }, new LanguageText() { LanguageCode = "nl", Text = "C-Klasse CSS" }, new LanguageText() { LanguageCode = "fr", Text = "C-Class CSS" }, new LanguageText() { LanguageCode = "de", Text = "C-Klasse CSS" } }, ClassType = ClassType.CSS },
                new RaceClass() { ID = new Guid("3B204FBF-A1A7-43D2-8B41-A2AA310B29BE"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "G", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "Veteran"}, new LanguageText() { LanguageCode = "nl", Text = "Veteranen"}, new LanguageText() { LanguageCode = "fr", Text = "Vétéran"}, new LanguageText() { LanguageCode = "de", Text = "Veteran"} }, ClassType = ClassType.Mixed },
                new RaceClass() { ID = new Guid("809D7D3A-4BA2-4B89-ACF6-50735199FDA2"), MixedClassID = new Guid("3B204FBF-A1A7-43D2-8B41-A2AA310B29BE"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "G", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "Veteran FCI-CACIL" }, new LanguageText() { LanguageCode = "nl", Text = "Veteranen FCI-CACIL" }, new LanguageText() { LanguageCode = "fr", Text = "Vétéran FCI-CACIL" }, new LanguageText() { LanguageCode = "de", Text = "Veteran FCI-CACIL" } }, ClassType = ClassType.FCICACIL },
                new RaceClass() { ID = new Guid("3A22B699-3489-4749-B766-B2C63275068E"), MixedClassID = new Guid("3B204FBF-A1A7-43D2-8B41-A2AA310B29BE"), CompetitionID = new Guid("64B11D35-97FC-4223-82DA-23E09BEC1BD6"), Code = "G", Names = new List<LanguageText>() { new LanguageText() { LanguageCode = "en", Text = "Veteran CSS" }, new LanguageText() { LanguageCode = "nl", Text = "Veteranen CSS" }, new LanguageText() { LanguageCode = "fr", Text = "Vétéran CSS" }, new LanguageText() { LanguageCode = "de", Text = "Veteran CSS" } }, ClassType = ClassType.CSS },
            });
        }
        private void SeedAddresses(ModelBuilder modelBuilder)
        {
            int srid = 4326;
            modelBuilder.Entity<Address>().HasData(new List<Address>(){
                new Address() { ID = new Guid("A55714D4-A40A-4F2A-9D68-282BBADECB46"), Street = "Paalsesteenweg", StreetNumber = "91", PostCode = "3580", City = "Beringen", CountryID = new Guid("0AFEC050-198A-4248-B736-E5BD611550A9"), Coordinates = new Point(5.2043387767037625, 51.04629826617232) { SRID = srid } },
                new Address() { ID = new Guid("CEEA56E8-6193-4541-B760-89AF6F762A4A"), Street = "Rue Jean Lambert Defrêne", StreetNumber = "98", PostCode = "4340", City = "Awans", CountryID = new Guid("0AFEC050-198A-4248-B736-E5BD611550A9"), Coordinates = new Point(5.469089715340752, 50.67511672146613) { SRID = srid } },
                new Address() { ID = new Guid("0A7100B9-A371-475E-843D-5681D4123320"), Street = "Alberdingweg", StreetNumber = "171", PostCode = "48161", City = "Münster", CountryID = new Guid("21D61853-43C2-422F-993B-EF96FA75AFEA"), Coordinates = new Point(7.512220369318495, 52.00803087574718) { SRID = srid } },
                new Address() { ID = new Guid("FE8AC32B-10FD-43AF-AC29-C8749AF9ECB0"), Street = "Wiedehopfstraße", StreetNumber = "197", PostCode = "45892", City = "Gelsenkirchen-Resse", CountryID = new Guid("21D61853-43C2-422F-993B-EF96FA75AFEA"), Coordinates = new Point(7.141436499999999, 51.553632324864154) { SRID = srid } },
                new Address() { ID = new Guid("75CC3997-7D8B-4AC3-B46C-F1CA12D6A060"), Street = "Bosrand", StreetNumber = "130", PostCode = "5665 ET", City = "Geldrop", CountryID = new Guid("ADE8E58E-F037-48AA-8FAE-5BEDCB6AD0D8"), Coordinates = new Point(5.577288230681506, 51.41417833236854) { SRID = srid } },
            });
        }
        #endregion
    }
}
