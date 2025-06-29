using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

internal class MethodCallExpression1 : MethodCallExpression, IArgumentProvider
{
	private object _arg0;

	int IArgumentProvider.ArgumentCount => 1;

	public MethodCallExpression1(MethodInfo method, Expression arg0)
		: base(method)
	{
		_arg0 = arg0;
	}

	Expression IArgumentProvider.GetArgument(int index)
	{
		if (index == 0)
		{
			return Expression.ReturnObject<Expression>(_arg0);
		}
		throw new InvalidOperationException();
	}

	internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
	{
		return Expression.ReturnReadOnly(this, ref _arg0);
	}

	internal override MethodCallExpression Rewrite(Expression instance, IList<Expression> args)
	{
		if (args != null)
		{
			return Expression.Call(base.Method, args[0]);
		}
		return Expression.Call(base.Method, Expression.ReturnObject<Expression>(_arg0));
	}
}
