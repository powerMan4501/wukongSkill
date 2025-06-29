using System.Collections.Generic;

namespace System.Net;

internal class PrefixLookup
{
	private class PrefixValuePair
	{
		public string prefix;

		public object value;

		public PrefixValuePair(string pre, object val)
		{
			prefix = pre;
			value = val;
		}
	}

	private const int defaultCapacity = 100;

	private volatile int capacity;

	private readonly LinkedList<PrefixValuePair> lruList = new LinkedList<PrefixValuePair>();

	public PrefixLookup()
		: this(100)
	{
	}

	public PrefixLookup(int capacity)
	{
		this.capacity = capacity;
	}

	public void Add(string prefix, object value)
	{
		if (capacity == 0 || prefix == null || prefix.Length == 0 || value == null)
		{
			return;
		}
		lock (lruList)
		{
			if (lruList.First != null && lruList.First.Value.prefix.Equals(prefix))
			{
				lruList.First.Value.value = value;
				return;
			}
			lruList.AddFirst(new PrefixValuePair(prefix, value));
			while (lruList.Count > capacity)
			{
				lruList.RemoveLast();
			}
		}
	}

	public object Lookup(string lookupKey)
	{
		if (lookupKey == null || lookupKey.Length == 0 || lruList.Count == 0)
		{
			return null;
		}
		LinkedListNode<PrefixValuePair> linkedListNode = null;
		lock (lruList)
		{
			int num = 0;
			for (LinkedListNode<PrefixValuePair> linkedListNode2 = lruList.First; linkedListNode2 != null; linkedListNode2 = linkedListNode2.Next)
			{
				string prefix = linkedListNode2.Value.prefix;
				if (prefix.Length > num && lookupKey.StartsWith(prefix))
				{
					num = prefix.Length;
					linkedListNode = linkedListNode2;
					if (num == lookupKey.Length)
					{
						break;
					}
				}
			}
			if (linkedListNode != null && linkedListNode != lruList.First)
			{
				lruList.Remove(linkedListNode);
				lruList.AddFirst(linkedListNode);
			}
		}
		return linkedListNode?.Value.value;
	}
}
