using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NEGRASM.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consumidores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CPF = table.Column<string>(type: "char(11)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Telefone = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumidores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consumidores");
        }
    }
}
