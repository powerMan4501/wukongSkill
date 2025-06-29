using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace System.Dynamic;

[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
[DebuggerDisplay("{DebugView}")]
[global::__DynamicallyInvokable]
public abstract class BindingRestrictions
{
	private sealed class TestBuilder
	{
		private struct AndNode
		{
			internal int Depth;

			internal Expression Node;
		}

		private readonly Set<BindingRestrictions> _unique = new Set<BindingRestrictions>();

		private readonly Stack<AndNode> _tests = new Stack<AndNode>();

		internal void Append(BindingRestrictions restrictions)
		{
			if (!_unique.Contains(restrictions))
			{
				_unique.Add(restrictions);
				Push(restrictions.GetExpression(), 0);
			}
		}

		internal Expression ToExpression()
		{
			Expression expression = _tests.Pop().Node;
			while (_tests.Count > 0)
			{
				expression = Expression.AndAlso(_tests.Pop().Node, expression);
			}
			return expression;
		}

		private void Push(Expression node, int depth)
		{
			while (_tests.Count > 0 && _tests.Peek().Depth == depth)
			{
				node = Expression.AndAlso(_tests.Pop().Node, node);
				depth++;
			}
			_tests.Push(new AndNode
			{
				Node = node,
				Depth = depth
			});
		}
	}

	private sealed class MergedRestriction : BindingRestrictions
	{
		internal readonly BindingRestrictions Left;

		internal readonly BindingRestrictions Right;

		internal MergedRestriction(BindingRestrictions left, BindingRestrictions right)
		{
			Left = left;
			Right = right;
		}

		internal override Expression GetExpression()
		{
			throw ContractUtils.Unreachable;
		}
	}

	private sealed class CustomRestriction : BindingRestrictions
	{
		private readonly Expression _expression;

		internal CustomRestriction(Expression expression)
		{
			_expression = expression;
		}

		public override bool Equals(object obj)
		{
			if (obj is CustomRestriction customRestriction)
			{
				return customRestriction._expression == _expression;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return 0x40000000 ^ _expression.GetHashCode();
		}

		internal override Expression GetExpression()
		{
			return _expression;
		}
	}

	private sealed class TypeRestriction : BindingRestrictions
	{
		private readonly Expression _expression;

		private readonly Type _type;

		internal TypeRestriction(Expression parameter, Type type)
		{
			_expression = parameter;
			_type = type;
		}

		public override bool Equals(object obj)
		{
			if (obj is TypeRestriction typeRestriction && TypeUtils.AreEquivalent(typeRestriction._type, _type))
			{
				return typeRestriction._expression == _expression;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return 0x10000000 ^ _expression.GetHashCode() ^ _type.GetHashCode();
		}

		internal override Expression GetExpression()
		{
			return Expression.TypeEqual(_expression, _type);
		}
	}

	private sealed class InstanceRestriction : BindingRestrictions
	{
		private readonly Expression _expression;

		private readonly object _instance;

		internal InstanceRestriction(Expression parameter, object instance)
		{
			_expression = parameter;
			_instance = instance;
		}

		public override bool Equals(object obj)
		{
			if (obj is InstanceRestriction instanceRestriction && instanceRestriction._instance == _instance)
			{
				return instanceRestriction._expression == _expression;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return 0x20000000 ^ RuntimeHelpers.GetHashCode(_instance) ^ _expression.GetHashCode();
		}

		internal override Expression GetExpression()
		{
			if (_instance == null)
			{
				return Expression.Equal(Expression.Convert(_expression, typeof(object)), Expression.Constant(null));
			}
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			return Expression.Block(new ParameterExpression[1] { parameterExpression }, Expression.Assign(parameterExpression, Expression.Property(Expression.Constant(new WeakReference(_instance)), typeof(WeakReference).GetProperty("Target"))), Expression.AndAlso(Expression.NotEqual(parameterExpression, Expression.Constant(null)), Expression.Equal(Expression.Convert(_expression, typeof(object)), parameterExpression)));
		}
	}

	private sealed class BindingRestrictionsProxy
	{
		private readonly BindingRestrictions _node;

		public bool IsEmpty => _node == Empty;

		public Expression Test => _node.ToExpression();

		public BindingRestrictions[] Restrictions
		{
			get
			{
				List<BindingRestrictions> list = new List<BindingRestrictions>();
				Stack<BindingRestrictions> stack = new Stack<BindingRestrictions>();
				stack.Push(_node);
				do
				{
					BindingRestrictions bindingRestrictions = stack.Pop();
					if (bindingRestrictions is MergedRestriction mergedRestriction)
					{
						stack.Push(mergedRestriction.Right);
						stack.Push(mergedRestriction.Left);
					}
					else
					{
						list.Add(bindingRestrictions);
					}
				}
				while (stack.Count > 0);
				return list.ToArray();
			}
		}

		public BindingRestrictionsProxy(BindingRestrictions node)
		{
			_node = node;
		}

		public override string ToString()
		{
			return _node.DebugView;
		}
	}

	[global::__DynamicallyInvokable]
	public static readonly BindingRestrictions Empty = new CustomRestriction(Expression.Constant(true));

	private const int TypeRestrictionHash = 268435456;

	private const int InstanceRestrictionHash = 536870912;

	private const int CustomRestrictionHash = 1073741824;

	private string DebugView => ToExpression().ToString();

	private BindingRestrictions()
	{
	}

	internal abstract Expression GetExpression();

	[global::__DynamicallyInvokable]
	public BindingRestrictions Merge(BindingRestrictions restrictions)
	{
		ContractUtils.RequiresNotNull(restrictions, "restrictions");
		if (this == Empty)
		{
			return restrictions;
		}
		if (restrictions == Empty)
		{
			return this;
		}
		return new MergedRestriction(this, restrictions);
	}

	[global::__DynamicallyInvokable]
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type)
	{
		ContractUtils.RequiresNotNull(expression, "expression");
		ContractUtils.RequiresNotNull(type, "type");
		return new TypeRestriction(expression, type);
	}

	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj)
	{
		if (obj.Value == null && obj.HasValue)
		{
			return GetInstanceRestriction(obj.Expression, null);
		}
		return GetTypeRestriction(obj.Expression, obj.LimitType);
	}

	[global::__DynamicallyInvokable]
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance)
	{
		ContractUtils.RequiresNotNull(expression, "expression");
		return new InstanceRestriction(expression, instance);
	}

	[global::__DynamicallyInvokable]
	public static BindingRestrictions GetExpressionRestriction(Expression expression)
	{
		ContractUtils.RequiresNotNull(expression, "expression");
		ContractUtils.Requires(expression.Type == typeof(bool), "expression");
		return new CustomRestriction(expression);
	}

	[global::__DynamicallyInvokable]
	public static BindingRestrictions Combine(IList<DynamicMetaObject> contributingObjects)
	{
		BindingRestrictions bindingRestrictions = Empty;
		if (contributingObjects != null)
		{
			foreach (DynamicMetaObject contributingObject in contributingObjects)
			{
				if (contributingObject != null)
				{
					bindingRestrictions = bindingRestrictions.Merge(contributingObject.Restrictions);
				}
			}
		}
		return bindingRestrictions;
	}

	[global::__DynamicallyInvokable]
	public Expression ToExpression()
	{
		if (this == Empty)
		{
			return Expression.Constant(true);
		}
		TestBuilder testBuilder = new TestBuilder();
		Stack<BindingRestrictions> stack = new Stack<BindingRestrictions>();
		stack.Push(this);
		do
		{
			BindingRestrictions bindingRestrictions = stack.Pop();
			if (bindingRestrictions is MergedRestriction mergedRestriction)
			{
				stack.Push(mergedRestriction.Right);
				stack.Push(mergedRestriction.Left);
			}
			else
			{
				testBuilder.Append(bindingRestrictions);
			}
		}
		while (stack.Count > 0);
		return testBuilder.ToExpression();
	}
}
