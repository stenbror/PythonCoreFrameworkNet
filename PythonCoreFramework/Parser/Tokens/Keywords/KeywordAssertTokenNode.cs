namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordAssertTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"AssertToken( [ {Start}..{End} ] )";

        var text = $"AssertToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}