namespace CovidTracker.Blazor.Data.Entities;

public class Exercise
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public int DurationInMinutes { get; set; }

    // Navigation properties
    public int ExerciseTypeId { get; set; }
    public ExerciseType ExerciseType { get; set; } = null!;
}