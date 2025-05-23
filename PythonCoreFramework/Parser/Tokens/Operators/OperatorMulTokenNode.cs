namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorMulTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"MulToken( [ {Start}..{End} ] )";

        var text = $"MulToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}