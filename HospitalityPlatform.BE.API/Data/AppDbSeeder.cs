using HospitalityPlatform.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalityPlatform.Api.Data;

public static class AppDbSeeder
{
    public static async Task SeedAsync(AppDbContext db)
    {
        if (await db.Locations.AnyAsync())
        {
            return;
        }

        var locations = new List<Location>
        {
            new()
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "Emerald Lounge",
                City = "Berlin",
                Description = "Premium lounge experience with modern design and relaxed seating.",
                ImageUrl = "https://images.unsplash.com/photo-1517248135467-4c7edcad34c4",
                Category = "Lounge",
                Address = "Alexanderplatz 1, Berlin",
                IsFeatured = true
            },
            new()
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Urban Coffee Spot",
                City = "Hamburg",
                Description = "Boutique coffee spot with community vibe and curated interior.",
                ImageUrl = "https://images.unsplash.com/photo-1509042239860-f550ce710b93",
                Category = "Cafe",
                Address = "Jungfernstieg 10, Hamburg",
                IsFeatured = false
            },
            new()
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Name = "Garden Social House",
                City = "Munich",
                Description = "Hybrid social venue with premium design, terrace seating and events.",
                ImageUrl = "https://images.unsplash.com/photo-1552566626-52f8b828add9",
                Category = "Boutique",
                Address = "Leopoldstraße 20, München",
                IsFeatured = true
            }
        };

        await db.Locations.AddRangeAsync(locations);
        await db.SaveChangesAsync();
    }
}
