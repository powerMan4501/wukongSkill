using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

internal sealed class TypedDynamicExpression1 : DynamicExpression1
{
	private readonly Type _retType;

	public sealed override Type Type => _retType;

	internal TypedDynamicExpression1(Type retType, Type delegateType, CallSiteBinder binder, Expression arg0)
		: base(delegateType, binder, arg0)
	{
		_retType = retType;
	}
}
