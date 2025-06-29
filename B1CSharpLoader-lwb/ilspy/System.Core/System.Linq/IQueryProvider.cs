using System.Linq.Expressions;

namespace System.Linq;

[global::__DynamicallyInvokable]
public interface IQueryProvider
{
	[global::__DynamicallyInvokable]
	IQueryable CreateQuery(Expression expression);

	[global::__DynamicallyInvokable]
	IQueryable<TElement> CreateQuery<TElement>(Expression expression);

	[global::__DynamicallyInvokable]
	object Execute(Expression expression);

	[global::__DynamicallyInvokable]
	TResult Execute<TResult>(Expression expression);
}
