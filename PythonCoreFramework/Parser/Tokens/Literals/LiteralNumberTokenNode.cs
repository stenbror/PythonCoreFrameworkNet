namespace PythonCoreFramework.Parser.Tokens.Literals;

public sealed class LiteralNumberTokenNode(uint start, uint end, Trivia.Trivia[] trivia, string data) : Token(start, end, trivia)
{
    public string Data { get; set; } = data;
    
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"NumberToken( [ {Start}..{End} ] : '{Data}' )";

        var text = $"NumberToken( [ {Start}..{End} ]  : '{Data}' : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}