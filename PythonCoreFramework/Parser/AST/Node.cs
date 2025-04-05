namespace PythonCoreFramework.Parser.AST;

public abstract class Node(uint start, uint end)
{
    public uint Start { get; set; } = start;
    public uint End { get; set; } = end;
}