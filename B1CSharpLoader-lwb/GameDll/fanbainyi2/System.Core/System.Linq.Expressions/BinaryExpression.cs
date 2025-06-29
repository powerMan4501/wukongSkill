using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
[global::__DynamicallyInvokable]
public class BinaryExpression : Expression
{
	private readonly Expression _left;

	private readonly Expression _right;

	[global::__DynamicallyInvokable]
	public override bool CanReduce
	{
		[global::__DynamicallyInvokable]
		get
		{
			return IsOpAssignment(NodeType);
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Right
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _right;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Left
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _left;
		}
	}

	[global::__DynamicallyInvokable]
	public MethodInfo Method
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetMethod();
		}
	}

	[global::__DynamicallyInvokable]
	public LambdaExpression Conversion
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetConversion();
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsLifted
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (NodeType == ExpressionType.Coalesce || NodeType == ExpressionType.Assign)
			{
				return false;
			}
			if (_left.Type.IsNullableType())
			{
				MethodInfo method = GetMethod();
				if (!(method == null))
				{
					return !TypeUtils.AreEquivalent(method.GetParametersCached()[0].ParameterType.GetNonRefType(), _left.Type);
				}
				return true;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsLiftedToNull
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (IsLifted)
			{
				return Type.IsNullableType();
			}
			return false;
		}
	}

	internal bool IsLiftedLogical
	{
		get
		{
			Type type = _left.Type;
			Type type2 = _right.Type;
			MethodInfo method = GetMethod();
			ExpressionType nodeType = NodeType;
			if ((nodeType == ExpressionType.AndAlso || nodeType == ExpressionType.OrElse) && TypeUtils.AreEquivalent(type2, type) && type.IsNullableType() && method != null)
			{
				return TypeUtils.AreEquivalent(method.ReturnType, type.GetNonNullableType());
			}
			return false;
		}
	}

	internal bool IsReferenceComparison
	{
		get
		{
			Type type = _left.Type;
			Type type2 = _right.Type;
			MethodInfo method = GetMethod();
			ExpressionType nodeType = NodeType;
			if ((nodeType == ExpressionType.Equal || nodeType == ExpressionType.NotEqual) && method == null && !type.IsValueType)
			{
				return !type2.IsValueType;
			}
			return false;
		}
	}

	internal BinaryExpression(Expression left, Expression right)
	{
		_left = left;
		_right = right;
	}

	private static bool IsOpAssignment(ExpressionType op)
	{
		if ((uint)(op - 63) <= 13u)
		{
			return true;
		}
		return false;
	}

	internal virtual MethodInfo GetMethod()
	{
		return null;
	}

	[global::__DynamicallyInvokable]
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right)
	{
		if (left == Left && right == Right && conversion == Conversion)
		{
			return this;
		}
		if (IsReferenceComparison)
		{
			if (NodeType == ExpressionType.Equal)
			{
				return Expression.ReferenceEqual(left, right);
			}
			return Expression.ReferenceNotEqual(left, right);
		}
		return Expression.MakeBinary(NodeType, left, right, IsLiftedToNull, Method, conversion);
	}

	[global::__DynamicallyInvokable]
	public override Expression Reduce()
	{
		if (IsOpAssignment(NodeType))
		{
			return _left.NodeType switch
			{
				ExpressionType.MemberAccess => ReduceMember(), 
				ExpressionType.Index => ReduceIndex(), 
				_ => ReduceVariable(), 
			};
		}
		return this;
	}

	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op)
	{
		return op switch
		{
			ExpressionType.AddAssign => ExpressionType.Add, 
			ExpressionType.AddAssignChecked => ExpressionType.AddChecked, 
			ExpressionType.SubtractAssign => ExpressionType.Subtract, 
			ExpressionType.SubtractAssignChecked => ExpressionType.SubtractChecked, 
			ExpressionType.MultiplyAssign => ExpressionType.Multiply, 
			ExpressionType.MultiplyAssignChecked => ExpressionType.MultiplyChecked, 
			ExpressionType.DivideAssign => ExpressionType.Divide, 
			ExpressionType.ModuloAssign => ExpressionType.Modulo, 
			ExpressionType.PowerAssign => ExpressionType.Power, 
			ExpressionType.AndAssign => ExpressionType.And, 
			ExpressionType.OrAssign => ExpressionType.Or, 
			ExpressionType.RightShiftAssign => ExpressionType.RightShift, 
			ExpressionType.LeftShiftAssign => ExpressionType.LeftShift, 
			ExpressionType.ExclusiveOrAssign => ExpressionType.ExclusiveOr, 
			_ => throw Error.InvalidOperation("op"), 
		};
	}

	private Expression ReduceVariable()
	{
		ExpressionType binaryOpFromAssignmentOp = GetBinaryOpFromAssignmentOp(NodeType);
		Expression expression = Expression.MakeBinary(binaryOpFromAssignmentOp, _left, _right, liftToNull: false, Method);
		LambdaExpression conversion = GetConversion();
		if (conversion != null)
		{
			expression = Expression.Invoke(conversion, expression);
		}
		return Expression.Assign(_left, expression);
	}

	private Expression ReduceMember()
	{
		MemberExpression memberExpression = (MemberExpression)_left;
		if (memberExpression.Expression == null)
		{
			return ReduceVariable();
		}
		ParameterExpression parameterExpression = Expression.Variable(memberExpression.Expression.Type, "temp1");
		Expression expression = Expression.Assign(parameterExpression, memberExpression.Expression);
		ExpressionType binaryOpFromAssignmentOp = GetBinaryOpFromAssignmentOp(NodeType);
		Expression expression2 = Expression.MakeBinary(binaryOpFromAssignmentOp, Expression.MakeMemberAccess(parameterExpression, memberExpression.Member), _right, liftToNull: false, Method);
		LambdaExpression conversion = GetConversion();
		if (conversion != null)
		{
			expression2 = Expression.Invoke(conversion, expression2);
		}
		ParameterExpression parameterExpression2 = Expression.Variable(expression2.Type, "temp2");
		expression2 = Expression.Assign(parameterExpression2, expression2);
		Expression expression3 = Expression.Assign(Expression.MakeMemberAccess(parameterExpression, memberExpression.Member), parameterExpression2);
		Expression expression4 = parameterExpression2;
		return Expression.Block(new ParameterExpression[2] { parameterExpression, parameterExpression2 }, expression, expression2, expression3, expression4);
	}

	private Expression ReduceIndex()
	{
		IndexExpression indexExpression = (IndexExpression)_left;
		List<ParameterExpression> list = new List<ParameterExpression>(indexExpression.Arguments.Count + 2);
		List<Expression> list2 = new List<Expression>(indexExpression.Arguments.Count + 3);
		ParameterExpression parameterExpression = Expression.Variable(indexExpression.Object.Type, "tempObj");
		list.Add(parameterExpression);
		list2.Add(Expression.Assign(parameterExpression, indexExpression.Object));
		List<Expression> list3 = new List<Expression>(indexExpression.Arguments.Count);
		foreach (Expression argument in indexExpression.Arguments)
		{
			ParameterExpression parameterExpression2 = Expression.Variable(argument.Type, "tempArg" + list3.Count);
			list.Add(parameterExpression2);
			list3.Add(parameterExpression2);
			list2.Add(Expression.Assign(parameterExpression2, argument));
		}
		IndexExpression left = Expression.MakeIndex(parameterExpression, indexExpression.Indexer, list3);
		ExpressionType binaryOpFromAssignmentOp = GetBinaryOpFromAssignmentOp(NodeType);
		Expression expression = Expression.MakeBinary(binaryOpFromAssignmentOp, left, _right, liftToNull: false, Method);
		LambdaExpression conversion = GetConversion();
		if (conversion != null)
		{
			expression = Expression.Invoke(conversion, expression);
		}
		ParameterExpression parameterExpression3 = Expression.Variable(expression.Type, "tempValue");
		list.Add(parameterExpression3);
		list2.Add(Expression.Assign(parameterExpression3, expression));
		list2.Add(Expression.Assign(left, parameterExpression3));
		return Expression.Block(list, list2);
	}

	internal virtual LambdaExpression GetConversion()
	{
		return null;
	}

	[global::__DynamicallyInvokable]
	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitBinary(this);
	}

	internal static Expression Create(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion)
	{
		if (nodeType == ExpressionType.Assign)
		{
			return new AssignBinaryExpression(left, right);
		}
		if (conversion != null)
		{
			return new CoalesceConversionBinaryExpression(left, right, conversion);
		}
		if (method != null)
		{
			return new MethodBinaryExpression(nodeType, left, right, type, method);
		}
		if (type == typeof(bool))
		{
			return new LogicalBinaryExpression(nodeType, left, right);
		}
		return new SimpleBinaryExpression(nodeType, left, right, type);
	}

	internal Expression ReduceUserdefinedLifted()
	{
		ParameterExpression parameterExpression = Expression.Parameter(_left.Type, "left");
		ParameterExpression parameterExpression2 = Expression.Parameter(Right.Type, "right");
		string name = ((NodeType == ExpressionType.AndAlso) ? "op_False" : "op_True");
		MethodInfo booleanOperator = TypeUtils.GetBooleanOperator(Method.DeclaringType, name);
		return Expression.Block(new ParameterExpression[1] { parameterExpression }, Expression.Assign(parameterExpression, _left), Expression.Condition(Expression.Property(parameterExpression, "HasValue"), Expression.Condition(Expression.Call(booleanOperator, Expression.Call(parameterExpression, "GetValueOrDefault", null)), parameterExpression, Expression.Block(new ParameterExpression[1] { parameterExpression2 }, Expression.Assign(parameterExpression2, _right), Expression.Condition(Expression.Property(parameterExpression2, "HasValue"), Expression.Convert(Expression.Call(Method, Expression.Call(parameterExpression, "GetValueOrDefault", null), Expression.Call(parameterExpression2, "GetValueOrDefault", null)), Type), Expression.Constant(null, Type)))), Expression.Constant(null, Type)));
	}
}
