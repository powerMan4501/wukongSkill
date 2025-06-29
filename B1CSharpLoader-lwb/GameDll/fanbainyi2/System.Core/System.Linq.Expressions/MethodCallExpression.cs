using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MethodCallExpressionProxy))]
[global::__DynamicallyInvokable]
public class MethodCallExpression : Expression, IArgumentProvider
{
	private readonly MethodInfo _method;

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Call;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _method.ReturnType;
		}
	}

	[global::__DynamicallyInvokable]
	public MethodInfo Method
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _method;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Object
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetInstance();
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

	internal MethodCallExpression(MethodInfo method)
	{
		_method = method;
	}

	internal virtual Expression GetInstance()
	{
		return null;
	}

	[global::__DynamicallyInvokable]
	public MethodCallExpression Update(Expression @object, IEnumerable<Expression> arguments)
	{
		if (@object == Object && arguments == Arguments)
		{
			return this;
		}
		return Expression.Call(@object, Method, arguments);
	}

	internal virtual ReadOnlyCollection<Expression> GetOrMakeArguments()
	{
		throw ContractUtils.Unreachable;
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitMethodCall(this);
	}

	internal virtual MethodCallExpression Rewrite(Expression instance, IList<Expression> args)
	{
		throw ContractUtils.Unreachable;
	}

	[global::__DynamicallyInvokable]
	Expression IArgumentProvider.GetArgument(int index)
	{
		throw ContractUtils.Unreachable;
	}
}
