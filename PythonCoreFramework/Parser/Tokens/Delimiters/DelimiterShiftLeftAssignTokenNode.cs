namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterShiftLeftAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ShiftLeftAssignToken( [ {Start}..{End} ] )";

        var text = $"ShiftLeftAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}