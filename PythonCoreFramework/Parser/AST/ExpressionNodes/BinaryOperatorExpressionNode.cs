using PythonCoreFramework.Parser.Tokens;

namespace PythonCoreFramework.Parser.AST.ExpressionNodes;

public abstract class BinaryOperatorExpressionNode(uint start, uint end, ExpressionNode left, Token symbol, ExpressionNode right) : ExpressionNode(start, end)
{
    public ExpressionNode Left { get; set; } = left;
    public Token Symbol { get; set; } = symbol;
    public ExpressionNode Right { get; set; } = right;
}