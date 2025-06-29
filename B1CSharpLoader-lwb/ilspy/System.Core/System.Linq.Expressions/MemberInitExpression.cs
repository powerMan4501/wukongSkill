using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberInitExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class MemberInitExpression : Expression
{
	private readonly NewExpression _newExpression;

	private readonly ReadOnlyCollection<MemberBinding> _bindings;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _newExpression.Type;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool CanReduce
	{
		[global::__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.MemberInit;
		}
	}

	[global::__DynamicallyInvokable]
	public NewExpression NewExpression
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _newExpression;
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<MemberBinding> Bindings
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _bindings;
		}
	}

	internal MemberInitExpression(NewExpression newExpression, ReadOnlyCollection<MemberBinding> bindings)
	{
		_newExpression = newExpression;
		_bindings = bindings;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitMemberInit(this);
	}

	[global::__DynamicallyInvokable]
	public override Expression Reduce()
	{
		return ReduceMemberInit(_newExpression, _bindings, keepOnStack: true);
	}

	internal static Expression ReduceMemberInit(Expression objExpression, ReadOnlyCollection<MemberBinding> bindings, bool keepOnStack)
	{
		ParameterExpression parameterExpression = Expression.Variable(objExpression.Type, null);
		int count = bindings.Count;
		Expression[] array = new Expression[count + 2];
		array[0] = Expression.Assign(parameterExpression, objExpression);
		for (int i = 0; i < count; i++)
		{
			array[i + 1] = ReduceMemberBinding(parameterExpression, bindings[i]);
		}
		array[count + 1] = (keepOnStack ? ((Expression)parameterExpression) : ((Expression)Expression.Empty()));
		return Expression.Block(new TrueReadOnlyCollection<Expression>(array));
	}

	internal static Expression ReduceListInit(Expression listExpression, ReadOnlyCollection<ElementInit> initializers, bool keepOnStack)
	{
		ParameterExpression parameterExpression = Expression.Variable(listExpression.Type, null);
		int count = initializers.Count;
		Expression[] array = new Expression[count + 2];
		array[0] = Expression.Assign(parameterExpression, listExpression);
		for (int i = 0; i < count; i++)
		{
			ElementInit elementInit = initializers[i];
			array[i + 1] = Expression.Call(parameterExpression, elementInit.AddMethod, elementInit.Arguments);
		}
		array[count + 1] = (keepOnStack ? ((Expression)parameterExpression) : ((Expression)Expression.Empty()));
		return Expression.Block(new TrueReadOnlyCollection<Expression>(array));
	}

	internal static Expression ReduceMemberBinding(ParameterExpression objVar, MemberBinding binding)
	{
		MemberExpression memberExpression = Expression.MakeMemberAccess(objVar, binding.Member);
		return binding.BindingType switch
		{
			MemberBindingType.Assignment => Expression.Assign(memberExpression, ((MemberAssignment)binding).Expression), 
			MemberBindingType.ListBinding => ReduceListInit(memberExpression, ((MemberListBinding)binding).Initializers, keepOnStack: false), 
			MemberBindingType.MemberBinding => ReduceMemberInit(memberExpression, ((MemberMemberBinding)binding).Bindings, keepOnStack: false), 
			_ => throw ContractUtils.Unreachable, 
		};
	}

	[global::__DynamicallyInvokable]
	public MemberInitExpression Update(NewExpression newExpression, IEnumerable<MemberBinding> bindings)
	{
		if (newExpression == NewExpression && bindings == Bindings)
		{
			return this;
		}
		return Expression.MemberInit(newExpression, bindings);
	}
}
