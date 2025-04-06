namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordIfTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"IfToken( [ {Start}..{End} ] )";

        var text = $"IfToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}