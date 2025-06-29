using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(UnaryExpressionProxy))]
[global::__DynamicallyInvokable]
public sealed class UnaryExpression : Expression
{
	private readonly Expression _operand;

	private readonly MethodInfo _method;

	private readonly ExpressionType _nodeType;

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
	public sealed override ExpressionType NodeType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _nodeType;
		}
	}

	[global::__DynamicallyInvokable]
	public Expression Operand
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _operand;
		}
	}

	[global::__DynamicallyInvokable]
	public MethodInfo Method
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _method;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsLifted
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (NodeType == ExpressionType.TypeAs || NodeType == ExpressionType.Quote || NodeType == ExpressionType.Throw)
			{
				return false;
			}
			bool flag = _operand.Type.IsNullableType();
			bool flag2 = Type.IsNullableType();
			if (_method != null)
			{
				if (!flag || TypeUtils.AreEquivalent(_method.GetParametersCached()[0].ParameterType, _operand.Type))
				{
					if (flag2)
					{
						return !TypeUtils.AreEquivalent(_method.ReturnType, Type);
					}
					return false;
				}
				return true;
			}
			return flag || flag2;
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

	[global::__DynamicallyInvokable]
	public override bool CanReduce
	{
		[global::__DynamicallyInvokable]
		get
		{
			ExpressionType nodeType = _nodeType;
			if ((uint)(nodeType - 77) <= 3u)
			{
				return true;
			}
			return false;
		}
	}

	private bool IsPrefix
	{
		get
		{
			if (_nodeType != ExpressionType.PreIncrementAssign)
			{
				return _nodeType == ExpressionType.PreDecrementAssign;
			}
			return true;
		}
	}

	internal UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method)
	{
		_operand = expression;
		_method = method;
		_nodeType = nodeType;
		_type = type;
	}

	protected internal override Expression Accept(ExpressionVisitor visitor)
	{
		return visitor.VisitUnary(this);
	}

	[global::__DynamicallyInvokable]
	public override Expression Reduce()
	{
		if (CanReduce)
		{
			return _operand.NodeType switch
			{
				ExpressionType.Index => ReduceIndex(), 
				ExpressionType.MemberAccess => ReduceMember(), 
				_ => ReduceVariable(), 
			};
		}
		return this;
	}

	private UnaryExpression FunctionalOp(Expression operand)
	{
		ExpressionType nodeType = ((_nodeType != ExpressionType.PreIncrementAssign && _nodeType != ExpressionType.PostIncrementAssign) ? ExpressionType.Decrement : ExpressionType.Increment);
		return new UnaryExpression(nodeType, operand, operand.Type, _method);
	}

	private Expression ReduceVariable()
	{
		if (IsPrefix)
		{
			return Expression.Assign(_operand, FunctionalOp(_operand));
		}
		ParameterExpression parameterExpression = Expression.Parameter(_operand.Type, null);
		return Expression.Block(new ParameterExpression[1] { parameterExpression }, Expression.Assign(parameterExpression, _operand), Expression.Assign(_operand, FunctionalOp(parameterExpression)), parameterExpression);
	}

	private Expression ReduceMember()
	{
		MemberExpression memberExpression = (MemberExpression)_operand;
		if (memberExpression.Expression == null)
		{
			return ReduceVariable();
		}
		ParameterExpression parameterExpression = Expression.Parameter(memberExpression.Expression.Type, null);
		BinaryExpression binaryExpression = Expression.Assign(parameterExpression, memberExpression.Expression);
		memberExpression = Expression.MakeMemberAccess(parameterExpression, memberExpression.Member);
		if (IsPrefix)
		{
			return Expression.Block(new ParameterExpression[1] { parameterExpression }, binaryExpression, Expression.Assign(memberExpression, FunctionalOp(memberExpression)));
		}
		ParameterExpression parameterExpression2 = Expression.Parameter(memberExpression.Type, null);
		return Expression.Block(new ParameterExpression[2] { parameterExpression, parameterExpression2 }, binaryExpression, Expression.Assign(parameterExpression2, memberExpression), Expression.Assign(memberExpression, FunctionalOp(parameterExpression2)), parameterExpression2);
	}

	private Expression ReduceIndex()
	{
		bool isPrefix = IsPrefix;
		IndexExpression indexExpression = (IndexExpression)_operand;
		int count = indexExpression.Arguments.Count;
		Expression[] array = new Expression[count + (isPrefix ? 2 : 4)];
		ParameterExpression[] array2 = new ParameterExpression[count + (isPrefix ? 1 : 2)];
		ParameterExpression[] array3 = new ParameterExpression[count];
		int num = 0;
		array2[num] = Expression.Parameter(indexExpression.Object.Type, null);
		array[num] = Expression.Assign(array2[num], indexExpression.Object);
		for (num++; num <= count; num++)
		{
			Expression expression = indexExpression.Arguments[num - 1];
			array3[num - 1] = (array2[num] = Expression.Parameter(expression.Type, null));
			array[num] = Expression.Assign(array2[num], expression);
		}
		ParameterExpression instance = array2[0];
		PropertyInfo indexer = indexExpression.Indexer;
		Expression[] list = array3;
		indexExpression = Expression.MakeIndex(instance, indexer, new TrueReadOnlyCollection<Expression>(list));
		if (!isPrefix)
		{
			ParameterExpression parameterExpression = (array2[num] = Expression.Parameter(indexExpression.Type, null));
			array[num] = Expression.Assign(array2[num], indexExpression);
			num++;
			array[num++] = Expression.Assign(indexExpression, FunctionalOp(parameterExpression));
			array[num++] = parameterExpression;
		}
		else
		{
			array[num++] = Expression.Assign(indexExpression, FunctionalOp(indexExpression));
		}
		return Expression.Block(new TrueReadOnlyCollection<ParameterExpression>(array2), new TrueReadOnlyCollection<Expression>(array));
	}

	[global::__DynamicallyInvokable]
	public UnaryExpression Update(Expression operand)
	{
		if (operand == Operand)
		{
			return this;
		}
		return Expression.MakeUnary(NodeType, operand, Type, Method);
	}
}
