using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarefas.Repository.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    data_criacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 3, 20, 16, 43, 11, 206, DateTimeKind.Local).AddTicks(2543)),
                    excluido = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_recurso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    tipo_recurso = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_criacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 3, 20, 16, 43, 11, 237, DateTimeKind.Local).AddTicks(4419)),
                    excluido = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_recurso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    data_criacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 3, 20, 16, 43, 11, 272, DateTimeKind.Local).AddTicks(4396)),
                    excluido = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_tarefa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    categoria_id = table.Column<int>(type: "int", nullable: false),
                    usuario_id = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    data_criacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 3, 20, 16, 43, 11, 246, DateTimeKind.Local).AddTicks(7962)),
                    excluido = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tarefa", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_tarefa_tb_categoria_categoria_id",
                        column: x => x.categoria_id,
                        principalTable: "tb_categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_tarefa_tb_usuario_usuario_id",
                        column: x => x.usuario_id,
                        principalTable: "tb_usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_tarefa_recurso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarefa_id = table.Column<int>(type: "int", nullable: false),
                    recurso_id = table.Column<int>(type: "int", nullable: false),
                    favorito = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    data_criacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 3, 20, 16, 43, 11, 269, DateTimeKind.Local).AddTicks(5794)),
                    excluido = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tarefa_recurso", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_tarefa_recurso_tb_recurso_recurso_id",
                        column: x => x.recurso_id,
                        principalTable: "tb_recurso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_tarefa_recurso_tb_tarefa_tarefa_id",
                        column: x => x.tarefa_id,
                        principalTable: "tb_tarefa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_tarefa_categoria_id",
                table: "tb_tarefa",
                column: "categoria_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tarefa_usuario_id",
                table: "tb_tarefa",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tarefa_recurso_recurso_id",
                table: "tb_tarefa_recurso",
                column: "recurso_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tarefa_recurso_tarefa_id",
                table: "tb_tarefa_recurso",
                column: "tarefa_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_tarefa_recurso");

            migrationBuilder.DropTable(
                name: "tb_recurso");

            migrationBuilder.DropTable(
                name: "tb_tarefa");

            migrationBuilder.DropTable(
                name: "tb_categoria");

            migrationBuilder.DropTable(
                name: "tb_usuario");
        }
    }
}
