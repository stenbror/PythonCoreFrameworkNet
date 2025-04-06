namespace PythonCoreFramework.Parser.Tokens.Literals;

public sealed class LiteralStringElementTokenNode(uint start, uint end, Trivia.Trivia[] trivia, string data) : Token(start, end, trivia)
{
    public string Data { get; set; } = data;
    
    public override string ToString()
    {
        if (Trivia.Length == 0) return $"StringElementToken( [ {Start}..{End} ] : {Data} )";

        var text = $"StringElementToken( [ {Start}..{End} ]  : {Data} : [";
        foreach (var trivia in Trivia) text += $" {trivia}";
        text += $" ] )";
        return text;
    }
}

public sealed class LiteralStringTokenNode(uint start, uint end, Trivia.Trivia[] trivia) : Token(start, end, trivia)
{
    private readonly List<LiteralStringElementTokenNode> _elements = [];
        
    public void AddElement(LiteralStringElementTokenNode element)
    {
        _elements.Add(element);
    }

    public LiteralStringElementTokenNode[] GetElements() => _elements.ToArray();
    
    public override string ToString()
    {
        var text = $"StringToken( [ {Start}..{End} ] : ";

        if (Trivia.Length != 0)
        {
            foreach (var trivia in Trivia) text += $" {trivia}";
            text += $" ] : ";
        }

        text += "[ ";
        foreach (var element in _elements) text += element.ToString() + " ";
        text += "] )";

        return text;
    }
}