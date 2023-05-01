using Microsoft.EntityFrameworkCore.Migrations;

namespace CPU.Migrations
{
    public partial class aresegatrugnimolq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SerieId",
                table: "CPUs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeriesId",
                table: "CPUs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_SerieId",
                table: "CPUs",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_CPUs_Series_SerieId",
                table: "CPUs",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPUs_Series_SerieId",
                table: "CPUs");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropIndex(
                name: "IX_CPUs_SerieId",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "SerieId",
                table: "CPUs");

            migrationBuilder.DropColumn(
                name: "SeriesId",
                table: "CPUs");
        }
    }
}
