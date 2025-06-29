using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewArrayExpressionProxy))]
[global::__DynamicallyInvokable]
public class NewArrayExpression : Expression
{
	private readonly ReadOnlyCollection<Expression> _expressions;

	private readonly Type _type;

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
	public ReadOnlyCollection<Expression> Expressions
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _expressions;
		}
	}

	internal NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions)
	{
		_expressions = expressions;
		_type = type;
	}

	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions)
	{
		if (nodeType == ExpressionType.NewArrayInit)
		{
			return new NewArrayInitExpression(type, expressions);
		}
		return new NewArrayBoundsExpression(type, expressions);
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitNewArray(this);
	}

	[global::__DynamicallyInvokable]
	public NewArrayExpression Update(IEnumerable<Expression> expressions)
	{
		if (expressions == Expressions)
		{
			return this;
		}
		if (NodeType == ExpressionType.NewArrayInit)
		{
			return Expression.NewArrayInit(Type.GetElementType(), expressions);
		}
		return Expression.NewArrayBounds(Type.GetElementType(), expressions);
	}
}
