using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions;

internal sealed class Scope1 : ScopeExpression
{
	private object _body;

	internal override int ExpressionCount => 1;

	internal Scope1(IList<ParameterExpression> variables, Expression body)
		: base(variables)
	{
		_body = body;
	}

	internal override Expression GetExpression(int index)
	{
		if (index == 0)
		{
			return Expression.ReturnObject<Expression>(_body);
		}
		throw new InvalidOperationException();
	}

	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions()
	{
		return BlockExpression.ReturnReadOnlyExpressions(this, ref _body);
	}

	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
	{
		return new Scope1(ReuseOrValidateVariables(variables), args[0]);
	}
}
