namespace PythonCoreFramework.Parser.Tokens.Operators;

public sealed class OperatorModuloTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ModuloToken( [ {Start}..{End} ] )";

        var text = $"ModuloToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}