using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ListInitExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class ListInitExpression : Expression
{
	private readonly NewExpression _newExpression;

	private readonly ReadOnlyCollection<ElementInit> _initializers;

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.ListInit;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _newExpression.Type;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool CanReduce
	{
		[global::__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[global::__DynamicallyInvokable]
	public NewExpression NewExpression
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _newExpression;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<ElementInit> Initializers
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _initializers;
		}
	}

	internal ListInitExpression(NewExpression newExpression, ReadOnlyCollection<ElementInit> initializers)
	{
		_newExpression = newExpression;
		_initializers = initializers;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitListInit(this);
	}

	[global::__DynamicallyInvokable]
	public override Expression Reduce()
	{
		return MemberInitExpression.ReduceListInit(_newExpression, _initializers, keepOnStack: true);
	}

	[global::__DynamicallyInvokable]
	public ListInitExpression Update(NewExpression newExpression, IEnumerable<ElementInit> initializers)
	{
		if (newExpression == NewExpression && initializers == Initializers)
		{
			return this;
		}
		return Expression.ListInit(newExpression, initializers);
	}
}
