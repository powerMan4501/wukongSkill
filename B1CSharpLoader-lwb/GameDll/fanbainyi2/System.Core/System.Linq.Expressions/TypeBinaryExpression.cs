using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class TypeBinaryExpression : Expression
{
	private readonly Expression _expression;

	private readonly Type _typeOperand;

	private readonly ExpressionType _nodeKind;

	[global::__DynamicallyInvokable]
	public sealed override Type Type
	{
		[global::__DynamicallyInvokable]
		get
		{
			return typeof(bool);
		}
	}

	[global::__DynamicallyInvokable]
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _nodeKind;
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
	public Type TypeOperand
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _typeOperand;
		}
	}

	internal TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeKind)
	{
		_expression = expression;
		_typeOperand = typeOperand;
		_nodeKind = nodeKind;
	}

	internal Expression ReduceTypeEqual()
	{
		Type type = Expression.Type;
		if (type.IsValueType && !type.IsNullableType())
		{
			return Expression.Block(Expression, Expression.Constant(type == _typeOperand.GetNonNullableType()));
		}
		if (Expression.NodeType == ExpressionType.Constant)
		{
			return ReduceConstantTypeEqual();
		}
		if (type.IsSealed && type == _typeOperand)
		{
			if (type.IsNullableType())
			{
				return Expression.NotEqual(Expression, Expression.Constant(null, Expression.Type));
			}
			return Expression.ReferenceNotEqual(Expression, Expression.Constant(null, Expression.Type));
		}
		if (Expression is ParameterExpression { IsByRef: false } parameterExpression)
		{
			return ByValParameterTypeEqual(parameterExpression);
		}
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object));
		Expression expression = Expression;
		if (!TypeUtils.AreReferenceAssignable(typeof(object), expression.Type))
		{
			expression = Expression.Convert(expression, typeof(object));
		}
		return Expression.Block(new ParameterExpression[1] { parameterExpression2 }, Expression.Assign(parameterExpression2, expression), ByValParameterTypeEqual(parameterExpression2));
	}

	private Expression ByValParameterTypeEqual(ParameterExpression value)
	{
		Expression expression = Expression.Call(value, typeof(object).GetMethod("GetType"));
		if (_typeOperand.IsInterface)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(Type));
			expression = Expression.Block(new ParameterExpression[1] { parameterExpression }, Expression.Assign(parameterExpression, expression), parameterExpression);
		}
		return Expression.AndAlso(Expression.ReferenceNotEqual(value, Expression.Constant(null)), Expression.ReferenceEqual(expression, Expression.Constant(_typeOperand.GetNonNullableType(), typeof(Type))));
	}

	private Expression ReduceConstantTypeEqual()
	{
		ConstantExpression constantExpression = Expression as ConstantExpression;
		if (constantExpression.Value == null)
		{
			return Expression.Constant(false);
		}
		return Expression.Constant(_typeOperand.GetNonNullableType() == constantExpression.Value.GetType());
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitTypeBinary(this);
	}

	[global::__DynamicallyInvokable]
	public TypeBinaryExpression Update(Expression expression)
	{
		if (expression == Expression)
		{
			return this;
		}
		if (NodeType == ExpressionType.TypeIs)
		{
			return Expression.TypeIs(expression, TypeOperand);
		}
		return Expression.TypeEqual(expression, TypeOperand);
	}
}
