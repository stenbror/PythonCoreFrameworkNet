namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterLeftCurlyTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"LeftCurlyToken( [ {Start}..{End} ] )";

        var text = $"LeftCurlyToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}