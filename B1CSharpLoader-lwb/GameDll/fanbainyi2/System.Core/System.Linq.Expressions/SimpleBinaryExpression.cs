namespace System.Linq.Expressions;

internal class SimpleBinaryExpression : BinaryExpression
{
	private readonly ExpressionType _nodeType;

	private readonly Type _type;

	public sealed override ExpressionType NodeType => _nodeType;

	public sealed override Type Type => _type;

	internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type)
		: base(left, right)
	{
		_nodeType = nodeType;
		_type = type;
	}
}
