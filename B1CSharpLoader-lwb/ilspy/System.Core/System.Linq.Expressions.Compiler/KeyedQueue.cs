using System.Collections.Generic;

namespace System.Linq.Expressions.Compiler;

internal sealed class KeyedQueue<K, V>
{
	private readonly Dictionary<K, Queue<V>> _data;

	internal KeyedQueue()
	{
		_data = new Dictionary<K, Queue<V>>();
	}

	internal void Enqueue(K key, V value)
	{
		if (!_data.TryGetValue(key, out var value2))
		{
			_data.Add(key, value2 = new Queue<V>());
		}
		value2.Enqueue(value);
	}

	internal V Dequeue(K key)
	{
		if (!_data.TryGetValue(key, out var value))
		{
			throw Error.QueueEmpty();
		}
		V result = value.Dequeue();
		if (value.Count == 0)
		{
			_data.Remove(key);
		}
		return result;
	}

	internal bool TryDequeue(K key, out V value)
	{
		if (_data.TryGetValue(key, out var value2) && value2.Count > 0)
		{
			value = value2.Dequeue();
			if (value2.Count == 0)
			{
				_data.Remove(key);
			}
			return true;
		}
		value = default(V);
		return false;
	}

	internal V Peek(K key)
	{
		if (!_data.TryGetValue(key, out var value))
		{
			throw Error.QueueEmpty();
		}
		return value.Peek();
	}

	internal int GetCount(K key)
	{
		if (!_data.TryGetValue(key, out var value))
		{
			return 0;
		}
		return value.Count;
	}

	internal void Clear()
	{
		_data.Clear();
	}
}
