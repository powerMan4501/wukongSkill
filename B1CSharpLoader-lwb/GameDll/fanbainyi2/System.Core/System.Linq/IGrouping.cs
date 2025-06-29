using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

[global::__DynamicallyInvokable]
public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
{
	[global::__DynamicallyInvokable]
	TKey Key
	{
		[global::__DynamicallyInvokable]
		get;
	}
}
