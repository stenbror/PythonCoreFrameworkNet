using PythonCoreFramework.Parser.Tokens;

namespace PythonCoreFramework.Parser.AST.ExpressionNodes;

public class UnaryOperatorExpressionNode(uint start, uint end, Token symbol, ExpressionNode right) : ExpressionNode(start, end)
{
    public Token Symbol { get; set;  } = symbol;
    public ExpressionNode Right { get; set; } = right;
}