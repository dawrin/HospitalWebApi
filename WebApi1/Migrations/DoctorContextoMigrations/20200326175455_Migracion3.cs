using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi1.Migrations.DoctorContextoMigrations
{
    public partial class Migracion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellidos = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Expericencia = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorItem", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorItem");
        }
    }
}
