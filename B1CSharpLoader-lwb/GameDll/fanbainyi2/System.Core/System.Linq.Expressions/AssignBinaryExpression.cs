namespace System.Linq.Expressions;

internal sealed class AssignBinaryExpression : BinaryExpression
{
	public sealed override Type Type => base.Left.Type;

	public sealed override ExpressionType NodeType => ExpressionType.Assign;

	internal AssignBinaryExpression(Expression left, Expression right)
		: base(left, right)
	{
	}
}
