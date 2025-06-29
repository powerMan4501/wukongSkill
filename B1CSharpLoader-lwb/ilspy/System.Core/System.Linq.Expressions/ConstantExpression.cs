using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ConstantExpressionProxy))]
[global::__DynamicallyInvokable]
public class ConstantExpression : Expression
{
	private readonly object _value;

	[global::__DynamicallyInvokable]
	public override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_value == null)
			{
				return typeof(object);
			}
			return _value.GetType();
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Constant;
		}
	}

	[global::__DynamicallyInvokable]
	public object Value
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _value;
		}
	}

	internal ConstantExpression(object value)
	{
		_value = value;
	}

	internal static ConstantExpression Make(object value, Type type)
	{
		if ((value == null && type == typeof(object)) || (value != null && value.GetType() == type))
		{
			return new ConstantExpression(value);
		}
		return new TypedConstantExpression(value, type);
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitConstant(this);
	}
}
