namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordNoneTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"NoneToken( [ {Start}..{End} ] )";

        var text = $"NoneToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}