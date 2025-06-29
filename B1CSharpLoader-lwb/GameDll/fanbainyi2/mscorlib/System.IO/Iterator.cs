using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace System.IO;

internal abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
{
	private int threadId;

	internal int state;

	internal TSource current;

	public TSource Current => current;

	object IEnumerator.Current => Current;

	public Iterator()
	{
		threadId = Thread.CurrentThread.ManagedThreadId;
	}

	protected abstract Iterator<TSource> Clone();

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		current = default(TSource);
		state = -1;
	}

	public IEnumerator<TSource> GetEnumerator()
	{
		if (threadId == Thread.CurrentThread.ManagedThreadId && state == 0)
		{
			state = 1;
			return this;
		}
		Iterator<TSource> iterator = Clone();
		iterator.state = 1;
		return iterator;
	}

	public abstract bool MoveNext();

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	void IEnumerator.Reset()
	{
		throw new NotSupportedException();
	}
}
