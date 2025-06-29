using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Linq;

internal sealed class SystemCore_EnumerableDebugView<T>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEnumerable<T> enumerable;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private T[] cachedCollection;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int count;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items
	{
		get
		{
			List<T> list = new List<T>();
			IEnumerator<T> enumerator = enumerable.GetEnumerator();
			if (enumerator != null)
			{
				count = 0;
				while (enumerator.MoveNext())
				{
					list.Add(enumerator.Current);
					count++;
				}
			}
			if (count == 0)
			{
				throw new SystemCore_EnumerableDebugViewEmptyException();
			}
			cachedCollection = new T[count];
			list.CopyTo(cachedCollection, 0);
			return cachedCollection;
		}
	}

	public SystemCore_EnumerableDebugView(IEnumerable<T> enumerable)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		this.enumerable = enumerable;
	}
}
internal sealed class SystemCore_EnumerableDebugView
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEnumerable enumerable;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object[] cachedCollection;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int count;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public object[] Items
	{
		get
		{
			List<object> list = new List<object>();
			IEnumerator enumerator = enumerable.GetEnumerator();
			if (enumerator != null)
			{
				count = 0;
				while (enumerator.MoveNext())
				{
					list.Add(enumerator.Current);
					count++;
				}
			}
			if (count == 0)
			{
				throw new SystemCore_EnumerableDebugViewEmptyException();
			}
			cachedCollection = new object[count];
			list.CopyTo(cachedCollection, 0);
			return cachedCollection;
		}
	}

	public SystemCore_EnumerableDebugView(IEnumerable enumerable)
	{
		if (enumerable == null)
		{
			throw new ArgumentNullException("enumerable");
		}
		this.enumerable = enumerable;
		count = 0;
		cachedCollection = null;
	}
}
