namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterLeftParenTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"LeftParenToken( [ {Start}..{End} ] )";

        var text = $"LeftParenToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}