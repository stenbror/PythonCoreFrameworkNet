namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordBreakTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BreakToken( [ {Start}..{End} ] )";

        var text = $"BreakToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}