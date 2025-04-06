namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterMulAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"MulAssignToken( [ {Start}..{End} ] )";

        var text = $"MulAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}