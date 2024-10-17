using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebBiblioteca.Models;

public partial class WebBibliotecaContext : DbContext
{
    public WebBibliotecaContext()
    {
    }

    public WebBibliotecaContext(DbContextOptions<WebBibliotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autore> Autores { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//    => optionsBuilder.UseSqlServer("server=localhost; database=WebBiblioteca; integrated security=true; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autore>(entity =>
        {
            entity.HasKey(e => e.AutorId).HasName("PK__Autores__F58AE909379191BB");

            entity.Property(e => e.AutorId).HasColumnName("AutorID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Libros__C4971C0F7897F7DA");

            entity.Property(e => e.Id).HasColumnName("ID_");
            entity.Property(e => e.IdAutor).HasColumnName("ID_Autor");
            entity.Property(e => e.Titulo).HasMaxLength(50);

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdAutor)
                .HasConstraintName("FK_Libros_Autor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
