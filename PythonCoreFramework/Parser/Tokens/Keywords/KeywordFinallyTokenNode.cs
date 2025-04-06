namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordFinallyTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"FinallyToken( [ {Start}..{End} ] )";

        var text = $"FinallyToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}