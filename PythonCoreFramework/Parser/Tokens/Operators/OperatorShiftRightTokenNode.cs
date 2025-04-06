namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorShiftRightTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ShiftRightToken( [ {Start}..{End} ] )";

        var text = $"ShiftRightToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}