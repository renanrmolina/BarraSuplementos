using BarraSuplementos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BarraSuplementos.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Carrinho> Carrinhos { get; set; }
    public DbSet<CarrinhoProduto> CarrinhoProdutos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Objetivo> Objetivos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoObjetivo> ProdutoObjetivos { get; set; }
    public DbSet<ProdutoSabor> ProdutoSabores { get; set; }
    public DbSet<Sabor> Sabores { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed seed = new(builder);

        #region Relacionamento Muito para Muitos - CarrinhoProduto
        builder.Entity<CarrinhoProduto>().HasKey(
            cp => new { cp.Id, cp.CarrinhoId }
        );

        builder.Entity<CarrinhoProduto>()
            .HasOne(cp => cp.Produto)
            .WithMany(p => p.Carrinhos)
            .HasForeignKey(cp => cp.ProdutoId);
        
        builder.Entity<CarrinhoProduto>()
            .HasOne(cp => cp.Sabor)
            .WithMany(s => s.Carrinhos)
            .HasForeignKey(cp => cp.SaborId);
        
        builder.Entity<CarrinhoProduto>()
            .HasOne(cp => cp.Carrinho)
            .WithMany(c => c.Produtos)
            .HasForeignKey(cp => cp.CarrinhoId);
        #endregion

        #region Relacionamento Muito para Muitos - ProdutoObjetivo
        builder.Entity<ProdutoObjetivo>().HasKey(
            po => new { po.ProdutoId, po.ObjetivoId }
        );

        builder.Entity<ProdutoObjetivo>()
            .HasOne(po => po.Produto)
            .WithMany(p => p.Objetivos)
            .HasForeignKey(po => po.ProdutoId);
        
        builder.Entity<ProdutoObjetivo>()
            .HasOne(po => po.Objetivo)
            .WithMany(o => o.Produtos)
            .HasForeignKey(po => po.ObjetivoId);
        #endregion

        #region Relacionamento Muito para Muitos - ProdutoSabor
        builder.Entity<ProdutoSabor>().HasKey(
            po => new { po.ProdutoId, po.SaborId }
        );

        builder.Entity<ProdutoSabor>()
            .HasOne(ps => ps.Produto)
            .WithMany(p => p.Sabores)
            .HasForeignKey(ps => ps.ProdutoId);
        
        builder.Entity<ProdutoSabor>()
            .HasOne(ps => ps.Sabor)
            .WithMany(o => o.Produtos)
            .HasForeignKey(ps => ps.SaborId);
        #endregion
    }
}
