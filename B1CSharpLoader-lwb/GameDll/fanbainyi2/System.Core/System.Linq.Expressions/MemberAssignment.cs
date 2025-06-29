using System.Reflection;

namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public sealed class MemberAssignment : MemberBinding
{
	private Expression _expression;

	[global::__DynamicallyInvokable]
	public Expression Expression
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _expression;
		}
	}

	internal MemberAssignment(MemberInfo member, Expression expression)
		: base(MemberBindingType.Assignment, member)
	{
		_expression = expression;
	}

	[global::__DynamicallyInvokable]
	public MemberAssignment Update(Expression expression)
	{
		if (expression == Expression)
		{
			return this;
		}
		return Expression.Bind(base.Member, expression);
	}
}
