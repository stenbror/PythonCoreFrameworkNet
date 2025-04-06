namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorColonAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ColonAssignToken( [ {Start}..{End} ] )";

        var text = $"ColonAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}