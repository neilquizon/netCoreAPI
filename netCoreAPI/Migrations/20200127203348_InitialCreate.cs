﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netCoreAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotToDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    IsComplete = table.Column<bool>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotToDos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    IsComplete = table.Column<bool>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NotToDos",
                columns: new[] { "Id", "CreatedOn", "Description", "IsComplete", "Priority" },
                values: new object[] { 2, new DateTime(2020, 1, 27, 12, 33, 47, 729, DateTimeKind.Local).AddTicks(4925), "Clean house", true, 1 });

            migrationBuilder.InsertData(
                table: "NotToDos",
                columns: new[] { "Id", "CreatedOn", "Description", "IsComplete", "Priority" },
                values: new object[] { 3, new DateTime(2020, 1, 27, 12, 33, 47, 729, DateTimeKind.Local).AddTicks(4938), "Bake cake", false, 3 });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "CreatedOn", "Description", "IsComplete", "Priority" },
                values: new object[] { 1, new DateTime(2020, 1, 27, 12, 33, 47, 726, DateTimeKind.Local).AddTicks(6949), "Sleep", true, 1 });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "CreatedOn", "Description", "IsComplete", "Priority" },
                values: new object[] { 2, new DateTime(2020, 1, 27, 12, 33, 47, 729, DateTimeKind.Local).AddTicks(2614), "Sing", false, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotToDos");

            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}
