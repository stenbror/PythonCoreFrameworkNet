namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterRightCurlyTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"RightCurlyToken( [ {Start}..{End} ] )";

        var text = $"RightCurlyToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}