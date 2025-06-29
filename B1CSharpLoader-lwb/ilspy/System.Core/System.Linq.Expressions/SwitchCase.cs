using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(Expression.SwitchCaseProxy))]
[global::__DynamicallyInvokable]
public sealed class SwitchCase
{
	private readonly ReadOnlyCollection<Expression> _testValues;

	private readonly Expression _body;

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<Expression> TestValues
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _testValues;
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

	internal SwitchCase(Expression body, ReadOnlyCollection<Expression> testValues)
	{
		_body = body;
		_testValues = testValues;
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return ExpressionStringBuilder.SwitchCaseToString(this);
	}

	[global::__DynamicallyInvokable]
	public SwitchCase Update(IEnumerable<Expression> testValues, Expression body)
	{
		if (testValues == TestValues && body == Body)
		{
			return this;
		}
		return Expression.SwitchCase(body, testValues);
	}
}
