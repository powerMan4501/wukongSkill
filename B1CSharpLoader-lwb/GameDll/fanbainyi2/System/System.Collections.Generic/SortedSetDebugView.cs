using System.Diagnostics;

namespace System.Collections.Generic;

internal class SortedSetDebugView<T>
{
	private SortedSet<T> set;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items => set.ToArray();

	public SortedSetDebugView(SortedSet<T> set)
	{
		if (set == null)
		{
			throw new ArgumentNullException("set");
		}
		this.set = set;
	}
}
