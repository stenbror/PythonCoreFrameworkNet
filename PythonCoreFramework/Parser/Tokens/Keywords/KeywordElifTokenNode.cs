namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordElifTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ElifToken( [ {Start}..{End} ] )";

        var text = $"ElifToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}