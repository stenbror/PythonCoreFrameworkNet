namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorPowerTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"PowerToken( [ {Start}..{End} ] )";

        var text = $"PowerToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}