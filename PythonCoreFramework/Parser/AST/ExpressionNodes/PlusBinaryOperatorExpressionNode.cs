using PythonCoreFramework.Parser.Tokens;

namespace PythonCoreFramework.Parser.AST.ExpressionNodes;

public partial class PlusBinaryOperatorExpressionNode(uint start, uint end, ExpressionNode left, Token symbol, ExpressionNode right) : BinaryOperatorExpressionNode(start, end, left, symbol, right)
{
    public override string ToString() => $"PlusBinaryOperatorExpressionNode( [{Start}..{End}] - Left: {Left} Symbol: {Symbol} Right: {Right})";
}