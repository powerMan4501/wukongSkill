using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Linq;

[global::__DynamicallyInvokable]
public abstract class EnumerableQuery
{
	internal abstract Expression Expression { get; }

	internal abstract IEnumerable Enumerable { get; }

	internal static IQueryable Create(Type elementType, IEnumerable sequence)
	{
		Type type = typeof(EnumerableQuery<>).MakeGenericType(elementType);
		return (IQueryable)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { sequence }, null);
	}

	internal static IQueryable Create(Type elementType, Expression expression)
	{
		Type type = typeof(EnumerableQuery<>).MakeGenericType(elementType);
		return (IQueryable)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { expression }, null);
	}

	[global::__DynamicallyInvokable]
	protected EnumerableQuery()
	{
	}
}
[global::__DynamicallyInvokable]
public class EnumerableQuery<T> : EnumerableQuery, IOrderedQueryable<T>, IQueryable<T>, IEnumerable<T>, IEnumerable, IQueryable, IOrderedQueryable, IQueryProvider
{
	private Expression expression;

	private IEnumerable<T> enumerable;

	[global::__DynamicallyInvokable]
	IQueryProvider IQueryable.Provider
	{
		[global::__DynamicallyInvokable]
		get
		{
			return this;
		}
	}

	internal override Expression Expression => expression;

	internal override IEnumerable Enumerable => enumerable;

	[global::__DynamicallyInvokable]
	Expression IQueryable.Expression
	{
		[global::__DynamicallyInvokable]
		get
		{
			return expression;
		}
	}

	[global::__DynamicallyInvokable]
	Type IQueryable.ElementType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return typeof(T);
		}
	}

	[global::__DynamicallyInvokable]
	public EnumerableQuery(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
		expression = Expression.Constant(this);
	}

	[global::__DynamicallyInvokable]
	public EnumerableQuery(Expression expression)
	{
		this.expression = expression;
	}

	[global::__DynamicallyInvokable]
	IQueryable IQueryProvider.CreateQuery(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		Type type = TypeHelper.FindGenericType(typeof(IQueryable<>), expression.Type);
		if (type == null)
		{
			throw Error.ArgumentNotValid("expression");
		}
		return EnumerableQuery.Create(type.GetGenericArguments()[0], expression);
	}

	[global::__DynamicallyInvokable]
	IQueryable<S> IQueryProvider.CreateQuery<S>(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if (!typeof(IQueryable<S>).IsAssignableFrom(expression.Type))
		{
			throw Error.ArgumentNotValid("expression");
		}
		return new EnumerableQuery<S>(expression);
	}

	[global::__DynamicallyInvokable]
	object IQueryProvider.Execute(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		Type type = typeof(EnumerableExecutor<>).MakeGenericType(expression.Type);
		return EnumerableExecutor.Create(expression).ExecuteBoxed();
	}

	[global::__DynamicallyInvokable]
	S IQueryProvider.Execute<S>(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if (!typeof(S).IsAssignableFrom(expression.Type))
		{
			throw Error.ArgumentNotValid("expression");
		}
		return new EnumerableExecutor<S>(expression).Execute();
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return GetEnumerator();
	}

	private IEnumerator<T> GetEnumerator()
	{
		if (enumerable == null)
		{
			EnumerableRewriter enumerableRewriter = new EnumerableRewriter();
			Expression body = enumerableRewriter.Visit(this.expression);
			Expression<Func<IEnumerable<T>>> expression = Expression.Lambda<Func<IEnumerable<T>>>(body, (IEnumerable<ParameterExpression>)null);
			enumerable = expression.Compile()();
		}
		return enumerable.GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		if (expression is ConstantExpression constantExpression && constantExpression.Value == this)
		{
			if (enumerable != null)
			{
				return enumerable.ToString();
			}
			return "null";
		}
		return expression.ToString();
	}
}
