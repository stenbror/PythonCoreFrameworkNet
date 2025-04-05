namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordAwaitTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"AwaitToken( [ {Start}..{End} ] )";

        var text = $"AwaitToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}