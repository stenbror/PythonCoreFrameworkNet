namespace PythonCoreFramework.Parser.Tokens.Literals;

public sealed class LiteralNameTokenNode(uint start, uint end, Trivia.Trivia[] trivia, string data) : Token(start, end, trivia)
{
    public string Data { get; set; } = data;
    
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"NameToken( [ {Start}..{End} ] : '{Data}' )";

        var text = $"NameToken( [ {Start}..{End} ]  : '{Data}' : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}