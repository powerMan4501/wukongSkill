using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Linq.Expressions.Compiler;

namespace System.Runtime.CompilerServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[DebuggerStepThrough]
[global::__DynamicallyInvokable]
public static class RuntimeOps
{
	private sealed class ExpressionQuoter : ExpressionVisitor
	{
		private readonly HoistedLocals _scope;

		private readonly object[] _locals;

		private readonly Stack<Set<ParameterExpression>> _shadowedVars = new Stack<Set<ParameterExpression>>();

		internal ExpressionQuoter(HoistedLocals scope, object[] locals)
		{
			_scope = scope;
			_locals = locals;
		}

		protected internal override Expression VisitLambda<T>(Expression<T> node)
		{
			_shadowedVars.Push(new Set<ParameterExpression>(node.Parameters));
			Expression expression = Visit(node.Body);
			_shadowedVars.Pop();
			if (expression == node.Body)
			{
				return node;
			}
			return Expression.Lambda<T>(expression, node.Name, node.TailCall, node.Parameters);
		}

		protected internal override Expression VisitBlock(BlockExpression node)
		{
			if (node.Variables.Count > 0)
			{
				_shadowedVars.Push(new Set<ParameterExpression>(node.Variables));
			}
			ReadOnlyCollection<Expression> readOnlyCollection = Visit(node.Expressions);
			if (node.Variables.Count > 0)
			{
				_shadowedVars.Pop();
			}
			if (readOnlyCollection == node.Expressions)
			{
				return node;
			}
			return Expression.Block(node.Variables, readOnlyCollection);
		}

		protected override CatchBlock VisitCatchBlock(CatchBlock node)
		{
			if (node.Variable != null)
			{
				_shadowedVars.Push(new Set<ParameterExpression>(new ParameterExpression[1] { node.Variable }));
			}
			Expression expression = Visit(node.Body);
			Expression expression2 = Visit(node.Filter);
			if (node.Variable != null)
			{
				_shadowedVars.Pop();
			}
			if (expression == node.Body && expression2 == node.Filter)
			{
				return node;
			}
			return Expression.MakeCatchBlock(node.Test, node.Variable, expression, expression2);
		}

		protected internal override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
		{
			int count = node.Variables.Count;
			List<IStrongBox> list = new List<IStrongBox>();
			List<ParameterExpression> list2 = new List<ParameterExpression>();
			int[] array = new int[count];
			for (int i = 0; i < count; i++)
			{
				IStrongBox box = GetBox(node.Variables[i]);
				if (box == null)
				{
					array[i] = list2.Count;
					list2.Add(node.Variables[i]);
				}
				else
				{
					array[i] = -1 - list.Count;
					list.Add(box);
				}
			}
			if (list.Count == 0)
			{
				return node;
			}
			ConstantExpression constantExpression = Expression.Constant(new RuntimeVariables(list.ToArray()), typeof(IRuntimeVariables));
			if (list2.Count == 0)
			{
				return constantExpression;
			}
			return Expression.Call(typeof(RuntimeOps).GetMethod("MergeRuntimeVariables"), Expression.RuntimeVariables(new TrueReadOnlyCollection<ParameterExpression>(list2.ToArray())), constantExpression, Expression.Constant(array));
		}

		protected internal override Expression VisitParameter(ParameterExpression node)
		{
			IStrongBox box = GetBox(node);
			if (box == null)
			{
				return node;
			}
			return Expression.Field(Expression.Constant(box), "Value");
		}

		private IStrongBox GetBox(ParameterExpression variable)
		{
			foreach (Set<ParameterExpression> shadowedVar in _shadowedVars)
			{
				if (shadowedVar.Contains(variable))
				{
					return null;
				}
			}
			HoistedLocals hoistedLocals = _scope;
			object[] array = _locals;
			while (true)
			{
				if (hoistedLocals.Indexes.TryGetValue(variable, out var value))
				{
					return (IStrongBox)array[value];
				}
				hoistedLocals = hoistedLocals.Parent;
				if (hoistedLocals == null)
				{
					break;
				}
				array = HoistedLocals.GetParent(array);
			}
			throw ContractUtils.Unreachable;
		}
	}

	private sealed class RuntimeVariables : IRuntimeVariables
	{
		private readonly IStrongBox[] _boxes;

		int IRuntimeVariables.Count => _boxes.Length;

		object IRuntimeVariables.this[int index]
		{
			get
			{
				return _boxes[index].Value;
			}
			set
			{
				_boxes[index].Value = value;
			}
		}

		internal RuntimeVariables(IStrongBox[] boxes)
		{
			_boxes = boxes;
		}
	}

	private sealed class MergedRuntimeVariables : IRuntimeVariables
	{
		private readonly IRuntimeVariables _first;

		private readonly IRuntimeVariables _second;

		private readonly int[] _indexes;

		public int Count => _indexes.Length;

		public object this[int index]
		{
			get
			{
				index = _indexes[index];
				if (index < 0)
				{
					return _second[-1 - index];
				}
				return _first[index];
			}
			set
			{
				index = _indexes[index];
				if (index >= 0)
				{
					_first[index] = value;
				}
				else
				{
					_second[-1 - index] = value;
				}
			}
		}

		internal MergedRuntimeVariables(IRuntimeVariables first, IRuntimeVariables second, int[] indexes)
		{
			_first = first;
			_second = second;
			_indexes = indexes;
		}
	}

	private sealed class EmptyRuntimeVariables : IRuntimeVariables
	{
		int IRuntimeVariables.Count => 0;

		object IRuntimeVariables.this[int index]
		{
			get
			{
				throw new ArgumentOutOfRangeException("index");
			}
			set
			{
				throw new ArgumentOutOfRangeException("index");
			}
		}
	}

	private sealed class RuntimeVariableList : IRuntimeVariables
	{
		private readonly object[] _data;

		private readonly long[] _indexes;

		public int Count => _indexes.Length;

		public object this[int index]
		{
			get
			{
				return GetStrongBox(index).Value;
			}
			set
			{
				GetStrongBox(index).Value = value;
			}
		}

		internal RuntimeVariableList(object[] data, long[] indexes)
		{
			_data = data;
			_indexes = indexes;
		}

		private IStrongBox GetStrongBox(int index)
		{
			long num = _indexes[index];
			object[] array = _data;
			for (int num2 = (int)(num >> 32); num2 > 0; num2--)
			{
				array = HoistedLocals.GetParent(array);
			}
			return (IStrongBox)array[(int)num];
		}
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value)
	{
		return expando.TryGetValue(indexClass, index, name, ignoreCase, out value);
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase)
	{
		expando.TrySetValue(indexClass, index, value, name, ignoreCase, add: false);
		return value;
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase)
	{
		return expando.TryDeleteValue(indexClass, index, name, ignoreCase, ExpandoObject.Uninitialized);
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static bool ExpandoCheckVersion(ExpandoObject expando, object version)
	{
		return expando.Class == version;
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass)
	{
		expando.PromoteClass(oldClass, newClass);
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static Expression Quote(Expression expression, object hoistedLocals, object[] locals)
	{
		ExpressionQuoter expressionQuoter = new ExpressionQuoter((HoistedLocals)hoistedLocals, locals);
		return expressionQuoter.Visit(expression);
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static IRuntimeVariables MergeRuntimeVariables(IRuntimeVariables first, IRuntimeVariables second, int[] indexes)
	{
		return new MergedRuntimeVariables(first, second, indexes);
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static IRuntimeVariables CreateRuntimeVariables(object[] data, long[] indexes)
	{
		return new RuntimeVariableList(data, indexes);
	}

	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::__DynamicallyInvokable]
	public static IRuntimeVariables CreateRuntimeVariables()
	{
		return new EmptyRuntimeVariables();
	}
}
