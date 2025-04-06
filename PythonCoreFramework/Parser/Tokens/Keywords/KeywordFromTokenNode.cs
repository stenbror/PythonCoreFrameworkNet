namespace PythonCoreFramework.Parser.Tokens.Keywords;

public class KeywordFromTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"FromToken( [ {Start}..{End} ] )";

        var text = $"FromToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}