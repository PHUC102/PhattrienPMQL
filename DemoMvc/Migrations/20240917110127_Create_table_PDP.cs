using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_PDP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PDP",
                columns: table => new
                {
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Hight = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDP", x => x.FullName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PDP");
        }
    }
}
