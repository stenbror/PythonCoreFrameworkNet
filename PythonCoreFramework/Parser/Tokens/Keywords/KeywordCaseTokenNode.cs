namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordCaseTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"CaseToken( [ {Start}..{End} ] )";

        var text = $"CaseToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}