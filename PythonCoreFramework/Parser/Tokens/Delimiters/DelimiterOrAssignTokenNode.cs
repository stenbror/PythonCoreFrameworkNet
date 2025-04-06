namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterOrAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BitwiseOrAssignToken( [ {Start}..{End} ] )";

        var text = $"BitwiseOrToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}