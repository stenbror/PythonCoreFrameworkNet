namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorMinusTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"MinusToken( [ {Start}..{End} ] )";

        var text = $"MinusToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}