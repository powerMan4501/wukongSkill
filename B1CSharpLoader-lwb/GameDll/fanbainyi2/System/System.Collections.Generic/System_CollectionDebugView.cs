using System.Diagnostics;

namespace System.Collections.Generic;

internal sealed class System_CollectionDebugView<T>
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

	public System_CollectionDebugView(ICollection<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		this.collection = collection;
	}
}
