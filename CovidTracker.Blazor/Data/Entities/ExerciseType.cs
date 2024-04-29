using System.ComponentModel.DataAnnotations;

namespace CovidTracker.Blazor.Data.Entities;

public class ExerciseType
{
    public int ExerciseTypeId { get; set; }
    [MaxLength(25)] public string ExerciseName { get; set; } = null!;

    // Navigation property
    public ICollection<Exercise> Exercises { get; set; } = [];


    public int ExerciseCategoryId { get; set; }
    public ExerciseCategory ExerciseCategory { get; set; } = null!;
}