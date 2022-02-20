using Microsoft.EntityFrameworkCore;
using NEGRASM.Models;

namespace NEGRASM.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Consumidor> Consumidores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL5080.site4now.net,1433;Initial Catalog=db_a83211_negros;User Id=db_a83211_negros_admin;Password=DESKTOP3RKPI3K");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Consumidor>(table =>
            {
                table.ToTable("Consumidores");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.Nome).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.CPF).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.Endereco).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Complemento).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Cidade).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Email).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Estado).HasConversion<string>().HasMaxLength(5);
                table.Property(prop => prop.Telefone).HasMaxLength(11);
                table.Property(prop => prop.Nascimento).HasColumnType("date");
                table.Property(prop => prop.Sexo).HasConversion<string>().HasMaxLength(11);


            });
        }
    }
}
