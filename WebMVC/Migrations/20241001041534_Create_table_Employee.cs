using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GioiTinh",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tuoi",
                table: "Person",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Tuoi",
                table: "Person");
        }
    }
}
