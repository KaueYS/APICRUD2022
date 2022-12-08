﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    public partial class PreencherCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categorias(Nome, ImagemUrl) Values('Bebidas','bebidas.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome, ImagemUrl) Values('Lanches','lanches.jpg')");
            migrationBuilder.Sql("Insert into Categorias(Nome, ImagemUrl) Values('Sobremesas','sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}
