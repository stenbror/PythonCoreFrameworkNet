namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterSemicolonTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"SemicolonToken( [ {Start}..{End} ] )";

        var text = $"SemicolonToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}