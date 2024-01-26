using System.Text;

namespace TestProject;

public class StringFactory
{
    private static readonly Random _random = new();
    private static readonly Dictionary<string, (char startSymbol, int alphabetSize)> languageMap = new()
    {
        ["Русский"] = ('А', 32),
        ["English"] = ('A', 26),
    };

    public static string Create()
        => $"{CreateDatePart(DateTime.Now.AddYears(-5).Date, DateTime.Now.Date)}||{CreateTextPart(10, "English")}||{CreateTextPart(10, "Русский")}||{CreateIntPart(1, 100_000_000)}||{CreateRealPart(1, 20, 8)}";

    private static DateOnly CreateDatePart(DateTime from, DateTime to)
        => DateOnly.FromDateTime(from.AddDays(_random.Next((to - from).Days + 1)));

    private static string CreateTextPart(int length, string language)
    {
        StringBuilder stringBuilder = new();
        var startSymbol = languageMap[language].startSymbol;
        var alphabetSize = languageMap[language].alphabetSize;
        for (int i = 0; i < length; i++)
        {
            var symbol = (char)(startSymbol + _random.Next(alphabetSize) + 32 * _random.Next(2));
            stringBuilder.Append(symbol);
        }

        return stringBuilder.ToString();
    }

    private static int CreateIntPart(int minValue, int maxValue) => _random.Next(minValue/2, maxValue/2) * 2;

    private static double CreateRealPart(int minValue, int maxValue, int digitsCount) 
        => _random.Next(minValue, maxValue - 1) + Math.Round(_random.NextDouble(), digitsCount);
}