namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterMinusAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"MinusAssignToken( [ {Start}..{End} ] )";

        var text = $"MinusAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}