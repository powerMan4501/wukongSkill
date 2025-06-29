using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(SwitchExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class SwitchExpression : Expression
{
	private readonly Type _type;

	private readonly Expression _switchValue;

	private readonly ReadOnlyCollection<SwitchCase> _cases;

	private readonly Expression _defaultBody;

	private readonly MethodInfo _comparison;

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
			return ExpressionType.Switch;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression SwitchValue
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _switchValue;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<SwitchCase> Cases
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _cases;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression DefaultBody
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _defaultBody;
		}
	}

	[global::__DynamicallyInvokable]
	public MethodInfo Comparison
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _comparison;
		}
	}

	internal bool IsLifted
	{
		get
		{
			if (_switchValue.Type.IsNullableType())
			{
				if (!(_comparison == null))
				{
					return !TypeUtils.AreEquivalent(_switchValue.Type, _comparison.GetParametersCached()[0].ParameterType.GetNonRefType());
				}
				return true;
			}
			return false;
		}
	}

	internal SwitchExpression(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, ReadOnlyCollection<SwitchCase> cases)
	{
		_type = type;
		_switchValue = switchValue;
		_defaultBody = defaultBody;
		_comparison = comparison;
		_cases = cases;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitSwitch(this);
	}

	[global::__DynamicallyInvokable]
	public SwitchExpression Update(Expression switchValue, IEnumerable<SwitchCase> cases, Expression defaultBody)
	{
		if (switchValue == SwitchValue && cases == Cases && defaultBody == DefaultBody)
		{
			return this;
		}
		return Expression.Switch(Type, switchValue, defaultBody, Comparison, cases);
	}
}
