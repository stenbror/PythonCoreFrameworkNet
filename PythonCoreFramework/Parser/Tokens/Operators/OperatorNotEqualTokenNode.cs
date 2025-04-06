namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorNotEqualTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"NotEqualToken( [ {Start}..{End} ] )";

        var text = $"NotEqualToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}