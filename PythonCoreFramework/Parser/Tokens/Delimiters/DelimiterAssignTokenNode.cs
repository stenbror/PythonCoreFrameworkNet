namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"AssignToken( [ {Start}..{End} ] )";

        var text = $"AssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}