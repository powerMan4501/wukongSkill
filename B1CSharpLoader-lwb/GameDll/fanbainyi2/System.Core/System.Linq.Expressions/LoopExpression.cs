using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class LoopExpression : Expression
{
	private readonly Expression _body;

	private readonly LabelTarget _break;

	private readonly LabelTarget _continue;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_break != null)
			{
				return _break.Type;
			}
			return typeof(void);
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Loop;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Body
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _body;
		}
	}

	[global::__DynamicallyInvokable]
	public LabelTarget BreakLabel
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _break;
		}
	}

	[global::__DynamicallyInvokable]
	public LabelTarget ContinueLabel
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _continue;
		}
	}

	internal LoopExpression(Expression body, LabelTarget @break, LabelTarget @continue)
	{
		_body = body;
		_break = @break;
		_continue = @continue;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitLoop(this);
	}

	[global::__DynamicallyInvokable]
	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body)
	{
		if (breakLabel == BreakLabel && continueLabel == ContinueLabel && body == Body)
		{
			return this;
		}
		return Expression.Loop(body, breakLabel, continueLabel);
	}
}
