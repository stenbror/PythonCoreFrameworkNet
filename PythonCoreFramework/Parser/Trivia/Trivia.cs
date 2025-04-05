namespace PythonCoreFramework.Parser.Trivia;

public abstract class Trivia(uint start, uint end)
{
    public uint Start { get; set; } = start;
    public uint End { get; set; } = end;
}