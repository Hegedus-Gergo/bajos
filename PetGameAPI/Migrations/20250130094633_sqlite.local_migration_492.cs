using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetGameAPI.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_492 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    IngameCurrency = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Energy = table.Column<int>(type: "INTEGER", nullable: false),
                    Hunger = table.Column<int>(type: "INTEGER", nullable: false),
                    Happiness = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlayerID = table.Column<int>(type: "INTEGER", nullable: false),
                    PetName = table.Column<string>(type: "TEXT", nullable: false),
                    PetType = table.Column<int>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Happiness = table.Column<int>(type: "INTEGER", nullable: false),
                    Hunger = table.Column<int>(type: "INTEGER", nullable: false),
                    Energy = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pets_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PetID = table.Column<int>(type: "INTEGER", nullable: false),
                    ToolID = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inventories_Pets_PetID",
                        column: x => x.PetID,
                        principalTable: "Pets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventories_Tools_ToolID",
                        column: x => x.ToolID,
                        principalTable: "Tools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_PetID",
                table: "Inventories",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ToolID",
                table: "Inventories",
                column: "ToolID");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PlayerID",
                table: "Pets",
                column: "PlayerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
