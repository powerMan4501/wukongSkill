using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
[global::__DynamicallyInvokable]
public class MemberExpression : Expression
{
	private readonly Expression _expression;

	[global::__DynamicallyInvokable]
	public MemberInfo Member
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetMember();
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Expression
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _expression;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.MemberAccess;
		}
	}

	internal MemberExpression(Expression expression)
	{
		_expression = expression;
	}

	internal static MemberExpression Make(Expression expression, MemberInfo member)
	{
		if (member.MemberType == MemberTypes.Field)
		{
			FieldInfo member2 = (FieldInfo)member;
			return new FieldExpression(expression, member2);
		}
		PropertyInfo member3 = (PropertyInfo)member;
		return new PropertyExpression(expression, member3);
	}

	internal virtual MemberInfo GetMember()
	{
		throw ContractUtils.Unreachable;
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitMember(this);
	}

	[global::__DynamicallyInvokable]
	public MemberExpression Update(Expression expression)
	{
		if (expression == Expression)
		{
			return this;
		}
		return Expression.MakeMemberAccess(expression, Member);
	}
}
