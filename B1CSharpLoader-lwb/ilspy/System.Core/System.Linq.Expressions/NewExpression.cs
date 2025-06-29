using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewExpressionProxy))]
[global::__DynamicallyInvokable]
public class NewExpression : Expression, IArgumentProvider
{
	private readonly ConstructorInfo _constructor;

	private IList<Expression> _arguments;

	private readonly ReadOnlyCollection<MemberInfo> _members;

	[global::__DynamicallyInvokable]
	public override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _constructor.DeclaringType;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.New;
		}
	}

	[global::__DynamicallyInvokable]
	public ConstructorInfo Constructor
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _constructor;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<Expression> Arguments
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Expression.ReturnReadOnly(ref _arguments);
		}
	}

	[global::__DynamicallyInvokable]
	int IArgumentProvider.ArgumentCount
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _arguments.Count;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<MemberInfo> Members
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _members;
		}
	}

	internal NewExpression(ConstructorInfo constructor, IList<Expression> arguments, ReadOnlyCollection<MemberInfo> members)
	{
		_constructor = constructor;
		_arguments = arguments;
		_members = members;
	}

	[global::__DynamicallyInvokable]
	Expression IArgumentProvider.GetArgument(int index)
	{
		return _arguments[index];
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitNew(this);
	}

	[global::__DynamicallyInvokable]
	public NewExpression Update(IEnumerable<Expression> arguments)
	{
		if (arguments == Arguments)
		{
			return this;
		}
		if (Members != null)
		{
			return Expression.New(Constructor, arguments, Members);
		}
		return Expression.New(Constructor, arguments);
	}
}
