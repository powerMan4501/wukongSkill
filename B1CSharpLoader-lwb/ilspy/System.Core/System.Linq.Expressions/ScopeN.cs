using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal class ScopeN : ScopeExpression
{
	private IList<Expression> _body;

	internal override int ExpressionCount => _body.Count;

	internal ScopeN(IList<ParameterExpression> variables, IList<Expression> body)
		: base(variables)
	{
		_body = body;
	}

	internal override Expression GetExpression(int index)
	{
		return _body[index];
	}

	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
	{
		return Expression.ReturnReadOnly(ref _body);
	}

	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
	{
		return new ScopeN(ReuseOrValidateVariables(variables), args);
	}
}
