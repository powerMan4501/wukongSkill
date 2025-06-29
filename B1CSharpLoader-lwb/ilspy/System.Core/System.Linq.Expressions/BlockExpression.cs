using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Threading;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
[global::__DynamicallyInvokable]
public class BlockExpression : Expression
{
	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<Expression> Expressions
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetOrMakeExpressions();
		}
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<ParameterExpression> Variables
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetOrMakeVariables();
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Result
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetExpression(ExpressionCount - 1);
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return ExpressionType.Block;
		}
	}

	[global::__DynamicallyInvokable]
	public override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetExpression(ExpressionCount - 1).Type;
		}
	}

	internal virtual int ExpressionCount
	{
		get
		{
			throw ContractUtils.Unreachable;
		}
	}

	internal virtual int VariableCount => 0;

	internal BlockExpression()
	{
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitBlock(this);
	}

	[global::__DynamicallyInvokable]
	public BlockExpression Update(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions)
	{
		if (variables == Variables && expressions == Expressions)
		{
			return this;
		}
		return Expression.Block(Type, variables, expressions);
	}

	internal virtual Expression GetExpression(int index)
	{
		throw ContractUtils.Unreachable;
	}

	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions()
	{
		throw ContractUtils.Unreachable;
	}

	internal virtual ParameterExpression GetVariable(int index)
	{
		throw ContractUtils.Unreachable;
	}

	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
	{
		return EmptyReadOnlyCollection<ParameterExpression>.Instance;
	}

	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
	{
		throw ContractUtils.Unreachable;
	}

	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection)
	{
		if (collection is Expression expression)
		{
			Interlocked.CompareExchange(ref collection, new ReadOnlyCollection<Expression>(new BlockExpressionList(provider, expression)), expression);
		}
		return (ReadOnlyCollection<Expression>)collection;
	}
}
