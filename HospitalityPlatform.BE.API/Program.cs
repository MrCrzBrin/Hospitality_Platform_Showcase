using HospitalityPlatform.Api.Data;
using HospitalityPlatform.Api.Extensions;
using HospitalityPlatform.Api.Repositories;
using HospitalityPlatform.Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("FrontendPolicy", policy =>
    {
        var origins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? Array.Empty<string>();
        policy.WithOrigins(origins)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IContactRequestRepository, ContactRequestRepository>();

builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IContactRequestService, ContactRequestService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("FrontendPolicy");

app.UseHttpsRedirection();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    // For full migration workflow, create the migration locally with dotnet-ef.
    // If you want immediate startup without migrations, you can replace this with EnsureCreated().
    db.Database.Migrate();
    await AppDbSeeder.SeedAsync(db);
}

app.Run();
