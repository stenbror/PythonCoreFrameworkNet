namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public class DelimiterNewlineTokenNode(uint start, uint end, Trivia.Trivia[] trivia,char ch1, char ch2) : Token(start, end, trivia)
{
    public char First { get; set; } = ch1;
    public char Second { get; set; } = ch2;
    
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"NewlineToken( [ {Start}..{End} ] )";

        var text = $"NewlineToken( [ {Start}..{End} ] : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}