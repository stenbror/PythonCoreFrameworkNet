namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorLessEqualTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"LessEqualToken( [ {Start}..{End} ] )";

        var text = $"LessEqualToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}