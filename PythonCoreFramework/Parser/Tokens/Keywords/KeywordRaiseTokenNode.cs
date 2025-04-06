namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordRaiseTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"RaiseToken( [ {Start}..{End} ] )";

        var text = $"RaiseToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}