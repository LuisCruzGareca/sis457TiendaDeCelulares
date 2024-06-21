using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTiendaCelulares.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__categori__3213E83FD9A82C6C", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "colores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__colores__3213E83FB0CA302D", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    password = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    nombre = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usuarios__3213E83F189C6714", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "celulares",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "(sysdatetime())"),
                    fecha_modificacion = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "(sysdatetime())"),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    marca = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    modelo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    idColor = table.Column<int>(type: "int", nullable: true),
                    idCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__celulare__3213E83FD7733505", x => x.id);
                    table.ForeignKey(
                        name: "FK_celulares_categorias",
                        column: x => x.idCategoria,
                        principalTable: "categorias",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_celulares_colores",
                        column: x => x.idColor,
                        principalTable: "colores",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "compras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion_envio = table.Column<string>(type: "text", nullable: false),
                    total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    fecha_venta = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "(sysdatetime())"),
                    id_usuario = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    idCelular = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__compras__3213E83F8AFA8E1D", x => x.id);
                    table.ForeignKey(
                        name: "FK__compras__id_usua__4AB81AF0",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_compras_celulares",
                        column: x => x.idCelular,
                        principalTable: "celulares",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_celulares_idCategoria",
                table: "celulares",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_celulares_idColor",
                table: "celulares",
                column: "idColor");

            migrationBuilder.CreateIndex(
                name: "IX_compras_id_usuario",
                table: "compras",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_compras_idCelular",
                table: "compras",
                column: "idCelular");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compras");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "celulares");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "colores");
        }
    }
}
