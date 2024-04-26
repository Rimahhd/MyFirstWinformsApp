using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyFirstWinformsApp.Repositorys.Models;

namespace MyFirstWinformsApp.Repositorys;

public partial class TEntities : DbContext
{
    public TEntities()
    {
    }

    public TEntities(DbContextOptions<TEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Travel> Travels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-5764QME;Initial Catalog=TravelDBb;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0748DB756D");
        });

        modelBuilder.Entity<Travel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__travel__3214EC07C76C85C1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
