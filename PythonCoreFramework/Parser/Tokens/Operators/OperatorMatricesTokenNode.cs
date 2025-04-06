namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorMatricesTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"MatricesToken( [ {Start}..{End} ] )";

        var text = $"MatricesToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}