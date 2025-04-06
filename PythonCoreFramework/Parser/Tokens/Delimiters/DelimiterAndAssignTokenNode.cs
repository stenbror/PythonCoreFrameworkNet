namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterAndAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BitwiseAndAssignToken( [ {Start}..{End} ] )";

        var text = $"BitwiseAndAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}