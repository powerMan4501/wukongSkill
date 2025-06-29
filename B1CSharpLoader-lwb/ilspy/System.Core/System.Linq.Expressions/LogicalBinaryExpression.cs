namespace System.Linq.Expressions;

internal sealed class LogicalBinaryExpression : BinaryExpression
{
	private readonly ExpressionType _nodeType;

	public sealed override Type Type => typeof(bool);

	public sealed override ExpressionType NodeType => _nodeType;

	internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right)
		: base(left, right)
	{
		_nodeType = nodeType;
	}
}
