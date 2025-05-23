namespace PythonCoreFramework.Parser.Tokens.Keywords;

public sealed class KeywordLambdaTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"LambdaToken( [ {Start}..{End} ] )";

        var text = $"LambdaToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}