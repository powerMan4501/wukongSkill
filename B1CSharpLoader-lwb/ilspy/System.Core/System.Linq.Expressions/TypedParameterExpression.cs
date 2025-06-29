namespace System.Linq.Expressions;

internal class TypedParameterExpression : ParameterExpression
{
	private readonly Type _paramType;

	public sealed override Type Type => _paramType;

	internal TypedParameterExpression(Type type, string name)
		: base(name)
	{
		_paramType = type;
	}
}
