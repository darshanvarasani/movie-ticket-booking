using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMovieTicketBooking.Data.Migrations
{
    public partial class forth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTable_MovieDetails_MovieDetailsId",
                table: "BookingTable");

            migrationBuilder.DropIndex(
                name: "IX_BookingTable_MovieDetailsId",
                table: "BookingTable");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BookingTable",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTable_MovieDetails_Id",
                table: "BookingTable",
                column: "Id",
                principalTable: "MovieDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTable_MovieDetails_Id",
                table: "BookingTable");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BookingTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTable_MovieDetailsId",
                table: "BookingTable",
                column: "MovieDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTable_MovieDetails_MovieDetailsId",
                table: "BookingTable",
                column: "MovieDetailsId",
                principalTable: "MovieDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
