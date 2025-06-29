using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq;

[global::__DynamicallyInvokable]
public interface IQueryable : IEnumerable
{
	[global::__DynamicallyInvokable]
	Expression Expression
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	Type ElementType
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	IQueryProvider Provider
	{
		[global::__DynamicallyInvokable]
		get;
	}
}
[global::__DynamicallyInvokable]
public interface IQueryable<out T> : IEnumerable<T>, IEnumerable, IQueryable
{
}
