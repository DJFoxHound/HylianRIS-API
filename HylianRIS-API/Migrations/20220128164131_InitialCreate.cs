﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace HylianRIS_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breeds",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExternalSystemUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PluralNames = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeds", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RunnerTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsProfessional = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    _Names = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CrewTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    _Names = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Distances",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    IsOfficial = table.Column<bool>(type: "bit", nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distances", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RaceTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsOfficial = table.Column<bool>(type: "bit", nullable: false),
                    _Names = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RunResultTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    HasCustomOrder = table.Column<bool>(type: "bit", nullable: false),
                    _Names = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunResultTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PluralNames = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AgeRestrictions",
                columns: table => new
                {
                    BreedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompetitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MinAge = table.Column<int>(type: "int", nullable: false),
                    MaxAge = table.Column<int>(type: "int", nullable: false),
                    TillEndOfYear = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeRestrictions", x => new { x.BreedId, x.CompetitionID });
                    table.ForeignKey(
                        name: "FK_AgeRestrictions_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgeRestrictions_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    RequiredAge = table.Column<int>(type: "int", nullable: false),
                    ClassType = table.Column<int>(type: "int", nullable: false),
                    CompetitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MixedClassID = table.Column<Guid?>(type: "uniqueidentifier", nullable: true),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Classes_Classes_MixedClassID",
                        column: x => x.MixedClassID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jerseys",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Codes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jerseys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Jerseys_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Box = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Coordinates = table.Column<Point>(type: "geography", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionTypes",
                columns: table => new
                {
                    CompetitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionTypes", x => new { x.CompetitionID, x.TypeID });
                    table.ForeignKey(
                        name: "FK_CompetitionTypes_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionTypes_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "RaceTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BreedClasses",
                columns: table => new
                {
                    BreedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedClasses", x => new { x.BreedID, x.ClassID });
                    table.ForeignKey(
                        name: "FK_BreedClasses_Breeds_BreedID",
                        column: x => x.BreedID,
                        principalTable: "Breeds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BreedClasses_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Accounts_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompetitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Organisations_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organisations_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tracks_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Persons_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountRoles",
                columns: table => new
                {
                    AccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganisationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRoles", x => new { x.RoleID, x.AccountID, x.OrganisationID });
                    table.ForeignKey(
                        name: "FK_AccountRoles_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountRoles_Organisations_OrganisationID",
                        column: x => x.OrganisationID,
                        principalTable: "Organisations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contact_ContactTypes_TypeID",
                        column: x => x.TypeID,
                        principalTable: "ContactTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_Organisations_OrganisationID",
                        column: x => x.OrganisationID,
                        principalTable: "Organisations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionTracks",
                columns: table => new
                {
                    CompetitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionTracks", x => new { x.CompetitionID, x.TrackID });
                    table.ForeignKey(
                        name: "FK_CompetitionTracks_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionTracks_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganisationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompetitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsOfficial = table.Column<bool>(type: "bit", nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Events_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Organisations_OrganisationID",
                        column: x => x.OrganisationID,
                        principalTable: "Organisations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrackDistances",
                columns: table => new
                {
                    DistanceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackDistances", x => new { x.DistanceID, x.TrackID });
                    table.ForeignKey(
                        name: "FK_TrackDistances_Distances_DistanceID",
                        column: x => x.DistanceID,
                        principalTable: "Distances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackDistances_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrackOrganisations",
                columns: table => new
                {
                    OrganisationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackOrganisations", x => new { x.OrganisationID, x.TrackID });
                    table.ForeignKey(
                        name: "FK_TrackOrganisations_Organisations_OrganisationID",
                        column: x => x.OrganisationID,
                        principalTable: "Organisations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackOrganisations_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SexId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pedigree = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Chip = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    RunnerType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dogs_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dogs_Persons_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dogs_Sexes_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewMembers",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CrewTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMembers", x => new { x.EventId, x.PersonID, x.CrewTypeID });
                    table.ForeignKey(
                        name: "FK_CrewMembers_CrewTypes_CrewTypeID",
                        column: x => x.CrewTypeID,
                        principalTable: "CrewTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrewMembers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrewMembers_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNr = table.Column<int>(type: "int", nullable: false),
                    RaceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BreedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SexId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Races_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_Distances_DistanceId",
                        column: x => x.DistanceId,
                        principalTable: "Distances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Races_RaceTypes_RaceTypeId",
                        column: x => x.RaceTypeId,
                        principalTable: "RaceTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_Sexes_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    DogID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => new { x.DogID, x.EventID });
                    table.ForeignKey(
                        name: "FK_Participants_Dogs_DogID",
                        column: x => x.DogID,
                        principalTable: "Dogs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participants_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RaceLicenses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaceClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompetitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceLicenses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RaceLicenses_Classes_RaceClassId",
                        column: x => x.RaceClassId,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceLicenses_Competitions_CompetitionID",
                        column: x => x.CompetitionID,
                        principalTable: "Competitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RaceLicenses_Dogs_DogID",
                        column: x => x.DogID,
                        principalTable: "Dogs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Runs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JerseyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResultTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TimeTicks = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Runs_Dogs_DogID",
                        column: x => x.DogID,
                        principalTable: "Dogs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Runs_Jerseys_JerseyID",
                        column: x => x.JerseyID,
                        principalTable: "Jerseys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Runs_Races_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Races",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Runs_RunResultTypes_ResultTypeID",
                        column: x => x.ResultTypeID,
                        principalTable: "RunResultTypes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TrackRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistanceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BreedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SexID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RunID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DogName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPreSystem = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrackRecords_Breeds_BreedID",
                        column: x => x.BreedID,
                        principalTable: "Breeds",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackRecords_Distances_DistanceID",
                        column: x => x.DistanceID,
                        principalTable: "Distances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackRecords_Runs_RunID",
                        column: x => x.RunID,
                        principalTable: "Runs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TrackRecords_Sexes_SexID",
                        column: x => x.SexID,
                        principalTable: "Sexes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackRecords_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoles_AccountID",
                table: "AccountRoles",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoles_OrganisationID",
                table: "AccountRoles",
                column: "OrganisationID");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AddressID",
                table: "Accounts",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryID",
                table: "Addresses",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_AgeRestrictions_CompetitionID",
                table: "AgeRestrictions",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_BreedClasses_ClassID",
                table: "BreedClasses",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Code",
                table: "Classes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CompetitionID",
                table: "Classes",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_MixedClassID",
                table: "Classes",
                column: "MixedClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_Code",
                table: "Competitions",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionTracks_TrackID",
                table: "CompetitionTracks",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionTypes_TypeID",
                table: "CompetitionTypes",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_OrganisationID_TypeID",
                table: "Contact",
                columns: new[] { "OrganisationID", "TypeID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_TypeID",
                table: "Contact",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Code",
                table: "Countries",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CrewMembers_CrewTypeID",
                table: "CrewMembers",
                column: "CrewTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CrewMembers_PersonID",
                table: "CrewMembers",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Distances_Length",
                table: "Distances",
                column: "Length",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_BreedId",
                table: "Dogs",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_CountryId",
                table: "Dogs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_OwnerId",
                table: "Dogs",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_SexId",
                table: "Dogs",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CompetitionID",
                table: "Events",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganisationID",
                table: "Events",
                column: "OrganisationID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TrackID",
                table: "Events",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_Jerseys_CompetitionID",
                table: "Jerseys",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Jerseys_Number_CompetitionID",
                table: "Jerseys",
                columns: new[] { "Number", "CompetitionID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_AddressID",
                table: "Organisations",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_CompetitionID",
                table: "Organisations",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_EventID",
                table: "Participants",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AccountId",
                table: "Persons",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CountryId",
                table: "Persons",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceLicenses_CompetitionID",
                table: "RaceLicenses",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_RaceLicenses_DogID",
                table: "RaceLicenses",
                column: "DogID");

            migrationBuilder.CreateIndex(
                name: "IX_RaceLicenses_RaceClassId",
                table: "RaceLicenses",
                column: "RaceClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_BreedId",
                table: "Races",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_ClassId",
                table: "Races",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_DistanceId",
                table: "Races",
                column: "DistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_EventId",
                table: "Races",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_RaceTypeId",
                table: "Races",
                column: "RaceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SexId",
                table: "Races",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_RunResultTypes_Code",
                table: "RunResultTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Runs_DogID",
                table: "Runs",
                column: "DogID");

            migrationBuilder.CreateIndex(
                name: "IX_Runs_JerseyID",
                table: "Runs",
                column: "JerseyID");

            migrationBuilder.CreateIndex(
                name: "IX_Runs_RaceID",
                table: "Runs",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Runs_ResultTypeID",
                table: "Runs",
                column: "ResultTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackDistances_TrackID",
                table: "TrackDistances",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackOrganisations_TrackID",
                table: "TrackOrganisations",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_BreedID",
                table: "TrackRecords",
                column: "BreedID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_DistanceID",
                table: "TrackRecords",
                column: "DistanceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_RunID",
                table: "TrackRecords",
                column: "RunID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_SexID",
                table: "TrackRecords",
                column: "SexID");

            migrationBuilder.CreateIndex(
                name: "IX_TrackRecords_TrackID",
                table: "TrackRecords",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AddressID",
                table: "Tracks",
                column: "AddressID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountRoles");

            migrationBuilder.DropTable(
                name: "AgeRestrictions");

            migrationBuilder.DropTable(
                name: "BreedClasses");

            migrationBuilder.DropTable(
                name: "CompetitionTracks");

            migrationBuilder.DropTable(
                name: "CompetitionTypes");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "CrewMembers");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "RaceLicenses");

            migrationBuilder.DropTable(
                name: "TrackDistances");

            migrationBuilder.DropTable(
                name: "TrackOrganisations");

            migrationBuilder.DropTable(
                name: "TrackRecords");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "CrewTypes");

            migrationBuilder.DropTable(
                name: "Runs");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Jerseys");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "RunResultTypes");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Breeds");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Distances");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "RaceTypes");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
