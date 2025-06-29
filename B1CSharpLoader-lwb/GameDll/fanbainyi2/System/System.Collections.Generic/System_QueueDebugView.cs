using System.Diagnostics;

namespace System.Collections.Generic;

internal sealed class System_QueueDebugView<T>
{
	private Queue<T> queue;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items => queue.ToArray();

	public System_QueueDebugView(Queue<T> queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		this.queue = queue;
	}
}
