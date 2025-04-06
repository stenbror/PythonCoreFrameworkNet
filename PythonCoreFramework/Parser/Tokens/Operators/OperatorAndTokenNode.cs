namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorAndTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BitwiseAndToken( [ {Start}..{End} ] )";

        var text = $"BitwiseAndToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}