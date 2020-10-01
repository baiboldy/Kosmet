using Microsoft.EntityFrameworkCore.Migrations;

namespace Kosmetica.Migrations
{
    public partial class add_files_to_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "File",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_File_ProductId",
                table: "File",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_File_Product_ProductId",
                table: "File",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_File_Product_ProductId",
                table: "File");

            migrationBuilder.DropIndex(
                name: "IX_File_ProductId",
                table: "File");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "File");
        }
    }
}
