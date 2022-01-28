using Hylian.RIS.API.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
                .HasKey(k => new { k.BreedId, k.CompetitionID });
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
                .HasKey(k => new { k.EventId, k.PersonID, k.CrewTypeID });
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
            modelBuilder.Entity<RaceClass>().ToTable("Classes")
                .HasIndex(i => i.Code)
                .IsUnique();
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
            #endregion
        }
        private void RaceLicenseModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RaceLicense>().ToTable("RaceLicenses");
            #endregion
            #region Relations
            #endregion
        }
        private void RaceTrackModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RaceTrack>().ToTable("Tracks");
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
                    .OnDelete(DeleteBehavior.Cascade)
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
            #endregion
        }
        private void RunResultModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<RunResultType>().ToTable("RunResultTypes");
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
            modelBuilder.Entity<Sex>().ToTable("Sexes");
            modelBuilder.Entity<Sex>().Property(l => l._Names).HasColumnName("Names");
            modelBuilder.Entity<Sex>().Property(l => l._PluralNames).HasColumnName("PluralNames");
            #endregion
            #region Relations
            #endregion
        }
        private void TrackRecordCreating(ModelBuilder modelBuilder)
        {
            #region Mapping
            modelBuilder.Entity<TrackRecord>().ToTable("TrackRecords");
            #endregion
            #region Relations
            #endregion
        }
        #endregion
    }
}
