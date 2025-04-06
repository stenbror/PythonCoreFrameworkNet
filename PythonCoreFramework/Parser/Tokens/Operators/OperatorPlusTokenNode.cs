namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorPlusTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"PlusToken( [ {Start}..{End} ] )";

        var text = $"PlusToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}