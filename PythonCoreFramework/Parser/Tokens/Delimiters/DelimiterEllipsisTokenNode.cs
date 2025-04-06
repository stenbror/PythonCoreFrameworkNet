namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterEllipsisTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"EllipsisToken( [ {Start}..{End} ] )";

        var text = $"EllipsisToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}