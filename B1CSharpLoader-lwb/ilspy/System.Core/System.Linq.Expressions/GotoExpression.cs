using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(GotoExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class GotoExpression : Expression
{
	private readonly GotoExpressionKind _kind;

	private readonly Expression _value;

	private readonly LabelTarget _target;

	private readonly Type _type;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _type;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Goto;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Value
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _value;
		}
	}

	[global::__DynamicallyInvokable]
	public LabelTarget Target
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _target;
		}
	}

	[global::__DynamicallyInvokable]
	public GotoExpressionKind Kind
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _kind;
		}
	}

	internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, Type type)
	{
		_kind = kind;
		_value = value;
		_target = target;
		_type = type;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitGoto(this);
	}

	[global::__DynamicallyInvokable]
	public GotoExpression Update(LabelTarget target, Expression value)
	{
		if (target == Target && value == Value)
		{
			return this;
		}
		return Expression.MakeGoto(Kind, target, value, Type);
	}
}
