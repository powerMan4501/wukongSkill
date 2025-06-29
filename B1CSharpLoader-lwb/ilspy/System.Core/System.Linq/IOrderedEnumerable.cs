using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

[global::__DynamicallyInvokable]
public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable
{
	[global::__DynamicallyInvokable]
	IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
}
