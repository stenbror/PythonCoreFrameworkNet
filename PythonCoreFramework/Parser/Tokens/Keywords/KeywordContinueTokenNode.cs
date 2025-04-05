namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordContinueTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ContinueToken( [ {Start}..{End} ] )";

        var text = $"ContinueToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}