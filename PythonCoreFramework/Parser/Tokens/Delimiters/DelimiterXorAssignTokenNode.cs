namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterXorAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BitwiseXorAssignToken( [ {Start}..{End} ] )";

        var text = $"BitwiseXorAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}