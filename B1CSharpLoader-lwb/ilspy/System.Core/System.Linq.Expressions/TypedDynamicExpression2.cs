using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

internal sealed class TypedDynamicExpression2 : DynamicExpression2
{
	private readonly Type _retType;

	public sealed override Type Type => _retType;

	internal TypedDynamicExpression2(Type retType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
		: base(delegateType, binder, arg0, arg1)
	{
		_retType = retType;
	}
}
