using System;
using System.Collections.Generic;

namespace b1;

public class PriorityQueue<T> where T : IComparable<T>
{
	private SortedList<T, int> list = new SortedList<T, int>();

	private int count;

	public void Add(T item)
	{
		if (!list.ContainsKey(item))
		{
			list.Add(item, 1);
			count++;
		}
	}

	public T PopFirst()
	{
		if (Size() == 0)
		{
			return default(T);
		}
		int index = 0;
		T result = list.Keys[index];
		list.RemoveAt(index);
		count--;
		return result;
	}

	public T PopLast()
	{
		if (Size() == 0)
		{
			return default(T);
		}
		int index = list.Count - 1;
		T result = list.Keys[index];
		list.RemoveAt(index);
		count--;
		return result;
	}

	public T PeekFirst()
	{
		if (Size() == 0)
		{
			return default(T);
		}
		int index = 0;
		return list.Keys[index];
	}

	public T PeekLast()
	{
		if (Size() == 0)
		{
			return default(T);
		}
		int index = list.Count - 1;
		return list.Keys[index];
	}

	public int Size()
	{
		return count;
	}

	public IList<T> GetAllItems()
	{
		if (Size() == 0)
		{
			return null;
		}
		return list.Keys;
	}

	public void Remove(T item)
	{
		if (Size() != 0 && list.ContainsKey(item))
		{
			list.Remove(item);
			count--;
		}
	}
}
