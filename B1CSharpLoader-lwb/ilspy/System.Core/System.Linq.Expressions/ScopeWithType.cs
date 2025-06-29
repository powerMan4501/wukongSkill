using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal class ScopeWithType : ScopeN
{
	private readonly Type _type;

	public sealed override Type Type => _type;

	internal ScopeWithType(IList<ParameterExpression> variables, IList<Expression> expressions, Type type)
		: base(variables, expressions)
	{
		_type = type;
	}

	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
	{
		return new ScopeWithType(ReuseOrValidateVariables(variables), args, _type);
	}
}
