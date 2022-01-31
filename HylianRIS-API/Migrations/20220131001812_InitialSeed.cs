using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace HylianRIS_API.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "ID", "ExternalSystemUrl", "Names", "PluralNames" },
                values: new object[,]
                {
                    { new Guid("02b86e36-0ccd-435b-b665-6c7b2b246244"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Podenco Iberico\"},{\"LanguageCode\":\"nl\",\"Text\":\"Podenco Iberico\"},{\"LanguageCode\":\"fr\",\"Text\":\"Podenco Iberico\"},{\"LanguageCode\":\"de\",\"Text\":\"Podenco Iberico\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Podenco Iberico\"},{\"LanguageCode\":\"nl\",\"Text\":\"Podenco Iberico\"},{\"LanguageCode\":\"fr\",\"Text\":\"Podenco Iberico\"},{\"LanguageCode\":\"de\",\"Text\":\"Podenco Iberico\"}]" },
                    { new Guid("0b50ff12-d15f-4995-9f0f-4b21e96f862b"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Greyhound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Greyhound\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Anglais\"},{\"LanguageCode\":\"de\",\"Text\":\"Greyhound\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Greyhound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Greyhound\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Anglais\"},{\"LanguageCode\":\"de\",\"Text\":\"Greyhound\"}]" },
                    { new Guid("1ec110cc-7f70-4060-93ef-58727fcbaeb9"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Pharao Hound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Pharao Hound\"},{\"LanguageCode\":\"fr\",\"Text\":\"Chien du Pharaon\"},{\"LanguageCode\":\"de\",\"Text\":\"Pharaonenhund\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Pharao Hound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Pharao Hound\"},{\"LanguageCode\":\"fr\",\"Text\":\"Chien du Pharaon\"},{\"LanguageCode\":\"de\",\"Text\":\"Pharaonenhund\"}]" },
                    { new Guid("2bb65b3a-0d1c-4d8e-aa2d-1648358df96c"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Whippet Sprinter\"},{\"LanguageCode\":\"nl\",\"Text\":\"Whippet Sprinter\"},{\"LanguageCode\":\"fr\",\"Text\":\"Whippet Sprinter\"},{\"LanguageCode\":\"de\",\"Text\":\"Whippet Sprinter\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Whippet Sprinter\"},{\"LanguageCode\":\"nl\",\"Text\":\"Whippet Sprinter\"},{\"LanguageCode\":\"fr\",\"Text\":\"Whippet Sprinter\"},{\"LanguageCode\":\"de\",\"Text\":\"Whippet Sprinter\"}]" },
                    { new Guid("33bbe8c5-d286-4e45-91a0-0ec52cdea9c8"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Borzoi\"},{\"LanguageCode\":\"nl\",\"Text\":\"Barzoi\"},{\"LanguageCode\":\"fr\",\"Text\":\"Barzoi\"},{\"LanguageCode\":\"de\",\"Text\":\"Barsoi\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Borzoi\"},{\"LanguageCode\":\"nl\",\"Text\":\"Barzoi\"},{\"LanguageCode\":\"fr\",\"Text\":\"Barzoi\"},{\"LanguageCode\":\"de\",\"Text\":\"Barsoi\"}]" },
                    { new Guid("3a366646-a678-4706-a7eb-9eb1cc1b4961"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Saluki\"},{\"LanguageCode\":\"nl\",\"Text\":\"Saluki\"},{\"LanguageCode\":\"fr\",\"Text\":\"Saluki\"},{\"LanguageCode\":\"de\",\"Text\":\"Saluki\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Saluki\"},{\"LanguageCode\":\"nl\",\"Text\":\"Saluki\"},{\"LanguageCode\":\"fr\",\"Text\":\"Saluki\"},{\"LanguageCode\":\"de\",\"Text\":\"Saluki\"}]" },
                    { new Guid("42ac8b3a-bbfb-4243-b104-d608efdcf7b4"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Hungarian Greyhound - Magyar Agar\"},{\"LanguageCode\":\"nl\",\"Text\":\"Hongaarse Windhond - Magyar Agar\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Hongrois - Magyar Agar\"},{\"LanguageCode\":\"de\",\"Text\":\"Ungarischer Wundhund - Magyar Agar\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Hungarian Greyhound - Magyar Agar\"},{\"LanguageCode\":\"nl\",\"Text\":\"Hongaarse Windhond - Magyar Agar\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Hongrois - Magyar Agar\"},{\"LanguageCode\":\"de\",\"Text\":\"Ungarischer Wundhund - Magyar Agar\"}]" },
                    { new Guid("453abb88-6912-42c2-9f77-90582d1d467f"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Sloughi\"},{\"LanguageCode\":\"nl\",\"Text\":\"Sloughi\"},{\"LanguageCode\":\"fr\",\"Text\":\"Sloughi\"},{\"LanguageCode\":\"de\",\"Text\":\"Sloughi\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Sloughi\"},{\"LanguageCode\":\"nl\",\"Text\":\"Sloughi\"},{\"LanguageCode\":\"fr\",\"Text\":\"Sloughi\"},{\"LanguageCode\":\"de\",\"Text\":\"Sloughi\"}]" },
                    { new Guid("4e469cfa-b1f1-452a-b983-70a803aad06c"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Azawakh\"},{\"LanguageCode\":\"nl\",\"Text\":\"Azawakh\"},{\"LanguageCode\":\"fr\",\"Text\":\"Azawakh\"},{\"LanguageCode\":\"de\",\"Text\":\"Azawakh\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Azawakh\"},{\"LanguageCode\":\"nl\",\"Text\":\"Azawakh\"},{\"LanguageCode\":\"fr\",\"Text\":\"Azawakh\"},{\"LanguageCode\":\"de\",\"Text\":\"Azawakh\"}]" },
                    { new Guid("59bec42e-a9b1-44b4-bf6c-57566d8cf8bb"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Irish Wolfhound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Ierse Wolfshond\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Irlandais\"},{\"LanguageCode\":\"de\",\"Text\":\"Irischer Wolfshund\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Irish Wolfhound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Ierse Wolfshond\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Irlandais\"},{\"LanguageCode\":\"de\",\"Text\":\"Irischer Wolfshund\"}]" },
                    { new Guid("5e04bdaf-a785-456b-a18e-cc4922a1e776"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Spanish Greyhound - Galgo Espagnol\"},{\"LanguageCode\":\"nl\",\"Text\":\"Spaanse Windhond - Galgo Espagnol\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levier Espagnol - Galgo Espagnol\"},{\"LanguageCode\":\"de\",\"Text\":\"Spanischer Windhund - Galgo Espagnol\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Spanish Greyhound - Galgo Espagnol\"},{\"LanguageCode\":\"nl\",\"Text\":\"Spaanse Windhond - Galgo Espagnol\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levier Espagnol - Galgo Espagnol\"},{\"LanguageCode\":\"de\",\"Text\":\"Spanischer Windhund - Galgo Espagnol\"}]" },
                    { new Guid("677f5efc-e697-4e8d-9ffe-ddf61394d595"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Basenji\"},{\"LanguageCode\":\"nl\",\"Text\":\"Basenji\"},{\"LanguageCode\":\"fr\",\"Text\":\"Basenji\"},{\"LanguageCode\":\"de\",\"Text\":\"Basenji\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Basenji\"},{\"LanguageCode\":\"nl\",\"Text\":\"Basenji\"},{\"LanguageCode\":\"fr\",\"Text\":\"Basenji\"},{\"LanguageCode\":\"de\",\"Text\":\"Basenji\"}]" },
                    { new Guid("6786b78b-611e-430a-a589-65df5c302e11"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Cirneco dell’Etna\"},{\"LanguageCode\":\"nl\",\"Text\":\"Cirneco dell’Etna\"},{\"LanguageCode\":\"fr\",\"Text\":\"Cirneco de l’Etna\"},{\"LanguageCode\":\"de\",\"Text\":\"Cirneco dell’Etna\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Cirneco dell’Etna\"},{\"LanguageCode\":\"nl\",\"Text\":\"Cirneco dell’Etna\"},{\"LanguageCode\":\"fr\",\"Text\":\"Cirneco de l’Etna\"},{\"LanguageCode\":\"de\",\"Text\":\"Cirneco dell’Etna\"}]" },
                    { new Guid("72a99b45-1069-4576-ae00-242b563c6bad"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Polish Greyhound - Chart Polski\"},{\"LanguageCode\":\"nl\",\"Text\":\"Poolse Windhond - Chart Polski\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Polonais - Chart Polski\"},{\"LanguageCode\":\"de\",\"Text\":\"Polnischer Windhund - Chart Polski\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Polish Greyhound - Chart Polski\"},{\"LanguageCode\":\"nl\",\"Text\":\"Poolse Windhond - Chart Polski\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Polonais - Chart Polski\"},{\"LanguageCode\":\"de\",\"Text\":\"Polnischer Windhund - Chart Polski\"}]" },
                    { new Guid("7f991e29-2e61-48e7-b97a-50f90a573cac"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Afghan Hound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Afgaanse Windhond\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Afghan\"},{\"LanguageCode\":\"de\",\"Text\":\"Afghanischer Windhund\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Afghan Hound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Afgaanse Windhond\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrier Afghan\"},{\"LanguageCode\":\"de\",\"Text\":\"Afghanischer Windhund\"}]" },
                    { new Guid("a52bcb82-9d9d-41a7-ad2d-f1b037e937a3"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Italian Greyhound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Italiaanse Windhond - PLI\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrette d'Italie - PLI\"},{\"LanguageCode\":\"de\",\"Text\":\"Italienisches Windspiel\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Italian Greyhound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Italiaanse Windhond - PLI\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrette d'Italie - PLI\"},{\"LanguageCode\":\"de\",\"Text\":\"Italienisches Windspiel\"}]" },
                    { new Guid("b64afe74-5fc1-4d42-bb9c-f2fdd65e90a7"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Italian Greyhound Sprinter\"},{\"LanguageCode\":\"nl\",\"Text\":\"Italiaanse Windhond - PLI Sprinter\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrette d'Italie - PLI Sprinters\"},{\"LanguageCode\":\"de\",\"Text\":\"Italienisches Windspiel Sprinters\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Italian Greyhound Sprinter\"},{\"LanguageCode\":\"nl\",\"Text\":\"Italiaanse Windhond - PLI Sprinter\"},{\"LanguageCode\":\"fr\",\"Text\":\"Levrette d'Italie - PLI Sprinters\"},{\"LanguageCode\":\"de\",\"Text\":\"Italienisches Windspiel Sprinters\"}]" },
                    { new Guid("c1d0390a-a688-498e-a1f1-782ed18b2787"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Whippet\"},{\"LanguageCode\":\"nl\",\"Text\":\"Whippet\"},{\"LanguageCode\":\"fr\",\"Text\":\"Whippet\"},{\"LanguageCode\":\"de\",\"Text\":\"Whippet\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Whippet\"},{\"LanguageCode\":\"nl\",\"Text\":\"Whippet\"},{\"LanguageCode\":\"fr\",\"Text\":\"Whippet\"},{\"LanguageCode\":\"de\",\"Text\":\"Whippet\"}]" },
                    { new Guid("d670c778-a372-455b-9570-05a1fc330023"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Deerhound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Deerhound\"},{\"LanguageCode\":\"fr\",\"Text\":\"Deerhounds\"},{\"LanguageCode\":\"de\",\"Text\":\"Schottischer Hirschhund\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Deerhound\"},{\"LanguageCode\":\"nl\",\"Text\":\"Deerhound\"},{\"LanguageCode\":\"fr\",\"Text\":\"Deerhounds\"},{\"LanguageCode\":\"de\",\"Text\":\"Schottischer Hirschhund\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "ID", "Code", "IsProfessional", "Name", "RunnerTypes" },
                values: new object[] { new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), "FCI", false, "FCI", "Normal,Wide" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Code", "Names" },
                values: new object[,]
                {
                    { new Guid("0088049b-c496-43f1-b6a6-5abc8e2762bb"), "COM", "[{\"LanguageCode\":\"en\",\"Text\":\"Comoros\"},{\"LanguageCode\":\"nl\",\"Text\":\"Comoren\"},{\"LanguageCode\":\"fr\",\"Text\":\"Comores\"},{\"LanguageCode\":\"de\",\"Text\":\"Komoren\"}]" },
                    { new Guid("01ea759e-57f0-4dc9-9817-504d06b864d4"), "ZWE", "[{\"LanguageCode\":\"en\",\"Text\":\"Zimbabwe\"},{\"LanguageCode\":\"nl\",\"Text\":\"Zimbabwe\"},{\"LanguageCode\":\"fr\",\"Text\":\"Zimbabwe\"},{\"LanguageCode\":\"de\",\"Text\":\"Simbabwe\"}]" },
                    { new Guid("024d4f47-56d4-4267-a298-bd54d6f80634"), "HRV", "[{\"LanguageCode\":\"en\",\"Text\":\"Croatia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Kroatië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Croatie\"},{\"LanguageCode\":\"de\",\"Text\":\"Kroatien\"}]" },
                    { new Guid("0426a22d-45d2-4341-9b03-9532b07e5a86"), "SLE", "[{\"LanguageCode\":\"en\",\"Text\":\"Sierra Leone\"},{\"LanguageCode\":\"nl\",\"Text\":\"Sierra Leone\"},{\"LanguageCode\":\"fr\",\"Text\":\"Sierra Leone\"},{\"LanguageCode\":\"de\",\"Text\":\"Sierra Leone\"}]" },
                    { new Guid("08387049-6564-4c12-b882-14001f383f43"), "SLB", "[{\"LanguageCode\":\"en\",\"Text\":\"Solomon Islands\"},{\"LanguageCode\":\"nl\",\"Text\":\"Salomonseilanden\"},{\"LanguageCode\":\"fr\",\"Text\":\"Îles Salomon\"},{\"LanguageCode\":\"de\",\"Text\":\"Salomonen\"}]" },
                    { new Guid("0a258ac6-6730-459e-ba76-6dbedec19339"), "RWA", "[{\"LanguageCode\":\"en\",\"Text\":\"Rwanda\"},{\"LanguageCode\":\"nl\",\"Text\":\"Rwanda\"},{\"LanguageCode\":\"fr\",\"Text\":\"Rwanda\"},{\"LanguageCode\":\"de\",\"Text\":\"Ruanda\"}]" },
                    { new Guid("0afec050-198a-4248-b736-e5bd611550a9"), "BEL", "[{\"LanguageCode\":\"en\",\"Text\":\"Belgium\"},{\"LanguageCode\":\"nl\",\"Text\":\"België\"},{\"LanguageCode\":\"fr\",\"Text\":\"Belgique\"},{\"LanguageCode\":\"de\",\"Text\":\"Belgien\"}]" },
                    { new Guid("0b4c2720-07b9-456e-bf80-39c77e9b7ee2"), "TCD", "[{\"LanguageCode\":\"en\",\"Text\":\"Chad\"},{\"LanguageCode\":\"nl\",\"Text\":\"Tsjaad\"},{\"LanguageCode\":\"fr\",\"Text\":\"Tchad\"},{\"LanguageCode\":\"de\",\"Text\":\"Tschad\"}]" },
                    { new Guid("0de606db-21c0-4bb1-bc40-fc2b1cc088a3"), "DJI", "[{\"LanguageCode\":\"en\",\"Text\":\"Djibouti\"},{\"LanguageCode\":\"nl\",\"Text\":\"Djibouti\"},{\"LanguageCode\":\"fr\",\"Text\":\"Djibouti\"},{\"LanguageCode\":\"de\",\"Text\":\"Dschibuti\"}]" },
                    { new Guid("10795cac-9d91-41c2-b5d0-658b02b07f95"), "SAU", "[{\"LanguageCode\":\"en\",\"Text\":\"Saudi Arabia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Saoedi-Arabië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Arabie saoudite\"},{\"LanguageCode\":\"de\",\"Text\":\"Saudi-Arabien\"}]" },
                    { new Guid("10b94735-2a5c-4994-9462-1c5227a5f84a"), "TWN", "[{\"LanguageCode\":\"en\",\"Text\":\"Taiwan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Taiwan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Taïwan\"},{\"LanguageCode\":\"de\",\"Text\":\"Taiwan\"}]" },
                    { new Guid("128d4b8b-cac9-4349-a8c9-a17ca4839d1b"), "ISR", "[{\"LanguageCode\":\"en\",\"Text\":\"Israel\"},{\"LanguageCode\":\"nl\",\"Text\":\"Israël\"},{\"LanguageCode\":\"fr\",\"Text\":\"Israël\"},{\"LanguageCode\":\"de\",\"Text\":\"Israel\"}]" },
                    { new Guid("1836bce0-c94b-40f3-81d7-21edc7e9a74e"), "GTM", "[{\"LanguageCode\":\"en\",\"Text\":\"Guatemala\"},{\"LanguageCode\":\"nl\",\"Text\":\"Guatemala\"},{\"LanguageCode\":\"fr\",\"Text\":\"Guatemala\"},{\"LanguageCode\":\"de\",\"Text\":\"Guatemala\"}]" },
                    { new Guid("189b5ec1-8edd-4d3f-9e94-9a37d9c7fa68"), "YEM", "[{\"LanguageCode\":\"en\",\"Text\":\"Yemen\"},{\"LanguageCode\":\"nl\",\"Text\":\"Jemen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Yémen\"},{\"LanguageCode\":\"de\",\"Text\":\"Jemen\"}]" },
                    { new Guid("1a6629f0-3df6-4f4d-9366-652d7babc3eb"), "LIE", "[{\"LanguageCode\":\"en\",\"Text\":\"Liechtenstein\"},{\"LanguageCode\":\"nl\",\"Text\":\"Liechtenstein\"},{\"LanguageCode\":\"fr\",\"Text\":\"Liechtenstein\"},{\"LanguageCode\":\"de\",\"Text\":\"Liechtenstein\"}]" },
                    { new Guid("1b977d51-4832-493d-b163-7d3188777cc8"), "UKR", "[{\"LanguageCode\":\"en\",\"Text\":\"Ukraine\"},{\"LanguageCode\":\"nl\",\"Text\":\"Oekraïne\"},{\"LanguageCode\":\"fr\",\"Text\":\"Ukraine\"},{\"LanguageCode\":\"de\",\"Text\":\"Ukraine\"}]" },
                    { new Guid("1df4a070-d82a-4fab-9c24-61ab6014ed75"), "COL", "[{\"LanguageCode\":\"en\",\"Text\":\"Colombia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Colombia\"},{\"LanguageCode\":\"fr\",\"Text\":\"Colombie\"},{\"LanguageCode\":\"de\",\"Text\":\"Kolumbien\"}]" },
                    { new Guid("1e368542-5666-4cda-a572-e177f2408d26"), "CAN", "[{\"LanguageCode\":\"en\",\"Text\":\"Canada\"},{\"LanguageCode\":\"nl\",\"Text\":\"Canada\"},{\"LanguageCode\":\"fr\",\"Text\":\"Canada\"},{\"LanguageCode\":\"de\",\"Text\":\"Kanada\"}]" },
                    { new Guid("1e6a616f-d9f5-4744-947b-8e37839ebfa2"), "BFA", "[{\"LanguageCode\":\"en\",\"Text\":\"Burkina Faso\"},{\"LanguageCode\":\"nl\",\"Text\":\"Burkina Faso\"},{\"LanguageCode\":\"fr\",\"Text\":\"Burkina Faso\"},{\"LanguageCode\":\"de\",\"Text\":\"Burkina Faso\"}]" },
                    { new Guid("21d61853-43c2-422f-993b-ef96fa75afea"), "DEU", "[{\"LanguageCode\":\"en\",\"Text\":\"Germany\"},{\"LanguageCode\":\"nl\",\"Text\":\"Duitsland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Allemagne\"},{\"LanguageCode\":\"de\",\"Text\":\"Deutschland\"}]" },
                    { new Guid("22fde9e8-1192-4c27-908f-f1a3732fedcf"), "MNG", "[{\"LanguageCode\":\"en\",\"Text\":\"Mongolia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Mongolië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Mongolie\"},{\"LanguageCode\":\"de\",\"Text\":\"Mongolei\"}]" },
                    { new Guid("2335932d-decc-46ae-a4e0-066e1b7756c3"), "CZE", "[{\"LanguageCode\":\"en\",\"Text\":\"Czech Republic\"},{\"LanguageCode\":\"nl\",\"Text\":\"Tsjechië\"},{\"LanguageCode\":\"fr\",\"Text\":\"République tchèque\"},{\"LanguageCode\":\"de\",\"Text\":\"Tschechien\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Code", "Names" },
                values: new object[,]
                {
                    { new Guid("238fd90f-b7a7-4134-a1fb-8a717f8f1bb9"), "SYR", "[{\"LanguageCode\":\"en\",\"Text\":\"Syria\"},{\"LanguageCode\":\"nl\",\"Text\":\"Syrië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Syrie\"},{\"LanguageCode\":\"de\",\"Text\":\"Syrien\"}]" },
                    { new Guid("26a0c02f-fd03-4066-a0bf-2ada5e3345bb"), "PLW", "[{\"LanguageCode\":\"en\",\"Text\":\"Palau\"},{\"LanguageCode\":\"nl\",\"Text\":\"Palau\"},{\"LanguageCode\":\"fr\",\"Text\":\"Palaos\"},{\"LanguageCode\":\"de\",\"Text\":\"Palau\"}]" },
                    { new Guid("27e1b987-a017-4519-bdf6-2652420f9b37"), "SWE", "[{\"LanguageCode\":\"en\",\"Text\":\"Sweden\"},{\"LanguageCode\":\"nl\",\"Text\":\"Zweden\"},{\"LanguageCode\":\"fr\",\"Text\":\"Suède\"},{\"LanguageCode\":\"de\",\"Text\":\"Schweden\"}]" },
                    { new Guid("27fa03e1-3386-4f68-8bf7-8360224d3c23"), "TUR", "[{\"LanguageCode\":\"en\",\"Text\":\"Turkey\"},{\"LanguageCode\":\"nl\",\"Text\":\"Turkije\"},{\"LanguageCode\":\"fr\",\"Text\":\"Turquie\"},{\"LanguageCode\":\"de\",\"Text\":\"Türkei\"}]" },
                    { new Guid("2ca4ab2c-cd60-475b-ad4f-131970200e2c"), "LBY", "[{\"LanguageCode\":\"en\",\"Text\":\"Libya\"},{\"LanguageCode\":\"nl\",\"Text\":\"Libië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Libye\"},{\"LanguageCode\":\"de\",\"Text\":\"Libyen\"}]" },
                    { new Guid("2eb24fab-b67a-405a-a4a4-a82b471203f2"), "KGZ", "[{\"LanguageCode\":\"en\",\"Text\":\"Kyrgyzstan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Kirgizië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Kirghizie\"},{\"LanguageCode\":\"de\",\"Text\":\"Kirgisistan\"}]" },
                    { new Guid("2f00e5f7-9825-4135-bb46-b819136e5555"), "SDN", "[{\"LanguageCode\":\"en\",\"Text\":\"Sudan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Soedan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Soudan\"},{\"LanguageCode\":\"de\",\"Text\":\"Sudan\"}]" },
                    { new Guid("2faa60f0-3823-4016-9b81-3ca8683223c4"), "NZL", "[{\"LanguageCode\":\"en\",\"Text\":\"New Zealand\"},{\"LanguageCode\":\"nl\",\"Text\":\"Nieuw-Zeeland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Nouvelle-Zélande\"},{\"LanguageCode\":\"de\",\"Text\":\"Neuseeland\"}]" },
                    { new Guid("2fb9d022-96d0-4c19-919f-3f368fdce39a"), "ROU", "[{\"LanguageCode\":\"en\",\"Text\":\"Romania\"},{\"LanguageCode\":\"nl\",\"Text\":\"Roemenië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Roumanie\"},{\"LanguageCode\":\"de\",\"Text\":\"Rumänien\"}]" },
                    { new Guid("3063a56e-3633-4fcb-b11a-41e138b7d91f"), "TUN", "[{\"LanguageCode\":\"en\",\"Text\":\"Tunisia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Tunesië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Tunisie\"},{\"LanguageCode\":\"de\",\"Text\":\"Tunesien\"}]" },
                    { new Guid("32cb7e58-c98b-4ab3-8923-6952d4326970"), "BDI", "[{\"LanguageCode\":\"en\",\"Text\":\"Burundi\"},{\"LanguageCode\":\"nl\",\"Text\":\"Burundi\"},{\"LanguageCode\":\"fr\",\"Text\":\"Burundi\"},{\"LanguageCode\":\"de\",\"Text\":\"Burundi\"}]" },
                    { new Guid("340b58e3-0e57-42ab-92ca-7a774902fbf3"), "BGR", "[{\"LanguageCode\":\"en\",\"Text\":\"Bulgaria\"},{\"LanguageCode\":\"nl\",\"Text\":\"Bulgarije\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bulgarie\"},{\"LanguageCode\":\"de\",\"Text\":\"Bulgarien\"}]" },
                    { new Guid("35c08100-ede7-4970-ba51-eb5b1168e71d"), "BRB", "[{\"LanguageCode\":\"en\",\"Text\":\"Barbados\"},{\"LanguageCode\":\"nl\",\"Text\":\"Barbados\"},{\"LanguageCode\":\"fr\",\"Text\":\"Barbade\"},{\"LanguageCode\":\"de\",\"Text\":\"Barbados\"}]" },
                    { new Guid("360e18bd-6832-4fb6-bd06-381a8cf17d36"), "BOL", "[{\"LanguageCode\":\"en\",\"Text\":\"Bolivia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Bolivia\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bolivie\"},{\"LanguageCode\":\"de\",\"Text\":\"Bolivien\"}]" },
                    { new Guid("37f0d470-847e-4f5b-9ebb-193288a58708"), "CPV", "[{\"LanguageCode\":\"en\",\"Text\":\"Cape Verde\"},{\"LanguageCode\":\"nl\",\"Text\":\"Kaapverdië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Cap-Vert\"},{\"LanguageCode\":\"de\",\"Text\":\"Kap Verde\"}]" },
                    { new Guid("382959c4-e338-431f-8347-23f442f9a499"), "NPL", "[{\"LanguageCode\":\"en\",\"Text\":\"Nepal\"},{\"LanguageCode\":\"nl\",\"Text\":\"Nepal\"},{\"LanguageCode\":\"fr\",\"Text\":\"Népal\"},{\"LanguageCode\":\"de\",\"Text\":\"Nepal\"}]" },
                    { new Guid("3aaa355a-22cb-4f64-a8bd-836e6c8f0768"), "TLS", "[{\"LanguageCode\":\"en\",\"Text\":\"East Timor\"},{\"LanguageCode\":\"nl\",\"Text\":\"Oost-Timor\"},{\"LanguageCode\":\"fr\",\"Text\":\"Timor oriental\"},{\"LanguageCode\":\"de\",\"Text\":\"Osttimor\"}]" },
                    { new Guid("3bc08968-5503-4b68-9342-81fcca0c6b63"), "VNM", "[{\"LanguageCode\":\"en\",\"Text\":\"Vietnam\"},{\"LanguageCode\":\"nl\",\"Text\":\"Vietnam\"},{\"LanguageCode\":\"fr\",\"Text\":\"Viêt Nam\"},{\"LanguageCode\":\"de\",\"Text\":\"Vietnam\"}]" },
                    { new Guid("3e5bae0b-6c7f-4b1f-a80b-4f77df42483c"), "LUX", "[{\"LanguageCode\":\"en\",\"Text\":\"Luxembourg\"},{\"LanguageCode\":\"nl\",\"Text\":\"Luxemburg\"},{\"LanguageCode\":\"fr\",\"Text\":\"Luxembourg\"},{\"LanguageCode\":\"de\",\"Text\":\"Luxemburg\"}]" },
                    { new Guid("3fce84d1-bcff-4c3a-afd5-a52e98a7d95f"), "GUY", "[{\"LanguageCode\":\"en\",\"Text\":\"Guyana\"},{\"LanguageCode\":\"nl\",\"Text\":\"Guyana\"},{\"LanguageCode\":\"fr\",\"Text\":\"Guyana\"},{\"LanguageCode\":\"de\",\"Text\":\"Guyana\"}]" },
                    { new Guid("4404a755-535c-4723-9c12-adb52dd267e1"), "VCT", "[{\"LanguageCode\":\"en\",\"Text\":\"Saint Vincent and the Grenadines\"},{\"LanguageCode\":\"nl\",\"Text\":\"Saint Vincent en de Grenadines\"},{\"LanguageCode\":\"fr\",\"Text\":\"Saint-Vincent-et-les Grenadines\"},{\"LanguageCode\":\"de\",\"Text\":\"St. Vincent und die Grenadinen\"}]" },
                    { new Guid("4409e415-5916-4401-bdd4-18f95552e757"), "HND", "[{\"LanguageCode\":\"en\",\"Text\":\"Honduras\"},{\"LanguageCode\":\"nl\",\"Text\":\"Honduras\"},{\"LanguageCode\":\"fr\",\"Text\":\"Honduras\"},{\"LanguageCode\":\"de\",\"Text\":\"Honduras\"}]" },
                    { new Guid("4440fc3c-eb2e-4423-8dd7-086f31a596cc"), "SVN", "[{\"LanguageCode\":\"en\",\"Text\":\"Slovenia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Slovenië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Slovénie\"},{\"LanguageCode\":\"de\",\"Text\":\"Slowenien\"}]" },
                    { new Guid("458e4b31-3f55-4def-9fea-8080acfc17ce"), "KAZ", "[{\"LanguageCode\":\"en\",\"Text\":\"Kazakhstan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Kazachstan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Kazakhstan\"},{\"LanguageCode\":\"de\",\"Text\":\"Kasachstan\"}]" },
                    { new Guid("45e5153a-9c30-4951-a724-1326e549e420"), "BWA", "[{\"LanguageCode\":\"en\",\"Text\":\"Botswana\"},{\"LanguageCode\":\"nl\",\"Text\":\"Botswana\"},{\"LanguageCode\":\"fr\",\"Text\":\"Botswana\"},{\"LanguageCode\":\"de\",\"Text\":\"Botswana\"}]" },
                    { new Guid("47101e8f-234e-4f58-9aa7-ccfad2f77a1f"), "GNB", "[{\"LanguageCode\":\"en\",\"Text\":\"Guinea-Bissau\"},{\"LanguageCode\":\"nl\",\"Text\":\"Guinee-Bissau\"},{\"LanguageCode\":\"fr\",\"Text\":\"Guinée-Bissau\"},{\"LanguageCode\":\"de\",\"Text\":\"Guinea-Bissau\"}]" },
                    { new Guid("4b6bd9f1-f806-4571-bcd7-73851542ca25"), "LAO", "[{\"LanguageCode\":\"en\",\"Text\":\"Laos\"},{\"LanguageCode\":\"nl\",\"Text\":\"Laos\"},{\"LanguageCode\":\"fr\",\"Text\":\"Laos\"},{\"LanguageCode\":\"de\",\"Text\":\"Laos\"}]" },
                    { new Guid("4b8dd925-23e9-4606-a687-0ca0e564a058"), "PNG", "[{\"LanguageCode\":\"en\",\"Text\":\"Papua New Guinea\"},{\"LanguageCode\":\"nl\",\"Text\":\"Papoea-Nieuw-Guinea\"},{\"LanguageCode\":\"fr\",\"Text\":\"Papouasie-Nouvelle-Guinée\"},{\"LanguageCode\":\"de\",\"Text\":\"Papua-Neuguinea\"}]" },
                    { new Guid("4ccc1c73-4e7e-48aa-9850-8ddcbf58a34b"), "MWI", "[{\"LanguageCode\":\"en\",\"Text\":\"Malawi\"},{\"LanguageCode\":\"nl\",\"Text\":\"Malawi\"},{\"LanguageCode\":\"fr\",\"Text\":\"Malawi\"},{\"LanguageCode\":\"de\",\"Text\":\"Malawi\"}]" },
                    { new Guid("4dfca244-8c66-40b0-82bc-7076542ad027"), "AND", "[{\"LanguageCode\":\"en\",\"Text\":\"Andorra\"},{\"LanguageCode\":\"nl\",\"Text\":\"Andorra\"},{\"LanguageCode\":\"fr\",\"Text\":\"Andorre\"},{\"LanguageCode\":\"de\",\"Text\":\"Andorra\"}]" },
                    { new Guid("50abe28e-6664-43b7-956c-f12be24b7811"), "BHR", "[{\"LanguageCode\":\"en\",\"Text\":\"Bahrain\"},{\"LanguageCode\":\"nl\",\"Text\":\"Bahrein\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bahreïn\"},{\"LanguageCode\":\"de\",\"Text\":\"Bahrain\"}]" },
                    { new Guid("512f874e-6379-4f77-878b-75ad565a10ce"), "MLT", "[{\"LanguageCode\":\"en\",\"Text\":\"Malta\"},{\"LanguageCode\":\"nl\",\"Text\":\"Malta\"},{\"LanguageCode\":\"fr\",\"Text\":\"Malte\"},{\"LanguageCode\":\"de\",\"Text\":\"Malta\"}]" },
                    { new Guid("525c2d6b-c2da-49e9-a351-69af276813a7"), "GIN", "[{\"LanguageCode\":\"en\",\"Text\":\"Guinea\"},{\"LanguageCode\":\"nl\",\"Text\":\"Guinee\"},{\"LanguageCode\":\"fr\",\"Text\":\"Guinée\"},{\"LanguageCode\":\"de\",\"Text\":\"Guinea\"}]" },
                    { new Guid("53724950-d2f6-401f-b40b-72e0df1f6552"), "SWZ", "[{\"LanguageCode\":\"en\",\"Text\":\"Swaziland\"},{\"LanguageCode\":\"nl\",\"Text\":\"Swaziland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Swaziland\"},{\"LanguageCode\":\"de\",\"Text\":\"Swasiland\"}]" },
                    { new Guid("5372fdaa-99ea-40a6-9ff2-fba37e6c55ea"), "CHL", "[{\"LanguageCode\":\"en\",\"Text\":\"Chile\"},{\"LanguageCode\":\"nl\",\"Text\":\"Chili\"},{\"LanguageCode\":\"fr\",\"Text\":\"Chili\"},{\"LanguageCode\":\"de\",\"Text\":\"Chile\"}]" },
                    { new Guid("54985a37-0ef9-46db-8e70-cfc4325e2ecf"), "PAK", "[{\"LanguageCode\":\"en\",\"Text\":\"Pakistan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Pakistan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pakistan\"},{\"LanguageCode\":\"de\",\"Text\":\"Pakistan\"}]" },
                    { new Guid("55fec7e8-93b9-4f79-8c61-342f6ca28855"), "FIN", "[{\"LanguageCode\":\"en\",\"Text\":\"Finland\"},{\"LanguageCode\":\"nl\",\"Text\":\"Finland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Finlande\"},{\"LanguageCode\":\"de\",\"Text\":\"Finnland\"}]" },
                    { new Guid("589f9ee4-3750-4370-a27c-6508670848c8"), "CMR", "[{\"LanguageCode\":\"en\",\"Text\":\"Cameroon\"},{\"LanguageCode\":\"nl\",\"Text\":\"Kameroen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Cameroun\"},{\"LanguageCode\":\"de\",\"Text\":\"Kamerun\"}]" },
                    { new Guid("5d47bf68-8a66-4456-99b3-e93268e7278b"), "GRC", "[{\"LanguageCode\":\"en\",\"Text\":\"Greece\"},{\"LanguageCode\":\"nl\",\"Text\":\"Griekenland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Grèce\"},{\"LanguageCode\":\"de\",\"Text\":\"Griechenland\"}]" },
                    { new Guid("5ffa6c6e-8835-4237-824b-96deea84cc4c"), "COD", "[{\"LanguageCode\":\"en\",\"Text\":\"Democratic Republic of the Congo\"},{\"LanguageCode\":\"nl\",\"Text\":\"Democratische Republiek Congo\"},{\"LanguageCode\":\"fr\",\"Text\":\"République démocratique du Congo\"},{\"LanguageCode\":\"de\",\"Text\":\"Demokratische Republik Kongo\"}]" },
                    { new Guid("61060a1e-8565-417a-beea-2212562384ef"), "MLI", "[{\"LanguageCode\":\"en\",\"Text\":\"Mali\"},{\"LanguageCode\":\"nl\",\"Text\":\"Mali\"},{\"LanguageCode\":\"fr\",\"Text\":\"Mali\"},{\"LanguageCode\":\"de\",\"Text\":\"Mali\"}]" },
                    { new Guid("636a4461-f0f8-4538-9c9f-5f8fb826d9f3"), "ITA", "[{\"LanguageCode\":\"en\",\"Text\":\"Italy\"},{\"LanguageCode\":\"nl\",\"Text\":\"Italië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Italie\"},{\"LanguageCode\":\"de\",\"Text\":\"Italien\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Code", "Names" },
                values: new object[,]
                {
                    { new Guid("6465214d-59d3-43b8-a4be-551c97580858"), "AFG", "[{\"LanguageCode\":\"en\",\"Text\":\"Afghanistan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Afghanistan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Afghanistan\"},{\"LanguageCode\":\"de\",\"Text\":\"Afghanistan\"}]" },
                    { new Guid("66fe58a6-a1ec-43db-84fe-1e88fddbe01f"), "COG", "[{\"LanguageCode\":\"en\",\"Text\":\"Republic of Congo\"},{\"LanguageCode\":\"nl\",\"Text\":\"Republiek Congo\"},{\"LanguageCode\":\"fr\",\"Text\":\"Congo\"},{\"LanguageCode\":\"de\",\"Text\":\"Republik Kongo\"}]" },
                    { new Guid("692bff96-9a0a-4ebb-bf3c-4700cbb43472"), "MOZ", "[{\"LanguageCode\":\"en\",\"Text\":\"Mozambique\"},{\"LanguageCode\":\"nl\",\"Text\":\"Mozambique\"},{\"LanguageCode\":\"fr\",\"Text\":\"Mozambique\"},{\"LanguageCode\":\"de\",\"Text\":\"Mosambik\"}]" },
                    { new Guid("69369bee-72ff-45c3-9d93-aaf728ccd7b4"), "OMN", "[{\"LanguageCode\":\"en\",\"Text\":\"Oman\"},{\"LanguageCode\":\"nl\",\"Text\":\"Oman\"},{\"LanguageCode\":\"fr\",\"Text\":\"Oman\"},{\"LanguageCode\":\"de\",\"Text\":\"Oman\"}]" },
                    { new Guid("698fd329-ebba-408f-95c0-6b2ebf18bb76"), "MDV", "[{\"LanguageCode\":\"en\",\"Text\":\"Maldives\"},{\"LanguageCode\":\"nl\",\"Text\":\"Maldiven\"},{\"LanguageCode\":\"fr\",\"Text\":\"Maldives\"},{\"LanguageCode\":\"de\",\"Text\":\"Malediven\"}]" },
                    { new Guid("69ce0187-9aad-4904-b2e1-ac999485b4c8"), "BHS", "[{\"LanguageCode\":\"en\",\"Text\":\"Bahamas\"},{\"LanguageCode\":\"nl\",\"Text\":\"Bahama's\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bahamas\"},{\"LanguageCode\":\"de\",\"Text\":\"Bahamas\"}]" },
                    { new Guid("69e8f68b-4845-4cc3-a710-12887fd7e8de"), "RUS", "[{\"LanguageCode\":\"en\",\"Text\":\"Russia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Rusland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Russie\"},{\"LanguageCode\":\"de\",\"Text\":\"Russland\"}]" },
                    { new Guid("6a4bbb0a-f7ae-4c29-8dc8-3ac049e2df4e"), "TJK", "[{\"LanguageCode\":\"en\",\"Text\":\"Tajikistan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Tadzjikistan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Tadjikistan\"},{\"LanguageCode\":\"de\",\"Text\":\"Tadschikistan\"}]" },
                    { new Guid("6a779a8b-003f-4a05-9876-6d7f2c3ba060"), "BEN", "[{\"LanguageCode\":\"en\",\"Text\":\"Benin\"},{\"LanguageCode\":\"nl\",\"Text\":\"Benin\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bénin\"},{\"LanguageCode\":\"de\",\"Text\":\"Benin\"}]" },
                    { new Guid("6b2325c8-9f2b-40c7-a1bd-9d022e51522b"), "AUS", "[{\"LanguageCode\":\"en\",\"Text\":\"Australia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Australië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Australie\"},{\"LanguageCode\":\"de\",\"Text\":\"Australien\"}]" },
                    { new Guid("6c8032d8-384f-44b2-a2a2-864003ceadba"), "CRI", "[{\"LanguageCode\":\"en\",\"Text\":\"Costa Rica\"},{\"LanguageCode\":\"nl\",\"Text\":\"Costa Rica\"},{\"LanguageCode\":\"fr\",\"Text\":\"Costa Rica\"},{\"LanguageCode\":\"de\",\"Text\":\"Costa Rica\"}]" },
                    { new Guid("71439aa6-1a20-4373-b368-c44dd833fedb"), "URY", "[{\"LanguageCode\":\"en\",\"Text\":\"Uruguay\"},{\"LanguageCode\":\"nl\",\"Text\":\"Uruguay\"},{\"LanguageCode\":\"fr\",\"Text\":\"Uruguay\"},{\"LanguageCode\":\"de\",\"Text\":\"Uruguay\"}]" },
                    { new Guid("71fba808-d9b6-4ab2-a2e4-5411bac561e6"), "IDN", "[{\"LanguageCode\":\"en\",\"Text\":\"Indonesia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Indonesië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Indonésie\"},{\"LanguageCode\":\"de\",\"Text\":\"Indonesien\"}]" },
                    { new Guid("72470cdc-b05b-4d01-a835-7259ef29a9fa"), "SOM", "[{\"LanguageCode\":\"en\",\"Text\":\"Somalia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Somalië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Somalie\"},{\"LanguageCode\":\"de\",\"Text\":\"Somalia\"}]" },
                    { new Guid("728a9808-27f0-4d1c-b933-f5ff10a3f5d5"), "MNE", "[{\"LanguageCode\":\"en\",\"Text\":\"Montenegro\"},{\"LanguageCode\":\"nl\",\"Text\":\"Montenegro\"},{\"LanguageCode\":\"fr\",\"Text\":\"Monténégro\"},{\"LanguageCode\":\"de\",\"Text\":\"Montenegro\"}]" },
                    { new Guid("72dc83bc-6f5c-4adc-a226-03caa8a3cb33"), "TKM", "[{\"LanguageCode\":\"en\",\"Text\":\"Turkmenistan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Turkmenistan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Turkménistan\"},{\"LanguageCode\":\"de\",\"Text\":\"Turkmenistan\"}]" },
                    { new Guid("754c4dc7-779e-457c-a5ea-eb44156431ad"), "SSD", "[{\"LanguageCode\":\"en\",\"Text\":\"South Sudan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Zuid-Soedan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Soudan du Sud\"},{\"LanguageCode\":\"de\",\"Text\":\"Südsudan\"}]" },
                    { new Guid("7b2893f9-3a38-4b4b-a1af-24c3351ad5ae"), "MYS", "[{\"LanguageCode\":\"en\",\"Text\":\"Malaysia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Maleisië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Malaisie\"},{\"LanguageCode\":\"de\",\"Text\":\"Malaysia\"}]" },
                    { new Guid("7b6191c2-dc99-4a28-b7c2-6646ab4db166"), "WSM", "[{\"LanguageCode\":\"en\",\"Text\":\"Samoa\"},{\"LanguageCode\":\"nl\",\"Text\":\"Samoa\"},{\"LanguageCode\":\"fr\",\"Text\":\"Samoa\"},{\"LanguageCode\":\"de\",\"Text\":\"Samoa\"}]" },
                    { new Guid("7c6cf509-7148-4ab2-9aa6-afc1061adf49"), "POL", "[{\"LanguageCode\":\"en\",\"Text\":\"Poland\"},{\"LanguageCode\":\"nl\",\"Text\":\"Polen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pologne\"},{\"LanguageCode\":\"de\",\"Text\":\"Polen\"}]" },
                    { new Guid("7cad010a-2901-4172-b532-6babdec346be"), "TON", "[{\"LanguageCode\":\"en\",\"Text\":\"Tonga\"},{\"LanguageCode\":\"nl\",\"Text\":\"Tonga\"},{\"LanguageCode\":\"fr\",\"Text\":\"Tonga\"},{\"LanguageCode\":\"de\",\"Text\":\"Tonga\"}]" },
                    { new Guid("7cb33a38-e968-4a9d-a0f2-37f89c8b6d6a"), "ARM", "[{\"LanguageCode\":\"en\",\"Text\":\"Armenia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Armenië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Arménie\"},{\"LanguageCode\":\"de\",\"Text\":\"Armenien\"}]" },
                    { new Guid("7d0f5947-fd33-46f4-b57e-4a1a910c0b77"), "ATG", "[{\"LanguageCode\":\"en\",\"Text\":\"Antigua and Barbuda\"},{\"LanguageCode\":\"nl\",\"Text\":\"Antigua en Barbuda\"},{\"LanguageCode\":\"fr\",\"Text\":\"Antigua-et-Barbuda\"},{\"LanguageCode\":\"de\",\"Text\":\"Antigua und Barbuda\"}]" },
                    { new Guid("7d4fd8ee-ba53-430d-b79d-14a6c0cac865"), "GEO", "[{\"LanguageCode\":\"en\",\"Text\":\"Georgia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Georgië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Géorgie\"},{\"LanguageCode\":\"de\",\"Text\":\"Georgien\"}]" },
                    { new Guid("812664ae-daba-492f-a571-9694f4ff46f8"), "LSO", "[{\"LanguageCode\":\"en\",\"Text\":\"Lesotho\"},{\"LanguageCode\":\"nl\",\"Text\":\"Lesotho\"},{\"LanguageCode\":\"fr\",\"Text\":\"Lesotho\"},{\"LanguageCode\":\"de\",\"Text\":\"Lesotho\"}]" },
                    { new Guid("81ed0a51-bc59-49dd-850c-4d85e0e74945"), "PSE", "[{\"LanguageCode\":\"en\",\"Text\":\"Palestine\"},{\"LanguageCode\":\"nl\",\"Text\":\"Palestina\"},{\"LanguageCode\":\"fr\",\"Text\":\"État de Palestine\"},{\"LanguageCode\":\"de\",\"Text\":\"Palästina\"}]" },
                    { new Guid("820f90bc-2670-43e6-b4bc-dc543a9b6dda"), "BIH", "[{\"LanguageCode\":\"en\",\"Text\":\"Bosnia and Herzegovina\"},{\"LanguageCode\":\"nl\",\"Text\":\"Bosnië en Herzegovina\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bosnie-Herzégovine\"},{\"LanguageCode\":\"de\",\"Text\":\"Bosnien und Herzegowina\"}]" },
                    { new Guid("84305281-52dc-4a09-b9be-318920adab26"), "DNK", "[{\"LanguageCode\":\"en\",\"Text\":\"Denmark\"},{\"LanguageCode\":\"nl\",\"Text\":\"Denemarken\"},{\"LanguageCode\":\"fr\",\"Text\":\"Danemark\"},{\"LanguageCode\":\"de\",\"Text\":\"Dänemark\"}]" },
                    { new Guid("867d3cbc-c8e9-45e1-9b64-60968bf9c828"), "DMA", "[{\"LanguageCode\":\"en\",\"Text\":\"Dominica\"},{\"LanguageCode\":\"nl\",\"Text\":\"Dominica\"},{\"LanguageCode\":\"fr\",\"Text\":\"Dominique\"},{\"LanguageCode\":\"de\",\"Text\":\"Dominica\"}]" },
                    { new Guid("874b4262-cd0b-4498-aad7-58987a270ad7"), "MRT", "[{\"LanguageCode\":\"en\",\"Text\":\"Mauritania\"},{\"LanguageCode\":\"nl\",\"Text\":\"Mauritanië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Mauritanie\"},{\"LanguageCode\":\"de\",\"Text\":\"Mauretanien\"}]" },
                    { new Guid("87e22dd2-fac7-43bb-97ed-7f6aba95cebe"), "BLZ", "[{\"LanguageCode\":\"en\",\"Text\":\"Belize\"},{\"LanguageCode\":\"nl\",\"Text\":\"Belize\"},{\"LanguageCode\":\"fr\",\"Text\":\"Belize\"},{\"LanguageCode\":\"de\",\"Text\":\"Belize\"}]" },
                    { new Guid("8a45ceef-61a3-4973-8053-b27ffbd14a10"), "KEN", "[{\"LanguageCode\":\"en\",\"Text\":\"Kenya\"},{\"LanguageCode\":\"nl\",\"Text\":\"Kenia\"},{\"LanguageCode\":\"fr\",\"Text\":\"Kenya\"},{\"LanguageCode\":\"de\",\"Text\":\"Kenia\"}]" },
                    { new Guid("8bfe495d-bb0e-4819-b792-1372913f825b"), "BRN", "[{\"LanguageCode\":\"en\",\"Text\":\"Brunei\"},{\"LanguageCode\":\"nl\",\"Text\":\"Brunei\"},{\"LanguageCode\":\"fr\",\"Text\":\"Brunei\"},{\"LanguageCode\":\"de\",\"Text\":\"Brunei\"}]" },
                    { new Guid("8efe5473-19a5-4109-b2d3-91c02a975209"), "STP", "[{\"LanguageCode\":\"en\",\"Text\":\"Sao Tome and Principe\"},{\"LanguageCode\":\"nl\",\"Text\":\"Sao Tomé en Principe\"},{\"LanguageCode\":\"fr\",\"Text\":\"Sao Tomé-et-Principe\"},{\"LanguageCode\":\"de\",\"Text\":\"São Tomé und Príncipe\"}]" },
                    { new Guid("926044f4-29e3-49dd-8755-3523ec024a06"), "MMR", "[{\"LanguageCode\":\"en\",\"Text\":\"Myanmar\"},{\"LanguageCode\":\"nl\",\"Text\":\"Myanmar\"},{\"LanguageCode\":\"fr\",\"Text\":\"Myanmar\"},{\"LanguageCode\":\"de\",\"Text\":\"Myanmar\"}]" },
                    { new Guid("970aaf9b-7a90-4021-b942-f1b73c1812f8"), "LBR", "[{\"LanguageCode\":\"en\",\"Text\":\"Liberia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Liberia\"},{\"LanguageCode\":\"fr\",\"Text\":\"Liberia\"},{\"LanguageCode\":\"de\",\"Text\":\"Liberia\"}]" },
                    { new Guid("9750618f-9644-4b3b-9235-ae27b86dd82d"), "KOR", "[{\"LanguageCode\":\"en\",\"Text\":\"South Korea\"},{\"LanguageCode\":\"nl\",\"Text\":\"Zuid-Korea\"},{\"LanguageCode\":\"fr\",\"Text\":\"Corée du Sud\"},{\"LanguageCode\":\"de\",\"Text\":\"Süd Korea\"}]" },
                    { new Guid("98c804b8-442a-4c47-a1d8-53cc23ad1b26"), "LCA", "[{\"LanguageCode\":\"en\",\"Text\":\"Saint Lucia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Saint Lucia\"},{\"LanguageCode\":\"fr\",\"Text\":\"Sainte-Lucie\"},{\"LanguageCode\":\"de\",\"Text\":\"St. Lucia\"}]" },
                    { new Guid("98f990e4-d4d6-4f6c-9684-b3bd9b8d3771"), "MUS", "[{\"LanguageCode\":\"en\",\"Text\":\"Mauritius\"},{\"LanguageCode\":\"nl\",\"Text\":\"Mauritius\"},{\"LanguageCode\":\"fr\",\"Text\":\"Maurice\"},{\"LanguageCode\":\"de\",\"Text\":\"Mauritius\"}]" },
                    { new Guid("9bc93d03-6c4e-4b76-9ca2-1ed7a6b5c743"), "SMR", "[{\"LanguageCode\":\"en\",\"Text\":\"San Marino\"},{\"LanguageCode\":\"nl\",\"Text\":\"San Marino\"},{\"LanguageCode\":\"fr\",\"Text\":\"Saint-Marin\"},{\"LanguageCode\":\"de\",\"Text\":\"San Marino\"}]" },
                    { new Guid("9c678bd9-8cb8-48d4-bf3c-094b5f20d718"), "FSM", "[{\"LanguageCode\":\"en\",\"Text\":\"Micronesia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Micronesia\"},{\"LanguageCode\":\"fr\",\"Text\":\"Micronésie\"},{\"LanguageCode\":\"de\",\"Text\":\"Mikronesien\"}]" },
                    { new Guid("9c870b2c-fce6-401d-abbf-385f07efc55d"), "NRU", "[{\"LanguageCode\":\"en\",\"Text\":\"Nauru\"},{\"LanguageCode\":\"nl\",\"Text\":\"Nauru\"},{\"LanguageCode\":\"fr\",\"Text\":\"Nauru\"},{\"LanguageCode\":\"de\",\"Text\":\"Nauru\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Code", "Names" },
                values: new object[,]
                {
                    { new Guid("9cbe6d4f-ef9e-4ca0-a18c-cdbdda840267"), "SEN", "[{\"LanguageCode\":\"en\",\"Text\":\"Senegal\"},{\"LanguageCode\":\"nl\",\"Text\":\"Senegal\"},{\"LanguageCode\":\"fr\",\"Text\":\"Sénégal\"},{\"LanguageCode\":\"de\",\"Text\":\"Senegal\"}]" },
                    { new Guid("9d23bb42-ee31-409b-90c2-0a5ab88485f4"), "PER", "[{\"LanguageCode\":\"en\",\"Text\":\"Peru\"},{\"LanguageCode\":\"nl\",\"Text\":\"Peru\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pérou\"},{\"LanguageCode\":\"de\",\"Text\":\"Peru\"}]" },
                    { new Guid("9d7f4e5c-90b2-42ca-973e-5360021ce1cd"), "UNK", "[{\"LanguageCode\":\"en\",\"Text\":\"Kosovo\"},{\"LanguageCode\":\"nl\",\"Text\":\"Kosovo\"},{\"LanguageCode\":\"fr\",\"Text\":\"Kosovo\"},{\"LanguageCode\":\"de\",\"Text\":\"Kosovo\"}]" },
                    { new Guid("9dfdaac8-f10c-4e5d-ab83-5a972338e8d6"), "NAM", "[{\"LanguageCode\":\"en\",\"Text\":\"Namibia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Namibië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Namibie\"},{\"LanguageCode\":\"de\",\"Text\":\"Namibia\"}]" },
                    { new Guid("a06867e9-6999-4664-ad17-c72a436264dc"), "NOR", "[{\"LanguageCode\":\"en\",\"Text\":\"Norway\"},{\"LanguageCode\":\"nl\",\"Text\":\"Noorwegen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Norvège\"},{\"LanguageCode\":\"de\",\"Text\":\"Norwegen\"}]" },
                    { new Guid("a09e426c-3fd3-4295-aac7-f02376b55427"), "VAT", "[{\"LanguageCode\":\"en\",\"Text\":\"Vatican City\"},{\"LanguageCode\":\"nl\",\"Text\":\"Vaticaanstad\"},{\"LanguageCode\":\"fr\",\"Text\":\"Vatican\"},{\"LanguageCode\":\"de\",\"Text\":\"Vatikanstadt\"}]" },
                    { new Guid("a31edeba-bf50-4bb5-888c-accf7c1d7abe"), "IRN", "[{\"LanguageCode\":\"en\",\"Text\":\"Iran\"},{\"LanguageCode\":\"nl\",\"Text\":\"Iran\"},{\"LanguageCode\":\"fr\",\"Text\":\"Iran\"},{\"LanguageCode\":\"de\",\"Text\":\"Iran\"}]" },
                    { new Guid("a54bab81-9678-4992-ad04-aa18c87120c7"), "DZA", "[{\"LanguageCode\":\"en\",\"Text\":\"Algeria\"},{\"LanguageCode\":\"nl\",\"Text\":\"Algerije\"},{\"LanguageCode\":\"fr\",\"Text\":\"Algérie\"},{\"LanguageCode\":\"de\",\"Text\":\"Algerien\"}]" },
                    { new Guid("a5c3d0a4-ef39-4b78-a5d3-061679991010"), "NER", "[{\"LanguageCode\":\"en\",\"Text\":\"Niger\"},{\"LanguageCode\":\"nl\",\"Text\":\"Niger\"},{\"LanguageCode\":\"fr\",\"Text\":\"Niger\"},{\"LanguageCode\":\"de\",\"Text\":\"Niger\"}]" },
                    { new Guid("a6461b00-6f3f-45f6-90f6-765b898eeee6"), "GNQ", "[{\"LanguageCode\":\"en\",\"Text\":\"Equatorial Guinea\"},{\"LanguageCode\":\"nl\",\"Text\":\"Equatoriaal-Guinea\"},{\"LanguageCode\":\"fr\",\"Text\":\"Guinée équatoriale\"},{\"LanguageCode\":\"de\",\"Text\":\"Äquatorialguinea\"}]" },
                    { new Guid("a66c6b3c-d42b-4222-a80b-241111d41c91"), "MEX", "[{\"LanguageCode\":\"en\",\"Text\":\"Mexico\"},{\"LanguageCode\":\"nl\",\"Text\":\"Mexico[\"},{\"LanguageCode\":\"fr\",\"Text\":\"Mexique\"},{\"LanguageCode\":\"de\",\"Text\":\"Mexiko\"}]" },
                    { new Guid("a6978482-b773-45ab-9460-b46ce81a4808"), "PAN", "[{\"LanguageCode\":\"en\",\"Text\":\"Panama\"},{\"LanguageCode\":\"nl\",\"Text\":\"Panama\"},{\"LanguageCode\":\"fr\",\"Text\":\"Panama\"},{\"LanguageCode\":\"de\",\"Text\":\"Panama\"}]" },
                    { new Guid("a89db47f-c03d-4766-866a-f1a7507bc38f"), "KNA", "[{\"LanguageCode\":\"en\",\"Text\":\"Saint Kitts and Nevis\"},{\"LanguageCode\":\"nl\",\"Text\":\"Saint Kitts en Nevis\"},{\"LanguageCode\":\"fr\",\"Text\":\"Saint-Christophe-et-Niévès\"},{\"LanguageCode\":\"de\",\"Text\":\"St. Kitts und Nevis\"}]" },
                    { new Guid("a9df6d05-7a19-4a1e-980b-081247ffaabe"), "UZB", "[{\"LanguageCode\":\"en\",\"Text\":\"Uzbekistan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Oezbekistan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Ouzbékistan\"},{\"LanguageCode\":\"de\",\"Text\":\"Usbekistan\"}]" },
                    { new Guid("aafb8c3d-c285-4b1f-9969-c005ea01b43a"), "MDG", "[{\"LanguageCode\":\"en\",\"Text\":\"Madagascar\"},{\"LanguageCode\":\"nl\",\"Text\":\"Madagaskar\"},{\"LanguageCode\":\"fr\",\"Text\":\"Madagascar\"},{\"LanguageCode\":\"de\",\"Text\":\"Madagaskar\"}]" },
                    { new Guid("ab096653-13ee-402d-9dc2-3563c775105e"), "MDA", "[{\"LanguageCode\":\"en\",\"Text\":\"Moldova\"},{\"LanguageCode\":\"nl\",\"Text\":\"Moldavië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Moldavie\"},{\"LanguageCode\":\"de\",\"Text\":\"Moldawien\"}]" },
                    { new Guid("ab9803dc-81c9-4f40-ab6d-88afa03ca3ad"), "GAB", "[{\"LanguageCode\":\"en\",\"Text\":\"Gabon\"},{\"LanguageCode\":\"nl\",\"Text\":\"Gabon\"},{\"LanguageCode\":\"fr\",\"Text\":\"Gabon\"},{\"LanguageCode\":\"de\",\"Text\":\"Gabun\"}]" },
                    { new Guid("ac1fc25d-ba93-4ffc-8f90-80f3acf39fe1"), "NIC", "[{\"LanguageCode\":\"en\",\"Text\":\"Nicaragua\"},{\"LanguageCode\":\"nl\",\"Text\":\"Nicaragua\"},{\"LanguageCode\":\"fr\",\"Text\":\"Nicaragua\"},{\"LanguageCode\":\"de\",\"Text\":\"Nicaragua\"}]" },
                    { new Guid("ade8e58e-f037-48aa-8fae-5bedcb6ad0d8"), "NLD", "[{\"LanguageCode\":\"en\",\"Text\":\"Netherlands\"},{\"LanguageCode\":\"nl\",\"Text\":\"Nederland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pays-Bas\"},{\"LanguageCode\":\"de\",\"Text\":\"Niederlande\"}]" },
                    { new Guid("ae568287-2dae-4c3c-bada-fd10064397c6"), "HTI", "[{\"LanguageCode\":\"en\",\"Text\":\"Haiti\"},{\"LanguageCode\":\"nl\",\"Text\":\"Haïti\"},{\"LanguageCode\":\"fr\",\"Text\":\"Haïti\"},{\"LanguageCode\":\"de\",\"Text\":\"Haiti\"}]" },
                    { new Guid("aefcace9-48d4-41a3-be3b-2047a9a50797"), "SGP", "[{\"LanguageCode\":\"en\",\"Text\":\"Singapore\"},{\"LanguageCode\":\"nl\",\"Text\":\"Singapore\"},{\"LanguageCode\":\"fr\",\"Text\":\"Singapour\"},{\"LanguageCode\":\"de\",\"Text\":\"Singapur\"}]" },
                    { new Guid("b1cb9a3a-6a81-4979-8c28-4e5715dd562f"), "THA", "[{\"LanguageCode\":\"en\",\"Text\":\"Thailand\"},{\"LanguageCode\":\"nl\",\"Text\":\"Thailand\"},{\"LanguageCode\":\"fr\",\"Text\":\"Thaïlande\"},{\"LanguageCode\":\"de\",\"Text\":\"Thailand\"}]" },
                    { new Guid("b272a659-8ead-4951-98e2-06f3225f182e"), "HUN", "[{\"LanguageCode\":\"en\",\"Text\":\"Hungary\"},{\"LanguageCode\":\"nl\",\"Text\":\"Hongarije\"},{\"LanguageCode\":\"fr\",\"Text\":\"Hongrie\"},{\"LanguageCode\":\"de\",\"Text\":\"Ungarn\"}]" },
                    { new Guid("b2d673e9-8749-4e2c-8f41-f723d93b0d71"), "COK", "[{\"LanguageCode\":\"en\",\"Text\":\"Cook Islands\"},{\"LanguageCode\":\"nl\",\"Text\":\"Cookeilanden\"},{\"LanguageCode\":\"fr\",\"Text\":\"Îles Cook\"},{\"LanguageCode\":\"de\",\"Text\":\"Cookinseln\"}]" },
                    { new Guid("b338193d-ab3f-48dc-825f-4a69d8af8b3b"), "SYC", "[{\"LanguageCode\":\"en\",\"Text\":\"Seychelles\"},{\"LanguageCode\":\"nl\",\"Text\":\"Seychellen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Seychelles\"},{\"LanguageCode\":\"de\",\"Text\":\"Seychellen\"}]" },
                    { new Guid("b5ca2166-5cfd-4449-bcb8-1112fe2a850c"), "AUT", "[{\"LanguageCode\":\"en\",\"Text\":\"Austria\"},{\"LanguageCode\":\"nl\",\"Text\":\"Oostenrijk\"},{\"LanguageCode\":\"fr\",\"Text\":\"Autriche\"},{\"LanguageCode\":\"de\",\"Text\":\"Österreich\"}]" },
                    { new Guid("b62995e3-1ec7-4655-a3a8-e865181b3f2c"), "NIU", "[{\"LanguageCode\":\"en\",\"Text\":\"Niue\"},{\"LanguageCode\":\"nl\",\"Text\":\"Niue\"},{\"LanguageCode\":\"fr\",\"Text\":\"Niue\"},{\"LanguageCode\":\"de\",\"Text\":\"Niue\"}]" },
                    { new Guid("b6d3aef8-defe-4dd1-9b19-fbf68e7bde01"), "MHL", "[{\"LanguageCode\":\"en\",\"Text\":\"Marshall Islands\"},{\"LanguageCode\":\"nl\",\"Text\":\"Marshalleilanden\"},{\"LanguageCode\":\"fr\",\"Text\":\"Îles Marshall\"},{\"LanguageCode\":\"de\",\"Text\":\"Marshallinseln\"}]" },
                    { new Guid("b87b82ab-72a4-4d3f-8b36-2869096187f7"), "CAF", "[{\"LanguageCode\":\"en\",\"Text\":\"Central African Republic\"},{\"LanguageCode\":\"nl\",\"Text\":\"Centraal-Afrikaanse Republiek\"},{\"LanguageCode\":\"fr\",\"Text\":\"République centrafricaine\"},{\"LanguageCode\":\"de\",\"Text\":\"Zentral­afrikanische Republik\"}]" },
                    { new Guid("b882edc8-3799-4592-a4db-0c785a8ec9f6"), "LKA", "[{\"LanguageCode\":\"en\",\"Text\":\"Sri Lanka\"},{\"LanguageCode\":\"nl\",\"Text\":\"Sri Lanka\"},{\"LanguageCode\":\"fr\",\"Text\":\"Sri Lanka\"},{\"LanguageCode\":\"de\",\"Text\":\"Sri Lanka\"}]" },
                    { new Guid("b97fed10-bcbc-4653-8d2a-76e8c85b826a"), "PRT", "[{\"LanguageCode\":\"en\",\"Text\":\"Portugal\"},{\"LanguageCode\":\"nl\",\"Text\":\"Portugal\"},{\"LanguageCode\":\"fr\",\"Text\":\"Portugal\"},{\"LanguageCode\":\"de\",\"Text\":\"Portugal\"}]" },
                    { new Guid("b981d442-5509-43a2-b3a1-affa64972664"), "ECU", "[{\"LanguageCode\":\"en\",\"Text\":\"Ecuador\"},{\"LanguageCode\":\"nl\",\"Text\":\"Ecuador\"},{\"LanguageCode\":\"fr\",\"Text\":\"Équateur\"},{\"LanguageCode\":\"de\",\"Text\":\"Ecuador\"}]" },
                    { new Guid("bb33a24b-0498-4e86-b5bf-a0a73b066d42"), "LBN", "[{\"LanguageCode\":\"en\",\"Text\":\"Lebanon\"},{\"LanguageCode\":\"nl\",\"Text\":\"Libanon\"},{\"LanguageCode\":\"fr\",\"Text\":\"Liban\"},{\"LanguageCode\":\"de\",\"Text\":\"Libanon\"}]" },
                    { new Guid("bc4a3e7f-1c47-47f1-b881-0d671564fd4c"), "BGD", "[{\"LanguageCode\":\"en\",\"Text\":\"Bangladesh\"},{\"LanguageCode\":\"nl\",\"Text\":\"Bangladesh\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bangladesh\"},{\"LanguageCode\":\"de\",\"Text\":\"Bangladesch\"}]" },
                    { new Guid("bdf9e765-e93b-4308-ad06-3238bc009833"), "TGO", "[{\"LanguageCode\":\"en\",\"Text\":\"Togo\"},{\"LanguageCode\":\"nl\",\"Text\":\"Togo\"},{\"LanguageCode\":\"fr\",\"Text\":\"Togo\"},{\"LanguageCode\":\"de\",\"Text\":\"Togo\"}]" },
                    { new Guid("bf1f1a38-1904-4b87-ab5c-4888dd2e24f1"), "JOR", "[{\"LanguageCode\":\"en\",\"Text\":\"Jordan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Jordanië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Jordanie\"},{\"LanguageCode\":\"de\",\"Text\":\"Jordanien\"}]" },
                    { new Guid("bf29f7ca-0da0-4b9a-9423-a78e26b0bcef"), "SLV", "[{\"LanguageCode\":\"en\",\"Text\":\"El Salvador\"},{\"LanguageCode\":\"nl\",\"Text\":\"El Salvador\"},{\"LanguageCode\":\"fr\",\"Text\":\"El Salvador\"},{\"LanguageCode\":\"de\",\"Text\":\"El Salvador\"}]" },
                    { new Guid("bf78508b-5679-4b91-8958-efa23ad055c2"), "DOM", "[{\"LanguageCode\":\"en\",\"Text\":\"Dominican Republic\"},{\"LanguageCode\":\"nl\",\"Text\":\"Dominicaanse Republiek\"},{\"LanguageCode\":\"fr\",\"Text\":\"République dominicaine\"},{\"LanguageCode\":\"de\",\"Text\":\"Dominikanische Republik\"}]" },
                    { new Guid("c0084b10-3755-44cf-8552-5d2d8269ecac"), "FJI", "[{\"LanguageCode\":\"en\",\"Text\":\"Fiji\"},{\"LanguageCode\":\"nl\",\"Text\":\"Fiji\"},{\"LanguageCode\":\"fr\",\"Text\":\"Fidji\"},{\"LanguageCode\":\"de\",\"Text\":\"Fidschi\"}]" },
                    { new Guid("c0559341-609b-48ce-8406-1a305c227689"), "LTU", "[{\"LanguageCode\":\"en\",\"Text\":\"Lithuania\"},{\"LanguageCode\":\"nl\",\"Text\":\"Litouwen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Lituanie\"},{\"LanguageCode\":\"de\",\"Text\":\"Litauen\"}]" },
                    { new Guid("c0629d48-da5f-43c1-be22-1cd02c417a7b"), "ZAF", "[{\"LanguageCode\":\"en\",\"Text\":\"South Africa\"},{\"LanguageCode\":\"nl\",\"Text\":\"Zuid-Afrika\"},{\"LanguageCode\":\"fr\",\"Text\":\"Afrique du Sud\"},{\"LanguageCode\":\"de\",\"Text\":\"Südafrika\"}]" },
                    { new Guid("c0fa519d-c094-4f9a-89d6-12e14a52a2b8"), "TUV", "[{\"LanguageCode\":\"en\",\"Text\":\"Tuvalu\"},{\"LanguageCode\":\"nl\",\"Text\":\"Tuvalu\"},{\"LanguageCode\":\"fr\",\"Text\":\"Tuvalu\"},{\"LanguageCode\":\"de\",\"Text\":\"Tuvalu\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Code", "Names" },
                values: new object[,]
                {
                    { new Guid("c284464a-4175-425f-bd6c-5afe9a4c5f4a"), "VEN", "[{\"LanguageCode\":\"en\",\"Text\":\"Venezuela\"},{\"LanguageCode\":\"nl\",\"Text\":\"Venezuela\"},{\"LanguageCode\":\"fr\",\"Text\":\"Venezuela\"},{\"LanguageCode\":\"de\",\"Text\":\"Venezuela\"}]" },
                    { new Guid("c3152ad1-5190-4dec-9ff8-6d91cb5a66c2"), "SUR", "[{\"LanguageCode\":\"en\",\"Text\":\"Suriname\"},{\"LanguageCode\":\"nl\",\"Text\":\"Suriname\"},{\"LanguageCode\":\"fr\",\"Text\":\"Suriname\"},{\"LanguageCode\":\"de\",\"Text\":\"Suriname\"}]" },
                    { new Guid("c3bde949-09f9-47d7-99e2-1897b71290f9"), "GBR", "[{\"LanguageCode\":\"en\",\"Text\":\"United Kingdom\"},{\"LanguageCode\":\"nl\",\"Text\":\"Verenigd Koninkrijk\"},{\"LanguageCode\":\"fr\",\"Text\":\"Royaume-Uni\"},{\"LanguageCode\":\"de\",\"Text\":\"Vereinigtes Königreich\"}]" },
                    { new Guid("c6c176bd-8704-4739-8cd0-2750369167be"), "JPN", "[{\"LanguageCode\":\"en\",\"Text\":\"Japan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Japan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Japon\"},{\"LanguageCode\":\"de\",\"Text\":\"Japan\"}]" },
                    { new Guid("c6d7509d-fec0-4cb3-b03d-4b8bd72b8fcf"), "ALB", "[{\"LanguageCode\":\"en\",\"Text\":\"Albania\"},{\"LanguageCode\":\"nl\",\"Text\":\"Albanië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Albanie\"},{\"LanguageCode\":\"de\",\"Text\":\"Albanien\"}]" },
                    { new Guid("c80c294a-3f5e-41ad-ab88-f9efef59b167"), "NGA", "[{\"LanguageCode\":\"en\",\"Text\":\"Nigeria\"},{\"LanguageCode\":\"nl\",\"Text\":\"Nigeria\"},{\"LanguageCode\":\"fr\",\"Text\":\"Nigéria\"},{\"LanguageCode\":\"de\",\"Text\":\"Nigeria\"}]" },
                    { new Guid("c90c38cf-7408-4d17-a976-30d3d7cfd80c"), "AZE", "[{\"LanguageCode\":\"en\",\"Text\":\"Azerbaijan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Azerbeidzjan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Azerbaïdjan\"},{\"LanguageCode\":\"de\",\"Text\":\"Aserbaidschan\"}]" },
                    { new Guid("c9763d47-df87-43fb-a940-bc4dfa350ca8"), "MKD", "[{\"LanguageCode\":\"en\",\"Text\":\"Macedonia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Macedonië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Macédoine\"},{\"LanguageCode\":\"de\",\"Text\":\"Mazedonien\"}]" },
                    { new Guid("ca50adbc-6613-489f-8da1-2bbc6846867b"), "LVA", "[{\"LanguageCode\":\"en\",\"Text\":\"Latvia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Letland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Lettonie\"},{\"LanguageCode\":\"de\",\"Text\":\"Lettland\"}]" },
                    { new Guid("caabca5c-597f-4ad8-a93c-56f095c7f096"), "BTN", "[{\"LanguageCode\":\"en\",\"Text\":\"Bhutan\"},{\"LanguageCode\":\"nl\",\"Text\":\"Bhutan\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bhoutan\"},{\"LanguageCode\":\"de\",\"Text\":\"Bhutan\"}]" },
                    { new Guid("cb872447-babe-4542-9b17-9675148e52bc"), "UGA", "[{\"LanguageCode\":\"en\",\"Text\":\"Uganda\"},{\"LanguageCode\":\"nl\",\"Text\":\"Oeganda\"},{\"LanguageCode\":\"fr\",\"Text\":\"Ouganda\"},{\"LanguageCode\":\"de\",\"Text\":\"Uganda\"}]" },
                    { new Guid("cbae60f0-2d5c-4128-bbfd-3e90723f2826"), "IRQ", "[{\"LanguageCode\":\"en\",\"Text\":\"Iraq\"},{\"LanguageCode\":\"nl\",\"Text\":\"Irak\"},{\"LanguageCode\":\"fr\",\"Text\":\"Irak\"},{\"LanguageCode\":\"de\",\"Text\":\"Irak\"}]" },
                    { new Guid("cbc2c59c-8479-4568-ab97-5a6ac02e6dff"), "VUT", "[{\"LanguageCode\":\"en\",\"Text\":\"Vanuatu\"},{\"LanguageCode\":\"nl\",\"Text\":\"Vanuatu\"},{\"LanguageCode\":\"fr\",\"Text\":\"Vanuatu\"},{\"LanguageCode\":\"de\",\"Text\":\"Vanuatu\"}]" },
                    { new Guid("cdcf33fb-e869-4499-af7f-3673ab1e8d45"), "ZMB", "[{\"LanguageCode\":\"en\",\"Text\":\"Zambia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Zambia\"},{\"LanguageCode\":\"fr\",\"Text\":\"Zambie\"},{\"LanguageCode\":\"de\",\"Text\":\"Sambia\"}]" },
                    { new Guid("d07c2307-e98c-4b30-ad77-e7e1ca617eab"), "MCO", "[{\"LanguageCode\":\"en\",\"Text\":\"Monaco\"},{\"LanguageCode\":\"nl\",\"Text\":\"Monaco\"},{\"LanguageCode\":\"fr\",\"Text\":\"Monaco\"},{\"LanguageCode\":\"de\",\"Text\":\"Monaco\"}]" },
                    { new Guid("d1aa5ed9-a10e-4046-a00c-939298d9d0f4"), "ESP", "[{\"LanguageCode\":\"en\",\"Text\":\"Spain\"},{\"LanguageCode\":\"nl\",\"Text\":\"Spanje\"},{\"LanguageCode\":\"fr\",\"Text\":\"Espagne\"},{\"LanguageCode\":\"de\",\"Text\":\"Spanien\"}]" },
                    { new Guid("d99823ef-9bbf-404a-9f12-72217dc66a20"), "CUB", "[{\"LanguageCode\":\"en\",\"Text\":\"Cuba\"},{\"LanguageCode\":\"nl\",\"Text\":\"Cuba\"},{\"LanguageCode\":\"fr\",\"Text\":\"Cuba\"},{\"LanguageCode\":\"de\",\"Text\":\"Kuba\"}]" },
                    { new Guid("da5a4d8b-917d-4e70-b500-b21ed772609f"), "ARE", "[{\"LanguageCode\":\"en\",\"Text\":\"United Arab Emirates\"},{\"LanguageCode\":\"nl\",\"Text\":\"Verenigde Arabische Emiraten\"},{\"LanguageCode\":\"fr\",\"Text\":\"Émirats Arabes Unis\"},{\"LanguageCode\":\"de\",\"Text\":\"Vereinigte Arabische Emirate\"}]" },
                    { new Guid("daec9832-78f3-4351-b1c1-f87311f37669"), "CYP", "[{\"LanguageCode\":\"en\",\"Text\":\"Cyprus\"},{\"LanguageCode\":\"nl\",\"Text\":\"Cyprus\"},{\"LanguageCode\":\"fr\",\"Text\":\"Chypre\"},{\"LanguageCode\":\"de\",\"Text\":\"Zypern\"}]" },
                    { new Guid("db4a240b-d8f8-4684-bf18-808fa051b965"), "CHE", "[{\"LanguageCode\":\"en\",\"Text\":\"Switzerland\"},{\"LanguageCode\":\"nl\",\"Text\":\"Zwitserland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Suisse\"},{\"LanguageCode\":\"de\",\"Text\":\"Schweiz\"}]" },
                    { new Guid("dd5f860f-9d88-4253-8b82-878bd8287a84"), "AGO", "[{\"LanguageCode\":\"en\",\"Text\":\"Angola\"},{\"LanguageCode\":\"nl\",\"Text\":\"Angola\"},{\"LanguageCode\":\"fr\",\"Text\":\"Angola\"},{\"LanguageCode\":\"de\",\"Text\":\"Angola\"}]" },
                    { new Guid("de4d22ed-1945-46ab-a21d-c7a467b428c3"), "KWT", "[{\"LanguageCode\":\"en\",\"Text\":\"Kuwait\"},{\"LanguageCode\":\"nl\",\"Text\":\"Koeweit\"},{\"LanguageCode\":\"fr\",\"Text\":\"Koweït\"},{\"LanguageCode\":\"de\",\"Text\":\"Kuwait\"}]" },
                    { new Guid("df097ee1-7b51-49e5-919f-a065617025f5"), "EST", "[{\"LanguageCode\":\"en\",\"Text\":\"Estonia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Estland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Estonie\"},{\"LanguageCode\":\"de\",\"Text\":\"Estland\"}]" },
                    { new Guid("df6f5842-00ee-4ab4-8a8e-a892b22658f1"), "SVK", "[{\"LanguageCode\":\"en\",\"Text\":\"Slovakia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Slowakije\"},{\"LanguageCode\":\"fr\",\"Text\":\"Slovaquie\"},{\"LanguageCode\":\"de\",\"Text\":\"Slowakei\"}]" },
                    { new Guid("dfa91655-2ee8-4413-be84-ff591051efdd"), "TZA", "[{\"LanguageCode\":\"en\",\"Text\":\"Tanzania\"},{\"LanguageCode\":\"nl\",\"Text\":\"Tanzania\"},{\"LanguageCode\":\"fr\",\"Text\":\"Tanzanie\"},{\"LanguageCode\":\"de\",\"Text\":\"Tansania\"}]" },
                    { new Guid("e1eda6da-b9fc-4a7b-8c97-86fdff05ea0c"), "MAR", "[{\"LanguageCode\":\"en\",\"Text\":\"Morocco\"},{\"LanguageCode\":\"nl\",\"Text\":\"Marokko\"},{\"LanguageCode\":\"fr\",\"Text\":\"Maroc\"},{\"LanguageCode\":\"de\",\"Text\":\"Marokko\"}]" },
                    { new Guid("e22e68cc-f3be-43af-918c-1c177fcaa595"), "GRD", "[{\"LanguageCode\":\"en\",\"Text\":\"Grenada\"},{\"LanguageCode\":\"nl\",\"Text\":\"Grenada\"},{\"LanguageCode\":\"fr\",\"Text\":\"Grenade\"},{\"LanguageCode\":\"de\",\"Text\":\"Grenada\"}]" },
                    { new Guid("e42e318a-026b-4008-a775-6949a99a1eff"), "KHM", "[{\"LanguageCode\":\"en\",\"Text\":\"Cambodia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Cambodja\"},{\"LanguageCode\":\"fr\",\"Text\":\"Cambodge\"},{\"LanguageCode\":\"de\",\"Text\":\"Kambodscha\"}]" },
                    { new Guid("e4d020a4-9cb4-400f-9a11-576ed7062362"), "QAT", "[{\"LanguageCode\":\"en\",\"Text\":\"Qatar\"},{\"LanguageCode\":\"nl\",\"Text\":\"Qatar\"},{\"LanguageCode\":\"fr\",\"Text\":\"Qatar\"},{\"LanguageCode\":\"de\",\"Text\":\"Katar\"}]" },
                    { new Guid("e624c6e2-4937-4422-a083-d502c772859c"), "ETH", "[{\"LanguageCode\":\"en\",\"Text\":\"Ethiopia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Ethiopië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Éthiopie\"},{\"LanguageCode\":\"de\",\"Text\":\"Äthiopien\"}]" },
                    { new Guid("e6e6b40d-2d78-4f35-90d5-fc5ac28a5cbd"), "ERI", "[{\"LanguageCode\":\"en\",\"Text\":\"Eritrea\"},{\"LanguageCode\":\"nl\",\"Text\":\"Eritrea\"},{\"LanguageCode\":\"fr\",\"Text\":\"Érythrée\"},{\"LanguageCode\":\"de\",\"Text\":\"Eritrea\"}]" },
                    { new Guid("e7584eea-f033-4f5a-a609-b5ce29ade267"), "EGY", "[{\"LanguageCode\":\"en\",\"Text\":\"Egypt\"},{\"LanguageCode\":\"nl\",\"Text\":\"Egypte\"},{\"LanguageCode\":\"fr\",\"Text\":\"Égypte\"},{\"LanguageCode\":\"de\",\"Text\":\"Ägypten\"}]" },
                    { new Guid("e89f370f-b87b-4234-a392-42e4ff43deb1"), "ARG", "[{\"LanguageCode\":\"en\",\"Text\":\"Argentina\"},{\"LanguageCode\":\"nl\",\"Text\":\"Argentinië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Argentine\"},{\"LanguageCode\":\"de\",\"Text\":\"Argentinien\"}]" },
                    { new Guid("ea4d1817-9b1c-4f24-bcde-2940737a5a5e"), "ISL", "[{\"LanguageCode\":\"en\",\"Text\":\"Iceland\"},{\"LanguageCode\":\"nl\",\"Text\":\"IJsland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Islande\"},{\"LanguageCode\":\"de\",\"Text\":\"Island\"}]" },
                    { new Guid("ec3c1b33-4c55-4b4a-8f4e-c49ccd0a89c9"), "PRY", "[{\"LanguageCode\":\"en\",\"Text\":\"Paraguay\"},{\"LanguageCode\":\"nl\",\"Text\":\"Paraguay\"},{\"LanguageCode\":\"fr\",\"Text\":\"Paraguay\"},{\"LanguageCode\":\"de\",\"Text\":\"Paraguay\"}]" },
                    { new Guid("ec4ebc6a-a4c1-4897-b793-f17c93e173e9"), "BRA", "[{\"LanguageCode\":\"en\",\"Text\":\"Brazil\"},{\"LanguageCode\":\"nl\",\"Text\":\"Brazilië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Brésil\"},{\"LanguageCode\":\"de\",\"Text\":\"Brasilien\"}]" },
                    { new Guid("ed554a7b-bce3-4a10-bf4b-a113a71533c3"), "FRA", "[{\"LanguageCode\":\"en\",\"Text\":\"France\"},{\"LanguageCode\":\"nl\",\"Text\":\"Frankrijk\"},{\"LanguageCode\":\"fr\",\"Text\":\"France\"},{\"LanguageCode\":\"de\",\"Text\":\"Frankreich\"}]" },
                    { new Guid("ee1830f5-68fc-4e6b-83d3-f224c8f076d4"), "KIR", "[{\"LanguageCode\":\"en\",\"Text\":\"Kiribati\"},{\"LanguageCode\":\"nl\",\"Text\":\"Kiribati\"},{\"LanguageCode\":\"fr\",\"Text\":\"Kiribati\"},{\"LanguageCode\":\"de\",\"Text\":\"Kiribati\"}]" },
                    { new Guid("f0270845-1810-40f1-b3ac-bf111c42892d"), "CIV", "[{\"LanguageCode\":\"en\",\"Text\":\"Cote d'Ivoire\"},{\"LanguageCode\":\"nl\",\"Text\":\"Ivoorkust\"},{\"LanguageCode\":\"fr\",\"Text\":\"Côte d'Ivoire\"},{\"LanguageCode\":\"de\",\"Text\":\"Elfenbeinküste\"}]" },
                    { new Guid("f3edc011-9a2f-4ad4-8c00-2193bd4d5f49"), "SRB", "[{\"LanguageCode\":\"en\",\"Text\":\"Serbia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Servië\"},{\"LanguageCode\":\"fr\",\"Text\":\"Serbie\"},{\"LanguageCode\":\"de\",\"Text\":\"Serbien\"}]" },
                    { new Guid("f4537bb4-c120-4f5c-ac8d-7157e6988fd8"), "PHL", "[{\"LanguageCode\":\"en\",\"Text\":\"Philippines\"},{\"LanguageCode\":\"nl\",\"Text\":\"Filipijnen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Philippines\"},{\"LanguageCode\":\"de\",\"Text\":\"Philippinen\"}]" },
                    { new Guid("f522dcd6-6129-40b9-8265-8015696ffbae"), "GMB", "[{\"LanguageCode\":\"en\",\"Text\":\"Gambia\"},{\"LanguageCode\":\"nl\",\"Text\":\"Gambia\"},{\"LanguageCode\":\"fr\",\"Text\":\"Gambie\"},{\"LanguageCode\":\"de\",\"Text\":\"Gambia\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Code", "Names" },
                values: new object[,]
                {
                    { new Guid("f725e114-c733-4bb4-ba24-57a5758355db"), "JAM", "[{\"LanguageCode\":\"en\",\"Text\":\"Jamaica\"},{\"LanguageCode\":\"nl\",\"Text\":\"Jamaica\"},{\"LanguageCode\":\"fr\",\"Text\":\"Jamaïque\"},{\"LanguageCode\":\"de\",\"Text\":\"Jamaika\"}]" },
                    { new Guid("f992c83b-0ca4-45aa-bb41-bf740ee53610"), "IRL", "[{\"LanguageCode\":\"en\",\"Text\":\"Ireland\"},{\"LanguageCode\":\"nl\",\"Text\":\"Ierland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Irlande\"},{\"LanguageCode\":\"de\",\"Text\":\"Irland\"}]" },
                    { new Guid("f9955c31-d822-41ea-89a6-5907e360b3e5"), "PRK", "[{\"LanguageCode\":\"en\",\"Text\":\"North Korea\"},{\"LanguageCode\":\"nl\",\"Text\":\"Noord-Korea\"},{\"LanguageCode\":\"fr\",\"Text\":\"Corée du Nord\"},{\"LanguageCode\":\"de\",\"Text\":\"Nord Korea\"}]" },
                    { new Guid("fbb84182-c3f1-422e-b98f-ca09e8ad0d69"), "BLR", "[{\"LanguageCode\":\"en\",\"Text\":\"Belarus\"},{\"LanguageCode\":\"nl\",\"Text\":\"Wit-Rusland\"},{\"LanguageCode\":\"fr\",\"Text\":\"Belarus\"},{\"LanguageCode\":\"de\",\"Text\":\"Weißrussland\"}]" },
                    { new Guid("fbbad9a4-d3a2-4ec7-8ad1-8137fdbd59eb"), "USA", "[{\"LanguageCode\":\"en\",\"Text\":\"United States of America\"},{\"LanguageCode\":\"nl\",\"Text\":\"Verenigde Staten\"},{\"LanguageCode\":\"fr\",\"Text\":\"États-Unis\"},{\"LanguageCode\":\"de\",\"Text\":\"Vereinigte Staaten\"}]" },
                    { new Guid("fbda5250-10dd-4ae4-9c33-169d5e22ea20"), "TTO", "[{\"LanguageCode\":\"en\",\"Text\":\"Trinidad and Tobago\"},{\"LanguageCode\":\"nl\",\"Text\":\"Trinidad en Tobago\"},{\"LanguageCode\":\"fr\",\"Text\":\"Trinité-et-Tobago\"},{\"LanguageCode\":\"de\",\"Text\":\"Trinidad und Tobago\"}]" },
                    { new Guid("fe45a47f-0bb4-4132-aa0e-cc73e7284d2a"), "IND", "[{\"LanguageCode\":\"en\",\"Text\":\"India\"},{\"LanguageCode\":\"nl\",\"Text\":\"India\"},{\"LanguageCode\":\"fr\",\"Text\":\"Inde\"},{\"LanguageCode\":\"de\",\"Text\":\"Indien\"}]" },
                    { new Guid("fe9c3c1b-3425-43be-8203-b081d7951f9e"), "GHA", "[{\"LanguageCode\":\"en\",\"Text\":\"Ghana\"},{\"LanguageCode\":\"nl\",\"Text\":\"Ghana\"},{\"LanguageCode\":\"fr\",\"Text\":\"Ghana\"},{\"LanguageCode\":\"de\",\"Text\":\"Ghana\"}]" },
                    { new Guid("ff464088-9616-43ed-9b1b-38f302edc8ee"), "CHN", "[{\"LanguageCode\":\"en\",\"Text\":\"China\"},{\"LanguageCode\":\"nl\",\"Text\":\"China\"},{\"LanguageCode\":\"fr\",\"Text\":\"Chine\"},{\"LanguageCode\":\"de\",\"Text\":\"China\"}]" }
                });

            migrationBuilder.InsertData(
                table: "CrewTypes",
                columns: new[] { "ID", "Names" },
                values: new object[,]
                {
                    { new Guid("153d2723-5769-4a03-a496-0a65b461dcf3"), "[{\"LanguageCode\":\"en\",\"Text\":\"Time observation\"},{\"LanguageCode\":\"nl\",\"Text\":\"Tijdwaarneming\"},{\"LanguageCode\":\"fr\",\"Text\":\"Chronométrage\"},{\"LanguageCode\":\"de\",\"Text\":\"Zeitnahme\"}]" },
                    { new Guid("2eb77547-e033-4595-bae7-f82f6efa58ac"), "[{\"LanguageCode\":\"en\",\"Text\":\"Collaborator\"},{\"LanguageCode\":\"nl\",\"Text\":\"Finish\"},{\"LanguageCode\":\"fr\",\"Text\":\"Collaborateur\"},{\"LanguageCode\":\"de\",\"Text\":\"Mitarbeiter\"}]" },
                    { new Guid("40c6a00d-11be-422f-8470-90aa8894d7ec"), "[{\"LanguageCode\":\"en\",\"Text\":\"Race leader\"},{\"LanguageCode\":\"nl\",\"Text\":\"Renleider\"},{\"LanguageCode\":\"fr\",\"Text\":\"Chef de course\"},{\"LanguageCode\":\"de\",\"Text\":\"Rennführer\"}]" },
                    { new Guid("5af3404e-403d-4a03-b258-e49ba035ddad"), "[{\"LanguageCode\":\"en\",\"Text\":\"Hare Control\"},{\"LanguageCode\":\"nl\",\"Text\":\"Haastechniek\"},{\"LanguageCode\":\"fr\",\"Text\":\"Technique de Lièvre\"},{\"LanguageCode\":\"de\",\"Text\":\"Hasetechnik\"}]" },
                    { new Guid("bc32177b-1649-44a9-b55a-66486c586674"), "[{\"LanguageCode\":\"en\",\"Text\":\"Jury\"},{\"LanguageCode\":\"nl\",\"Text\":\"Jury\"},{\"LanguageCode\":\"fr\",\"Text\":\"Jury\"},{\"LanguageCode\":\"de\",\"Text\":\"Jury\"}]" },
                    { new Guid("e1a12ebd-8a70-44fd-973d-b2ee5feba09f"), "[{\"LanguageCode\":\"en\",\"Text\":\"Turn comissioner\"},{\"LanguageCode\":\"nl\",\"Text\":\"Bochtcommissaris\"},{\"LanguageCode\":\"fr\",\"Text\":\"Commissaire de courbure\"},{\"LanguageCode\":\"de\",\"Text\":\"BendKommisar\"}]" },
                    { new Guid("f7dfa36a-bd7d-468e-aba1-0a9171d67af7"), "[{\"LanguageCode\":\"en\",\"Text\":\"Finish\"},{\"LanguageCode\":\"nl\",\"Text\":\"Finish\"},{\"LanguageCode\":\"fr\",\"Text\":\"Arrivée\"},{\"LanguageCode\":\"de\",\"Text\":\"Ziel\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Distances",
                columns: new[] { "ID", "IsOfficial", "Length", "Names" },
                values: new object[,]
                {
                    { new Guid("197a1b1b-077c-460b-b235-0d2136df18d1"), false, 200, "[{\"LanguageCode\":\"en\",\"Text\":\"Piece from Clock\"},{\"LanguageCode\":\"nl\",\"Text\":\"Stukje vanaf de Klok\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pièce partir de l'horloge\"},{\"LanguageCode\":\"de\",\"Text\":\"Stück vom Takt\"}]" },
                    { new Guid("440f210c-e1f0-4aa1-9ac8-71e5cdc6b214"), true, 275, "[{\"LanguageCode\":\"en\",\"Text\":\"275m\"},{\"LanguageCode\":\"nl\",\"Text\":\"275m\"},{\"LanguageCode\":\"fr\",\"Text\":\"275m\"},{\"LanguageCode\":\"de\",\"Text\":\"275m\"}]" },
                    { new Guid("4ca3bc50-8eab-4b6e-a62f-6eb549bc5a9e"), false, 50, "[{\"LanguageCode\":\"en\",\"Text\":\"Piece from Jury House\"},{\"LanguageCode\":\"nl\",\"Text\":\"Stukje vanaf Juryhuis\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pièce de la Maison du Jury\"},{\"LanguageCode\":\"de\",\"Text\":\"Stück vom Jury Hause\"}]" },
                    { new Guid("8cf38bf9-6e49-45ca-a5bf-41367413b979"), false, 150, "[{\"LanguageCode\":\"en\",\"Text\":\"Piece from Red Post\"},{\"LanguageCode\":\"nl\",\"Text\":\"Stukje vanaf de Rode Paal\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pièce au pôle rouge\"},{\"LanguageCode\":\"de\",\"Text\":\"Stück vom roten Pol\"}]" },
                    { new Guid("aa13072d-7b03-4f77-baee-7db5b76aa524"), true, 480, "[{\"LanguageCode\":\"en\",\"Text\":\"480m\"},{\"LanguageCode\":\"nl\",\"Text\":\"480m\"},{\"LanguageCode\":\"fr\",\"Text\":\"480m\"},{\"LanguageCode\":\"de\",\"Text\":\"480m\"}]" },
                    { new Guid("bfe7b982-d7a0-4622-90c3-7bddae99a01d"), false, 100, "[{\"LanguageCode\":\"en\",\"Text\":\"Straight\"},{\"LanguageCode\":\"nl\",\"Text\":\"Recht stukje\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pièce à droite\"},{\"LanguageCode\":\"de\",\"Text\":\"Richtiges Stück\"}]" },
                    { new Guid("d9ae6e63-1eb3-4c53-ab2c-94471e183120"), true, 345, "[{\"LanguageCode\":\"en\",\"Text\":\"345m\"},{\"LanguageCode\":\"nl\",\"Text\":\"345m\"},{\"LanguageCode\":\"fr\",\"Text\":\"345m\"},{\"LanguageCode\":\"de\",\"Text\":\"345m\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "ID", "Code", "Name", "Translated" },
                values: new object[,]
                {
                    { new Guid("0f1d7a6a-1a39-4cec-bbde-cdf640110838"), "sl", "Slovenski", false },
                    { new Guid("184f350a-12d7-413b-a582-7dec0493eee0"), "lt", "Lietuvių", false },
                    { new Guid("1a45dcb1-94e9-4d29-8cb0-aaa47cd702a7"), "ro", "Română", false },
                    { new Guid("23b9a00e-a261-4fac-aa4b-8d9db81bee44"), "nl", "Nederlands", true },
                    { new Guid("2f815813-93af-406b-ba6f-7103df25edd7"), "et", "Eesti", false },
                    { new Guid("3995e0c7-c3ee-4ea3-84c2-d35e93b51c9e"), "pt", "Português", false },
                    { new Guid("3d0cd848-b194-47e4-8602-a37af4c91cc3"), "sv", "Svenska", false },
                    { new Guid("417db2b0-e4db-481b-ae4f-c9f256dee6f2"), "ru", "Русский", false },
                    { new Guid("66fa4291-0b61-4d7b-96c7-ef5aefe3669e"), "en", "English", true },
                    { new Guid("68cb6204-2bc9-4f0c-b5d5-7dac9d2e8a80"), "de", "Deutsch", true },
                    { new Guid("68fd9eb7-87b5-4e3b-99d3-8681ebe4f31a"), "hu", "Magyar", false },
                    { new Guid("8e65746b-b206-444a-9584-4d354ea72eb1"), "hr", "Hrvatski", false },
                    { new Guid("96c6e3be-81fb-4788-af8e-11e3054d1269"), "fi", "Suomen", false },
                    { new Guid("a1c3c927-8fd9-4c03-ab14-10e4a2f50c0e"), "fr", "Français", true },
                    { new Guid("a5db799b-b67c-481f-b9c1-0497c55b05b6"), "bg", "Bǎlgarski", false },
                    { new Guid("aa8c88a7-c083-4fb2-acae-616a8b853011"), "pl", "Polski", false },
                    { new Guid("b547ac64-2e43-4293-9a8e-c253927f5280"), "el", "Ελληνικά", false },
                    { new Guid("b59548e3-d2ce-471e-9763-63606a7d8f22"), "cs", "Čeština", false },
                    { new Guid("b86e859e-693b-4dc5-ac56-5f7ed7e88841"), "ga", "Gaeilge", false }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "ID", "Code", "Name", "Translated" },
                values: new object[,]
                {
                    { new Guid("c0b4cae0-ecca-4213-ad88-ff38d19a537c"), "it", "Italiano", false },
                    { new Guid("c5b79b83-af19-45ce-8347-3e4052f4e367"), "es", "Espagnol", false },
                    { new Guid("cd273eb2-5159-4ab0-862a-1491085cb7fd"), "da", "Dansk", false },
                    { new Guid("e16269be-fbcb-4813-8ee0-6d496a78dfef"), "lv", "Latviešu", false },
                    { new Guid("e2f328b0-2e42-4a2e-b73b-f8b39d500622"), "sk", "Slovenčina", false },
                    { new Guid("f849ff9c-080f-4eb1-b286-a16b6cca58b8"), "mt", "Malti", false }
                });

            migrationBuilder.InsertData(
                table: "RaceTypes",
                columns: new[] { "ID", "IsOfficial", "Names" },
                values: new object[,]
                {
                    { new Guid("14e7f603-92d6-437b-b93d-56300c5a4d92"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"Preliminary\"},{\"LanguageCode\":\"nl\",\"Text\":\"Voorloop\"},{\"LanguageCode\":\"fr\",\"Text\":\"Préliminaire\"},{\"LanguageCode\":\"de\",\"Text\":\"Vorläuf\"}]" },
                    { new Guid("3b6dd69c-8903-4df4-bc04-34ed8802bfb5"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"Demo run\"},{\"LanguageCode\":\"nl\",\"Text\":\"Demostratierit\"},{\"LanguageCode\":\"fr\",\"Text\":\"Course de Démostration\"},{\"LanguageCode\":\"de\",\"Text\":\"Demo-Läuf\"}]" },
                    { new Guid("5a6454fe-9bbe-4aa8-be8d-1937d61a29fc"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"C-Final\"},{\"LanguageCode\":\"nl\",\"Text\":\"C-Finale\"},{\"LanguageCode\":\"fr\",\"Text\":\"Finale C\"},{\"LanguageCode\":\"de\",\"Text\":\"C-Finale\"}]" },
                    { new Guid("63114685-c48a-4f44-a910-8c6979b5b687"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"2nd Chance\"},{\"LanguageCode\":\"nl\",\"Text\":\"Herkansing\"},{\"LanguageCode\":\"fr\",\"Text\":\"Resit\"},{\"LanguageCode\":\"de\",\"Text\":\"Wiederholung\"}]" },
                    { new Guid("6b10b543-db0d-423d-b597-0c5c2b5b2fd4"), false, "[{\"LanguageCode\":\"en\",\"Text\":\"Training\"},{\"LanguageCode\":\"nl\",\"Text\":\"Training\"},{\"LanguageCode\":\"fr\",\"Text\":\"Formation\"},{\"LanguageCode\":\"de\",\"Text\":\"Training\"}]" },
                    { new Guid("88ddfaf8-a5a4-4212-935e-bed616972426"), false, "[{\"LanguageCode\":\"en\",\"Text\":\"Licence Trial\"},{\"LanguageCode\":\"nl\",\"Text\":\"Goed Rond\"},{\"LanguageCode\":\"fr\",\"Text\":\"Essai de licence\"},{\"LanguageCode\":\"de\",\"Text\":\"Lizenzversuch\"}]" },
                    { new Guid("8ca11bbb-ce66-4b79-95d9-ee0ac650561e"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"Final\"},{\"LanguageCode\":\"nl\",\"Text\":\"Finale\"},{\"LanguageCode\":\"fr\",\"Text\":\"Finale\"},{\"LanguageCode\":\"de\",\"Text\":\"Finale\"}]" },
                    { new Guid("d64d05a6-eabc-4820-9011-047fdded0a84"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"Semi Final\"},{\"LanguageCode\":\"nl\",\"Text\":\"Halve Finale\"},{\"LanguageCode\":\"fr\",\"Text\":\"Demi-finale\"},{\"LanguageCode\":\"de\",\"Text\":\"Halbfinale\"}]" },
                    { new Guid("d7625773-fe4b-46a0-a2c6-5f3b3caf64e9"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"Solo run\"},{\"LanguageCode\":\"nl\",\"Text\":\"Solorit\"},{\"LanguageCode\":\"fr\",\"Text\":\"Course Solitaire\"},{\"LanguageCode\":\"de\",\"Text\":\"Einzelläuf\"}]" },
                    { new Guid("e72d9dfb-0e30-4e37-96f8-3dc002ea963d"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"2nd Preliminary\"},{\"LanguageCode\":\"nl\",\"Text\":\"2e Voorloop\"},{\"LanguageCode\":\"fr\",\"Text\":\"2ième Préliminaire\"},{\"LanguageCode\":\"de\",\"Text\":\"2e Vorläuf\"}]" },
                    { new Guid("ee86bfca-4c3f-437e-84c2-60d236573059"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"B-Final\"},{\"LanguageCode\":\"nl\",\"Text\":\"B-Finale\"},{\"LanguageCode\":\"fr\",\"Text\":\"Finale B\"},{\"LanguageCode\":\"de\",\"Text\":\"B-Finale\"}]" },
                    { new Guid("f5f7a330-213d-4843-80da-61be75d400e8"), true, "[{\"LanguageCode\":\"en\",\"Text\":\"D-Final\"},{\"LanguageCode\":\"nl\",\"Text\":\"D-Finale\"},{\"LanguageCode\":\"fr\",\"Text\":\"Finale D\"},{\"LanguageCode\":\"de\",\"Text\":\"D-Finale\"}]" }
                });

            migrationBuilder.InsertData(
                table: "RunResultTypes",
                columns: new[] { "ID", "Code", "Order", "Names" },
                values: new object[,]
                {
                    { new Guid("04af5196-9108-432d-b9d0-6a6ee540ed16"), "OK", 0, "[{\"LanguageCode\":\"en\",\"Text\":\"OK\"},{\"LanguageCode\":\"nl\",\"Text\":\"OK\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bon\"},{\"LanguageCode\":\"de\",\"Text\":\"OK\"}]" },
                    { new Guid("6ed4bd7d-ef60-4528-9d71-e4915d810a04"), "DNS", 3, "[{\"LanguageCode\":\"en\",\"Text\":\"Did Not Start\"},{\"LanguageCode\":\"nl\",\"Text\":\"Niet Gestart\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pas Commencé\"},{\"LanguageCode\":\"de\",\"Text\":\"Nicht Gestartet\"}]" },
                    { new Guid("b5f052cf-2818-4a58-8c57-01abb088b04b"), "NR", 1, "[{\"LanguageCode\":\"en\",\"Text\":\"No Result\"},{\"LanguageCode\":\"nl\",\"Text\":\"Geen Resultaat\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pas de résultat\"},{\"LanguageCode\":\"de\",\"Text\":\"Kein Ergebnis\"}]" },
                    { new Guid("dbe4699a-3b22-4dd1-b86b-ab44bb600cfb"), "DNF", 2, "[{\"LanguageCode\":\"en\",\"Text\":\"Did Not Finish\"},{\"LanguageCode\":\"nl\",\"Text\":\"Niet Gefinisht\"},{\"LanguageCode\":\"fr\",\"Text\":\"Pas fini\"},{\"LanguageCode\":\"de\",\"Text\":\"Nicht Beendet\"}]" },
                    { new Guid("f5eea2b5-c69b-49f3-9f54-b5b9876ab6b4"), "DIS", 4, "[{\"LanguageCode\":\"en\",\"Text\":\"Disqualified\"},{\"LanguageCode\":\"nl\",\"Text\":\"Gediskwalificeerd\"},{\"LanguageCode\":\"fr\",\"Text\":\"Disqualifié\"},{\"LanguageCode\":\"de\",\"Text\":\"Disqualifiziert\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Sexes",
                columns: new[] { "ID", "Code", "Names", "PluralNames" },
                values: new object[,]
                {
                    { new Guid("3eb13e00-2006-40bd-a15f-aecb206a5c72"), "F", "[{\"LanguageCode\":\"en\",\"Text\":\"Bitch\"},{\"LanguageCode\":\"nl\",\"Text\":\"Teef\"},{\"LanguageCode\":\"fr\",\"Text\":\"Femelle\"},{\"LanguageCode\":\"de\",\"Text\":\"Hündin\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Bitches\"},{\"LanguageCode\":\"nl\",\"Text\":\"Teven\"},{\"LanguageCode\":\"fr\",\"Text\":\"Femelles\"},{\"LanguageCode\":\"de\",\"Text\":\"Hündinnen\"}]" },
                    { new Guid("818ff154-7208-4f28-880e-19f48ccb94ad"), "M", "[{\"LanguageCode\":\"en\",\"Text\":\"Male\"},{\"LanguageCode\":\"nl\",\"Text\":\"Reu\"},{\"LanguageCode\":\"fr\",\"Text\":\"Male\"},{\"LanguageCode\":\"de\",\"Text\":\"Hund\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Males\"},{\"LanguageCode\":\"nl\",\"Text\":\"Reuen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Males\"},{\"LanguageCode\":\"de\",\"Text\":\"Rüden\"}]" },
                    { new Guid("83b150fe-89c0-4fe2-947e-18198244963f"), "X", "[{\"LanguageCode\":\"en\",\"Text\":\"Mixed\"},{\"LanguageCode\":\"nl\",\"Text\":\"Gemengd\"},{\"LanguageCode\":\"fr\",\"Text\":\"Mixe\"},{\"LanguageCode\":\"de\",\"Text\":\"Gesmischt\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Mixed\"},{\"LanguageCode\":\"nl\",\"Text\":\"Gemengd\"},{\"LanguageCode\":\"fr\",\"Text\":\"Mixe\"},{\"LanguageCode\":\"de\",\"Text\":\"Gesmischt\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "ID", "Box", "City", "Coordinates", "CountryID", "Name", "PostCode", "State", "Street", "StreetNumber" },
                values: new object[,]
                {
                    { new Guid("0a7100b9-a371-475e-843d-5681d4123320"), null, "Münster", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (7.512220369318495 52.00803087574718)"), new Guid("21d61853-43c2-422f-993b-ef96fa75afea"), null, "48161", null, "Alberdingweg", "171" },
                    { new Guid("75cc3997-7d8b-4ac3-b46c-f1ca12d6a060"), null, "Geldrop", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (5.577288230681506 51.41417833236854)"), new Guid("ade8e58e-f037-48aa-8fae-5bedcb6ad0d8"), null, "5665 ET", null, "Bosrand", "130" },
                    { new Guid("a55714d4-a40a-4f2a-9d68-282bbadecb46"), null, "Beringen", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (5.2043387767037625 51.04629826617232)"), new Guid("0afec050-198a-4248-b736-e5bd611550a9"), null, "3580", null, "Paalsesteenweg", "91" },
                    { new Guid("ceea56e8-6193-4541-b760-89af6f762a4a"), null, "Awans", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (5.469089715340752 50.67511672146613)"), new Guid("0afec050-198a-4248-b736-e5bd611550a9"), null, "4340", null, "Rue Jean Lambert Defrêne", "98" },
                    { new Guid("fe8ac32b-10fd-43af-ac29-c8749af9ecb0"), null, "Gelsenkirchen-Resse", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (7.141436499999999 51.553632324864154)"), new Guid("21d61853-43c2-422f-993b-ef96fa75afea"), null, "45892", null, "Wiedehopfstraße", "197" }
                });

            migrationBuilder.InsertData(
                table: "AgeRestrictions",
                columns: new[] { "BreedID", "CompetitionID", "MaxAge", "MinAge", "TillEndOfYear" },
                values: new object[,]
                {
                    { new Guid("02b86e36-0ccd-435b-b665-6c7b2b246244"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("0b50ff12-d15f-4995-9f0f-4b21e96f862b"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("1ec110cc-7f70-4060-93ef-58727fcbaeb9"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("2bb65b3a-0d1c-4d8e-aa2d-1648358df96c"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 15, true },
                    { new Guid("33bbe8c5-d286-4e45-91a0-0ec52cdea9c8"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("3a366646-a678-4706-a7eb-9eb1cc1b4961"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("42ac8b3a-bbfb-4243-b104-d608efdcf7b4"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("453abb88-6912-42c2-9f77-90582d1d467f"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("4e469cfa-b1f1-452a-b983-70a803aad06c"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("59bec42e-a9b1-44b4-bf6c-57566d8cf8bb"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("5e04bdaf-a785-456b-a18e-cc4922a1e776"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("677f5efc-e697-4e8d-9ffe-ddf61394d595"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 15, true },
                    { new Guid("6786b78b-611e-430a-a589-65df5c302e11"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 15, true },
                    { new Guid("72a99b45-1069-4576-ae00-242b563c6bad"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("7f991e29-2e61-48e7-b97a-50f90a573cac"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true },
                    { new Guid("a52bcb82-9d9d-41a7-ad2d-f1b037e937a3"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 15, true },
                    { new Guid("b64afe74-5fc1-4d42-bb9c-f2fdd65e90a7"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 15, true },
                    { new Guid("c1d0390a-a688-498e-a1f1-782ed18b2787"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 15, true },
                    { new Guid("d670c778-a372-455b-9570-05a1fc330023"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 96, 18, true }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ID", "ClassType", "Code", "CompetitionID", "MixedClassID", "Names" },
                values: new object[,]
                {
                    { new Guid("3b204fbf-a1a7-43d2-8b41-a2aa310b29be"), 0, "G", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Veteran\"},{\"LanguageCode\":\"nl\",\"Text\":\"Veteranen\"},{\"LanguageCode\":\"fr\",\"Text\":\"Vétéran\"},{\"LanguageCode\":\"de\",\"Text\":\"Veteran\"}]" },
                    { new Guid("3e9108a4-d235-44ef-b0fb-92e8d5e16878"), 0, "C", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"C-Class\"},{\"LanguageCode\":\"nl\",\"Text\":\"C-Klasse\"},{\"LanguageCode\":\"fr\",\"Text\":\"C-Class\"},{\"LanguageCode\":\"de\",\"Text\":\"C-Klasse\"}]" },
                    { new Guid("c37f460f-e121-433f-8b4e-a04c9b8498e6"), 0, "O", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"Open\"},{\"LanguageCode\":\"nl\",\"Text\":\"Open\"},{\"LanguageCode\":\"fr\",\"Text\":\"Ouverte\"},{\"LanguageCode\":\"de\",\"Text\":\"Open\"}]" },
                    { new Guid("ca9590ff-1714-4d98-8ee1-fc7bcbc1b836"), 0, "A", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"A-Class\"},{\"LanguageCode\":\"nl\",\"Text\":\"A-Klasse\"},{\"LanguageCode\":\"fr\",\"Text\":\"A-Class\"},{\"LanguageCode\":\"de\",\"Text\":\"A-Klasse\"}]" },
                    { new Guid("ce6d34b8-d832-4308-a163-cd97e82fce43"), 0, "B", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), null, "[{\"LanguageCode\":\"en\",\"Text\":\"B-Class\"},{\"LanguageCode\":\"nl\",\"Text\":\"B-Klasse\"},{\"LanguageCode\":\"fr\",\"Text\":\"B-Class\"},{\"LanguageCode\":\"de\",\"Text\":\"B-Klasse\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Jerseys",
                columns: new[] { "ID", "CompetitionID", "Number", "Codes", "Names" },
                values: new object[,]
                {
                    { new Guid("04446811-485d-4c1b-a759-40f372983b08"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 4, "[{\"LanguageCode\":\"en\",\"Text\":\"BK\"},{\"LanguageCode\":\"nl\",\"Text\":\"Z\"},{\"LanguageCode\":\"fr\",\"Text\":\"N\"},{\"LanguageCode\":\"de\",\"Text\":\"S\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Black\"},{\"LanguageCode\":\"nl\",\"Text\":\"Zwart\"},{\"LanguageCode\":\"fr\",\"Text\":\"Noir\"},{\"LanguageCode\":\"de\",\"Text\":\"Schwarz\"}]" },
                    { new Guid("23b3c4e1-51ab-44f3-b40a-8c4bead40636"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 3, "[{\"LanguageCode\":\"en\",\"Text\":\"W\"},{\"LanguageCode\":\"nl\",\"Text\":\"W\"},{\"LanguageCode\":\"fr\",\"Text\":\"BC\"},{\"LanguageCode\":\"de\",\"Text\":\"W\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"White\"},{\"LanguageCode\":\"nl\",\"Text\":\"Wit\"},{\"LanguageCode\":\"fr\",\"Text\":\"Blanc\"},{\"LanguageCode\":\"de\",\"Text\":\"Weiß\"}]" },
                    { new Guid("834db893-4d73-4142-aac8-8beb0b334bff"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 1, "[{\"LanguageCode\":\"en\",\"Text\":\"R\"},{\"LanguageCode\":\"nl\",\"Text\":\"R\"},{\"LanguageCode\":\"fr\",\"Text\":\"R\"},{\"LanguageCode\":\"de\",\"Text\":\"R\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Red\"},{\"LanguageCode\":\"nl\",\"Text\":\"Rood\"},{\"LanguageCode\":\"fr\",\"Text\":\"Rouge\"},{\"LanguageCode\":\"de\",\"Text\":\"Rot\"}]" },
                    { new Guid("935cfa45-62d1-483d-8dd3-5264b57b7f09"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 6, "[{\"LanguageCode\":\"en\",\"Text\":\"BK/W\"},{\"LanguageCode\":\"nl\",\"Text\":\"Z/W\"},{\"LanguageCode\":\"fr\",\"Text\":\"N/BC\"},{\"LanguageCode\":\"de\",\"Text\":\"S/W\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"B/W Stripes\"},{\"LanguageCode\":\"nl\",\"Text\":\"Z/W Gestreept\"},{\"LanguageCode\":\"fr\",\"Text\":\"N/Bc Rayé\"},{\"LanguageCode\":\"de\",\"Text\":\"S/W Gestreift\"}]" },
                    { new Guid("c2c8dd39-e395-468b-8be9-90580013c659"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 5, "[{\"LanguageCode\":\"en\",\"Text\":\"Y\"},{\"LanguageCode\":\"nl\",\"Text\":\"G\"},{\"LanguageCode\":\"fr\",\"Text\":\"J\"},{\"LanguageCode\":\"de\",\"Text\":\"G\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Yellow\"},{\"LanguageCode\":\"nl\",\"Text\":\"Geel\"},{\"LanguageCode\":\"fr\",\"Text\":\"Jaune\"},{\"LanguageCode\":\"de\",\"Text\":\"Gelb\"}]" },
                    { new Guid("f5570613-57c4-423b-b45f-c87f03995099"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), 2, "[{\"LanguageCode\":\"en\",\"Text\":\"B\"},{\"LanguageCode\":\"nl\",\"Text\":\"B\"},{\"LanguageCode\":\"fr\",\"Text\":\"B\"},{\"LanguageCode\":\"de\",\"Text\":\"B\"}]", "[{\"LanguageCode\":\"en\",\"Text\":\"Blue\"},{\"LanguageCode\":\"nl\",\"Text\":\"Blauw\"},{\"LanguageCode\":\"fr\",\"Text\":\"Bleu\"},{\"LanguageCode\":\"de\",\"Text\":\"Blau\"}]" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ID", "ClassType", "Code", "CompetitionID", "MixedClassID", "Names" },
                values: new object[,]
                {
                    { new Guid("20dff530-754d-46ed-9cdc-69080a683b22"), 2, "C", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("3e9108a4-d235-44ef-b0fb-92e8d5e16878"), "[{\"LanguageCode\":\"en\",\"Text\":\"C-Class CSS\"},{\"LanguageCode\":\"nl\",\"Text\":\"C-Klasse CSS\"},{\"LanguageCode\":\"fr\",\"Text\":\"C-Class CSS\"},{\"LanguageCode\":\"de\",\"Text\":\"C-Klasse CSS\"}]" },
                    { new Guid("3a1b3c22-c1c6-44d7-9608-39fbe92480e7"), 1, "B", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("ce6d34b8-d832-4308-a163-cd97e82fce43"), "[{\"LanguageCode\":\"en\",\"Text\":\"B-Class FCI-CACIL\"},{\"LanguageCode\":\"nl\",\"Text\":\"B-Klasse FCI-CACIL\"},{\"LanguageCode\":\"fr\",\"Text\":\"B-Class FCI-CACIL\"},{\"LanguageCode\":\"de\",\"Text\":\"B-Klasse FCI-CACIL\"}]" },
                    { new Guid("3a22b699-3489-4749-b766-b2c63275068e"), 2, "G", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("3b204fbf-a1a7-43d2-8b41-a2aa310b29be"), "[{\"LanguageCode\":\"en\",\"Text\":\"Veteran CSS\"},{\"LanguageCode\":\"nl\",\"Text\":\"Veteranen CSS\"},{\"LanguageCode\":\"fr\",\"Text\":\"Vétéran CSS\"},{\"LanguageCode\":\"de\",\"Text\":\"Veteran CSS\"}]" },
                    { new Guid("4fe73b6e-3041-41dd-800d-785221165c71"), 1, "O", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("c37f460f-e121-433f-8b4e-a04c9b8498e6"), "[{\"LanguageCode\":\"en\",\"Text\":\"Open FCI-CACIL\"},{\"LanguageCode\":\"nl\",\"Text\":\"Open FCI-CACIL\"},{\"LanguageCode\":\"fr\",\"Text\":\"Ouverte FCI-CACIL\"},{\"LanguageCode\":\"de\",\"Text\":\"Open FCI-CACIL\"}]" },
                    { new Guid("809d7d3a-4ba2-4b89-acf6-50735199fda2"), 1, "G", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("3b204fbf-a1a7-43d2-8b41-a2aa310b29be"), "[{\"LanguageCode\":\"en\",\"Text\":\"Veteran FCI-CACIL\"},{\"LanguageCode\":\"nl\",\"Text\":\"Veteranen FCI-CACIL\"},{\"LanguageCode\":\"fr\",\"Text\":\"Vétéran FCI-CACIL\"},{\"LanguageCode\":\"de\",\"Text\":\"Veteran FCI-CACIL\"}]" },
                    { new Guid("827c18c9-8d10-4cca-915f-61699560a5ea"), 1, "A", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("ca9590ff-1714-4d98-8ee1-fc7bcbc1b836"), "[{\"LanguageCode\":\"en\",\"Text\":\"A-Class FCI-CACIL\"},{\"LanguageCode\":\"nl\",\"Text\":\"A-Klasse FCI-CACIL\"},{\"LanguageCode\":\"fr\",\"Text\":\"A-Class FCI-CACIL\"},{\"LanguageCode\":\"de\",\"Text\":\"A-Klasse FCI-CACIL\"}]" },
                    { new Guid("9c7865eb-56de-4dd8-8491-2161649d3aaf"), 2, "O", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("c37f460f-e121-433f-8b4e-a04c9b8498e6"), "[{\"LanguageCode\":\"en\",\"Text\":\"Open CSS\"},{\"LanguageCode\":\"nl\",\"Text\":\"Open CSS\"},{\"LanguageCode\":\"fr\",\"Text\":\"Ouverte CSS\"},{\"LanguageCode\":\"de\",\"Text\":\"Open CSS\"}]" },
                    { new Guid("c730ba8c-4d8c-46fd-bdf9-207963321bd6"), 2, "A", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("ca9590ff-1714-4d98-8ee1-fc7bcbc1b836"), "[{\"LanguageCode\":\"en\",\"Text\":\"A-Class CSS\"},{\"LanguageCode\":\"nl\",\"Text\":\"A-Klasse CSS\"},{\"LanguageCode\":\"fr\",\"Text\":\"A-Class CSS\"},{\"LanguageCode\":\"de\",\"Text\":\"A-Klasse CSS\"}]" },
                    { new Guid("d32848b7-4cea-4201-958d-6578a0019950"), 2, "B", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("ce6d34b8-d832-4308-a163-cd97e82fce43"), "[{\"LanguageCode\":\"en\",\"Text\":\"B-Class CSS\"},{\"LanguageCode\":\"nl\",\"Text\":\"B-Klasse CSS\"},{\"LanguageCode\":\"fr\",\"Text\":\"B-Class CSS\"},{\"LanguageCode\":\"de\",\"Text\":\"B-Klasse CSS\"}]" },
                    { new Guid("f9afdb87-b524-4356-9743-ebb38144aaf6"), 1, "C", new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"), new Guid("3e9108a4-d235-44ef-b0fb-92e8d5e16878"), "[{\"LanguageCode\":\"en\",\"Text\":\"C-Class FCI-CACIL\"},{\"LanguageCode\":\"nl\",\"Text\":\"C-Klasse FCI-CACIL\"},{\"LanguageCode\":\"fr\",\"Text\":\"C-Class FCI-CACIL\"},{\"LanguageCode\":\"de\",\"Text\":\"C-Klasse FCI-CACIL\"}]" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: new Guid("0a7100b9-a371-475e-843d-5681d4123320"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: new Guid("75cc3997-7d8b-4ac3-b46c-f1ca12d6a060"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: new Guid("a55714d4-a40a-4f2a-9d68-282bbadecb46"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: new Guid("ceea56e8-6193-4541-b760-89af6f762a4a"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "ID",
                keyValue: new Guid("fe8ac32b-10fd-43af-ac29-c8749af9ecb0"));

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("02b86e36-0ccd-435b-b665-6c7b2b246244"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("0b50ff12-d15f-4995-9f0f-4b21e96f862b"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("1ec110cc-7f70-4060-93ef-58727fcbaeb9"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("2bb65b3a-0d1c-4d8e-aa2d-1648358df96c"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("33bbe8c5-d286-4e45-91a0-0ec52cdea9c8"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("3a366646-a678-4706-a7eb-9eb1cc1b4961"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("42ac8b3a-bbfb-4243-b104-d608efdcf7b4"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("453abb88-6912-42c2-9f77-90582d1d467f"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("4e469cfa-b1f1-452a-b983-70a803aad06c"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("59bec42e-a9b1-44b4-bf6c-57566d8cf8bb"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("5e04bdaf-a785-456b-a18e-cc4922a1e776"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("677f5efc-e697-4e8d-9ffe-ddf61394d595"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("6786b78b-611e-430a-a589-65df5c302e11"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("72a99b45-1069-4576-ae00-242b563c6bad"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("7f991e29-2e61-48e7-b97a-50f90a573cac"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("a52bcb82-9d9d-41a7-ad2d-f1b037e937a3"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("b64afe74-5fc1-4d42-bb9c-f2fdd65e90a7"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("c1d0390a-a688-498e-a1f1-782ed18b2787"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "AgeRestrictions",
                keyColumns: new[] { "BreedID", "CompetitionID" },
                keyValues: new object[] { new Guid("d670c778-a372-455b-9570-05a1fc330023"), new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6") });

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("20dff530-754d-46ed-9cdc-69080a683b22"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("3a1b3c22-c1c6-44d7-9608-39fbe92480e7"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("3a22b699-3489-4749-b766-b2c63275068e"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("4fe73b6e-3041-41dd-800d-785221165c71"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("809d7d3a-4ba2-4b89-acf6-50735199fda2"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("827c18c9-8d10-4cca-915f-61699560a5ea"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("9c7865eb-56de-4dd8-8491-2161649d3aaf"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("c730ba8c-4d8c-46fd-bdf9-207963321bd6"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("d32848b7-4cea-4201-958d-6578a0019950"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("f9afdb87-b524-4356-9743-ebb38144aaf6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("0088049b-c496-43f1-b6a6-5abc8e2762bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("01ea759e-57f0-4dc9-9817-504d06b864d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("024d4f47-56d4-4267-a298-bd54d6f80634"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("0426a22d-45d2-4341-9b03-9532b07e5a86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("08387049-6564-4c12-b882-14001f383f43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("0a258ac6-6730-459e-ba76-6dbedec19339"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("0b4c2720-07b9-456e-bf80-39c77e9b7ee2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("0de606db-21c0-4bb1-bc40-fc2b1cc088a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("10795cac-9d91-41c2-b5d0-658b02b07f95"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("10b94735-2a5c-4994-9462-1c5227a5f84a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("128d4b8b-cac9-4349-a8c9-a17ca4839d1b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("1836bce0-c94b-40f3-81d7-21edc7e9a74e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("189b5ec1-8edd-4d3f-9e94-9a37d9c7fa68"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("1a6629f0-3df6-4f4d-9366-652d7babc3eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("1b977d51-4832-493d-b163-7d3188777cc8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("1df4a070-d82a-4fab-9c24-61ab6014ed75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("1e368542-5666-4cda-a572-e177f2408d26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("1e6a616f-d9f5-4744-947b-8e37839ebfa2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("22fde9e8-1192-4c27-908f-f1a3732fedcf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("2335932d-decc-46ae-a4e0-066e1b7756c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("238fd90f-b7a7-4134-a1fb-8a717f8f1bb9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("26a0c02f-fd03-4066-a0bf-2ada5e3345bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("27e1b987-a017-4519-bdf6-2652420f9b37"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("27fa03e1-3386-4f68-8bf7-8360224d3c23"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("2ca4ab2c-cd60-475b-ad4f-131970200e2c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("2eb24fab-b67a-405a-a4a4-a82b471203f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("2f00e5f7-9825-4135-bb46-b819136e5555"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("2faa60f0-3823-4016-9b81-3ca8683223c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("2fb9d022-96d0-4c19-919f-3f368fdce39a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("3063a56e-3633-4fcb-b11a-41e138b7d91f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("32cb7e58-c98b-4ab3-8923-6952d4326970"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("340b58e3-0e57-42ab-92ca-7a774902fbf3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("35c08100-ede7-4970-ba51-eb5b1168e71d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("360e18bd-6832-4fb6-bd06-381a8cf17d36"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("37f0d470-847e-4f5b-9ebb-193288a58708"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("382959c4-e338-431f-8347-23f442f9a499"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("3aaa355a-22cb-4f64-a8bd-836e6c8f0768"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("3bc08968-5503-4b68-9342-81fcca0c6b63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("3e5bae0b-6c7f-4b1f-a80b-4f77df42483c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("3fce84d1-bcff-4c3a-afd5-a52e98a7d95f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("4404a755-535c-4723-9c12-adb52dd267e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("4409e415-5916-4401-bdd4-18f95552e757"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("4440fc3c-eb2e-4423-8dd7-086f31a596cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("458e4b31-3f55-4def-9fea-8080acfc17ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("45e5153a-9c30-4951-a724-1326e549e420"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("47101e8f-234e-4f58-9aa7-ccfad2f77a1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("4b6bd9f1-f806-4571-bcd7-73851542ca25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("4b8dd925-23e9-4606-a687-0ca0e564a058"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("4ccc1c73-4e7e-48aa-9850-8ddcbf58a34b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("4dfca244-8c66-40b0-82bc-7076542ad027"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("50abe28e-6664-43b7-956c-f12be24b7811"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("512f874e-6379-4f77-878b-75ad565a10ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("525c2d6b-c2da-49e9-a351-69af276813a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("53724950-d2f6-401f-b40b-72e0df1f6552"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("5372fdaa-99ea-40a6-9ff2-fba37e6c55ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("54985a37-0ef9-46db-8e70-cfc4325e2ecf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("55fec7e8-93b9-4f79-8c61-342f6ca28855"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("589f9ee4-3750-4370-a27c-6508670848c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("5d47bf68-8a66-4456-99b3-e93268e7278b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("5ffa6c6e-8835-4237-824b-96deea84cc4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("61060a1e-8565-417a-beea-2212562384ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("636a4461-f0f8-4538-9c9f-5f8fb826d9f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("6465214d-59d3-43b8-a4be-551c97580858"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("66fe58a6-a1ec-43db-84fe-1e88fddbe01f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("692bff96-9a0a-4ebb-bf3c-4700cbb43472"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("69369bee-72ff-45c3-9d93-aaf728ccd7b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("698fd329-ebba-408f-95c0-6b2ebf18bb76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("69ce0187-9aad-4904-b2e1-ac999485b4c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("69e8f68b-4845-4cc3-a710-12887fd7e8de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("6a4bbb0a-f7ae-4c29-8dc8-3ac049e2df4e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("6a779a8b-003f-4a05-9876-6d7f2c3ba060"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("6b2325c8-9f2b-40c7-a1bd-9d022e51522b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("6c8032d8-384f-44b2-a2a2-864003ceadba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("71439aa6-1a20-4373-b368-c44dd833fedb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("71fba808-d9b6-4ab2-a2e4-5411bac561e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("72470cdc-b05b-4d01-a835-7259ef29a9fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("728a9808-27f0-4d1c-b933-f5ff10a3f5d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("72dc83bc-6f5c-4adc-a226-03caa8a3cb33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("754c4dc7-779e-457c-a5ea-eb44156431ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("7b2893f9-3a38-4b4b-a1af-24c3351ad5ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("7b6191c2-dc99-4a28-b7c2-6646ab4db166"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("7c6cf509-7148-4ab2-9aa6-afc1061adf49"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("7cad010a-2901-4172-b532-6babdec346be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("7cb33a38-e968-4a9d-a0f2-37f89c8b6d6a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("7d0f5947-fd33-46f4-b57e-4a1a910c0b77"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("7d4fd8ee-ba53-430d-b79d-14a6c0cac865"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("812664ae-daba-492f-a571-9694f4ff46f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("81ed0a51-bc59-49dd-850c-4d85e0e74945"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("820f90bc-2670-43e6-b4bc-dc543a9b6dda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("84305281-52dc-4a09-b9be-318920adab26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("867d3cbc-c8e9-45e1-9b64-60968bf9c828"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("874b4262-cd0b-4498-aad7-58987a270ad7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("87e22dd2-fac7-43bb-97ed-7f6aba95cebe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("8a45ceef-61a3-4973-8053-b27ffbd14a10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("8bfe495d-bb0e-4819-b792-1372913f825b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("8efe5473-19a5-4109-b2d3-91c02a975209"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("926044f4-29e3-49dd-8755-3523ec024a06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("970aaf9b-7a90-4021-b942-f1b73c1812f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9750618f-9644-4b3b-9235-ae27b86dd82d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("98c804b8-442a-4c47-a1d8-53cc23ad1b26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("98f990e4-d4d6-4f6c-9684-b3bd9b8d3771"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9bc93d03-6c4e-4b76-9ca2-1ed7a6b5c743"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9c678bd9-8cb8-48d4-bf3c-094b5f20d718"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9c870b2c-fce6-401d-abbf-385f07efc55d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9cbe6d4f-ef9e-4ca0-a18c-cdbdda840267"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9d23bb42-ee31-409b-90c2-0a5ab88485f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9d7f4e5c-90b2-42ca-973e-5360021ce1cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("9dfdaac8-f10c-4e5d-ab83-5a972338e8d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a06867e9-6999-4664-ad17-c72a436264dc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a09e426c-3fd3-4295-aac7-f02376b55427"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a31edeba-bf50-4bb5-888c-accf7c1d7abe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a54bab81-9678-4992-ad04-aa18c87120c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a5c3d0a4-ef39-4b78-a5d3-061679991010"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a6461b00-6f3f-45f6-90f6-765b898eeee6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a66c6b3c-d42b-4222-a80b-241111d41c91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a6978482-b773-45ab-9460-b46ce81a4808"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a89db47f-c03d-4766-866a-f1a7507bc38f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("a9df6d05-7a19-4a1e-980b-081247ffaabe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("aafb8c3d-c285-4b1f-9969-c005ea01b43a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ab096653-13ee-402d-9dc2-3563c775105e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ab9803dc-81c9-4f40-ab6d-88afa03ca3ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ac1fc25d-ba93-4ffc-8f90-80f3acf39fe1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ae568287-2dae-4c3c-bada-fd10064397c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("aefcace9-48d4-41a3-be3b-2047a9a50797"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b1cb9a3a-6a81-4979-8c28-4e5715dd562f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b272a659-8ead-4951-98e2-06f3225f182e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b2d673e9-8749-4e2c-8f41-f723d93b0d71"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b338193d-ab3f-48dc-825f-4a69d8af8b3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b5ca2166-5cfd-4449-bcb8-1112fe2a850c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b62995e3-1ec7-4655-a3a8-e865181b3f2c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b6d3aef8-defe-4dd1-9b19-fbf68e7bde01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b87b82ab-72a4-4d3f-8b36-2869096187f7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b882edc8-3799-4592-a4db-0c785a8ec9f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b97fed10-bcbc-4653-8d2a-76e8c85b826a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("b981d442-5509-43a2-b3a1-affa64972664"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("bb33a24b-0498-4e86-b5bf-a0a73b066d42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("bc4a3e7f-1c47-47f1-b881-0d671564fd4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("bdf9e765-e93b-4308-ad06-3238bc009833"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("bf1f1a38-1904-4b87-ab5c-4888dd2e24f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("bf29f7ca-0da0-4b9a-9423-a78e26b0bcef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("bf78508b-5679-4b91-8958-efa23ad055c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c0084b10-3755-44cf-8552-5d2d8269ecac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c0559341-609b-48ce-8406-1a305c227689"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c0629d48-da5f-43c1-be22-1cd02c417a7b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c0fa519d-c094-4f9a-89d6-12e14a52a2b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c284464a-4175-425f-bd6c-5afe9a4c5f4a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c3152ad1-5190-4dec-9ff8-6d91cb5a66c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c3bde949-09f9-47d7-99e2-1897b71290f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c6c176bd-8704-4739-8cd0-2750369167be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c6d7509d-fec0-4cb3-b03d-4b8bd72b8fcf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c80c294a-3f5e-41ad-ab88-f9efef59b167"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c90c38cf-7408-4d17-a976-30d3d7cfd80c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("c9763d47-df87-43fb-a940-bc4dfa350ca8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ca50adbc-6613-489f-8da1-2bbc6846867b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("caabca5c-597f-4ad8-a93c-56f095c7f096"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("cb872447-babe-4542-9b17-9675148e52bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("cbae60f0-2d5c-4128-bbfd-3e90723f2826"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("cbc2c59c-8479-4568-ab97-5a6ac02e6dff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("cdcf33fb-e869-4499-af7f-3673ab1e8d45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("d07c2307-e98c-4b30-ad77-e7e1ca617eab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("d1aa5ed9-a10e-4046-a00c-939298d9d0f4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("d99823ef-9bbf-404a-9f12-72217dc66a20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("da5a4d8b-917d-4e70-b500-b21ed772609f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("daec9832-78f3-4351-b1c1-f87311f37669"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("db4a240b-d8f8-4684-bf18-808fa051b965"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("dd5f860f-9d88-4253-8b82-878bd8287a84"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("de4d22ed-1945-46ab-a21d-c7a467b428c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("df097ee1-7b51-49e5-919f-a065617025f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("df6f5842-00ee-4ab4-8a8e-a892b22658f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("dfa91655-2ee8-4413-be84-ff591051efdd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("e1eda6da-b9fc-4a7b-8c97-86fdff05ea0c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("e22e68cc-f3be-43af-918c-1c177fcaa595"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("e42e318a-026b-4008-a775-6949a99a1eff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("e4d020a4-9cb4-400f-9a11-576ed7062362"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("e624c6e2-4937-4422-a083-d502c772859c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("e6e6b40d-2d78-4f35-90d5-fc5ac28a5cbd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("e7584eea-f033-4f5a-a609-b5ce29ade267"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("e89f370f-b87b-4234-a392-42e4ff43deb1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ea4d1817-9b1c-4f24-bcde-2940737a5a5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ec3c1b33-4c55-4b4a-8f4e-c49ccd0a89c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ec4ebc6a-a4c1-4897-b793-f17c93e173e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ed554a7b-bce3-4a10-bf4b-a113a71533c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ee1830f5-68fc-4e6b-83d3-f224c8f076d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("f0270845-1810-40f1-b3ac-bf111c42892d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("f3edc011-9a2f-4ad4-8c00-2193bd4d5f49"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("f4537bb4-c120-4f5c-ac8d-7157e6988fd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("f522dcd6-6129-40b9-8265-8015696ffbae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("f725e114-c733-4bb4-ba24-57a5758355db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("f992c83b-0ca4-45aa-bb41-bf740ee53610"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("f9955c31-d822-41ea-89a6-5907e360b3e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("fbb84182-c3f1-422e-b98f-ca09e8ad0d69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("fbbad9a4-d3a2-4ec7-8ad1-8137fdbd59eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("fbda5250-10dd-4ae4-9c33-169d5e22ea20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("fe45a47f-0bb4-4132-aa0e-cc73e7284d2a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("fe9c3c1b-3425-43be-8203-b081d7951f9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ff464088-9616-43ed-9b1b-38f302edc8ee"));

            migrationBuilder.DeleteData(
                table: "CrewTypes",
                keyColumn: "ID",
                keyValue: new Guid("153d2723-5769-4a03-a496-0a65b461dcf3"));

            migrationBuilder.DeleteData(
                table: "CrewTypes",
                keyColumn: "ID",
                keyValue: new Guid("2eb77547-e033-4595-bae7-f82f6efa58ac"));

            migrationBuilder.DeleteData(
                table: "CrewTypes",
                keyColumn: "ID",
                keyValue: new Guid("40c6a00d-11be-422f-8470-90aa8894d7ec"));

            migrationBuilder.DeleteData(
                table: "CrewTypes",
                keyColumn: "ID",
                keyValue: new Guid("5af3404e-403d-4a03-b258-e49ba035ddad"));

            migrationBuilder.DeleteData(
                table: "CrewTypes",
                keyColumn: "ID",
                keyValue: new Guid("bc32177b-1649-44a9-b55a-66486c586674"));

            migrationBuilder.DeleteData(
                table: "CrewTypes",
                keyColumn: "ID",
                keyValue: new Guid("e1a12ebd-8a70-44fd-973d-b2ee5feba09f"));

            migrationBuilder.DeleteData(
                table: "CrewTypes",
                keyColumn: "ID",
                keyValue: new Guid("f7dfa36a-bd7d-468e-aba1-0a9171d67af7"));

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "ID",
                keyValue: new Guid("197a1b1b-077c-460b-b235-0d2136df18d1"));

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "ID",
                keyValue: new Guid("440f210c-e1f0-4aa1-9ac8-71e5cdc6b214"));

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "ID",
                keyValue: new Guid("4ca3bc50-8eab-4b6e-a62f-6eb549bc5a9e"));

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "ID",
                keyValue: new Guid("8cf38bf9-6e49-45ca-a5bf-41367413b979"));

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "ID",
                keyValue: new Guid("aa13072d-7b03-4f77-baee-7db5b76aa524"));

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "ID",
                keyValue: new Guid("bfe7b982-d7a0-4622-90c3-7bddae99a01d"));

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "ID",
                keyValue: new Guid("d9ae6e63-1eb3-4c53-ab2c-94471e183120"));

            migrationBuilder.DeleteData(
                table: "Jerseys",
                keyColumn: "ID",
                keyValue: new Guid("04446811-485d-4c1b-a759-40f372983b08"));

            migrationBuilder.DeleteData(
                table: "Jerseys",
                keyColumn: "ID",
                keyValue: new Guid("23b3c4e1-51ab-44f3-b40a-8c4bead40636"));

            migrationBuilder.DeleteData(
                table: "Jerseys",
                keyColumn: "ID",
                keyValue: new Guid("834db893-4d73-4142-aac8-8beb0b334bff"));

            migrationBuilder.DeleteData(
                table: "Jerseys",
                keyColumn: "ID",
                keyValue: new Guid("935cfa45-62d1-483d-8dd3-5264b57b7f09"));

            migrationBuilder.DeleteData(
                table: "Jerseys",
                keyColumn: "ID",
                keyValue: new Guid("c2c8dd39-e395-468b-8be9-90580013c659"));

            migrationBuilder.DeleteData(
                table: "Jerseys",
                keyColumn: "ID",
                keyValue: new Guid("f5570613-57c4-423b-b45f-c87f03995099"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("0f1d7a6a-1a39-4cec-bbde-cdf640110838"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("184f350a-12d7-413b-a582-7dec0493eee0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("1a45dcb1-94e9-4d29-8cb0-aaa47cd702a7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("23b9a00e-a261-4fac-aa4b-8d9db81bee44"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("2f815813-93af-406b-ba6f-7103df25edd7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("3995e0c7-c3ee-4ea3-84c2-d35e93b51c9e"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("3d0cd848-b194-47e4-8602-a37af4c91cc3"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("417db2b0-e4db-481b-ae4f-c9f256dee6f2"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("66fa4291-0b61-4d7b-96c7-ef5aefe3669e"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("68cb6204-2bc9-4f0c-b5d5-7dac9d2e8a80"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("68fd9eb7-87b5-4e3b-99d3-8681ebe4f31a"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("8e65746b-b206-444a-9584-4d354ea72eb1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("96c6e3be-81fb-4788-af8e-11e3054d1269"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("a1c3c927-8fd9-4c03-ab14-10e4a2f50c0e"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("a5db799b-b67c-481f-b9c1-0497c55b05b6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("aa8c88a7-c083-4fb2-acae-616a8b853011"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("b547ac64-2e43-4293-9a8e-c253927f5280"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("b59548e3-d2ce-471e-9763-63606a7d8f22"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("b86e859e-693b-4dc5-ac56-5f7ed7e88841"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("c0b4cae0-ecca-4213-ad88-ff38d19a537c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("c5b79b83-af19-45ce-8347-3e4052f4e367"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("cd273eb2-5159-4ab0-862a-1491085cb7fd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("e16269be-fbcb-4813-8ee0-6d496a78dfef"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("e2f328b0-2e42-4a2e-b73b-f8b39d500622"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "ID",
                keyValue: new Guid("f849ff9c-080f-4eb1-b286-a16b6cca58b8"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("14e7f603-92d6-437b-b93d-56300c5a4d92"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("3b6dd69c-8903-4df4-bc04-34ed8802bfb5"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("5a6454fe-9bbe-4aa8-be8d-1937d61a29fc"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("63114685-c48a-4f44-a910-8c6979b5b687"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("6b10b543-db0d-423d-b597-0c5c2b5b2fd4"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("88ddfaf8-a5a4-4212-935e-bed616972426"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("8ca11bbb-ce66-4b79-95d9-ee0ac650561e"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("d64d05a6-eabc-4820-9011-047fdded0a84"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("d7625773-fe4b-46a0-a2c6-5f3b3caf64e9"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("e72d9dfb-0e30-4e37-96f8-3dc002ea963d"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("ee86bfca-4c3f-437e-84c2-60d236573059"));

            migrationBuilder.DeleteData(
                table: "RaceTypes",
                keyColumn: "ID",
                keyValue: new Guid("f5f7a330-213d-4843-80da-61be75d400e8"));

            migrationBuilder.DeleteData(
                table: "RunResultTypes",
                keyColumn: "ID",
                keyValue: new Guid("04af5196-9108-432d-b9d0-6a6ee540ed16"));

            migrationBuilder.DeleteData(
                table: "RunResultTypes",
                keyColumn: "ID",
                keyValue: new Guid("6ed4bd7d-ef60-4528-9d71-e4915d810a04"));

            migrationBuilder.DeleteData(
                table: "RunResultTypes",
                keyColumn: "ID",
                keyValue: new Guid("b5f052cf-2818-4a58-8c57-01abb088b04b"));

            migrationBuilder.DeleteData(
                table: "RunResultTypes",
                keyColumn: "ID",
                keyValue: new Guid("dbe4699a-3b22-4dd1-b86b-ab44bb600cfb"));

            migrationBuilder.DeleteData(
                table: "RunResultTypes",
                keyColumn: "ID",
                keyValue: new Guid("f5eea2b5-c69b-49f3-9f54-b5b9876ab6b4"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "ID",
                keyValue: new Guid("3eb13e00-2006-40bd-a15f-aecb206a5c72"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "ID",
                keyValue: new Guid("818ff154-7208-4f28-880e-19f48ccb94ad"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "ID",
                keyValue: new Guid("83b150fe-89c0-4fe2-947e-18198244963f"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("02b86e36-0ccd-435b-b665-6c7b2b246244"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("0b50ff12-d15f-4995-9f0f-4b21e96f862b"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("1ec110cc-7f70-4060-93ef-58727fcbaeb9"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("2bb65b3a-0d1c-4d8e-aa2d-1648358df96c"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("33bbe8c5-d286-4e45-91a0-0ec52cdea9c8"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("3a366646-a678-4706-a7eb-9eb1cc1b4961"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("42ac8b3a-bbfb-4243-b104-d608efdcf7b4"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("453abb88-6912-42c2-9f77-90582d1d467f"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("4e469cfa-b1f1-452a-b983-70a803aad06c"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("59bec42e-a9b1-44b4-bf6c-57566d8cf8bb"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("5e04bdaf-a785-456b-a18e-cc4922a1e776"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("677f5efc-e697-4e8d-9ffe-ddf61394d595"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("6786b78b-611e-430a-a589-65df5c302e11"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("72a99b45-1069-4576-ae00-242b563c6bad"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("7f991e29-2e61-48e7-b97a-50f90a573cac"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("a52bcb82-9d9d-41a7-ad2d-f1b037e937a3"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("b64afe74-5fc1-4d42-bb9c-f2fdd65e90a7"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("c1d0390a-a688-498e-a1f1-782ed18b2787"));

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "ID",
                keyValue: new Guid("d670c778-a372-455b-9570-05a1fc330023"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("3b204fbf-a1a7-43d2-8b41-a2aa310b29be"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("3e9108a4-d235-44ef-b0fb-92e8d5e16878"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("c37f460f-e121-433f-8b4e-a04c9b8498e6"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("ca9590ff-1714-4d98-8ee1-fc7bcbc1b836"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ID",
                keyValue: new Guid("ce6d34b8-d832-4308-a163-cd97e82fce43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("0afec050-198a-4248-b736-e5bd611550a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("21d61853-43c2-422f-993b-ef96fa75afea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: new Guid("ade8e58e-f037-48aa-8fae-5bedcb6ad0d8"));

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "ID",
                keyValue: new Guid("64b11d35-97fc-4223-82da-23e09bec1bd6"));
        }
    }
}
