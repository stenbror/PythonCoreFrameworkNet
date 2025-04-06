namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterPeriodTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"PeriodToken( [ {Start}..{End} ] )";

        var text = $"PeriodToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}