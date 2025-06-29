using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions;

internal class InstanceMethodCallExpression3 : MethodCallExpression, IArgumentProvider
{
	private readonly Expression _instance;

	private object _arg0;

	private readonly Expression _arg1;

	private readonly Expression _arg2;

	int IArgumentProvider.ArgumentCount => 3;

	public InstanceMethodCallExpression3(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2)
		: base(method)
	{
		_instance = instance;
		_arg0 = arg0;
		_arg1 = arg1;
		_arg2 = arg2;
	}

	Expression IArgumentProvider.GetArgument(int index)
	{
		return index switch
		{
			0 => Expression.ReturnObject<Expression>(_arg0), 
			1 => _arg1, 
			2 => _arg2, 
			_ => throw new InvalidOperationException(), 
		};
	}

	internal override Expression GetInstance()
	{
		return _instance;
	}

	internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
	{
		return Expression.ReturnReadOnly(this, ref _arg0);
	}

	internal override MethodCallExpression Rewrite(Expression instance, IList<Expression> args)
	{
		if (args != null)
		{
			return Expression.Call(instance, base.Method, args[0], args[1], args[2]);
		}
		return Expression.Call(instance, base.Method, Expression.ReturnObject<Expression>(_arg0), _arg1, _arg2);
	}
}
