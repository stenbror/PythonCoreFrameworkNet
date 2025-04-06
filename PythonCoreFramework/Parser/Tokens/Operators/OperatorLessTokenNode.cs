namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorLessTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"LessToken( [ {Start}..{End} ] )";

        var text = $"LessToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}