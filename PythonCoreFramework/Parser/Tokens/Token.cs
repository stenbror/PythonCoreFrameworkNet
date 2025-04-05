
namespace PythonCoreFramework.Parser.Tokens;

public abstract class Token(uint start, uint end, Trivia.Trivia[] trivia)
{
    public uint Start { get; set;  } = start;
    public uint End { get; set;  } = end;
    public Trivia.Trivia[] Trivia { get; set;  } = trivia;
}