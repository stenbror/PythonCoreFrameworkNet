namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterMatricesAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"MatricesAssignToken( [ {Start}..{End} ] )";

        var text = $"MatricesAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}