namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorDivTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"DivToken( [ {Start}..{End} ] )";

        var text = $"DivToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}