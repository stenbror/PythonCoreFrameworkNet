namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordTryTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"TryToken( [ {Start}..{End} ] )";

        var text = $"TryToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}