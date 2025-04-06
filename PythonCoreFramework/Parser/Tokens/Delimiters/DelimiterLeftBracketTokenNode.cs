namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterLeftBracketTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"LeftBracketToken( [ {Start}..{End} ] )";

        var text = $"LeftBracketToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}