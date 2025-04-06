namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorFloorDivTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"FloorDivToken( [ {Start}..{End} ] )";

        var text = $"FloorDivToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}