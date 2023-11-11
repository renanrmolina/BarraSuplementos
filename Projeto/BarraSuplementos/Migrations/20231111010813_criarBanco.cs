using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarraSuplementos.Migrations
{
    public partial class criarBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destaque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Objetivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetivo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sabor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sabor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lancamento = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    QtdEstoque = table.Column<int>(type: "int", nullable: false),
                    ValorAtual = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ValorDesconto = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinho_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoObjetivo",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    ObjetivoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoObjetivo", x => new { x.ProdutoId, x.ObjetivoId });
                    table.ForeignKey(
                        name: "FK_ProdutoObjetivo_Objetivo_ObjetivoId",
                        column: x => x.ObjetivoId,
                        principalTable: "Objetivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoObjetivo_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoSabor",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    SaborId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoSabor", x => new { x.ProdutoId, x.SaborId });
                    table.ForeignKey(
                        name: "FK_ProdutoSabor_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoSabor_Sabor_SaborId",
                        column: x => x.SaborId,
                        principalTable: "Sabor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarrinhoProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CarrinhoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    SaborId = table.Column<int>(type: "int", nullable: true),
                    Qtd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoProduto", x => new { x.Id, x.CarrinhoId });
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Carrinho_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Sabor_SaborId",
                        column: x => x.SaborId,
                        principalTable: "Sabor",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67b86261-6ba0-4888-863e-c506d5ff0522", "23a8757d-06e6-4c5b-a57e-ff0c1d792d9c", "Cliente", "CLIENTE" },
                    { "90901a72-ed64-4aa6-8d34-813e48389081", "62f0e9c2-1c1a-449f-b2a3-127bb0e705ad", "Administrador", "ADMINISTRADOR" },
                    { "9b5190b6-918d-458d-9473-c4cf0fdf6ff0", "e85e4929-790a-4812-9bbb-2c03723a90aa", "Funcionário", "FUNCIONARIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "66f78b3c-cea0-47b3-a8c5-04802a596522", 0, "39c970d4-6079-4ff1-b878-d09f9fe96726", "admin@barrasuplementos.com", true, false, null, "ADMIN@BARRASUPLEMENTOS.COM", "ADMIN", "AQAAAAEAACcQAAAAELZIdDj5xiuasbSHGY4plipFhmpu0nwWAggOmXp3o/JPZ7UjFgzNF3bC0s34gNJqOg==", null, false, "9940f935-751d-42ea-b375-1e3d5376b782", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Descricao", "Destaque", "Imagem", "Nome" },
                values: new object[,]
                {
                    { 1, null, false, null, "Acessórios" },
                    { 2, "Os melhores suplementos para atingir seu objetivo de emagrecer.", true, "/img/emagrecerObjetivo_resized.jpg", "Emagrecimento" },
                    { 3, null, false, null, "Energia e Resistência" },
                    { 4, "Os melhores suplementos para atingir seu objetivo de ganho de massa.", true, "img/ganhoMassa_resized (1).jpg", "Massa Muscular" },
                    { 5, null, false, null, "Naturais" },
                    { 6, "Os melhores suplementos para para atingir seu objetivo de definição.", true, "img/hipertrofia_resized.jpg", "Pré/Pró Hormonal" },
                    { 7, null, false, null, "Vestuário" },
                    { 8, null, false, null, "Vitamas e Minerais" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, null, "Adaptogen" },
                    { 2, null, "Atlhetica Nutrition" },
                    { 3, null, "Bestronger" },
                    { 4, null, "Blackskull" },
                    { 5, null, "Darkness" },
                    { 6, null, "Dr. Peanut" },
                    { 7, null, "FTW SPORTS NUTRITION" },
                    { 8, null, "Hopper" },
                    { 9, null, "Integralmédica" },
                    { 10, null, "Max Titanium" },
                    { 11, null, "Nitromax" },
                    { 12, null, "Nutrivale" },
                    { 13, null, "Orion Supplements" },
                    { 14, null, "Puritans Pride" },
                    { 15, null, "Rock" },
                    { 16, null, "Shark Pro" },
                    { 17, null, "SUDRACT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "67b86261-6ba0-4888-863e-c506d5ff0522", "66f78b3c-cea0-47b3-a8c5-04802a596522" },
                    { "90901a72-ed64-4aa6-8d34-813e48389081", "66f78b3c-cea0-47b3-a8c5-04802a596522" },
                    { "9b5190b6-918d-458d-9473-c4cf0fdf6ff0", "66f78b3c-cea0-47b3-a8c5-04802a596522" }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "CategoriaId", "Descricao", "Imagem", "Lancamento", "MarcaId", "Nome", "QtdEstoque", "ValorAtual", "ValorDesconto" },
                values: new object[,]
                {
                    { 32, 4, "Ganhe volume e massa muscular, aumente sua força e melhore o desempenho e resistência nos seus treinos suplementando com a Creatina Hardcore Integralmédica. Produto 100% puro, de excelente qualidade.", "img/produtos/25.jpg", false, 9, "Creatina 300g - INTEGRALMÉDICA", 49, 149.90m, 0m },
                    { 268, 8, "APRESENTAÇÃO: Pote com 60 cápsulas. INGREDIENTES: Acetato de retinol, picolinato de cromo, bisglicinato de cobre, tiamina mononitrato, riboflavina, cloridrato piridoxina, cianocobalamina, ácido ascórbico, vitamina D3 (colecalciferol), acetato de tocoferol, nicotinamida, pantotenato de cálcio, sulfato de manganês, sulfato de zinco, óxido de magnésio, estabilizantes celulose microcristalina e amido de milho e antiumectante dióxido de silício.", "img/produtos/31.jpg", false, 7, "Multivitaminico 60caps - FTW", 22, 24.90m, 0m },
                    { 6098, 1, "O Strap Monster Be Stronger é um acessório essencial pra você amador e profissional da musculação, cross training, powerlifting, bodybuilding e weightlifting!", "img/produtos/3.png", true, 3, "Strap monster - BESTRONGER", 24, 69.90m, 0m },
                    { 6228, 2, "NITRO FIRE 420mg é um suplemento a base de cafeína. Sua fórmula exclusiva além de dar um ânimo de imediato e duradouro, aumenta a termogênese do atleta!", "img/produtos/9.jpg", false, 11, "Termogêmico Nitrofire 60caps - NITROMAX", 1, 65m, 0m },
                    { 6328, 1, "600ml, polipropileno (BPA), matéria-prima atóxica, livre de Bisfenol A e Ftalato (DEHP) COR: PRETA", "img/produtos/1.png", true, 4, "Coqueteleira - BLACKSKULL", 67, 19.90m, 0m },
                    { 6344, 7, "A Regata Preta Basquete Max Titanium - Edição Limitada é uma opção moderna e estilosa para quem pratica esportes, oferecendo conforto e liberdade de movimento.", "img/produtos/30.jpg", false, 10, "Camisa / Regata - MAX TITANIUM", 14, 49.90m, 0m },
                    { 6414, 5, "Nutrientes essenciais utilizados como combustíveis para as células e uma das fontes de energia, os ácidos graxos não são produzidos pelo corpo, mas são muito importantes para nosso organismo. O ômega 3 é um ácido graxo e pode ser encontrado em peixes de água fria ou suplementos alimentares de forma concentrada e pura.", "img/produtos/28.jpg", false, 2, "Ômega 3 60caps - ATLHETICA NUTRITION", 2, 39.90m, 0m },
                    { 6472, 2, "O Diabo Verde é um pré-treino em cápsulas para atletas a base de cafeína que atua no aumento da capacidade de resistência e no desempenho de exercícios físicos.", "img/produtos/7.jpg", false, 7, "Thermo CAPS 60caps - DIABO VERDE FTW", 7, 74.90m, 0m },
                    { 1006498, 4, "Proteína e Emagrecimento A proteína é um nutriente que nos traz sensação de saciedade. No emagrecimento, o lanche rico em proteína irá auxiliar o controle da ingestão entre as refeições. Para quem visa o ganho de massa muscular, colocar proteína nos lanches é uma excelente estratégia para o consumo da necessidade proteica diária e, as barrinhas trazem muita praticidade e sabor!", "img/produtos/21.jpg", false, 10, "Top Whey Bar Chocolate com Avelã 41g - MAX TITANIUM", 82, 8m, 0m },
                    { 1006499, 4, "Proteína e Emagrecimento A proteína é um nutriente que nos traz sensação de saciedade. No emagrecimento, o lanche rico em proteína irá auxiliar o controle da ingestão entre as refeições. Para quem visa o ganho de massa muscular, colocar proteína nos lanches é uma excelente estratégia para o consumo da necessidade proteica diária e, as barrinhas trazem muita praticidade e sabor!", "img/produtos/20.jpg", false, 10, "Top Whey Bar Brigadeiro 41g - MAX TITANIUM", 86, 8m, 0m },
                    { 1006518, 2, "O Therma Pro Hardcore é um termogênico que fornece 280 mg de cafeína, ótima opção para aumentar a energia e queimar gordura.", "img/produtos/5.jpg", false, 9, "Therma Pro Hardcore 60caps - INTEGRALMÉDICA", 8, 69.90m, 0m },
                    { 1006531, 1, "Antivazamento.- 600ml. ", "img/produtos/4.jpg", true, 9, "Coqueteleira com mola - INTEGRALMÉDICA", 17, 24.90m, 0m },
                    { 1006545, 4, "A Cindy Bar sabor Doce de Coco, da Hopper, é uma barrinha que fornece 13 g de proteínas de alto valor biológico, com adição de TCM, carboidratos de baixo índice glicêmico além de um mix de vitaminas e minerais.", "img/produtos/17.jpg", false, 8, "Cindy Bar Doce de coco 45g - HOPPER", 96, 9.50m, 0m },
                    { 1006583, 1, "- Odor Free. - Antivazamento.- 600ml. ", "img/produtos/2.png", true, 1, "Coqueteleira - FTW", 36, 19.90m, 0m },
                    { 1006621, 4, "A Protein Crisp é formada por 13g proteínas de alto valor biológico. Essas proteínas são fundamentais para a construção de muscular, além de serem importantes para a manutenção da massa muscular em programas de perda de peso. Por isso a Protein Crisp pode ser consumida tanto em dietas para perda de peso, quanto em dietas para ganho de massa muscular. Por ser uma barra de proteína completa, com proteínas, gorduras essenciais e aminoácidos, sua ingestão aumenta a saciedade entre as refeições, diminuindo a vontade de comer doces e alimentos calóricos.", "img/produtos/24.jpg", false, 9, "CRISP BAR Duo Crunch 45g - INTEGRALMÉDICA", 50, 8m, 0m },
                    { 1006622, 4, "O Cracker Monster ROCK é um saboroso e delicioso cracker, coberto com chocolate e recheado com a Pasta de Amendoim Branco ROCK, tudo isso ZERO açúcar, com proteína WheyRock, ótimo valor nutricional e sabor totalmente insano", "img/produtos/26.jpg", false, 15, "Cracker Monster Chocolate Branco - ROCK", 44, 6.90m, 0m },
                    { 1006940, 2, "Apresentação: Pote com 60 cápsulas. Ingredientes: Picolinato de cromo, estabilizantes celulose microcristalina e amido, antiumectante dióxido de silício. Ingredientes da cápsula: Gelatina, opacificante dióxido de titânio e água potável filtrada.", "img/produtos/6.jpg", false, 7, "Picolinato de Cromo 60caps - FTW SPORTS NUTRITION", 7, 59.90m, 0m },
                    { 1006951, 3, "O que é o #Dilabol Black da FTW? Cada substância escolhida para o #Dilabol Black Diabo Verde foi pensada exclusivamente para o melhor desempenho das vias metabólicas do nosso organismo a combinação perfeita para o seu treino Hard!", "img/produtos/15.jpg", false, 7, "Dilabol Black 120caps - FTW SPORTS NUTRITION", 8, 99.90m, 0m },
                    { 1006959, 4, "Aumento de força muscular; Ganho de massa muscular; Aumento na saciedade; Recuperação muscular; Energia", "img/produtos/23.jpg", false, 5, "Dark Bar Creme de coco com castanha 90G -  DARKNESS", 56, 16.90m, 0m },
                    { 1006966, 3, "Quem é #DoctorLover de verdade sabe que essa é uma das queridinhas, né! A combinação perfeita da pasta de amendoim com chocolate, avelã e wafer, sem adição de açúcar e zero glúten só poderia resultar nessa delícia. Garanta já a sua e leve esse sabor especial para o seu dia a dia mais saudável!", "img/produtos/12.jpg", false, 6, "Dr Peanut Buenissimo 600g - DR. PEANUT", 36, 59.90m, 0m },
                    { 1006971, 3, "Essa é a pasta de amendoim dos seus sonhos, com o sabor irresistível de Avelã! Nossa receita faz com que ela seja incrivelmente cremosa, deliciosamente saborosa e perfeita para uma alimentação saudável. Feita com ingredientes de alta qualidade, sem adição de açúcar e sem glúten, cada colherada é uma explosão de sabores, com a combinação perfeita de amendoim e avelã. Experimente, seu lanche nunca mais será o mesmo! ", "img/produtos/16.jpg", false, 6, "Dr Peanut Avelã 600g - DR. PEANUT", 8, 59.90m, 0m },
                    { 1006972, 3, "Aquele sabor de infância que só a Doctor Leite em Pó pode te proporcionar! Aliada e coringa de todas as refeições, além de ter zero adição de açúcar e zero glúten, essa delícia é perfeita para o seu dia a dia. Desde o café da manhã mais completo, até um lanchinho rápido e saudável, esse sabor vai te conquistar", "img/produtos/14.jpg", false, 6, "Dr Peanut Leite em pó 600g - DR. PEANUT", 10, 79.90m, 0m },
                    { 1006987, 2, "O THERMO FLAME entrega 360mg de cafeína pura por dose, proporcionando mais energia e foco, otimizando os resultados na busca pelo emagrecimento.", "img/produtos/8.jpg", false, 11, "Thermoflame 60caps - BLACKSKULL", 6, 59.90m, 0m },
                    { 1007005, 8, "4-SLEEP possui a combinação de quatro compostos ativos que em conjunto atuam na indução do sono mais profundo e reparador", "img/produtos/32.jpg", false, 12, "4 Sleep 90caps - INTEGRALMÉDICA", 2, 69.90m, 0m },
                    { 1007036, 4, "O que é 100% Whey Protein Apresenta variedade e praticidade em um só produto. Praticantes de atividade física ou quem busca uma rotina alimentar com bons nutrientes se beneficia do uso das proteínas do soro do leite, que fornecem qualidade nutricional com alto valor biológico. Contém grande concentração de proteínas e aminoácidos (rico em Bcaas e Glutamina) que são essenciais para os processos de ganho, recuperação e manutenção muscular. ", "img/produtos/19.jpg", false, 7, "Whey Ftw 100% Chocolate 900g refil - FTW", 87, 149.90m, 0m },
                    { 1007037, 4, "O que é 100% Whey Protein Apresenta variedade e praticidade em um só produto. Praticantes de atividade física ou quem busca uma rotina alimentar com bons nutrientes se beneficia do uso das proteínas do soro do leite, que fornecem qualidade nutricional com alto valor biológico. Contém grande concentração de proteínas e aminoácidos (rico em Bcaas e Glutamina) que são essenciais para os processos de ganho, recuperação e manutenção muscular. ", "img/produtos/22.jpg", false, 7, "Whey Ftw 100% Morango 900g refil - FTW", 63, 149.90m, 0m },
                    { 1007039, 4, "O que é 100% Whey Protein Apresenta variedade e praticidade em um só produto. Praticantes de atividade física ou quem busca uma rotina alimentar com bons nutrientes se beneficia do uso das proteínas do soro do leite, que fornecem qualidade nutricional com alto valor biológico. Contém grande concentração de proteínas e aminoácidos (rico em Bcaas e Glutamina) que são essenciais para os processos de ganho, recuperação e manutenção muscular. ", "img/produtos/18.jpg", false, 7, "Whey Ftw 100% Cookies 900g refil - FTW", 96, 149.90m, 0m },
                    { 1007055, 3, "Somos conhecidos por nosso sabor inigualável e agora realizamos o sonho de todos os amantes de alfajor lançando nossa versão dessa maravilha. Composta por duas camadas de leves e crocantes bolachas, recheadas com a famosa pasta de amendoim Dr. Peanut e cobertas com chocolate zero açúcar. Sabor e textura inconfundíveis com ingredientes de altíssima qualidade. Experimente!", "img/produtos/11.jpg", false, 6, "Alfajor Chocolante Branco 55g - DR. PEANUT", 39, 12.90m, 0m },
                    { 1007058, 3, "omos conhecidos por nosso sabor inigualável e agora realizamos o sonho de todos os amantes de alfajor com nossa versão dessa maravilha. Composta por duas camadas de leves e crocantes bolachas, recheadas com a famosa pasta de amendoim Dr. Peanut e cobertas com chocolate zero açúcar. Sabor e textura inconfundíveis, com ingredientes de altíssima qualidade. Experimente! ", "img/produtos/10.jpg", false, 6, "Alfajor Avelã 55g - DR. PEANUT", 52, 12.90m, 0m },
                    { 1007074, 3, "Como preparar: diluir 20g (uma colher de sopa) do produto em 500ml de água gelada, mexer até que o produto se dissolva e estará pronto para o consumo; indicados para adultos praticantes de atividade. Repõe os eletrólitos perdidos no suor; - evita câimbras e desidratação; - melhor desempenho; - baixa caloria", "img/produtos/13.jpg", false, 17, "Hydramaxi Morango com maracujá 20g - SUDRACT", 17, 3.95m, 0m },
                    { 1007093, 6, "O Tribulus Terrestris Gold da Orion Supplements é um suplemento nutricional formulado para ajudar a aumentar a energia, a resistência e a força física. A fórmula avançada combina os benefícios do Tribulus Terrestris com outros ingredientes naturais cuidadosamente selecionados para ajudar a melhorar o desempenho físico e sexual.", "img/produtos/29.jpg", false, 13, "Tribulus GOLD 90caps - ORION SUPPLEMENTS", 4, 167m, 0m },
                    { 1007094, 8, "Melatonina 3mg GNC  é um suplemento ideal para pessoas que possuem dificuldades para dormir ou que querem melhorar ainda mais a qualidade do sono. Com a Melatonina é possível dormir menos horas e melhor, pois a melatonina vai te levar ao sono REM mais rapidamente. É impressionante como acordamos melhor ao utilizar a melatonina logo antes de dormir. A melatonina é um hormônio natural que o seu corpo já produz, portanto é 100% seguro o uso deste produto.", "img/produtos/33.jpg", false, 12, "Melatonina 120caps - GNC", 2, 140m, 0m },
                    { 1007095, 8, "O que é 5-HTP? O aminoácido 5-HTP — também conhecido como 5-hidroxitriptofano — vai agir no cérebro e no sistema nervoso central como ator principal para a formação de serotonina, aumentando sua produção.", "img/produtos/34.jpg", false, 14, "5-HTP 60Caps - PURITANS PRIDE", 1, 180m, 0m },
                    { 1007107, 4, "Potencialize Seu Desempenho Nossa Energy Creatina é a aliada perfeita para impulsionar seu desempenho atlético e alcançar novos patamares nos treinos. Sendo monohidratada e saborosa, essa creatina em pó é ideal para quem busca resultados eficazes e uma experiência saborosa. Com uma fórmula de alta qualidade, a Energy Creatina fornece a dose necessária desse poderoso suplemento alimentar, contribuindo para aumentar a força, a resistência e a recuperação muscular.", "img/produtos/27.jpg", false, 16, "Creatina 300g - SHARK PRO", 42, 119.90m, 0m }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "DataNascimento", "Foto", "Nome" },
                values: new object[] { "66f78b3c-cea0-47b3-a8c5-04802a596522", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/avatar.png", "José Roberto Grigolato" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_UsuarioId",
                table: "Carrinho",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_CarrinhoId",
                table: "CarrinhoProduto",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_ProdutoId",
                table: "CarrinhoProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_SaborId",
                table: "CarrinhoProduto",
                column: "SaborId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_MarcaId",
                table: "Produto",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoObjetivo_ObjetivoId",
                table: "ProdutoObjetivo",
                column: "ObjetivoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoSabor_SaborId",
                table: "ProdutoSabor",
                column: "SaborId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CarrinhoProduto");

            migrationBuilder.DropTable(
                name: "ProdutoObjetivo");

            migrationBuilder.DropTable(
                name: "ProdutoSabor");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropTable(
                name: "Objetivo");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Sabor");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
