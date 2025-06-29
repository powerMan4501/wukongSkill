using System.Diagnostics;

namespace System.Collections.Concurrent;

internal sealed class SystemThreadingCollections_BlockingCollectionDebugView<T>
{
	private BlockingCollection<T> m_blockingCollection;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items => m_blockingCollection.ToArray();

	public SystemThreadingCollections_BlockingCollectionDebugView(BlockingCollection<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		m_blockingCollection = collection;
	}
}
