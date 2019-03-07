using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganoPlenoApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organ",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organ", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Console",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Made = table.Column<string>(nullable: true),
                    OrganID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Console", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Console_Organ_OrganID",
                        column: x => x.OrganID,
                        principalTable: "Organ",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    OrganID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Division_Organ_OrganID",
                        column: x => x.OrganID,
                        principalTable: "Organ",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pipe",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    Specification = table.Column<int>(nullable: false),
                    Material = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    DivisionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pipe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pipe_Division_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Division",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Console_OrganID",
                table: "Console",
                column: "OrganID");

            migrationBuilder.CreateIndex(
                name: "IX_Division_OrganID",
                table: "Division",
                column: "OrganID");

            migrationBuilder.CreateIndex(
                name: "IX_Pipe_DivisionID",
                table: "Pipe",
                column: "DivisionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Console");

            migrationBuilder.DropTable(
                name: "Pipe");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "Organ");
        }
    }
}
