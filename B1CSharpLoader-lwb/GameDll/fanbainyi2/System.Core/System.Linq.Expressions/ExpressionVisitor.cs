using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public abstract class ExpressionVisitor
{
	[global::__DynamicallyInvokable]
	protected ExpressionVisitor()
	{
	}

	[global::__DynamicallyInvokable]
	public virtual Expression Visit(Expression node)
	{
		return node?.Accept(this);
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
	{
		Expression[] array = null;
		int i = 0;
		for (int count = nodes.Count; i < count; i++)
		{
			Expression expression = Visit(nodes[i]);
			if (array != null)
			{
				array[i] = expression;
			}
			else if (expression != nodes[i])
			{
				array = new Expression[count];
				for (int j = 0; j < i; j++)
				{
					array[j] = nodes[j];
				}
				array[i] = expression;
			}
		}
		if (array == null)
		{
			return nodes;
		}
		return new TrueReadOnlyCollection<Expression>(array);
	}

	internal Expression[] VisitArguments(IArgumentProvider nodes)
	{
		Expression[] array = null;
		int i = 0;
		for (int argumentCount = nodes.ArgumentCount; i < argumentCount; i++)
		{
			Expression argument = nodes.GetArgument(i);
			Expression expression = Visit(argument);
			if (array != null)
			{
				array[i] = expression;
			}
			else if (expression != argument)
			{
				array = new Expression[argumentCount];
				for (int j = 0; j < i; j++)
				{
					array[j] = nodes.GetArgument(j);
				}
				array[i] = expression;
			}
		}
		return array;
	}

	[global::__DynamicallyInvokable]
	public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
	{
		T[] array = null;
		int i = 0;
		for (int count = nodes.Count; i < count; i++)
		{
			T val = elementVisitor(nodes[i]);
			if (array != null)
			{
				array[i] = val;
			}
			else if ((object)val != (object)nodes[i])
			{
				array = new T[count];
				for (int j = 0; j < i; j++)
				{
					array[j] = nodes[j];
				}
				array[i] = val;
			}
		}
		if (array == null)
		{
			return nodes;
		}
		return new TrueReadOnlyCollection<T>(array);
	}

	[global::__DynamicallyInvokable]
	public T VisitAndConvert<T>(T node, string callerName) where T : Expression
	{
		if (node == null)
		{
			return null;
		}
		node = Visit(node) as T;
		if (node == null)
		{
			throw Error.MustRewriteToSameNode(callerName, typeof(T), callerName);
		}
		return node;
	}

	[global::__DynamicallyInvokable]
	public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
	{
		T[] array = null;
		int i = 0;
		for (int count = nodes.Count; i < count; i++)
		{
			if (!(Visit(nodes[i]) is T val))
			{
				throw Error.MustRewriteToSameNode(callerName, typeof(T), callerName);
			}
			if (array != null)
			{
				array[i] = val;
			}
			else if (val != nodes[i])
			{
				array = new T[count];
				for (int j = 0; j < i; j++)
				{
					array[j] = nodes[j];
				}
				array[i] = val;
			}
		}
		if (array == null)
		{
			return nodes;
		}
		return new TrueReadOnlyCollection<T>(array);
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitBinary(BinaryExpression node)
	{
		return ValidateBinary(node, node.Update(Visit(node.Left), VisitAndConvert(node.Conversion, "VisitBinary"), Visit(node.Right)));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitBlock(BlockExpression node)
	{
		int expressionCount = node.ExpressionCount;
		Expression[] array = null;
		for (int i = 0; i < expressionCount; i++)
		{
			Expression expression = node.GetExpression(i);
			Expression expression2 = Visit(expression);
			if (expression != expression2)
			{
				if (array == null)
				{
					array = new Expression[expressionCount];
				}
				array[i] = expression2;
			}
		}
		ReadOnlyCollection<ParameterExpression> readOnlyCollection = VisitAndConvert(node.Variables, "VisitBlock");
		if (readOnlyCollection == node.Variables && array == null)
		{
			return node;
		}
		for (int j = 0; j < expressionCount; j++)
		{
			if (array[j] == null)
			{
				array[j] = node.GetExpression(j);
			}
		}
		return node.Rewrite(readOnlyCollection, array);
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitConditional(ConditionalExpression node)
	{
		return node.Update(Visit(node.Test), Visit(node.IfTrue), Visit(node.IfFalse));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitConstant(ConstantExpression node)
	{
		return node;
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitDebugInfo(DebugInfoExpression node)
	{
		return node;
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitDynamic(DynamicExpression node)
	{
		Expression[] array = VisitArguments(node);
		if (array == null)
		{
			return node;
		}
		return node.Rewrite(array);
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitDefault(DefaultExpression node)
	{
		return node;
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitExtension(Expression node)
	{
		return node.VisitChildren(this);
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitGoto(GotoExpression node)
	{
		return node.Update(VisitLabelTarget(node.Target), Visit(node.Value));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitInvocation(InvocationExpression node)
	{
		Expression expression = Visit(node.Expression);
		Expression[] array = VisitArguments(node);
		if (expression == node.Expression && array == null)
		{
			return node;
		}
		return node.Rewrite(expression, array);
	}

	[global::__DynamicallyInvokable]
	protected virtual LabelTarget VisitLabelTarget(LabelTarget node)
	{
		return node;
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitLabel(LabelExpression node)
	{
		return node.Update(VisitLabelTarget(node.Target), Visit(node.DefaultValue));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitLambda<T>(Expression<T> node)
	{
		return node.Update(Visit(node.Body), VisitAndConvert(node.Parameters, "VisitLambda"));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitLoop(LoopExpression node)
	{
		return node.Update(VisitLabelTarget(node.BreakLabel), VisitLabelTarget(node.ContinueLabel), Visit(node.Body));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitMember(MemberExpression node)
	{
		return node.Update(Visit(node.Expression));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitIndex(IndexExpression node)
	{
		Expression expression = Visit(node.Object);
		Expression[] array = VisitArguments(node);
		if (expression == node.Object && array == null)
		{
			return node;
		}
		return node.Rewrite(expression, array);
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitMethodCall(MethodCallExpression node)
	{
		Expression expression = Visit(node.Object);
		Expression[] array = VisitArguments(node);
		if (expression == node.Object && array == null)
		{
			return node;
		}
		return node.Rewrite(expression, array);
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitNewArray(NewArrayExpression node)
	{
		return node.Update(Visit(node.Expressions));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitNew(NewExpression node)
	{
		return node.Update(Visit(node.Arguments));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitParameter(ParameterExpression node)
	{
		return node;
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
	{
		return node.Update(VisitAndConvert(node.Variables, "VisitRuntimeVariables"));
	}

	[global::__DynamicallyInvokable]
	protected virtual SwitchCase VisitSwitchCase(SwitchCase node)
	{
		return node.Update(Visit(node.TestValues), Visit(node.Body));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitSwitch(SwitchExpression node)
	{
		return ValidateSwitch(node, node.Update(Visit(node.SwitchValue), Visit(node.Cases, VisitSwitchCase), Visit(node.DefaultBody)));
	}

	[global::__DynamicallyInvokable]
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node)
	{
		return node.Update(VisitAndConvert(node.Variable, "VisitCatchBlock"), Visit(node.Filter), Visit(node.Body));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitTry(TryExpression node)
	{
		return node.Update(Visit(node.Body), Visit(node.Handlers, VisitCatchBlock), Visit(node.Finally), Visit(node.Fault));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node)
	{
		return node.Update(Visit(node.Expression));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitUnary(UnaryExpression node)
	{
		return ValidateUnary(node, node.Update(Visit(node.Operand)));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitMemberInit(MemberInitExpression node)
	{
		return node.Update(VisitAndConvert(node.NewExpression, "VisitMemberInit"), Visit(node.Bindings, VisitMemberBinding));
	}

	[global::__DynamicallyInvokable]
	protected internal virtual Expression VisitListInit(ListInitExpression node)
	{
		return node.Update(VisitAndConvert(node.NewExpression, "VisitListInit"), Visit(node.Initializers, VisitElementInit));
	}

	[global::__DynamicallyInvokable]
	protected virtual ElementInit VisitElementInit(ElementInit node)
	{
		return node.Update(Visit(node.Arguments));
	}

	[global::__DynamicallyInvokable]
	protected virtual MemberBinding VisitMemberBinding(MemberBinding node)
	{
		return node.BindingType switch
		{
			MemberBindingType.Assignment => VisitMemberAssignment((MemberAssignment)node), 
			MemberBindingType.MemberBinding => VisitMemberMemberBinding((MemberMemberBinding)node), 
			MemberBindingType.ListBinding => VisitMemberListBinding((MemberListBinding)node), 
			_ => throw Error.UnhandledBindingType(node.BindingType), 
		};
	}

	[global::__DynamicallyInvokable]
	protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment node)
	{
		return node.Update(Visit(node.Expression));
	}

	[global::__DynamicallyInvokable]
	protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
	{
		return node.Update(Visit(node.Bindings, VisitMemberBinding));
	}

	[global::__DynamicallyInvokable]
	protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding node)
	{
		return node.Update(Visit(node.Initializers, VisitElementInit));
	}

	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after)
	{
		if (before != after && before.Method == null)
		{
			if (after.Method != null)
			{
				throw Error.MustRewriteWithoutMethod(after.Method, "VisitUnary");
			}
			if (before.Operand != null && after.Operand != null)
			{
				ValidateChildType(before.Operand.Type, after.Operand.Type, "VisitUnary");
			}
		}
		return after;
	}

	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after)
	{
		if (before != after && before.Method == null)
		{
			if (after.Method != null)
			{
				throw Error.MustRewriteWithoutMethod(after.Method, "VisitBinary");
			}
			ValidateChildType(before.Left.Type, after.Left.Type, "VisitBinary");
			ValidateChildType(before.Right.Type, after.Right.Type, "VisitBinary");
		}
		return after;
	}

	private static SwitchExpression ValidateSwitch(SwitchExpression before, SwitchExpression after)
	{
		if (before.Comparison == null && after.Comparison != null)
		{
			throw Error.MustRewriteWithoutMethod(after.Comparison, "VisitSwitch");
		}
		return after;
	}

	private static void ValidateChildType(Type before, Type after, string methodName)
	{
		if (before.IsValueType)
		{
			if (TypeUtils.AreEquivalent(before, after))
			{
				return;
			}
		}
		else if (!after.IsValueType)
		{
			return;
		}
		throw Error.MustRewriteChildToSameType(before, after, methodName);
	}
}
