using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

[global::__DynamicallyInvokable]
public interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[global::__DynamicallyInvokable]
	int Count
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	IEnumerable<TElement> this[TKey key]
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	bool Contains(TKey key);
}
