﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Education_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Education_ID);
                });

            migrationBuilder.CreateTable(
                name: "Otdels",
                columns: table => new
                {
                    Otdel_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Telephone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otdels", x => x.Otdel_ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Position_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PositionName_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Oklad = table.Column<int>(type: "INTEGER", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Position_ID);
                });

            migrationBuilder.CreateTable(
                name: "Sotruds",
                columns: table => new
                {
                    Sotrud_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Otdel_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Otdel_ID1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Position_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Position_ID1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Education_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Education_ID1 = table.Column<int>(type: "INTEGER", nullable: true),
                    F_Name = table.Column<string>(type: "TEXT", nullable: true),
                    L_Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sotruds", x => x.Sotrud_ID);
                    table.ForeignKey(
                        name: "FK_Sotruds_Educations_Education_ID1",
                        column: x => x.Education_ID1,
                        principalTable: "Educations",
                        principalColumn: "Education_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sotruds_Otdels_Otdel_ID1",
                        column: x => x.Otdel_ID1,
                        principalTable: "Otdels",
                        principalColumn: "Otdel_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sotruds_Positions_Position_ID1",
                        column: x => x.Position_ID1,
                        principalTable: "Positions",
                        principalColumn: "Position_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sotruds_Education_ID1",
                table: "Sotruds",
                column: "Education_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Sotruds_Otdel_ID1",
                table: "Sotruds",
                column: "Otdel_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Sotruds_Position_ID1",
                table: "Sotruds",
                column: "Position_ID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sotruds");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Otdels");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
