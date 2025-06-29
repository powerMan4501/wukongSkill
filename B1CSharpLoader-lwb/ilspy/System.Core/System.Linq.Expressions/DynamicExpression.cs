using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DynamicExpressionProxy))]
[global::__DynamicallyInvokable]
public class DynamicExpression : Expression, IDynamicExpression, IArgumentProvider
{
	private readonly CallSiteBinder _binder;

	private readonly Type _delegateType;

	[global::__DynamicallyInvokable]
	public override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return typeof(object);
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Dynamic;
		}
	}

	[global::__DynamicallyInvokable]
	public CallSiteBinder Binder
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _binder;
		}
	}

	[global::__DynamicallyInvokable]
	public Type DelegateType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _delegateType;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<Expression> Arguments
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetOrMakeArguments();
		}
	}

	[global::__DynamicallyInvokable]
	int IArgumentProvider.ArgumentCount
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ContractUtils.Unreachable;
		}
	}

	internal DynamicExpression(Type delegateType, CallSiteBinder binder)
	{
		_delegateType = delegateType;
		_binder = binder;
	}

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, ReadOnlyCollection<Expression> arguments)
	{
		if (returnType == typeof(object))
		{
			return new DynamicExpressionN(delegateType, binder, arguments);
		}
		return new TypedDynamicExpressionN(returnType, delegateType, binder, arguments);
	}

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0)
	{
		if (returnType == typeof(object))
		{
			return new DynamicExpression1(delegateType, binder, arg0);
		}
		return new TypedDynamicExpression1(returnType, delegateType, binder, arg0);
	}

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
	{
		if (returnType == typeof(object))
		{
			return new DynamicExpression2(delegateType, binder, arg0, arg1);
		}
		return new TypedDynamicExpression2(returnType, delegateType, binder, arg0, arg1);
	}

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
	{
		if (returnType == typeof(object))
		{
			return new DynamicExpression3(delegateType, binder, arg0, arg1, arg2);
		}
		return new TypedDynamicExpression3(returnType, delegateType, binder, arg0, arg1, arg2);
	}

	internal static DynamicExpression Make(Type returnType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
	{
		if (returnType == typeof(object))
		{
			return new DynamicExpression4(delegateType, binder, arg0, arg1, arg2, arg3);
		}
		return new TypedDynamicExpression4(returnType, delegateType, binder, arg0, arg1, arg2, arg3);
	}

	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments()
	{
		throw ContractUtils.Unreachable;
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitDynamic(this);
	}

	internal virtual DynamicExpression Rewrite(Expression[] args)
	{
		throw ContractUtils.Unreachable;
	}

	[global::__DynamicallyInvokable]
	public DynamicExpression Update(IEnumerable<Expression> arguments)
	{
		if (arguments == Arguments)
		{
			return this;
		}
		return Expression.MakeDynamic(DelegateType, Binder, arguments);
	}

	[global::__DynamicallyInvokable]
	Expression IArgumentProvider.GetArgument(int index)
	{
		throw ContractUtils.Unreachable;
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, params Expression[] arguments)
	{
		return Expression.Dynamic(binder, returnType, arguments);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments)
	{
		return Expression.Dynamic(binder, returnType, arguments);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0)
	{
		return Expression.Dynamic(binder, returnType, arg0);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1)
	{
		return Expression.Dynamic(binder, returnType, arg0, arg1);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2)
	{
		return Expression.Dynamic(binder, returnType, arg0, arg1, arg2);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
	{
		return Expression.Dynamic(binder, returnType, arg0, arg1, arg2, arg3);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments)
	{
		return Expression.MakeDynamic(delegateType, binder, arguments);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, params Expression[] arguments)
	{
		return Expression.MakeDynamic(delegateType, binder, arguments);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0)
	{
		return Expression.MakeDynamic(delegateType, binder, arg0);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
	{
		return Expression.MakeDynamic(delegateType, binder, arg0, arg1);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
	{
		return Expression.MakeDynamic(delegateType, binder, arg0, arg1, arg2);
	}

	[global::__DynamicallyInvokable]
	public new static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
	{
		return Expression.MakeDynamic(delegateType, binder, arg0, arg1, arg2, arg3);
	}

	[global::__DynamicallyInvokable]
	Expression IDynamicExpression.Rewrite(Expression[] args)
	{
		return Rewrite(args);
	}

	[global::__DynamicallyInvokable]
	object IDynamicExpression.CreateCallSite()
	{
		return CallSite.Create(DelegateType, Binder);
	}
}
