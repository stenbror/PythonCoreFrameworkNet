namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordFalseTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"FalseToken( [ {Start}..{End} ] )";

        var text = $"FalseToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}