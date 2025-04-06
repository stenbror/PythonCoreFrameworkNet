namespace PythonCoreFramework.Parser.Tokens.Delimiters;

public class DelimiterEndOfFileTokenNode(uint position, Trivia.Trivia[] trivia ) : Token(position, position, trivia)
{
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"EndOfFileToken( [ {Start} ] )";

        var text = $"EndOfFileToken( [ {Start} ] : [ ";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}