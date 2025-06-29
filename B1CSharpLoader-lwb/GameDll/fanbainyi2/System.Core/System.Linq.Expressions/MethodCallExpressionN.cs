using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

internal class MethodCallExpressionN : MethodCallExpression, IArgumentProvider
{
	private IList<Expression> _arguments;

	int IArgumentProvider.ArgumentCount => _arguments.Count;

	public MethodCallExpressionN(MethodInfo method, IList<Expression> args)
		: base(method)
	{
		_arguments = args;
	}

	Expression IArgumentProvider.GetArgument(int index)
	{
		return _arguments[index];
	}

	internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
	{
		return Expression.ReturnReadOnly(ref _arguments);
	}

	internal override MethodCallExpression Rewrite(Expression instance, IList<Expression> args)
	{
		return Expression.Call(base.Method, args ?? _arguments);
	}
}
