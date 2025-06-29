using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

internal class TypedDynamicExpressionN : DynamicExpressionN
{
	private readonly Type _returnType;

	public sealed override Type Type => _returnType;

	internal TypedDynamicExpressionN(Type returnType, Type delegateType, CallSiteBinder binder, IList<Expression> arguments)
		: base(delegateType, binder, arguments)
	{
		_returnType = returnType;
	}
}
