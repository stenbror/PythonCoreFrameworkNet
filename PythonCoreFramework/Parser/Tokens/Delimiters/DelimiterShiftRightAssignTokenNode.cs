namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterShiftRightAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ShiftRightAssignToken( [ {Start}..{End} ] )";

        var text = $"ShiftRightAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}