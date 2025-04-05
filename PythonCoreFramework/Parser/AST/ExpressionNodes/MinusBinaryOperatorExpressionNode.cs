using PythonCoreFramework.Parser.Tokens;

namespace PythonCoreFramework.Parser.AST.ExpressionNodes;

public partial class MinusBinaryOperatorExpressionNode(uint start, uint end, ExpressionNode left, Token symbol, ExpressionNode right) : BinaryOperatorExpressionNode(start, end, left, symbol, right)
{
    public override string ToString() => $"MinusBinaryOperatorExpressionNode( [{Start}..{End}] - Left: {Left} Symbol: {Symbol} Right: {Right})";
}