using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

[global::__DynamicallyInvokable]
public interface IOrderedQueryable : IQueryable, IEnumerable
{
}
[global::__DynamicallyInvokable]
public interface IOrderedQueryable<out T> : IQueryable<T>, IEnumerable<T>, IEnumerable, IQueryable, IOrderedQueryable
{
}
