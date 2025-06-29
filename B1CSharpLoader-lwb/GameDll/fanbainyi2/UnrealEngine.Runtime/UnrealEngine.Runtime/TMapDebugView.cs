using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

internal class TMapDebugView<TKey, TValue>
{
	private IDictionary<TKey, TValue> collection;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public KeyValuePair<TKey, TValue>[] Items
	{
		get
		{
			KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[collection.Count];
			collection.CopyTo(array, 0);
			return array;
		}
	}

	public TMapDebugView(IDictionary<TKey, TValue> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		this.collection = collection;
	}
}
