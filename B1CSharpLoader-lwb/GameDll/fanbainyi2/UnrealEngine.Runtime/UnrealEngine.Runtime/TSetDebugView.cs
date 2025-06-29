using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

internal class TSetDebugView<T>
{
	private ICollection<T> collection;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items
	{
		get
		{
			T[] array = new T[collection.Count];
			collection.CopyTo(array, 0);
			return array;
		}
	}

	public TSetDebugView(ICollection<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		this.collection = collection;
	}
}
