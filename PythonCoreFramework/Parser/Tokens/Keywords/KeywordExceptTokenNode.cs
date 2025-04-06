namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordExceptTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ExceptToken( [ {Start}..{End} ] )";

        var text = $"ExceptToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}