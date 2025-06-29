using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LabelExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class LabelExpression : Expression
{
	private readonly Expression _defaultValue;

	private readonly LabelTarget _target;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _target.Type;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Label;
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
	public Expression DefaultValue
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _defaultValue;
		}
	}

	internal LabelExpression(LabelTarget label, Expression defaultValue)
	{
		_target = label;
		_defaultValue = defaultValue;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitLabel(this);
	}

	[global::__DynamicallyInvokable]
	public LabelExpression Update(LabelTarget target, Expression defaultValue)
	{
		if (target == Target && defaultValue == DefaultValue)
		{
			return this;
		}
		return Expression.Label(target, defaultValue);
	}
}
