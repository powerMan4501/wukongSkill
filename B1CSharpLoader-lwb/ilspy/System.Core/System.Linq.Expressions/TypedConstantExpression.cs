namespace System.Linq.Expressions;

internal class TypedConstantExpression : ConstantExpression
{
	private readonly Type _type;

	public sealed override Type Type => _type;

	internal TypedConstantExpression(object value, Type type)
		: base(value)
	{
		_type = type;
	}
}
