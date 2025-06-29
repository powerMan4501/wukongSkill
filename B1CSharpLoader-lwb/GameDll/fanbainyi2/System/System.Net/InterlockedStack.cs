using System.Collections;

namespace System.Net;

internal sealed class InterlockedStack
{
	private readonly Stack _stack = new Stack();

	private int _count;

	internal InterlockedStack()
	{
	}

	internal void Push(object pooledStream)
	{
		if (pooledStream == null)
		{
			throw new ArgumentNullException("pooledStream");
		}
		lock (_stack.SyncRoot)
		{
			_stack.Push(pooledStream);
			_count = _stack.Count;
		}
	}

	internal object Pop()
	{
		lock (_stack.SyncRoot)
		{
			object result = null;
			if (0 < _stack.Count)
			{
				result = _stack.Pop();
				_count = _stack.Count;
			}
			return result;
		}
	}
}
