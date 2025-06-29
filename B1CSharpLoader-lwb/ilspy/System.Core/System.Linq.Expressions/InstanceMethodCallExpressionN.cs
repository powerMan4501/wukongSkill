using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

internal class InstanceMethodCallExpressionN : MethodCallExpression, IArgumentProvider
{
	private IList<Expression> _arguments;

	private readonly Expression _instance;

	int IArgumentProvider.ArgumentCount => _arguments.Count;

	public InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IList<Expression> args)
		: base(method)
	{
		_instance = instance;
		_arguments = args;
	}

	Expression IArgumentProvider.GetArgument(int index)
	{
		return _arguments[index];
	}

	internal override Expression GetInstance()
	{
		return _instance;
	}

	internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
	{
		return Expression.ReturnReadOnly(ref _arguments);
	}

	internal override MethodCallExpression Rewrite(Expression instance, IList<Expression> args)
	{
		return Expression.Call(instance, base.Method, args ?? _arguments);
	}
}
