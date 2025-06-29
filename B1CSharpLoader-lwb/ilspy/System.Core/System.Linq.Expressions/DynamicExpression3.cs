using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

internal class DynamicExpression3 : DynamicExpression, IArgumentProvider
{
	private object _arg0;

	private readonly Expression _arg1;

	private readonly Expression _arg2;

	int IArgumentProvider.ArgumentCount => 3;

	internal DynamicExpression3(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
		: base(delegateType, binder)
	{
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

	internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
	{
		return Expression.ReturnReadOnly(this, ref _arg0);
	}

	internal override DynamicExpression Rewrite(Expression[] args)
	{
		return Expression.MakeDynamic(base.DelegateType, base.Binder, args[0], args[1], args[2]);
	}
}
