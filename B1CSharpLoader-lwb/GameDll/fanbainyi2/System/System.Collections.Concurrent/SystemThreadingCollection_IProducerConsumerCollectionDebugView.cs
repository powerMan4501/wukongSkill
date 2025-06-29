using System.Diagnostics;

namespace System.Collections.Concurrent;

internal sealed class SystemThreadingCollection_IProducerConsumerCollectionDebugView<T>
{
	private IProducerConsumerCollection<T> m_collection;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items => m_collection.ToArray();

	public SystemThreadingCollection_IProducerConsumerCollectionDebugView(IProducerConsumerCollection<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		m_collection = collection;
	}
}
