namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordWhileTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"WhileToken( [ {Start}..{End} ] )";

        var text = $"WhileToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}