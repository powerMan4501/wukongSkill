using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

internal class MethodCallExpression2 : MethodCallExpression, IArgumentProvider
{
	private object _arg0;

	private readonly Expression _arg1;

	int IArgumentProvider.ArgumentCount => 2;

	public MethodCallExpression2(MethodInfo method, Expression arg0, Expression arg1)
		: base(method)
	{
		_arg0 = arg0;
		_arg1 = arg1;
	}

	Expression IArgumentProvider.GetArgument(int index)
	{
		return index switch
		{
			0 => Expression.ReturnObject<Expression>(_arg0), 
			1 => _arg1, 
			_ => throw new InvalidOperationException(), 
		};
	}

	internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
	{
		return Expression.ReturnReadOnly(this, ref _arg0);
	}

	internal override MethodCallExpression Rewrite(Expression instance, IList<Expression> args)
	{
		if (args != null)
		{
			return Expression.Call(base.Method, args[0], args[1]);
		}
		return Expression.Call(base.Method, Expression.ReturnObject<Expression>(_arg0), _arg1);
	}
}
