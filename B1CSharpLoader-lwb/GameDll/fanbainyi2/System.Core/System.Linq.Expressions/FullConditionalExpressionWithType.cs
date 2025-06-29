namespace System.Linq.Expressions;

internal class FullConditionalExpressionWithType : FullConditionalExpression
{
	private readonly Type _type;

	public sealed override Type Type => _type;

	internal FullConditionalExpressionWithType(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		: base(test, ifTrue, ifFalse)
	{
		_type = type;
	}
}
