using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
[global::__DynamicallyInvokable]
public sealed class CatchBlock
{
	private readonly Type _test;

	private readonly ParameterExpression _var;

	private readonly Expression _body;

	private readonly Expression _filter;

	[global::__DynamicallyInvokable]
	public ParameterExpression Variable
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _var;
		}
	}

	[global::__DynamicallyInvokable]
	public Type Test
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _test;
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
	public Expression Filter
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _filter;
		}
	}

	internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter)
	{
		_test = test;
		_var = variable;
		_body = body;
		_filter = filter;
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return ExpressionStringBuilder.CatchBlockToString(this);
	}

	[global::__DynamicallyInvokable]
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body)
	{
		if (variable == Variable && filter == Filter && body == Body)
		{
			return this;
		}
		return Expression.MakeCatchBlock(Test, variable, body, filter);
	}
}
