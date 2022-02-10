using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

#nullable disable

namespace HylianRIS_API.Migrations
{
    public partial class CreateIsSimilarFunctions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var dirBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Migrations");
            migrationBuilder.Sql(File.ReadAllText(Path.Combine(dirBase, @"CreateIsSimilarFunctions.sql")));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var dirBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Migrations");
            migrationBuilder.Sql(File.ReadAllText(Path.Combine(dirBase, @"DropIsSimilarFunctions.sql")));
        }
    }
}
