namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterNotTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BitwiseNotToken( [ {Start}..{End} ] )";

        var text = $"BitwiseNotToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}