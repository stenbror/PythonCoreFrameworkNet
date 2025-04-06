namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterRightParenTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"RightParenToken( [ {Start}..{End} ] )";

        var text = $"RightParenToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}