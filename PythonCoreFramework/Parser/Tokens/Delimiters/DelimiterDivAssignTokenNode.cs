namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterDivAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"DivAssignToken( [ {Start}..{End} ] )";

        var text = $"DivAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}