using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Linq;

[global::__DynamicallyInvokable]
public abstract class EnumerableExecutor
{
	internal abstract object ExecuteBoxed();

	internal static EnumerableExecutor Create(Expression expression)
	{
		Type type = typeof(EnumerableExecutor<>).MakeGenericType(expression.Type);
		return (EnumerableExecutor)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { expression }, null);
	}

	[global::__DynamicallyInvokable]
	protected EnumerableExecutor()
	{
	}
}
[global::__DynamicallyInvokable]
public class EnumerableExecutor<T> : EnumerableExecutor
{
	private Expression expression;

	private Func<T> func;

	[global::__DynamicallyInvokable]
	public EnumerableExecutor(Expression expression)
	{
		this.expression = expression;
	}

	internal override object ExecuteBoxed()
	{
		return Execute();
	}

	internal T Execute()
	{
		if (func == null)
		{
			EnumerableRewriter enumerableRewriter = new EnumerableRewriter();
			Expression body = enumerableRewriter.Visit(this.expression);
			Expression<Func<T>> expression = Expression.Lambda<Func<T>>(body, (IEnumerable<ParameterExpression>)null);
			func = expression.Compile();
		}
		return func();
	}
}
