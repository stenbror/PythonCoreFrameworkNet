namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterPlusAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"PlusAssignToken( [ {Start}..{End} ] )";

        var text = $"PlusAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}