using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Migrations
{
    public partial class area : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    area = table.Column<int>(nullable: false),
                    beds = table.Column<int>(nullable: false),
                    baths = table.Column<int>(nullable: false),
                    inputAddress = table.Column<string>(nullable: true),
                    inputAddress2 = table.Column<string>(nullable: true),
                    inputCity = table.Column<string>(nullable: true),
                    inputState = table.Column<string>(nullable: true),
                    inputZip = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
