namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterColonTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ColonToken( [ {Start}..{End} ] )";

        var text = $"ColonToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}