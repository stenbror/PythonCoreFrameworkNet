namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorShiftLeftTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ShiftLeftToken( [ {Start}..{End} ] )";

        var text = $"ShiftLeftToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}