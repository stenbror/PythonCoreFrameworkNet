namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterArrowTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ArrowToken( [ {Start}..{End} ] )";

        var text = $"ArrowToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }   
}