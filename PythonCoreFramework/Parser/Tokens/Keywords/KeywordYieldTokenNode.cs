namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordYieldTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"YieldToken( [ {Start}..{End} ] )";

        var text = $"YieldToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}