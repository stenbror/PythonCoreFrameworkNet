namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterRightBracketTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"RightBracketToken( [ {Start}..{End} ] )";

        var text = $"RightBracketToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}