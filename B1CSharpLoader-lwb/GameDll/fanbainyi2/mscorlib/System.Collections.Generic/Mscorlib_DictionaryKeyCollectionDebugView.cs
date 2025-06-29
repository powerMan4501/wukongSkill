using System.Diagnostics;

namespace System.Collections.Generic;

internal sealed class Mscorlib_DictionaryKeyCollectionDebugView<TKey, TValue>
{
	private ICollection<TKey> collection;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public TKey[] Items
	{
		get
		{
			TKey[] array = new TKey[collection.Count];
			collection.CopyTo(array, 0);
			return array;
		}
	}

	public Mscorlib_DictionaryKeyCollectionDebugView(ICollection<TKey> collection)
	{
		if (collection == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
		}
		this.collection = collection;
	}
}
