using Microsoft.EntityFrameworkCore.Migrations;

namespace CommanderGQL.Migrations
{
    public partial class AddCommandToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Commands_PlatformId",
                table: "Commands",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commands_Platforms_PlatformId",
                table: "Commands",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commands_Platforms_PlatformId",
                table: "Commands");

            migrationBuilder.DropIndex(
                name: "IX_Commands_PlatformId",
                table: "Commands");
        }
    }
}
