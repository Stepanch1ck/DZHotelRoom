using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Microsoft.EntityFrameworkCore;

namespace DZHotelRoom;

public partial class HotelRoomContext : DbContext
{
    public HotelRoomContext()
    {
        Database.EnsureCreated();
    }

    public HotelRoomContext(DbContextOptions<HotelRoomContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite(@"Data Source=../../../HotelRoom.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.IdPerson);

            entity.ToTable("Person");

            entity.Property(e => e.Animal)
                .HasColumnType("BOOLEAN")
                .HasColumnName("animal");
            entity.Property(e => e.ArrivalDate).HasColumnType("DATETIME");
            entity.Property(e => e.Avatar)
                .HasColumnType("IMAGE")
                .HasColumnName("avatar");
            entity.Property(e => e.Birthday)
                .HasColumnType("DATETIME")
                .HasColumnName("birthday");
            entity.Property(e => e.FirstName)
                .HasColumnType("VARCHAR(50)")
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasColumnType("VARCHAR(50)")
                .HasColumnName("last_name");
            entity.Property(e => e.PaymentMetod).HasColumnName("paymentMetod");
            entity.Property(e => e.ReleaseDate).HasColumnType("DATETIME");
            entity.Property(e => e.Surname)
                .HasColumnType("VARCHAR(50)")
                .HasColumnName("surname");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.IdRoom);

            entity.Property(e => e.Person).HasColumnType("INT");

            entity.HasOne(d => d.PersonNavigation).WithMany(p => p.Rooms).HasForeignKey(d => d.Person);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
}
