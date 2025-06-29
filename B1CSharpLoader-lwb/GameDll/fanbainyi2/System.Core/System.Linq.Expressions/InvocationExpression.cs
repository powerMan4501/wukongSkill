using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class InvocationExpression : Expression, IArgumentProvider
{
	private IList<Expression> _arguments;

	private readonly Expression _lambda;

	private readonly Type _returnType;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _returnType;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Invoke;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Expression
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _lambda;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<Expression> Arguments
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Expression.ReturnReadOnly(ref _arguments);
		}
	}

	[global::__DynamicallyInvokable]
	int IArgumentProvider.ArgumentCount
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _arguments.Count;
		}
	}

	internal LambdaExpression LambdaOperand
	{
		get
		{
			if (_lambda.NodeType != ExpressionType.Quote)
			{
				return _lambda as LambdaExpression;
			}
			return (LambdaExpression)((UnaryExpression)_lambda).Operand;
		}
	}

	internal InvocationExpression(Expression lambda, IList<Expression> arguments, Type returnType)
	{
		_lambda = lambda;
		_arguments = arguments;
		_returnType = returnType;
	}

	[global::__DynamicallyInvokable]
	public InvocationExpression Update(Expression expression, IEnumerable<Expression> arguments)
	{
		if (expression == Expression && arguments == Arguments)
		{
			return this;
		}
		return Expression.Invoke(expression, arguments);
	}

	[global::__DynamicallyInvokable]
	Expression IArgumentProvider.GetArgument(int index)
	{
		return _arguments[index];
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitInvocation(this);
	}

	internal InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
	{
		return Expression.Invoke(lambda, arguments ?? _arguments);
	}
}
