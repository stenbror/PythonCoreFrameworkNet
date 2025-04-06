namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterFloorDivAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"FloorDivAssignToken( [ {Start}..{End} ] )";

        var text = $"FloorDivAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}