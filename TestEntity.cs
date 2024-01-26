namespace TestProject;

public class TestEntity
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public string EnglishText { get; set; } = null!;
    public string RussianText { get; set; } = null!;
    public int Number { get; set; }
    public double FloatNumber { get; set; }

    public static TestEntity FromString(string data)
    {
        var entityData = data.Split("||");
        return new()
        {
            Date = DateOnly.Parse(entityData[0]),
            EnglishText = entityData[1],
            RussianText = entityData[2],
            Number = int.Parse(entityData[3]),
            FloatNumber = double.Parse(entityData[4])
        };
    }
}