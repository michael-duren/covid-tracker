using CovidTracker.Blazor.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CovidTracker.Blazor.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    DbSet<Exercise> Exercises { get; set; } = null!;
    DbSet<ExerciseType> ExerciseTypes { get; set; } = null!;
    DbSet<ExerciseCategory> ExerciseCategories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ExerciseType>()
            .HasMany(et => et.Exercises)
            .WithOne(e => e.ExerciseType)
            .HasForeignKey(e => e.ExerciseTypeId)
            .HasPrincipalKey(et => et.ExerciseTypeId);

        modelBuilder.Entity<ExerciseCategory>()
            .HasMany(ec => ec.ExerciseTypes)
            .WithOne(et => et.ExerciseCategory)
            .HasForeignKey(et => et.ExerciseCategoryId)
            .HasPrincipalKey(ec => ec.ExerciseCategoryId);

        modelBuilder.Entity<ExerciseType>()
            .HasData(
                new ExerciseType()
                {
                    ExerciseName = "Running"
                }
            );
    }
}