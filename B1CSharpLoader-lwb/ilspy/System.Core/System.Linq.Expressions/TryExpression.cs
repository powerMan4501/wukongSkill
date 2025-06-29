using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TryExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class TryExpression : Expression
{
	private readonly Type _type;

	private readonly Expression _body;

	private readonly ReadOnlyCollection<CatchBlock> _handlers;

	private readonly Expression _finally;

	private readonly Expression _fault;

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
			return ExpressionType.Try;
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
	public ReadOnlyCollection<CatchBlock> Handlers
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _handlers;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Finally
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _finally;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Fault
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _fault;
		}
	}

	internal TryExpression(Type type, Expression body, Expression @finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers)
	{
		_type = type;
		_body = body;
		_handlers = handlers;
		_finally = @finally;
		_fault = fault;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitTry(this);
	}

	[global::__DynamicallyInvokable]
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault)
	{
		if (body == Body && handlers == Handlers && @finally == Finally && fault == Fault)
		{
			return this;
		}
		return Expression.MakeTry(Type, body, @finally, fault, handlers);
	}
}
