namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterCommaTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"CommaToken( [ {Start}..{End} ] )";

        var text = $"CommaToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}