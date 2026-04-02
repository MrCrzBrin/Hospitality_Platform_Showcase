using HospitalityPlatform.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalityPlatform.Api.Data;

public class AppDbContext : DbContext
{
    public DbSet<Location> Locations => Set<Location>();
    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<ContactRequest> ContactRequests => Set<ContactRequest>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("locations");
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(120).IsRequired();
            entity.Property(x => x.City).HasMaxLength(80).IsRequired();
            entity.Property(x => x.Description).HasMaxLength(1000).IsRequired();
            entity.Property(x => x.ImageUrl).HasMaxLength(1000);
            entity.Property(x => x.Category).HasMaxLength(80).IsRequired();
            entity.Property(x => x.Address).HasMaxLength(200).IsRequired();
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.ToTable("bookings");
            entity.HasKey(x => x.Id);
            entity.Property(x => x.FullName).HasMaxLength(120).IsRequired();
            entity.Property(x => x.Email).HasMaxLength(200).IsRequired();
            entity.Property(x => x.Phone).HasMaxLength(50);
            entity.Property(x => x.Notes).HasMaxLength(1000);
            entity.Property(x => x.Status).HasMaxLength(40).IsRequired();
            entity.HasOne(x => x.Location)
                  .WithMany(x => x.Bookings)
                  .HasForeignKey(x => x.LocationId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ContactRequest>(entity =>
        {
            entity.ToTable("contact_requests");
            entity.HasKey(x => x.Id);
            entity.Property(x => x.FullName).HasMaxLength(120).IsRequired();
            entity.Property(x => x.Email).HasMaxLength(200).IsRequired();
            entity.Property(x => x.Subject).HasMaxLength(180).IsRequired();
            entity.Property(x => x.Message).HasMaxLength(3000).IsRequired();
            entity.Property(x => x.Status).HasMaxLength(40).IsRequired();
        });
    }
}
