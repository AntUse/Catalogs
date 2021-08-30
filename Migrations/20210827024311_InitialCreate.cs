using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalogs.Migrations
{
    //this class was automatically created using the migration syntax using the add-migration 'name of migration' in our case is initialcreate
    // to finalize the database creation use the update-database 
    // this is to create a database if database is not existing before creating the app project
    //it pulls table and data structure as specified from the appdbcontext class
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemsTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsTable");
        }
    }
}
