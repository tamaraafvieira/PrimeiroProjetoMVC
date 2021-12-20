using Microsoft.EntityFrameworkCore;
using ProjetoRecode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRecode.Data
{
    public class ApplicationContext : DbContext
    {   
            public DbSet<Cadastro> Clientes { get; set; }
            
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-6VT4LF4I;Initial Catalog=LaVieEstBelle;Integrated Security=True");
            }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Cadastro>(t =>
                {
                    t.ToTable("Clientes");

                    t.HasKey(p => p.CodigoCliente);
                   
                    t.Property(p => p.Nome).HasMaxLength(50).IsRequired();                    
                    t.Property(p => p.Cpf).HasColumnType("char(14)").IsRequired();
                    t.Property(p => p.E_mail).HasMaxLength(50).IsRequired();
                    t.Property(p => p.Rua).HasMaxLength(40).IsRequired();
                    t.Property(p => p.Numero).HasColumnType("int").IsRequired();
                    t.Property(p => p.Complemento).HasMaxLength(20);
                    t.Property(p => p.Cep).HasColumnType("CHAR(9)").IsRequired();
                });               
                        
              
        }
    }
}

