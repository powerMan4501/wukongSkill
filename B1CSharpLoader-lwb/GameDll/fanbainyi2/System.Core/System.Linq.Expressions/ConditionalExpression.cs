using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ConditionalExpressionProxy))]
[global::__DynamicallyInvokable]
public class ConditionalExpression : Expression
{
	private readonly Expression _test;

	private readonly Expression _true;

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Conditional;
		}
	}

	[global::__DynamicallyInvokable]
	public override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return IfTrue.Type;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Test
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _test;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression IfTrue
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _true;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression IfFalse
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetFalse();
		}
	}

	internal ConditionalExpression(Expression test, Expression ifTrue)
	{
		_test = test;
		_true = ifTrue;
	}

	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type)
	{
		if (ifTrue.Type != type || ifFalse.Type != type)
		{
			return new FullConditionalExpressionWithType(test, ifTrue, ifFalse, type);
		}
		if (ifFalse is DefaultExpression && ifFalse.Type == typeof(void))
		{
			return new ConditionalExpression(test, ifTrue);
		}
		return new FullConditionalExpression(test, ifTrue, ifFalse);
	}

	internal virtual Expression GetFalse()
	{
		return Expression.Empty();
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitConditional(this);
	}

	[global::__DynamicallyInvokable]
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse)
	{
		if (test == Test && ifTrue == IfTrue && ifFalse == IfFalse)
		{
			return this;
		}
		return Expression.Condition(test, ifTrue, ifFalse, Type);
	}
}
