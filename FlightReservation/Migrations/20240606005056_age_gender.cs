using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightReservation.Migrations
{
    /// <inheritdoc />
    public partial class age_gender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerAge",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerAge",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Reservations");
        }
    }
}
