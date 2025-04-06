namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorOrTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BitwiseOrToken( [ {Start}..{End} ] )";

        var text = $"BitwiseOrToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}