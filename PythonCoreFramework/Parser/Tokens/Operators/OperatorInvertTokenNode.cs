namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorInvertTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BitwiseInvertToken( [ {Start}..{End} ] )";

        var text = $"BitwiseInvertToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}