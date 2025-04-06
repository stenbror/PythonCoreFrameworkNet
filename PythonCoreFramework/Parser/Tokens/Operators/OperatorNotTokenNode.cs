namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorNotTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"BitwiseNotToken( [ {Start}..{End} ] )";

        var text = $"BitwiseNotToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}