using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Compiler;

internal class StackSpiller
{
	private abstract class BindingRewriter
	{
		protected MemberBinding _binding;

		protected RewriteAction _action;

		protected StackSpiller _spiller;

		internal RewriteAction Action => _action;

		internal BindingRewriter(MemberBinding binding, StackSpiller spiller)
		{
			_binding = binding;
			_spiller = spiller;
		}

		internal abstract MemberBinding AsBinding();

		internal abstract Expression AsExpression(Expression target);

		internal static BindingRewriter Create(MemberBinding binding, StackSpiller spiller, Stack stack)
		{
			switch (binding.BindingType)
			{
			case MemberBindingType.Assignment:
			{
				MemberAssignment binding4 = (MemberAssignment)binding;
				return new MemberAssignmentRewriter(binding4, spiller, stack);
			}
			case MemberBindingType.ListBinding:
			{
				MemberListBinding binding3 = (MemberListBinding)binding;
				return new ListBindingRewriter(binding3, spiller, stack);
			}
			case MemberBindingType.MemberBinding:
			{
				MemberMemberBinding binding2 = (MemberMemberBinding)binding;
				return new MemberMemberBindingRewriter(binding2, spiller, stack);
			}
			default:
				throw Error.UnhandledBinding();
			}
		}
	}

	private class MemberMemberBindingRewriter : BindingRewriter
	{
		private ReadOnlyCollection<MemberBinding> _bindings;

		private BindingRewriter[] _bindingRewriters;

		internal MemberMemberBindingRewriter(MemberMemberBinding binding, StackSpiller spiller, Stack stack)
			: base(binding, spiller)
		{
			_bindings = binding.Bindings;
			_bindingRewriters = new BindingRewriter[_bindings.Count];
			for (int i = 0; i < _bindings.Count; i++)
			{
				BindingRewriter bindingRewriter = BindingRewriter.Create(_bindings[i], spiller, stack);
				_action |= bindingRewriter.Action;
				_bindingRewriters[i] = bindingRewriter;
			}
		}

		internal override MemberBinding AsBinding()
		{
			switch (_action)
			{
			case RewriteAction.None:
				return _binding;
			case RewriteAction.Copy:
			{
				MemberBinding[] array = new MemberBinding[_bindings.Count];
				for (int i = 0; i < _bindings.Count; i++)
				{
					array[i] = _bindingRewriters[i].AsBinding();
				}
				return Expression.MemberBind(_binding.Member, new TrueReadOnlyCollection<MemberBinding>(array));
			}
			default:
				throw ContractUtils.Unreachable;
			}
		}

		internal override Expression AsExpression(Expression target)
		{
			if (target.Type.IsValueType && _binding.Member is PropertyInfo)
			{
				throw Error.CannotAutoInitializeValueTypeMemberThroughProperty(_binding.Member);
			}
			RequireNotRefInstance(target);
			MemberExpression memberExpression = Expression.MakeMemberAccess(target, _binding.Member);
			ParameterExpression parameterExpression = _spiller.MakeTemp(memberExpression.Type);
			Expression[] array = new Expression[_bindings.Count + 2];
			array[0] = Expression.Assign(parameterExpression, memberExpression);
			for (int i = 0; i < _bindings.Count; i++)
			{
				BindingRewriter bindingRewriter = _bindingRewriters[i];
				array[i + 1] = bindingRewriter.AsExpression(parameterExpression);
			}
			if (parameterExpression.Type.IsValueType)
			{
				array[_bindings.Count + 1] = Expression.Block(typeof(void), Expression.Assign(Expression.MakeMemberAccess(target, _binding.Member), parameterExpression));
			}
			else
			{
				array[_bindings.Count + 1] = Expression.Empty();
			}
			return MakeBlock(array);
		}
	}

	private class ListBindingRewriter : BindingRewriter
	{
		private ReadOnlyCollection<ElementInit> _inits;

		private ChildRewriter[] _childRewriters;

		internal ListBindingRewriter(MemberListBinding binding, StackSpiller spiller, Stack stack)
			: base(binding, spiller)
		{
			_inits = binding.Initializers;
			_childRewriters = new ChildRewriter[_inits.Count];
			for (int i = 0; i < _inits.Count; i++)
			{
				ElementInit elementInit = _inits[i];
				ChildRewriter childRewriter = new ChildRewriter(spiller, stack, elementInit.Arguments.Count);
				childRewriter.Add(elementInit.Arguments);
				_action |= childRewriter.Action;
				_childRewriters[i] = childRewriter;
			}
		}

		internal override MemberBinding AsBinding()
		{
			switch (_action)
			{
			case RewriteAction.None:
				return _binding;
			case RewriteAction.Copy:
			{
				ElementInit[] array = new ElementInit[_inits.Count];
				for (int i = 0; i < _inits.Count; i++)
				{
					ChildRewriter childRewriter = _childRewriters[i];
					if (childRewriter.Action == RewriteAction.None)
					{
						array[i] = _inits[i];
					}
					else
					{
						array[i] = Expression.ElementInit(_inits[i].AddMethod, childRewriter[0, -1]);
					}
				}
				return Expression.ListBind(_binding.Member, new TrueReadOnlyCollection<ElementInit>(array));
			}
			default:
				throw ContractUtils.Unreachable;
			}
		}

		internal override Expression AsExpression(Expression target)
		{
			if (target.Type.IsValueType && _binding.Member is PropertyInfo)
			{
				throw Error.CannotAutoInitializeValueTypeElementThroughProperty(_binding.Member);
			}
			RequireNotRefInstance(target);
			MemberExpression memberExpression = Expression.MakeMemberAccess(target, _binding.Member);
			ParameterExpression parameterExpression = _spiller.MakeTemp(memberExpression.Type);
			Expression[] array = new Expression[_inits.Count + 2];
			array[0] = Expression.Assign(parameterExpression, memberExpression);
			for (int i = 0; i < _inits.Count; i++)
			{
				ChildRewriter childRewriter = _childRewriters[i];
				array[i + 1] = childRewriter.Finish(Expression.Call(parameterExpression, _inits[i].AddMethod, childRewriter[0, -1])).Node;
			}
			if (parameterExpression.Type.IsValueType)
			{
				array[_inits.Count + 1] = Expression.Block(typeof(void), Expression.Assign(Expression.MakeMemberAccess(target, _binding.Member), parameterExpression));
			}
			else
			{
				array[_inits.Count + 1] = Expression.Empty();
			}
			return MakeBlock(array);
		}
	}

	private class MemberAssignmentRewriter : BindingRewriter
	{
		private Expression _rhs;

		internal MemberAssignmentRewriter(MemberAssignment binding, StackSpiller spiller, Stack stack)
			: base(binding, spiller)
		{
			Result result = spiller.RewriteExpression(binding.Expression, stack);
			_action = result.Action;
			_rhs = result.Node;
		}

		internal override MemberBinding AsBinding()
		{
			return _action switch
			{
				RewriteAction.None => _binding, 
				RewriteAction.Copy => Expression.Bind(_binding.Member, _rhs), 
				_ => throw ContractUtils.Unreachable, 
			};
		}

		internal override Expression AsExpression(Expression target)
		{
			RequireNotRefInstance(target);
			MemberExpression memberExpression = Expression.MakeMemberAccess(target, _binding.Member);
			ParameterExpression parameterExpression = _spiller.MakeTemp(memberExpression.Type);
			return MakeBlock(Expression.Assign(parameterExpression, _rhs), Expression.Assign(memberExpression, parameterExpression), Expression.Empty());
		}
	}

	private enum Stack
	{
		Empty,
		NonEmpty
	}

	[Flags]
	private enum RewriteAction
	{
		None = 0,
		Copy = 1,
		SpillStack = 3
	}

	private struct Result
	{
		internal readonly RewriteAction Action;

		internal readonly Expression Node;

		internal Result(RewriteAction action, Expression node)
		{
			Action = action;
			Node = node;
		}
	}

	private class TempMaker
	{
		private int _temp;

		private List<ParameterExpression> _freeTemps;

		private Stack<ParameterExpression> _usedTemps;

		private List<ParameterExpression> _temps = new List<ParameterExpression>();

		internal List<ParameterExpression> Temps => _temps;

		internal ParameterExpression Temp(Type type)
		{
			ParameterExpression parameterExpression;
			if (_freeTemps != null)
			{
				for (int num = _freeTemps.Count - 1; num >= 0; num--)
				{
					parameterExpression = _freeTemps[num];
					if (parameterExpression.Type == type)
					{
						_freeTemps.RemoveAt(num);
						return UseTemp(parameterExpression);
					}
				}
			}
			parameterExpression = Expression.Variable(type, "$temp$" + _temp++);
			_temps.Add(parameterExpression);
			return UseTemp(parameterExpression);
		}

		private ParameterExpression UseTemp(ParameterExpression temp)
		{
			if (_usedTemps == null)
			{
				_usedTemps = new Stack<ParameterExpression>();
			}
			_usedTemps.Push(temp);
			return temp;
		}

		private void FreeTemp(ParameterExpression temp)
		{
			if (_freeTemps == null)
			{
				_freeTemps = new List<ParameterExpression>();
			}
			_freeTemps.Add(temp);
		}

		internal int Mark()
		{
			if (_usedTemps == null)
			{
				return 0;
			}
			return _usedTemps.Count;
		}

		internal void Free(int mark)
		{
			if (_usedTemps != null)
			{
				while (mark < _usedTemps.Count)
				{
					FreeTemp(_usedTemps.Pop());
				}
			}
		}

		[Conditional("DEBUG")]
		internal void VerifyTemps()
		{
		}
	}

	private class ChildRewriter
	{
		private readonly StackSpiller _self;

		private readonly Expression[] _expressions;

		private int _expressionsCount;

		private List<Expression> _comma;

		private RewriteAction _action;

		private Stack _stack;

		private bool _done;

		internal bool Rewrite => _action != RewriteAction.None;

		internal RewriteAction Action => _action;

		internal Expression this[int index]
		{
			get
			{
				EnsureDone();
				if (index < 0)
				{
					index += _expressions.Length;
				}
				return _expressions[index];
			}
		}

		internal Expression[] this[int first, int last]
		{
			get
			{
				EnsureDone();
				if (last < 0)
				{
					last += _expressions.Length;
				}
				int num = last - first + 1;
				ContractUtils.RequiresArrayRange(_expressions, first, num, "first", "last");
				if (num == _expressions.Length)
				{
					return _expressions;
				}
				Expression[] array = new Expression[num];
				Array.Copy(_expressions, first, array, 0, num);
				return array;
			}
		}

		internal ChildRewriter(StackSpiller self, Stack stack, int count)
		{
			_self = self;
			_stack = stack;
			_expressions = new Expression[count];
		}

		internal void Add(Expression node)
		{
			if (node == null)
			{
				_expressions[_expressionsCount++] = null;
				return;
			}
			Result result = _self.RewriteExpression(node, _stack);
			_action |= result.Action;
			_stack = Stack.NonEmpty;
			_expressions[_expressionsCount++] = result.Node;
		}

		internal void Add(IList<Expression> expressions)
		{
			int i = 0;
			for (int count = expressions.Count; i < count; i++)
			{
				Add(expressions[i]);
			}
		}

		internal void AddArguments(IArgumentProvider expressions)
		{
			int i = 0;
			for (int argumentCount = expressions.ArgumentCount; i < argumentCount; i++)
			{
				Add(expressions.GetArgument(i));
			}
		}

		private void EnsureDone()
		{
			if (_done)
			{
				return;
			}
			_done = true;
			if (_action != RewriteAction.SpillStack)
			{
				return;
			}
			Expression[] expressions = _expressions;
			int num = expressions.Length;
			List<Expression> list = new List<Expression>(num + 1);
			for (int i = 0; i < num; i++)
			{
				if (expressions[i] != null)
				{
					expressions[i] = _self.ToTemp(expressions[i], out var save);
					list.Add(save);
				}
			}
			list.Capacity = list.Count + 1;
			_comma = list;
		}

		internal Result Finish(Expression expr)
		{
			EnsureDone();
			if (_action == RewriteAction.SpillStack)
			{
				_comma.Add(expr);
				expr = MakeBlock(_comma);
			}
			return new Result(_action, expr);
		}
	}

	private readonly TempMaker _tm = new TempMaker();

	private readonly Stack _startingStack;

	private RewriteAction _lambdaRewrite;

	private readonly StackGuard _guard = new StackGuard();

	internal static LambdaExpression AnalyzeLambda(LambdaExpression lambda)
	{
		return lambda.Accept(new StackSpiller(Stack.Empty));
	}

	private StackSpiller(Stack stack)
	{
		_startingStack = stack;
	}

	internal Expression<T> Rewrite<T>(Expression<T> lambda)
	{
		Result result = RewriteExpressionFreeTemps(lambda.Body, _startingStack);
		_lambdaRewrite = result.Action;
		if (result.Action != RewriteAction.None)
		{
			Expression expression = result.Node;
			if (_tm.Temps.Count > 0)
			{
				expression = Expression.Block(_tm.Temps, expression);
			}
			return new Expression<T>(expression, lambda.Name, lambda.TailCall, lambda.Parameters);
		}
		return lambda;
	}

	[Conditional("DEBUG")]
	private static void VerifyRewrite(Result result, Expression node)
	{
	}

	private Result RewriteExpressionFreeTemps(Expression expression, Stack stack)
	{
		int mark = Mark();
		Result result = RewriteExpression(expression, stack);
		Free(mark);
		return result;
	}

	private Result RewriteDynamicExpression(Expression expr, Stack stack)
	{
		DynamicExpression dynamicExpression = (DynamicExpression)expr;
		IArgumentProvider argumentProvider = dynamicExpression;
		ChildRewriter childRewriter = new ChildRewriter(this, Stack.NonEmpty, argumentProvider.ArgumentCount);
		childRewriter.AddArguments(argumentProvider);
		if (childRewriter.Action == RewriteAction.SpillStack)
		{
			RequireNoRefArgs(dynamicExpression.DelegateType.GetMethod("Invoke"));
		}
		return childRewriter.Finish(childRewriter.Rewrite ? dynamicExpression.Rewrite(childRewriter[0, -1]) : expr);
	}

	private Result RewriteIndexAssignment(BinaryExpression node, Stack stack)
	{
		IndexExpression indexExpression = (IndexExpression)node.Left;
		ChildRewriter childRewriter = new ChildRewriter(this, stack, 2 + indexExpression.Arguments.Count);
		childRewriter.Add(indexExpression.Object);
		childRewriter.Add(indexExpression.Arguments);
		childRewriter.Add(node.Right);
		if (childRewriter.Action == RewriteAction.SpillStack)
		{
			RequireNotRefInstance(indexExpression.Object);
		}
		if (childRewriter.Rewrite)
		{
			node = new AssignBinaryExpression(new IndexExpression(childRewriter[0], indexExpression.Indexer, childRewriter[1, -2]), childRewriter[-1]);
		}
		return childRewriter.Finish(node);
	}

	private Result RewriteLogicalBinaryExpression(Expression expr, Stack stack)
	{
		BinaryExpression binaryExpression = (BinaryExpression)expr;
		Result result = RewriteExpression(binaryExpression.Left, stack);
		Result result2 = RewriteExpression(binaryExpression.Right, stack);
		Result result3 = RewriteExpression(binaryExpression.Conversion, stack);
		RewriteAction rewriteAction = result.Action | result2.Action | result3.Action;
		if (rewriteAction != RewriteAction.None)
		{
			expr = BinaryExpression.Create(binaryExpression.NodeType, result.Node, result2.Node, binaryExpression.Type, binaryExpression.Method, (LambdaExpression)result3.Node);
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteReducibleExpression(Expression expr, Stack stack)
	{
		Result result = RewriteExpression(expr.Reduce(), stack);
		return new Result(result.Action | RewriteAction.Copy, result.Node);
	}

	private Result RewriteBinaryExpression(Expression expr, Stack stack)
	{
		BinaryExpression binaryExpression = (BinaryExpression)expr;
		ChildRewriter childRewriter = new ChildRewriter(this, stack, 3);
		childRewriter.Add(binaryExpression.Left);
		childRewriter.Add(binaryExpression.Right);
		childRewriter.Add(binaryExpression.Conversion);
		if (childRewriter.Action == RewriteAction.SpillStack)
		{
			RequireNoRefArgs(binaryExpression.Method);
		}
		return childRewriter.Finish(childRewriter.Rewrite ? BinaryExpression.Create(binaryExpression.NodeType, childRewriter[0], childRewriter[1], binaryExpression.Type, binaryExpression.Method, (LambdaExpression)childRewriter[2]) : expr);
	}

	private Result RewriteVariableAssignment(BinaryExpression node, Stack stack)
	{
		Result result = RewriteExpression(node.Right, stack);
		if (result.Action != RewriteAction.None)
		{
			node = Expression.Assign(node.Left, result.Node);
		}
		return new Result(result.Action, node);
	}

	private Result RewriteAssignBinaryExpression(Expression expr, Stack stack)
	{
		BinaryExpression binaryExpression = (BinaryExpression)expr;
		return binaryExpression.Left.NodeType switch
		{
			ExpressionType.Index => RewriteIndexAssignment(binaryExpression, stack), 
			ExpressionType.MemberAccess => RewriteMemberAssignment(binaryExpression, stack), 
			ExpressionType.Parameter => RewriteVariableAssignment(binaryExpression, stack), 
			ExpressionType.Extension => RewriteExtensionAssignment(binaryExpression, stack), 
			_ => throw Error.InvalidLvalue(binaryExpression.Left.NodeType), 
		};
	}

	private Result RewriteExtensionAssignment(BinaryExpression node, Stack stack)
	{
		node = Expression.Assign(node.Left.ReduceExtensions(), node.Right);
		Result result = RewriteAssignBinaryExpression(node, stack);
		return new Result(result.Action | RewriteAction.Copy, result.Node);
	}

	private static Result RewriteLambdaExpression(Expression expr, Stack stack)
	{
		LambdaExpression lambdaExpression = (LambdaExpression)expr;
		expr = AnalyzeLambda(lambdaExpression);
		RewriteAction action = ((expr != lambdaExpression) ? RewriteAction.Copy : RewriteAction.None);
		return new Result(action, expr);
	}

	private Result RewriteConditionalExpression(Expression expr, Stack stack)
	{
		ConditionalExpression conditionalExpression = (ConditionalExpression)expr;
		Result result = RewriteExpression(conditionalExpression.Test, stack);
		Result result2 = RewriteExpression(conditionalExpression.IfTrue, stack);
		Result result3 = RewriteExpression(conditionalExpression.IfFalse, stack);
		RewriteAction rewriteAction = result.Action | result2.Action | result3.Action;
		if (rewriteAction != RewriteAction.None)
		{
			expr = Expression.Condition(result.Node, result2.Node, result3.Node, conditionalExpression.Type);
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteMemberAssignment(BinaryExpression node, Stack stack)
	{
		MemberExpression memberExpression = (MemberExpression)node.Left;
		ChildRewriter childRewriter = new ChildRewriter(this, stack, 2);
		childRewriter.Add(memberExpression.Expression);
		childRewriter.Add(node.Right);
		if (childRewriter.Action == RewriteAction.SpillStack)
		{
			RequireNotRefInstance(memberExpression.Expression);
		}
		if (childRewriter.Rewrite)
		{
			return childRewriter.Finish(new AssignBinaryExpression(MemberExpression.Make(childRewriter[0], memberExpression.Member), childRewriter[1]));
		}
		return new Result(RewriteAction.None, node);
	}

	private Result RewriteMemberExpression(Expression expr, Stack stack)
	{
		MemberExpression memberExpression = (MemberExpression)expr;
		Result result = RewriteExpression(memberExpression.Expression, stack);
		if (result.Action != RewriteAction.None)
		{
			if (result.Action == RewriteAction.SpillStack && memberExpression.Member.MemberType == MemberTypes.Property)
			{
				RequireNotRefInstance(memberExpression.Expression);
			}
			expr = MemberExpression.Make(result.Node, memberExpression.Member);
		}
		return new Result(result.Action, expr);
	}

	private Result RewriteIndexExpression(Expression expr, Stack stack)
	{
		IndexExpression indexExpression = (IndexExpression)expr;
		ChildRewriter childRewriter = new ChildRewriter(this, stack, indexExpression.Arguments.Count + 1);
		childRewriter.Add(indexExpression.Object);
		childRewriter.Add(indexExpression.Arguments);
		if (childRewriter.Action == RewriteAction.SpillStack)
		{
			RequireNotRefInstance(indexExpression.Object);
		}
		if (childRewriter.Rewrite)
		{
			expr = new IndexExpression(childRewriter[0], indexExpression.Indexer, childRewriter[1, -1]);
		}
		return childRewriter.Finish(expr);
	}

	private Result RewriteMethodCallExpression(Expression expr, Stack stack)
	{
		MethodCallExpression methodCallExpression = (MethodCallExpression)expr;
		ChildRewriter childRewriter = new ChildRewriter(this, stack, methodCallExpression.Arguments.Count + 1);
		childRewriter.Add(methodCallExpression.Object);
		childRewriter.AddArguments(methodCallExpression);
		if (childRewriter.Action == RewriteAction.SpillStack)
		{
			RequireNotRefInstance(methodCallExpression.Object);
			RequireNoRefArgs(methodCallExpression.Method);
		}
		return childRewriter.Finish(childRewriter.Rewrite ? methodCallExpression.Rewrite(childRewriter[0], childRewriter[1, -1]) : expr);
	}

	private Result RewriteNewArrayExpression(Expression expr, Stack stack)
	{
		NewArrayExpression newArrayExpression = (NewArrayExpression)expr;
		if (newArrayExpression.NodeType == ExpressionType.NewArrayInit)
		{
			stack = Stack.NonEmpty;
		}
		ChildRewriter childRewriter = new ChildRewriter(this, stack, newArrayExpression.Expressions.Count);
		childRewriter.Add(newArrayExpression.Expressions);
		if (childRewriter.Rewrite)
		{
			Type elementType = newArrayExpression.Type.GetElementType();
			expr = ((newArrayExpression.NodeType != ExpressionType.NewArrayInit) ? Expression.NewArrayBounds(elementType, childRewriter[0, -1]) : Expression.NewArrayInit(elementType, childRewriter[0, -1]));
		}
		return childRewriter.Finish(expr);
	}

	private Result RewriteInvocationExpression(Expression expr, Stack stack)
	{
		InvocationExpression invocationExpression = (InvocationExpression)expr;
		LambdaExpression lambdaOperand = invocationExpression.LambdaOperand;
		ChildRewriter childRewriter;
		if (lambdaOperand != null)
		{
			childRewriter = new ChildRewriter(this, stack, invocationExpression.Arguments.Count);
			childRewriter.Add(invocationExpression.Arguments);
			if (childRewriter.Action == RewriteAction.SpillStack)
			{
				RequireNoRefArgs(Expression.GetInvokeMethod(invocationExpression.Expression));
			}
			StackSpiller stackSpiller = new StackSpiller(stack);
			lambdaOperand = lambdaOperand.Accept(stackSpiller);
			if (childRewriter.Rewrite || stackSpiller._lambdaRewrite != RewriteAction.None)
			{
				invocationExpression = new InvocationExpression(lambdaOperand, childRewriter[0, -1], invocationExpression.Type);
			}
			Result result = childRewriter.Finish(invocationExpression);
			return new Result(result.Action | stackSpiller._lambdaRewrite, result.Node);
		}
		childRewriter = new ChildRewriter(this, stack, invocationExpression.Arguments.Count + 1);
		childRewriter.Add(invocationExpression.Expression);
		childRewriter.Add(invocationExpression.Arguments);
		if (childRewriter.Action == RewriteAction.SpillStack)
		{
			RequireNoRefArgs(Expression.GetInvokeMethod(invocationExpression.Expression));
		}
		return childRewriter.Finish(childRewriter.Rewrite ? new InvocationExpression(childRewriter[0], childRewriter[1, -1], invocationExpression.Type) : expr);
	}

	private Result RewriteNewExpression(Expression expr, Stack stack)
	{
		NewExpression newExpression = (NewExpression)expr;
		ChildRewriter childRewriter = new ChildRewriter(this, stack, newExpression.Arguments.Count);
		childRewriter.AddArguments(newExpression);
		if (childRewriter.Action == RewriteAction.SpillStack)
		{
			RequireNoRefArgs(newExpression.Constructor);
		}
		return childRewriter.Finish(childRewriter.Rewrite ? new NewExpression(newExpression.Constructor, childRewriter[0, -1], newExpression.Members) : expr);
	}

	private Result RewriteTypeBinaryExpression(Expression expr, Stack stack)
	{
		TypeBinaryExpression typeBinaryExpression = (TypeBinaryExpression)expr;
		Result result = RewriteExpression(typeBinaryExpression.Expression, stack);
		if (result.Action != RewriteAction.None)
		{
			expr = ((typeBinaryExpression.NodeType != ExpressionType.TypeIs) ? Expression.TypeEqual(result.Node, typeBinaryExpression.TypeOperand) : Expression.TypeIs(result.Node, typeBinaryExpression.TypeOperand));
		}
		return new Result(result.Action, expr);
	}

	private Result RewriteThrowUnaryExpression(Expression expr, Stack stack)
	{
		UnaryExpression unaryExpression = (UnaryExpression)expr;
		Result result = RewriteExpressionFreeTemps(unaryExpression.Operand, Stack.Empty);
		RewriteAction rewriteAction = result.Action;
		if (stack != Stack.Empty)
		{
			rewriteAction = RewriteAction.SpillStack;
		}
		if (rewriteAction != RewriteAction.None)
		{
			expr = Expression.Throw(result.Node, unaryExpression.Type);
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteUnaryExpression(Expression expr, Stack stack)
	{
		UnaryExpression unaryExpression = (UnaryExpression)expr;
		Result result = RewriteExpression(unaryExpression.Operand, stack);
		if (result.Action == RewriteAction.SpillStack)
		{
			RequireNoRefArgs(unaryExpression.Method);
		}
		if (result.Action != RewriteAction.None)
		{
			expr = new UnaryExpression(unaryExpression.NodeType, result.Node, unaryExpression.Type, unaryExpression.Method);
		}
		return new Result(result.Action, expr);
	}

	private Result RewriteListInitExpression(Expression expr, Stack stack)
	{
		ListInitExpression listInitExpression = (ListInitExpression)expr;
		Result result = RewriteExpression(listInitExpression.NewExpression, stack);
		Expression node = result.Node;
		RewriteAction rewriteAction = result.Action;
		ReadOnlyCollection<ElementInit> initializers = listInitExpression.Initializers;
		ChildRewriter[] array = new ChildRewriter[initializers.Count];
		for (int i = 0; i < initializers.Count; i++)
		{
			ElementInit elementInit = initializers[i];
			ChildRewriter childRewriter = new ChildRewriter(this, Stack.NonEmpty, elementInit.Arguments.Count);
			childRewriter.Add(elementInit.Arguments);
			rewriteAction |= childRewriter.Action;
			array[i] = childRewriter;
		}
		switch (rewriteAction)
		{
		case RewriteAction.Copy:
		{
			ElementInit[] array3 = new ElementInit[initializers.Count];
			for (int k = 0; k < initializers.Count; k++)
			{
				ChildRewriter childRewriter3 = array[k];
				if (childRewriter3.Action == RewriteAction.None)
				{
					array3[k] = initializers[k];
				}
				else
				{
					array3[k] = Expression.ElementInit(initializers[k].AddMethod, childRewriter3[0, -1]);
				}
			}
			expr = Expression.ListInit((NewExpression)node, new TrueReadOnlyCollection<ElementInit>(array3));
			break;
		}
		case RewriteAction.SpillStack:
		{
			RequireNotRefInstance(listInitExpression.NewExpression);
			ParameterExpression parameterExpression = MakeTemp(node.Type);
			Expression[] array2 = new Expression[initializers.Count + 2];
			array2[0] = Expression.Assign(parameterExpression, node);
			for (int j = 0; j < initializers.Count; j++)
			{
				ChildRewriter childRewriter2 = array[j];
				array2[j + 1] = childRewriter2.Finish(Expression.Call(parameterExpression, initializers[j].AddMethod, childRewriter2[0, -1])).Node;
			}
			array2[initializers.Count + 1] = parameterExpression;
			expr = MakeBlock(array2);
			break;
		}
		default:
			throw ContractUtils.Unreachable;
		case RewriteAction.None:
			break;
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteMemberInitExpression(Expression expr, Stack stack)
	{
		MemberInitExpression memberInitExpression = (MemberInitExpression)expr;
		Result result = RewriteExpression(memberInitExpression.NewExpression, stack);
		Expression node = result.Node;
		RewriteAction rewriteAction = result.Action;
		ReadOnlyCollection<MemberBinding> bindings = memberInitExpression.Bindings;
		BindingRewriter[] array = new BindingRewriter[bindings.Count];
		for (int i = 0; i < bindings.Count; i++)
		{
			MemberBinding binding = bindings[i];
			rewriteAction |= (array[i] = BindingRewriter.Create(binding, this, Stack.NonEmpty)).Action;
		}
		switch (rewriteAction)
		{
		case RewriteAction.Copy:
		{
			MemberBinding[] array3 = new MemberBinding[bindings.Count];
			for (int k = 0; k < bindings.Count; k++)
			{
				array3[k] = array[k].AsBinding();
			}
			expr = Expression.MemberInit((NewExpression)node, new TrueReadOnlyCollection<MemberBinding>(array3));
			break;
		}
		case RewriteAction.SpillStack:
		{
			RequireNotRefInstance(memberInitExpression.NewExpression);
			ParameterExpression parameterExpression = MakeTemp(node.Type);
			Expression[] array2 = new Expression[bindings.Count + 2];
			array2[0] = Expression.Assign(parameterExpression, node);
			for (int j = 0; j < bindings.Count; j++)
			{
				BindingRewriter bindingRewriter = array[j];
				Expression expression = bindingRewriter.AsExpression(parameterExpression);
				array2[j + 1] = expression;
			}
			array2[bindings.Count + 1] = parameterExpression;
			expr = MakeBlock(array2);
			break;
		}
		default:
			throw ContractUtils.Unreachable;
		case RewriteAction.None:
			break;
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteBlockExpression(Expression expr, Stack stack)
	{
		BlockExpression blockExpression = (BlockExpression)expr;
		int expressionCount = blockExpression.ExpressionCount;
		RewriteAction rewriteAction = RewriteAction.None;
		Expression[] array = null;
		for (int i = 0; i < expressionCount; i++)
		{
			Expression expression = blockExpression.GetExpression(i);
			Result result = RewriteExpression(expression, stack);
			rewriteAction |= result.Action;
			if (array == null && result.Action != RewriteAction.None)
			{
				array = Clone(blockExpression.Expressions, i);
			}
			if (array != null)
			{
				array[i] = result.Node;
			}
		}
		if (rewriteAction != RewriteAction.None)
		{
			expr = blockExpression.Rewrite(null, array);
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteLabelExpression(Expression expr, Stack stack)
	{
		LabelExpression labelExpression = (LabelExpression)expr;
		Result result = RewriteExpression(labelExpression.DefaultValue, stack);
		if (result.Action != RewriteAction.None)
		{
			expr = Expression.Label(labelExpression.Target, result.Node);
		}
		return new Result(result.Action, expr);
	}

	private Result RewriteLoopExpression(Expression expr, Stack stack)
	{
		LoopExpression loopExpression = (LoopExpression)expr;
		Result result = RewriteExpression(loopExpression.Body, Stack.Empty);
		RewriteAction rewriteAction = result.Action;
		if (stack != Stack.Empty)
		{
			rewriteAction = RewriteAction.SpillStack;
		}
		if (rewriteAction != RewriteAction.None)
		{
			expr = new LoopExpression(result.Node, loopExpression.BreakLabel, loopExpression.ContinueLabel);
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteGotoExpression(Expression expr, Stack stack)
	{
		GotoExpression gotoExpression = (GotoExpression)expr;
		Result result = RewriteExpressionFreeTemps(gotoExpression.Value, Stack.Empty);
		RewriteAction rewriteAction = result.Action;
		if (stack != Stack.Empty)
		{
			rewriteAction = RewriteAction.SpillStack;
		}
		if (rewriteAction != RewriteAction.None)
		{
			expr = Expression.MakeGoto(gotoExpression.Kind, gotoExpression.Target, result.Node, gotoExpression.Type);
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteSwitchExpression(Expression expr, Stack stack)
	{
		SwitchExpression switchExpression = (SwitchExpression)expr;
		Result result = RewriteExpressionFreeTemps(switchExpression.SwitchValue, stack);
		RewriteAction rewriteAction = result.Action;
		ReadOnlyCollection<SwitchCase> readOnlyCollection = switchExpression.Cases;
		SwitchCase[] array = null;
		for (int i = 0; i < readOnlyCollection.Count; i++)
		{
			SwitchCase switchCase = readOnlyCollection[i];
			Expression[] array2 = null;
			ReadOnlyCollection<Expression> readOnlyCollection2 = switchCase.TestValues;
			for (int j = 0; j < readOnlyCollection2.Count; j++)
			{
				Result result2 = RewriteExpression(readOnlyCollection2[j], stack);
				rewriteAction |= result2.Action;
				if (array2 == null && result2.Action != RewriteAction.None)
				{
					array2 = Clone(readOnlyCollection2, j);
				}
				if (array2 != null)
				{
					array2[j] = result2.Node;
				}
			}
			Result result3 = RewriteExpression(switchCase.Body, stack);
			rewriteAction |= result3.Action;
			if (result3.Action != RewriteAction.None || array2 != null)
			{
				if (array2 != null)
				{
					readOnlyCollection2 = new ReadOnlyCollection<Expression>(array2);
				}
				switchCase = new SwitchCase(result3.Node, readOnlyCollection2);
				if (array == null)
				{
					array = Clone(readOnlyCollection, i);
				}
			}
			if (array != null)
			{
				array[i] = switchCase;
			}
		}
		Result result4 = RewriteExpression(switchExpression.DefaultBody, stack);
		rewriteAction |= result4.Action;
		if (rewriteAction != RewriteAction.None)
		{
			if (array != null)
			{
				readOnlyCollection = new ReadOnlyCollection<SwitchCase>(array);
			}
			expr = new SwitchExpression(switchExpression.Type, result.Node, result4.Node, switchExpression.Comparison, readOnlyCollection);
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteTryExpression(Expression expr, Stack stack)
	{
		TryExpression tryExpression = (TryExpression)expr;
		Result result = RewriteExpression(tryExpression.Body, Stack.Empty);
		ReadOnlyCollection<CatchBlock> readOnlyCollection = tryExpression.Handlers;
		CatchBlock[] array = null;
		RewriteAction rewriteAction = result.Action;
		if (readOnlyCollection != null)
		{
			for (int i = 0; i < readOnlyCollection.Count; i++)
			{
				RewriteAction rewriteAction2 = result.Action;
				CatchBlock catchBlock = readOnlyCollection[i];
				Expression filter = catchBlock.Filter;
				if (catchBlock.Filter != null)
				{
					Result result2 = RewriteExpression(catchBlock.Filter, Stack.Empty);
					rewriteAction |= result2.Action;
					rewriteAction2 |= result2.Action;
					filter = result2.Node;
				}
				Result result3 = RewriteExpression(catchBlock.Body, Stack.Empty);
				rewriteAction |= result3.Action;
				if ((rewriteAction2 | result3.Action) != RewriteAction.None)
				{
					catchBlock = Expression.MakeCatchBlock(catchBlock.Test, catchBlock.Variable, result3.Node, filter);
					if (array == null)
					{
						array = Clone(readOnlyCollection, i);
					}
				}
				if (array != null)
				{
					array[i] = catchBlock;
				}
			}
		}
		Result result4 = RewriteExpression(tryExpression.Fault, Stack.Empty);
		rewriteAction |= result4.Action;
		Result result5 = RewriteExpression(tryExpression.Finally, Stack.Empty);
		rewriteAction |= result5.Action;
		if (stack != Stack.Empty)
		{
			rewriteAction = RewriteAction.SpillStack;
		}
		if (rewriteAction != RewriteAction.None)
		{
			if (array != null)
			{
				readOnlyCollection = new ReadOnlyCollection<CatchBlock>(array);
			}
			expr = new TryExpression(tryExpression.Type, result.Node, result5.Node, result4.Node, readOnlyCollection);
		}
		return new Result(rewriteAction, expr);
	}

	private Result RewriteExtensionExpression(Expression expr, Stack stack)
	{
		Result result = RewriteExpression(expr.ReduceExtensions(), stack);
		return new Result(result.Action | RewriteAction.Copy, result.Node);
	}

	private static T[] Clone<T>(ReadOnlyCollection<T> original, int max)
	{
		T[] array = new T[original.Count];
		for (int i = 0; i < max; i++)
		{
			array[i] = original[i];
		}
		return array;
	}

	private static void RequireNoRefArgs(MethodBase method)
	{
		if (method != null && method.GetParametersCached().Any((ParameterInfo p) => p.ParameterType.IsByRef))
		{
			throw Error.TryNotSupportedForMethodsWithRefArgs(method);
		}
	}

	private static void RequireNotRefInstance(Expression instance)
	{
		if (instance != null && instance.Type.IsValueType && Type.GetTypeCode(instance.Type) == TypeCode.Object)
		{
			throw Error.TryNotSupportedForValueTypeInstances(instance.Type);
		}
	}

	private Result RewriteExpression(Expression node, Stack stack)
	{
		if (node == null)
		{
			return new Result(RewriteAction.None, null);
		}
		if (!_guard.TryEnterOnCurrentStack())
		{
			return _guard.RunOnEmptyStack((StackSpiller @this, Expression n, Stack s) => @this.RewriteExpression(n, s), this, node, stack);
		}
		switch (node.NodeType)
		{
		case ExpressionType.Add:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.AddChecked:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.And:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.AndAlso:
			return RewriteLogicalBinaryExpression(node, stack);
		case ExpressionType.ArrayLength:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.ArrayIndex:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.Call:
			return RewriteMethodCallExpression(node, stack);
		case ExpressionType.Coalesce:
			return RewriteLogicalBinaryExpression(node, stack);
		case ExpressionType.Conditional:
			return RewriteConditionalExpression(node, stack);
		case ExpressionType.Convert:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.ConvertChecked:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.Divide:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.Equal:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.ExclusiveOr:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.GreaterThan:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.GreaterThanOrEqual:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.Invoke:
			return RewriteInvocationExpression(node, stack);
		case ExpressionType.Lambda:
			return RewriteLambdaExpression(node, stack);
		case ExpressionType.LeftShift:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.LessThan:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.LessThanOrEqual:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.ListInit:
			return RewriteListInitExpression(node, stack);
		case ExpressionType.MemberAccess:
			return RewriteMemberExpression(node, stack);
		case ExpressionType.MemberInit:
			return RewriteMemberInitExpression(node, stack);
		case ExpressionType.Modulo:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.Multiply:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.MultiplyChecked:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.Negate:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.UnaryPlus:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.NegateChecked:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.New:
			return RewriteNewExpression(node, stack);
		case ExpressionType.NewArrayInit:
			return RewriteNewArrayExpression(node, stack);
		case ExpressionType.NewArrayBounds:
			return RewriteNewArrayExpression(node, stack);
		case ExpressionType.Not:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.NotEqual:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.Or:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.OrElse:
			return RewriteLogicalBinaryExpression(node, stack);
		case ExpressionType.Power:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.RightShift:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.Subtract:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.SubtractChecked:
			return RewriteBinaryExpression(node, stack);
		case ExpressionType.TypeAs:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.TypeIs:
			return RewriteTypeBinaryExpression(node, stack);
		case ExpressionType.Assign:
			return RewriteAssignBinaryExpression(node, stack);
		case ExpressionType.Block:
			return RewriteBlockExpression(node, stack);
		case ExpressionType.Decrement:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.Dynamic:
			return RewriteDynamicExpression(node, stack);
		case ExpressionType.Extension:
			return RewriteExtensionExpression(node, stack);
		case ExpressionType.Goto:
			return RewriteGotoExpression(node, stack);
		case ExpressionType.Increment:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.Index:
			return RewriteIndexExpression(node, stack);
		case ExpressionType.Label:
			return RewriteLabelExpression(node, stack);
		case ExpressionType.Loop:
			return RewriteLoopExpression(node, stack);
		case ExpressionType.Switch:
			return RewriteSwitchExpression(node, stack);
		case ExpressionType.Throw:
			return RewriteThrowUnaryExpression(node, stack);
		case ExpressionType.Try:
			return RewriteTryExpression(node, stack);
		case ExpressionType.Unbox:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.TypeEqual:
			return RewriteTypeBinaryExpression(node, stack);
		case ExpressionType.OnesComplement:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.IsTrue:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.IsFalse:
			return RewriteUnaryExpression(node, stack);
		case ExpressionType.AddAssign:
		case ExpressionType.AndAssign:
		case ExpressionType.DivideAssign:
		case ExpressionType.ExclusiveOrAssign:
		case ExpressionType.LeftShiftAssign:
		case ExpressionType.ModuloAssign:
		case ExpressionType.MultiplyAssign:
		case ExpressionType.OrAssign:
		case ExpressionType.PowerAssign:
		case ExpressionType.RightShiftAssign:
		case ExpressionType.SubtractAssign:
		case ExpressionType.AddAssignChecked:
		case ExpressionType.MultiplyAssignChecked:
		case ExpressionType.SubtractAssignChecked:
		case ExpressionType.PreIncrementAssign:
		case ExpressionType.PreDecrementAssign:
		case ExpressionType.PostIncrementAssign:
		case ExpressionType.PostDecrementAssign:
			return RewriteReducibleExpression(node, stack);
		case ExpressionType.Constant:
		case ExpressionType.Parameter:
		case ExpressionType.Quote:
		case ExpressionType.DebugInfo:
		case ExpressionType.Default:
		case ExpressionType.RuntimeVariables:
			return new Result(RewriteAction.None, node);
		default:
			throw ContractUtils.Unreachable;
		}
	}

	private ParameterExpression MakeTemp(Type type)
	{
		return _tm.Temp(type);
	}

	private int Mark()
	{
		return _tm.Mark();
	}

	private void Free(int mark)
	{
		_tm.Free(mark);
	}

	[Conditional("DEBUG")]
	private void VerifyTemps()
	{
	}

	private ParameterExpression ToTemp(Expression expression, out Expression save)
	{
		ParameterExpression parameterExpression = MakeTemp(expression.Type);
		save = Expression.Assign(parameterExpression, expression);
		return parameterExpression;
	}

	private static Expression MakeBlock(params Expression[] expressions)
	{
		return MakeBlock((IList<Expression>)expressions);
	}

	private static Expression MakeBlock(IList<Expression> expressions)
	{
		return new SpilledExpressionBlock(expressions);
	}
}
