namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterPowerAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"PowerAssignToken( [ {Start}..{End} ] )";

        var text = $"PowerAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}