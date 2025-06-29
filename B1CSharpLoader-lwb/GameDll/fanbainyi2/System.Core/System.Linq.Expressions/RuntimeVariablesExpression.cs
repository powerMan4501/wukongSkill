using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(RuntimeVariablesExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class RuntimeVariablesExpression : Expression
{
	private readonly ReadOnlyCollection<ParameterExpression> _variables;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return typeof(IRuntimeVariables);
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.RuntimeVariables;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<ParameterExpression> Variables
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _variables;
		}
	}

	internal RuntimeVariablesExpression(ReadOnlyCollection<ParameterExpression> variables)
	{
		_variables = variables;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitRuntimeVariables(this);
	}

	[global::__DynamicallyInvokable]
	public RuntimeVariablesExpression Update(IEnumerable<ParameterExpression> variables)
	{
		if (variables == Variables)
		{
			return this;
		}
		return Expression.RuntimeVariables(variables);
	}
}
