namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public sealed class DelimiterModuloAssignTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"ModuloAssignToken( [ {Start}..{End} ] )";

        var text = $"ModuloAssignToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}