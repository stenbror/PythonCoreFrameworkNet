namespace PythonCoreFramework.Parser.Tokens.Keywords;

public class KeywordDefaultTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia) // '_' is the keyword.
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"DefaultToken( [ {Start}..{End} ] )";

        var text = $"DefaultToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}