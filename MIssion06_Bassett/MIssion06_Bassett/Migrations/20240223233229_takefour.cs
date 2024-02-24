using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIssion06_Bassett.Migrations
{
    /// <inheritdoc />
    public partial class takefour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_categoryID",
                table: "Movies");

            migrationBuilder.AlterColumn<string>(
                name: "rating",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "director",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "categoryID",
                table: "Movies",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_categoryID",
                table: "Movies",
                column: "categoryID",
                principalTable: "Categories",
                principalColumn: "categoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_categoryID",
                table: "Movies");

            migrationBuilder.AlterColumn<string>(
                name: "rating",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "director",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryID",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_categoryID",
                table: "Movies",
                column: "categoryID",
                principalTable: "Categories",
                principalColumn: "categoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
