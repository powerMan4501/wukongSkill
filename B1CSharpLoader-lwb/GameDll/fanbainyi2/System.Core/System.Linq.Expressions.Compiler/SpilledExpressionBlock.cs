using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions.Compiler;

internal sealed class SpilledExpressionBlock : BlockN
{
	internal SpilledExpressionBlock(IList<Expression> expressions)
		: base(expressions)
	{
	}

	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
	{
		throw ContractUtils.Unreachable;
	}
}
