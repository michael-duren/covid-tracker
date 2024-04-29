using System.ComponentModel.DataAnnotations;

namespace CovidTracker.Blazor.Data.Entities;

public class ExerciseCategory
{
    public int ExerciseCategoryId { get; set; }
    [MaxLength(25)] public string ExerciseCategoryName { get; set; } = null!;
    
    // Navigation property
    public ICollection<ExerciseType> ExerciseTypes { get; set; } = [];
}