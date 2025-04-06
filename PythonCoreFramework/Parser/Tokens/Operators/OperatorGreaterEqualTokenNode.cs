namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorGreaterEqualTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"GreaterEqualToken( [ {Start}..{End} ] )";

        var text = $"GreaterEqualToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}