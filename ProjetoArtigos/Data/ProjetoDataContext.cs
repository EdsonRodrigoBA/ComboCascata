using Microsoft.EntityFrameworkCore;
using ProjetoArtigos.Models;


namespace ProjetoArtigos.Data
{
    public class ProjetoDataContext : DbContext
    {
        public ProjetoDataContext(DbContextOptions<ProjetoDataContext> options) : base(options)
        {

        }

        public DbSet<Cidades> Cidades { get; set; }

        public DbSet<Estados> Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //Mapeando a Tabela de Cidades
            modelBuilder.Entity<Cidades>().ToTable("Cidades").HasKey(x => x.Id_Cidade);
            modelBuilder.Entity<Cidades>().Property(c => c.descricao).HasColumnType("VARCHAR(100)").IsRequired();
            modelBuilder.Entity<Cidades>().Property(c => c.UF).HasColumnType("VARCHAR(2)").IsRequired();

            //Criando o Relacionamento entre cidade e estado
            modelBuilder.Entity<Cidades>()
            .HasOne<Estados>(estados => estados.Estados)
            .WithMany(cidades => cidades.Cidades)
            .HasForeignKey(cidadeestadofk => cidadeestadofk.Id_estado).OnDelete(DeleteBehavior.NoAction);

            // Mapeando a Tabela de Estados
            modelBuilder.Entity<Estados>().ToTable("Estados").HasKey(x => x.id_estado);
            modelBuilder.Entity<Estados>().Property(e => e.descricao).HasColumnType("VARCHAR(40)").IsRequired();
            modelBuilder.Entity<Estados>().Property(e => e.UF).HasColumnType("CHAR(2)").IsRequired();
        }
    }
}
