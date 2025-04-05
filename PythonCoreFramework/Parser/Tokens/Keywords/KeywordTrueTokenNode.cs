namespace PythonCoreFramework.Parser.Tokens.Keywords;

public class KeywordTrueTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"TrueToken( [ {Start}..{End} ] )";

        var text = $"TrueToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}